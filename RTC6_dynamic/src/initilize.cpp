#include "include/RTC6impl.hpp"
#include <iostream>
#include <array>
#include <string>

using namespace std;

const UINT ERROR_NO_ERROR = 0U;
const UINT ERROR_NO_CARD = 1U;
const UINT ERROR_VERSION_MISMATCH = 256U;

const char *PROGRAM_FILE_PATH = nullptr;
const char *CORRECTION_FILE_PATH = "../misc/Cor_1to1.ct5";

// Subnet to use for Ethernet board search
const char *ETH_SEARCH_IP = "192.168.250.253";
const char *ETH_SEARCH_NETMASK = "255.255.255.0";
bool LoadProgramAndCorrectionFile(UINT card)
{ // DAT, ETH/OUT and RBF need to be in the current working directory
    const auto loadProgram = n_load_program_file(card, PROGRAM_FILE_PATH);
    if (loadProgram != ERROR_NO_ERROR)
    {
        cout << "n_load_program_file for card " << card << " failed with error code: " << loadProgram << endl;
        return false;
    }
    // Acquire board for further access
    const auto acquire = acquire_rtc(card);
    if (acquire != card)
    {
        cout << "acquire_rtc for card " << card << " failed with error code: " << acquire << endl;
        return false;
    }
    // Load 2D correction file as table 1
    const auto loadCorrection = n_load_correction_file(card, CORRECTION_FILE_PATH, 1, 2);
    if (loadCorrection != ERROR_NO_ERROR)
    {
        cout << "n_load_correction_file for card " << card << " failed with error code: " << loadCorrection << endl;
        return false;
    }
    // select_cor_table( 1, 0 ); is done internally. Call select_cor_table, if you want a different setting.
    const auto serialNumber = n_get_serial_number(card);
    cout << "Initialized card " << card << " (SN " << serialNumber << ")" << endl;
    return true;
}
bool InitializeRTC()
{ // Initialize DLL
    const auto initDLL = init_rtc6_dll();
    if (initDLL != ERROR_NO_ERROR)
    {
        if (initDLL & ERROR_VERSION_MISMATCH)
        {   // Version mismatch can happen if a board has been previously used with a different software version.
            // This error can be fixed by loading the current program file on to the board.
        }
        else if (initDLL & ERROR_NO_CARD)
        {   // The RTC6 DLL will return ERROR_NO_CARD if no PCIe board has been found.
            // We can still use Ethernet boards if available.
        }
        else
        {
            cout << "init_rtc6_dll failed with error code: " << initDLL << endl;
            return false;
        }
    }
    // Initialize PCIe boards
    const auto foundCards = rtc6_count_cards();
    for (auto card = 1; card <= foundCards; card++)
    {
        if (!LoadProgramAndCorrectionFile(card))
        {
            return false;
        }
    } // Search for and initialize Ethernet boards
    const auto ethSearchIP = eth_convert_string_to_ip(ETH_SEARCH_IP);
    const auto ethSearchNetmask = eth_convert_string_to_ip(ETH_SEARCH_NETMASK);
    const auto foundEthCards = eth_search_cards(ethSearchIP, ethSearchNetmask);
    if (foundEthCards > 0)
    {
        for (auto searchCard = 1; searchCard <= foundEthCards; searchCard++)
        {
            array<UINT, 16> cardInfo;
            // eth_get_card_info_search(searchCard, (UINT)cardInfo.data());
            const auto serialNumber = cardInfo[1];
            // Param 0 automatically assigns the board to the next free index
            const auto card = eth_assign_card(searchCard, 0);
            if (card <= 0)
            {
                cout << "eth_assign_card for SN " << serialNumber << " failed with error code: " << card;
                return false;
            }
            if (!LoadProgramAndCorrectionFile(card))
            {
                return false;
            }
        }
    }
    // At least one PCIe or Ethernet board available
    return (foundCards > 0) || (foundEthCards > 0);
}
int main(int argc, char *argv[])
{
    if (!InitializeRTC())
    {
        return 1;
    }
    // Use boards for marking etc...
    set_jump_speed(10000);
    // getch();
    return 0;
}