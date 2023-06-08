File: README.txt

SCANLAB RTC6 Software Readme

***************************************************************************

Usage

The RTC6 interface board in combination with the software driver is
designed for real-time control of scan systems, lasers and peripheral
equipment by an IBM compatible PC.

The RTC6 software driver and the RTC6 DLL of this package are designed for
Microsoft's 32-bit as well as 64-bit operating systems Windows 10, 8, 7. 
The RTC6 driver supports RTC6's plug and play capability and is able to 
drive simultaneously any number of RTC6 boards.

The files this software package contains are listed below. Additionally the
procedure to install the driver and the corresponding DLL and program files
is described in detail in this Readme file. Further instructions for a
successful operation of the RTC6 board are given in the RTC6 manual.

***************************************************************************

Manufacturer

   SCANLAB GmbH
   Siemensstr. 2a 
   82178 Puchheim
   Germany

   Tel. + 49 (89) 800 746-0
   Fax: + 49 (89) 800 746-199

   info@scanlab.de
   www.scanlab.de

***************************************************************************

Package Description

The RTC6 software contains the following files:

1. Package and Installation Description Files
   README.txt           this file
   LIESMICH.txt         Description in German
   RTC6_Release_Notes_<Date>.pdf   Release notes in English and German

2. Correction Files
   The RTC6 board uses the same correction files as the RTC5 board.

   cor_1to1.ct5         1:1 correction file (no field correction)

   (Note: The correction files of the RTC2, RTC3 and RTC4 interface boards
    use the file name extension "ctb")

3. CorrectionFileConverter Program
   The Win32-based program CorrectionFileConverter.exe converts RTC4
   correction files into RTC5 correction files and vice versa. The package
   also contains the corresponding operating manuals in German and English.

4. Demo Files not yet available

5. HPGL Converter Program
   Win32-based HPGL demo application
   (needs program files and the 32-bit DLL in the same directory)

6. iSCANConfig Program
   The program iSCANcfg.exe is a Win32-based diagnosis and configuration
   program for iDRIVE scan systems (intelliSCAN, intelliSCANde,
   intelliDRILL, intellicube, intelliWELD, varioSCANde)
   (needs program files, the 32-bit DLL and the RtcHalDLL.dll in the same directory!).
   The package also contains the corresponding operating manuals in
   German (Handbuch_iSCANcfg_v1-7.pdf) and English (Manual_iSCANcfg_v1-7.pdf).

7. Windows Driver Files
   RTC6DRV.inf          Device setup information file
   RTC6DRVx64.cat       Signed catalog file
   RTC6DRVx64.sys       Signed.sys file DLL
   RTC6DRVx86.cat       Signed catalog file
   RTC6DRVx86.sys       Signed.sys file DLL

   (Notice that the name of the signer of the signed files is:
    "SCANLAB AG".)

   Installation assistant help files:
   amd64/WdfCoInstaller01009.dll
   x86/WdfCoInstaller01009.dll

   Security installation script for driver upgrades and description:
   AfterInstallation/ScanlabClassChecker.cmd
   AfterInstallation/ReadMe_ScanlabClassChecker.pdf
   
8. RTC6 Files

 - Windows:
 
   - DLL File:
     RTC6DLL.DLL        Win32-based RTC6 dynamic link library
     RTC6DLLx64.DLL     Win64-based RTC6 dynamic link library

   - Utility Files for C, C++ and C#:  
     RTC6DLL.lib        Visual C++ import library for implicit linking
                        of the DLL for Win32-based applications
     RTC6DLLx64.lib     Visual C++ import library for implicit linking
                        of the DLL for Win64-based applications
     RTC6expl.c         C functions for DLL handling for explicit linking
     RTC6expl.h         C function prototypes of the RTC6 for explicit
                        linking of the DLL
     RTC6impl.h         C function prototypes of the RTC6 for implicit
                        linking of the DLL
     RTC6impl.hpp       C++ function prototypes of the RTC6 for implicit
                        linking of the DLL
     RTC6Wrap.cs        C# function prototypes of the RTC6 for implicit
                        linking of the DLL. If you intend to compile your
                        C# solution for the 64-bit platform, you need to
                        define the conditional compilation symbol: SL_x64
                        
   - Utility Files for Delphi:
     RTC6Import.pas     import declarations for Delphi
        
 - Program Files:
   RTC6OUT.out          DSP program file for RTC6 PCI Express
   RTC6ETH.out          DSP program file for RTC6 Ethernet
   RTC6RBF.rbf          firmware file
   RTC6DAT.dat          binary support file

 - Linux:
 
   - debian-stretch:
     rtc6-devel_<Version>_<Arch>.deb            Package for Debian Stretch
     rtc6-devel_<Version>-nocxx11_<Arch>.deb    Package for Debian Stretch 
                                                compiled with 
                                                _GLIBCXX_USE_CXX11_ABI=0 
                                                for compatibility with 
                                                older GCC versions
     
   - debian-buster
     rtc6-devel_<Version>_<Arch>.deb            Package for Debian Buster
     rtc6-devel_<Version>-nocxx11_<Arch>.deb    Package for Debian Buster 
                                                compiled with 
                                                _GLIBCXX_USE_CXX11_ABI=0 
                                                for compatibility with 
   - debian-bullseye
     rtc6-devel_<Version>_<Arch>.deb            Package for Debian Bullseye
     rtc6-devel_<Version>-nocxx11_<Arch>.deb    Package for Debian Bullseye 
                                                compiled with 
                                                _GLIBCXX_USE_CXX11_ABI=0 
                                                for compatibility with 
                                                older GCC versions
     
   readme.txt                           Info about package contents and
                                        installation instructions

 - For easy identifying and archiving of different software versions,
   the RTC6 files are also delivered zipped:

   - RTC6DAT_<Version>.zip
   - RTC6DLL_<Version>.zip (includes DLL and utility files)
   - RTC6OUT_<Version>.zip (includes also RTC6ETH.out)
   - RTC6RBF_<Version>.zip

   Differing versions of the program files and DLL cannot be arbitrarily
   combined with another. Each zip file includes a text file with
   corresponding version information.
   
 - Revision History
   Description of changes in the RTC6 software
   RTC6_Software_RevisionHistory_<Date>.pdf       (in English)
   RTC6_Software_Aenderungshistorie_<Date>.pdf    (in German)

