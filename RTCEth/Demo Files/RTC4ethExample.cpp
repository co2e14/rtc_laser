/*
	RTC4ethernet multiboard example program

	Shows how to search cards and how to get the IP and serial from each card.
	It then programs list 1 of card #1 with an absolute jump to (100,0) within a
	rotated coordinate system and prints the final Cartesian position.

	Disclaimer: THE SAMPLE CODE IS PROVIDED "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES,
	INCLUDING THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
	ARE DISCLAIMED.

	Manufacturer:

	SCANLAB GmbH
	Siemensstr. 2a
	82178 Puchheim
	Germany

	Tel. + 49 (89) 800 746-0
	Fax: + 49 (89) 800 746-199

	info@scanlab.de
	www.scanlab.de
*/

#include <stdlib.h>
#include <stdint.h>
#include <stdio.h>
#include "RTC4ethimpl.h"

#pragma comment(lib, "RTC4ethDLL.lib")
// RTC4ethDLL.dll automatically initializes RTC4netDLL.dll

void program_list1(unsigned short cardno)
{
	select_rtc(cardno);

	set_start_list_1();
	jump_abs(0, 0);
	
	// record x and y values every 10 micro seconds
	set_trigger(1, 7, 8);

	// Set rotation matrix to rotate coordinate system 60 degrees counter clockwise
	set_matrix(0.5, -0.866, 0.866, 0.5);
	mark_abs(100, 0);
	set_end_of_list();
}


int main(int argc, char *argv[])
{
	uint16_t num_found_cards;
	uint32_t res, card_ip;
	char ipbuff[16];
	
	rtc_search_cards(&num_found_cards,
		convert_string_to_ip("192.168.250.1"),
		convert_string_to_ip("255.255.255.0"));

	if (num_found_cards == 0) {
		printf("Error, no RTC4ethernet cards found.\n");
		return EXIT_FAILURE;
	}

	for (int i = 1; i <= num_found_cards; i++) {
		// assign card #i the user number i (1:1 mapping)
		if (assign_rtc(i, i) != i) {
			printf("Error, could not assign id %d to card #%d.\n", i, i);
			return EXIT_FAILURE;
		}

		// select card #i with an intrinsic acquire
		if (select_rtc(i) != 0) {
			printf("Error, could not select card %d.\n", i);
		}
		res = load_program_file("RTC4D3.hex");
		if (res) {
			printf("card %d, n_load_program_file error: %d\n", i, res);
			return EXIT_FAILURE;
		}
		
		res = load_correction_file("Cor_1to1.ctb", 1, 1.0, 1.0, 0, 0, 0);
		if (res) {
			printf("card %d, could not load correction file: %d\n", i, res);
			return EXIT_FAILURE;
		}
		
		card_ip = get_ip_address(i);
		convert_ip_to_string(card_ip, ipbuff);
		
		printf("Card #%d has IP: %s and serial %d.\n", i, ipbuff, n_get_serial_number_32(i));
	}

	int list_no = 1;
	unsigned short busy, pos;

	printf("Programming card 1, list 1...\n");
	program_list1(1);


	printf("Starting card 1, list 1...\n");
	select_rtc(1);
	execute_list_1();
	
	unsigned short busy1;
	unsigned short pos1;
	
	do {
		get_status(&busy1, &pos1);
		printf("Card1: List position %X\n", pos1);
	} while(busy1);

	printf("Lists ended...\n");

	do {
		measurement_status(&busy1, &pos1);
	} while (busy1);

	
	short x[200];
	short y[200];

	get_waveform(1, 200, x);
	get_waveform(2, 200, y);


	printf("Jump to (100,0) with rotated coordinate system results in:\n");
	printf("x-coordinate: %5d, y-coordinate: %5d\n", x[199], y[199]);
		
	for (int i = num_found_cards; i > 0; i--) {
		release_rtc(i);
	}

	return EXIT_SUCCESS;
}