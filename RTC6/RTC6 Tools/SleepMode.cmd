@ECHO OFF
REM   File: Sleepmode.cmd                                           March 2018
REM   (c) Copyright 2018         by SCANLAB GmbH.         All rights reserved.
REM
REM   THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
REM   KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
REM   IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
REM   PURPOSE.
REM
REM   Abstract
REM     This script deactivates the standby and hibernate mode by adding the
REM     corresponding entry to the registry.
REM
REM   Note
REM     This script needs to be called with administrative privileges.
REM     A repeated call of that script has no bad effects.


REM Reminder for the Customer to close all files an documents.

CLS
ECHO The system must be rebooted as a result of the update and registry changes.
ECHO This restart is triggered by executing this script.
ECHO Please close all important documents and files, as they may be damaged by a restart.
ECHO.
COLOR 17
timeout /T 30


REM Do OPENFILES to check for administrative privileges

OPENFILES > nul
IF ERRORLEVEL 1 (
  COLOR 17
  CLS
  ECHO The registry entry of the system needs to be updated. 
  ECHO To do this, run this cmd file as an administrator:
  ECHO.
  ECHO     Right click on this cmd file and select 'Run as administrator'.
  ECHO.
  PAUSE
  EXIT 1
  )


Powercfg.exe /h off
  
REG QUERY HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\ACPI\Parameters /v Attributes
IF %ERRORLEVEL% EQU 70 goto sub_routine_no_entry


REG add HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\ACPI\Parameters /v Attributes /t REG_DWORD /d 0x00000070 /f
REM     We need to reboot.
CLS
ECHO The update only takes effect after a reboot.
ECHO.
ECHO.
COLOR 17
SET /P UserChoice=Enter Y to reboot now: 
IF "%UserChoice%"=="" goto sub_routine_no_reboot
IF /I "%UserChoice%"=="Y" goto sub_routine_reboot

:sub_routine_no_reboot
COLOR 17
ECHO No reboot invoked.
ECHO.
PAUSE
goto:eof

:sub_routine_reboot
SHUTDOWN /r /d P:4:2
PAUSE
goto:eof

:sub_routine_no_entry
CLS
COLOR 17
ECHO Nothing to do. The system is ready.
ECHO.
PAUSE
goto:eof