9. RTC6 Tools

 - RTC6conf.exe     utility application to configure RTC6e and RTC6eth:
                    upgrade BIOS,
                    upgrade options,
                            in addition a auxilliary file (purchasable from 
                            SCANLAB) is necessary
                    net work configuration for RTC6eth.
 - RTC6BIOSOUT_<Version>.out       DSP program file for RTC6e BIOS
 - RTC6BIOSETH_<Version>.out       DSP program file for RTC6eth BIOS
 - RTC6conf.pdf             description how to use the tools
 - The program files out of this packet (DAT, DLL, OUT, RBF)
 - SleepMode.cmd                deactivates all sleep and hibernate modes
 - ReadMe_SleepMode.pdf     description how to use the script

If the software is delivered on a data CD, the CD contains all files in
unzipped version. For easy identifying and archiving of different software
versions (also see Revision History), the complete software package is
also delivered zipped: RTC6_Software_<Rev.x.y.z>_<Date>.zip


***************************************************************************

Installation Description

1. Insert the RTC6 board.
2. Start the computer.
3. WINDOWS 7:
   If the "Add Hardware Wizard" does not come up automatically, call him
   from the Control Panel. In the "Add Hardware Wizard" specify the driver 
   directory that includes the RTC6 drivers. During installation, the 
   operating system automatically selects the appropriate driver file 
   (32 oder 64 bit).
   WINDOWS 10, 8:
   Explicitly call WINDOWS' Device Manager. Find entry 'PCI device' in the 
   device tree displayed by the Device Manager and update its driver by 
   specifying the driver directory that includes the RTC6 drivers.
4. Recommended (mandatory for systems with certain RTC3/4/5 board 
                legacy drivers):
   Run AfterInstallation/ScanlabClassChecker.cmd as Administrator. 
   Refer to AfterInstallation/ReadMe_ScanlabClassChecker.pdf 
5. Copy or unzip the files RTC6DLL.dll, RTC6OUT.out, RTC6ETH.out, 
   RTC6RBF.rbf and RTC6DAT.dat to the hard disk of your PC.
   SCANLAB recommends storing these files in the directory in which the
   application software will be started.
   When replacing individual software files, note that differing program
   versions cannot be arbitrarily combined with another (see above).
6. Copy the correction file(s) (*.ct5) to the hard disk of your PC
   (existing correction files can still be used; do not overwrite
   customized correction files!).
   SCANLAB recommends storing these files in the directory in which the
   application software will be started.

With a 64-bit operating system, the 64-bit variant of the RTC6 software
driver supports function calls from Win64-based
applications as well as from Win32-based applications. In this way,
existing Win32-based applications for the RTC6 are able to execute
(even on 64-bit systems), if the included Win32-based DLL file RTC6Dll.dll
is used (as with 32-bit systems). For Win64-based applications, the
Win64-based DLL file RTC6DLLx64.dll is included in the software package.
In case an application utilizes implicit linking to the RTC6DLLx64.dll,
it must be linked with the Win64-based import library RTC6DLLx64.LIB.

***************************************************************************

Further instructions for a successful operation of the RTC6 board are
given in the RTC6 manual.

***************************************************************************