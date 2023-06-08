#include <stdint.h>
#include <stdlib.h>
#include <stdio.h>
#include <stdbool.h>

#include <scanlab/rtc6.h>

// RTC error codes
#define ERROR_NO_ERROR 0UL
#define ERROR_NO_CARD 1UL
#define ERROR_VERSION_MISMATCH 256UL

// use current working directory
const char *program_file_path = NULL;
const char *correction_file_path = "./Cor_1to1.ct5";

const char *eth_search_ip = "192.168.250.1";
const char *eth_search_netmask = "255.255.255.0";


bool load_program_and_correction_file(uint32_t card)
{
        // DAT, ETH/OUT and RBF need to be in the current
        // working directory
        uint32_t res;
        res = n_load_program_file(card, program_file_path);
        if (res != ERROR_NO_ERROR) {
                fprintf(stderr, "n_load_program_file error %lu\n", res);
                return false;
        }

        res = acquire_rtc(card);
        if (res != card) {
                fprintf(stderr, "acquire_rtc failed with %lu\n", res);
                return false;
        }

        res = n_load_correction_file(card, correction_file_path, 1, 2);
        if (res != ERROR_NO_ERROR) {
                fprintf(stderr, "n_load_correction_file returned %lu\n", res);
                return false;
        }

        // select_cor_table(1, 0); is done internally. Call it to
        // select a different one.

        uint32_t serial = n_get_serial_number(card);
        printf("Initialized card with serial %lu.\n", serial);

        return true;
}



bool initialize_rtc()
{
        uint32_t res;

        res = init_rtc6_dll();

        if (res != ERROR_NO_ERROR) {
                if (res & ERROR_VERSION_MISMATCH) {
                        fprintf(stderr, "Version mismatch, load current program file.\n");
                } else
                if (res & ERROR_NO_CARD) {
                        fprintf(stderr, "No PCI(e) card detected. Only ethernet possible.\n");
                } else {
                        fprintf(stderr, "Error: init_rtc6_dll returned %lu\n", res);
                        return false;
                }
        }

        // search and initialize ethernet boards
        uint32_t search_ip = eth_convert_string_to_ip(eth_search_ip);
        uint32_t search_nm = eth_convert_string_to_ip(eth_search_netmask);
        uint32_t found_cards = eth_search_cards(search_ip, search_nm);

        if (found_cards > 0) {
                for (uint32_t i = 1; i <= found_cards; i++) {
                        printf("Initializing card #%lu\n", i);
                        int32_t res = eth_assign_card(i, 0);
                        if (res <= 0) {
                                fprintf(stderr, "Error assigning card #%lu: %ld\n", i, res);
                                return false;
                        }

                        uint32_t card = (uint32_t)res;

                        // set appropriate timeouts for network infrastructure
                        n_eth_set_com_timeouts_auto(card, 0.75, 500.0, 1.3, 1);

                        if (!load_program_and_correction_file(card)) {
                                fprintf(stderr, "get_error: %lu, eth_get_error: %lu\n",
                                        n_get_error(card), n_eth_get_error(card));
                                return false;
                        }
                }
                return true;
        }

        fprintf(stderr, "No ethernet card found.\n");
        return false;
}


int main(int argc, char **argv)
{
        if (!initialize_rtc()) {
                return EXIT_FAILURE;
        }

        // use board for marking, etc...

        free_rtc6_dll();

        return EXIT_SUCCESS;
}
