RTC6 Ethernet Linux Developer Package
=====================================


Supported Distributions:
------------------------

* Debian / Stretch
* Debian / Buster
* Debian / Bullseye

Should work on Ubuntu as well.


Installation
------------

dpkg -i rtc6-devel_x.x.xx-x_amd64.deb


Package contents
----------------

/usr/share/scanlab/LICENSE              -- license for package
/usr/include/scanlab/rtc6.h             -- header for C/C++
/lib/x86_64-linux-gnu/librtc6.so        -- a symlink to the current version
/lib/x86_64-linux-gnu/librtc6.so.xx.x.x -- current version of shared library
/usr/share/scanlab/examples/1/example.c -- example program to use RTC6 Ethernet
/usr/share/scanlab/examples/1/Makefile  -- Makefile to build example program

Note:

The example also needs files from the disk directory (standard software package, such as
correction and program files.


Using the library
-----------------

#include <scanlab/rtc6.h>

and link with

-lpthread -lrtc6

Please also refer the the RTC6 user manual for OS independent information.
