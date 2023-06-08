@ECHO OFF
REM   File: ScanlabClassChecker.cmd                              January 2012
REM   (c) Copyright 2012         by SCANLAB AG.           All rights reserved.
REM
REM   THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
REM   KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
REM   IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
REM   PURPOSE.
REM
REM   Abstract
REM 	This script checks on the registry for a security entry that
REM		allows the built-in user group access to the RTC5 controller.
REM		If necessary, this script adds the particular security entry
REM		to the registry.
REM
REM   Use
REM 	Run this script subsequent to the installation of the WDF driver
REM		for the RTC5 controller.

reg query HKLM\System\CurrentControlSet\Control\Class\{D6797410-1514-11d4-BBA5-0050DA39AF40} /ve
IF %ERRORLEVEL% EQU 1 goto sub_routine_no_entry

SET _IsProperties=0
FOR /F "tokens=7 delims=\" %%G IN ('REG QUERY HKLM\System\CurrentControlSet\Control\Class\{D6797410-1514-11d4-BBA5-0050DA39AF40}') DO (IF %%G==Properties set _IsProperties=1)
IF %_IsProperties% NEQ 0 goto sub_routine_properties
REM	We need to run elevated to add the required sub-key Properties.
REM
REM Do OPENFILES to check for administrative privileges
OPENFILES > nul
IF ERRORLEVEL 1 (
  COLOR 0E
  CLS
  ECHO System's registry entry of the SCANLAB device class
  ECHO needs to be updated for the new RTC driver.
  ECHO In order to do this, run this cmd file as an administrator:
  ECHO.
  ECHO     Right click on this cmd file and select 'Run as administrator'.
  ECHO.
  PAUSE
  EXIT 1
  )

REG ADD HKLM\System\CurrentControlSet\Control\Class\{D6797410-1514-11d4-BBA5-0050DA39AF40}\Properties /v DeviceCharacteristics /t REG_DWORD /d 256
REG ADD HKLM\System\CurrentControlSet\Control\Class\{D6797410-1514-11d4-BBA5-0050DA39AF40}\Properties /v Security /t REG_BINARY /d 010004900000000000000000000000001400000002004c0003000000000014000000001001010000000000051200000000001800000000100102000000000005200000002002000000001800000000c001020000000000052000000021020000
REM		We need to reboot.
CLS
ECHO The update takes effect after a reboot.
ECHO.
ECHO.
COLOR 0E
SET /P UserChoice=Enter Y to reboot now: 
IF "%UserChoice%"=="" goto sub_routine_no_reboot
IF /I "%UserChoice%"=="Y" goto sub_routine_reboot
:sub_routine_no_reboot
COLOR
ECHO No reboot invoked.
ECHO.
PAUSE
goto:eof

:sub_routine_reboot
SHUTDOWN /r /d P:4:2
PAUSE
goto:eof

:sub_routine_properties
CLS
ECHO System's registry entry of the SCANLAB device class is up to date.
ECHO.
PAUSE
goto:eof

:sub_routine_no_entry
CLS
ECHO Nothing to do. The system is ready for a RTC installation.
ECHO.
PAUSE
goto:eof
