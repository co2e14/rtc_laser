//  File: RTC4ethWrap.cs
//-----------------------------------------------------------------------------
//  Copyright (c) 2022 by SCANLAB GmbH.                    All rights reserved.
//-----------------------------------------------------------------------------
//
//
//  Abstract
//      Defines the RTC4ethWrap class that imports RTC4eth functions
//      from RTC4eth's dynamic-link library.
//      RTC4ethWrap automatically selects RTC4eth’s 64-bit version
//      RTC4ethDLLx64.dll, if the 64-bit runtime is in use. Otherwise, the
//      32-bit version RTC4ethDLL.DLL is going to be selected. That is,
//      RTC4ethWrap is good to compile for the platform targets x86, x64,
//      or 'Any CPU', where the application, which is compiled for 'Any CPU',
//      is able to run under 32-bit or 64-bit operating systems, as well.
//
//  Author
//      Christian Lutz, Bernhard Schrems, Andreas J. Reichel
//
//      This file was automatically generated on 2022-01-21
//
//  NOTE
//      THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
//      KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//      IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
//      PURPOSE.
//
//-----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;

namespace RTC4ethImport
{
    /// <summary>
    /// Static RTC4eth Wrapper class.
    /// Notice that the construction of the RTC4ethWrap object or an initial
    /// call of any RTC4ethWrap method may throw a TypeInitializationException
    /// exception, which indicates that the required DLL is missing or the
    /// import of a particular DLL function failed. In order to analyze and
    /// properly handle such an error condition you need to catch that
    /// TypeInitializationException type exception.
    /// </summary>
    public class RTC4ethWrap
    {
        const int SampleArraySize = 32768;

        const string RTC4ethDLLx86 = "RTC4ethDLL.dll";     // DLL's 32-bit version.
        const string RTC4ethDLLx64 = "RTC4ethDLLx64.dll";  // DLL's 64-bit version.

        class FunctionImporter
        {
            static string RTC4ethDLL;

            [DllImport("Kernel32.dll")]
            private extern static IntPtr LoadLibrary(string path);

            [DllImport("kernel32.dll")]
            public extern static bool FreeLibrary(IntPtr hModule);

            [DllImport("Kernel32.dll")]
            private extern static IntPtr GetProcAddress(IntPtr hModule,
                                                        string procName);

            static IntPtr hModule;

            static FunctionImporter instance = null;

            protected FunctionImporter(string DllName)
            {
                hModule = LoadLibrary(DllName);
            }

            ~FunctionImporter()
            {
                if (hModule != IntPtr.Zero)
                    FreeLibrary(hModule);
            }


            public static void Unload()
            {
                if (instance != null)
                {
                    instance = null;
                }
            }


            public static void Load(String dll_name)
            {
                RTC4ethDLL = dll_name;
            }

                        
            public static Delegate Import<T>(string functionName)
            {
                if (instance == null)
                {
                    instance = new FunctionImporter(RTC4ethDLL);

                    if (hModule == IntPtr.Zero)
                        throw new System.IO.
                                FileNotFoundException(RTC4ethDLL + " not found. ");
                }
                var functionAddress = GetProcAddress(hModule, functionName);
                try
                {
                    return Marshal.
                        GetDelegateForFunctionPointer(functionAddress, typeof(T));
                }
                catch (Exception ex)
                {
                    if ((ex is ArgumentException) || (ex is ArgumentNullException))
                        throw new EntryPointNotFoundException(functionName);
                    else throw;
                }
            }
        }


        #region DLLFunctionDelegates
        public delegate uint get_driver_statusDelegate();
        public delegate uint get_net_dll_versionDelegate();
        public delegate uint acquire_rtcDelegate(uint card_no);
        public delegate uint release_rtcDelegate(uint card_no);
        public delegate void select_rtcDelegate(ushort card_no);
        public delegate uint assign_rtcDelegate(ushort search_no, ushort card_no);
        public delegate uint assign_rtc_by_ipDelegate(uint ip, ushort card_no);
        public delegate void remove_rtcDelegate(ushort card_no);
        public delegate uint convert_string_to_ipDelegate(string ip);
        public delegate void convert_ip_to_stringDelegate(uint ip, IntPtr cpip);
        public delegate void convert_mac_to_stringDelegate(long mac, IntPtr cpmac);
        public delegate uint rtc_search_cardsDelegate(out ushort cards, uint ip, uint netmask);
        public delegate long get_mac_addressDelegate(ushort cardno);
        public delegate uint get_ip_addressDelegate(ushort cardno);
        public delegate uint get_serialDelegate(ushort cardno);
        public delegate ushort get_connection_statusDelegate(ushort cardno);
        public delegate uint get_master_ip_addressDelegate(ushort cardno);
        public delegate uint get_master_idDelegate(ushort cardno, IntPtr id);
        public delegate uint set_static_ipDelegate(uint ip, uint netmask, uint gateway);
        public delegate uint get_static_ipDelegate(out uint ip, out uint netmask, out uint gateway);
        public delegate uint get_mcu_fw_versionDelegate(ushort cardno);
        public delegate uint get_nic_ip_countDelegate(out ushort count);
        public delegate void get_nic_ipDelegate(ushort count, out uint ip, out uint nm);
        public delegate void n_get_waveformDelegate(ushort n, ushort channel, ushort istop, [MarshalAs(UnmanagedType.LPArray, SizeConst=SampleArraySize)] short[] memptr);
        public delegate void get_waveformDelegate(ushort channel, ushort istop, [MarshalAs(UnmanagedType.LPArray, SizeConst=SampleArraySize)] short[] memptr);
        public delegate void n_measurement_statusDelegate(ushort n, out ushort busy, out ushort position);
        public delegate void measurement_statusDelegate(out ushort busy, out ushort position);
        public delegate void n_set_triggerDelegate(ushort n, ushort sampleperiod, ushort channel1, ushort channel2);
        public delegate void set_triggerDelegate(ushort sampleperiod, ushort signal1, ushort signal2);
        public delegate short n_get_valueDelegate(ushort n, ushort signal);
        public delegate short get_valueDelegate(ushort signal);
        public delegate void n_set_io_bitDelegate(ushort n, ushort mask1);
        public delegate void set_io_bitDelegate(ushort mask1);
        public delegate void n_clear_io_bitDelegate(ushort n, ushort mask0);
        public delegate void clear_io_bitDelegate(ushort mask0);
        public delegate void n_move_toDelegate(ushort n, ushort position);
        public delegate void move_toDelegate(ushort position);
        public delegate void n_control_commandDelegate(ushort n, ushort head, ushort axis, ushort data);
        public delegate void control_commandDelegate(ushort head, ushort axis, ushort data);
        public delegate void n_arc_relDelegate(ushort n, short dx, short dy, double angle);
        public delegate void arc_relDelegate(short dx, short dy, double angle);
        public delegate void n_arc_absDelegate(ushort n, short x, short y, double angle);
        public delegate void arc_absDelegate(short x, short y, double angle);
        public delegate void drillingDelegate(short pulsewidth, short relencoderdelay);
        public delegate void regulationDelegate();
        public delegate void flylineDelegate(short encoderdelay);
        public delegate void set_duty_cycle_tableDelegate(ushort index, ushort dutycycle);
        public delegate short n_load_varpolydelayDelegate(ushort n, string stbfilename, ushort tableno);
        public delegate short load_varpolydelayDelegate(string stbfilename, ushort tableno);
        public delegate short n_load_program_fileDelegate(ushort n, string name);
        public delegate short load_program_fileDelegate(string name);
        public delegate short n_load_correction_fileDelegate(ushort n, string filename, short cortable, double kx, double ky, double phi, double xoffset, double yoffset);
        public delegate short load_correction_fileDelegate(string filename, short cortable, double kx, double ky, double phi, double xoffset, double yoffset);
        public delegate short n_load_z_tableDelegate(ushort n, double a, double b, double c);
        public delegate short load_z_tableDelegate(double a, double b, double c);
        public delegate void n_list_nopDelegate(ushort n);
        public delegate void list_nopDelegate();
        public delegate void n_set_end_of_listDelegate(ushort n);
        public delegate void set_end_of_listDelegate();
        public delegate void n_jump_abs_3dDelegate(ushort n, short x, short y, short z);
        public delegate void jump_abs_3dDelegate(short x, short y, short z);
        public delegate void n_jump_absDelegate(ushort n, short x, short y);
        public delegate void jump_absDelegate(short x, short y);
        public delegate void n_mark_abs_3dDelegate(ushort n, short x, short y, short z);
        public delegate void mark_abs_3dDelegate(short x, short y, short z);
        public delegate void n_mark_absDelegate(ushort n, short x, short y);
        public delegate void mark_absDelegate(short x, short y);
        public delegate void n_jump_rel_3dDelegate(ushort n, short dx, short dy, short dz);
        public delegate void jump_rel_3dDelegate(short dx, short dy, short dz);
        public delegate void n_jump_relDelegate(ushort n, short dx, short dy);
        public delegate void jump_relDelegate(short dx, short dy);
        public delegate void n_mark_rel_3dDelegate(ushort n, short dx, short dy, short dz);
        public delegate void mark_rel_3dDelegate(short dx, short dy, short dz);
        public delegate void n_mark_relDelegate(ushort n, short dx, short dy);
        public delegate void mark_relDelegate(short dx, short dy);
        public delegate void n_write_8bit_port_listDelegate(ushort n, ushort value);
        public delegate void write_8bit_port_listDelegate(ushort value);
        public delegate void n_write_da_1_listDelegate(ushort n, ushort value);
        public delegate void write_da_1_listDelegate(ushort value);
        public delegate void n_write_da_2_listDelegate(ushort n, ushort value);
        public delegate void write_da_2_listDelegate(ushort value);
        public delegate void n_set_matrix_listDelegate(ushort n, ushort i, ushort j, double mij);
        public delegate void set_matrix_listDelegate(ushort i, ushort j, double mij);
        public delegate void n_set_offset_listDelegate(ushort n, short xoffset, short yoffset);
        public delegate void set_offset_listDelegate(short xoffset, short yoffset);
        public delegate void n_set_defocus_listDelegate(ushort n, short value);
        public delegate void set_defocus_listDelegate(short value);
        public delegate void n_set_defocusDelegate(ushort n, short value);
        public delegate void set_defocusDelegate(short value);
        public delegate void n_set_softstart_modeDelegate(ushort n, ushort mode, ushort number, ushort restartdelay);
        public delegate void set_softstart_modeDelegate(ushort mode, ushort number, ushort resetdelay);
        public delegate void n_set_softstart_levelDelegate(ushort n, ushort index, ushort level);
        public delegate void set_softstart_levelDelegate(ushort index, ushort level);
        public delegate void n_set_control_mode_listDelegate(ushort n, ushort mode);
        public delegate void set_control_mode_listDelegate(ushort mode);
        public delegate void n_set_control_modeDelegate(ushort n, ushort mode);
        public delegate void set_control_modeDelegate(ushort mode);
        public delegate void n_long_delayDelegate(ushort n, ushort value);
        public delegate void long_delayDelegate(ushort value);
        public delegate void n_laser_on_listDelegate(ushort n, ushort value);
        public delegate void laser_on_listDelegate(ushort value);
        public delegate void n_set_jump_speedDelegate(ushort n, double speed);
        public delegate void set_jump_speedDelegate(double speed);
        public delegate void n_set_mark_speedDelegate(ushort n, double speed);
        public delegate void set_mark_speedDelegate(double speed);
        public delegate void n_set_laser_delaysDelegate(ushort n, short ondelay, short offdelay);
        public delegate void set_laser_delaysDelegate(short ondelay, short offdelay);
        public delegate void n_set_scanner_delaysDelegate(ushort n, ushort jumpdelay, ushort markdelay, ushort polydelay);
        public delegate void set_scanner_delaysDelegate(ushort jumpdelay, ushort markdelay, ushort polydelay);
        public delegate void n_set_list_jumpDelegate(ushort n, ushort position);
        public delegate void set_list_jumpDelegate(ushort position);
        public delegate void n_set_input_pointerDelegate(ushort n, ushort pointer);
        public delegate void set_input_pointerDelegate(ushort pointer);
        public delegate void n_list_callDelegate(ushort n, ushort position);
        public delegate void list_callDelegate(ushort position);
        public delegate void n_list_returnDelegate(ushort n);
        public delegate void list_returnDelegate();
        public delegate void n_z_out_listDelegate(ushort n, short z);
        public delegate void z_out_listDelegate(short z);
        public delegate void n_set_standby_listDelegate(ushort n, ushort half_period, ushort pulse);
        public delegate void set_standby_listDelegate(ushort half_period, ushort pulse);
        public delegate void n_timed_jump_absDelegate(ushort n, short x, short y, double time);
        public delegate void timed_jump_absDelegate(short x, short y, double time);
        public delegate void n_timed_mark_absDelegate(ushort n, short x, short y, double time);
        public delegate void timed_mark_absDelegate(short x, short y, double time);
        public delegate void n_timed_jump_relDelegate(ushort n, short dx, short dy, double time);
        public delegate void timed_jump_relDelegate(short dx, short dy, double time);
        public delegate void n_timed_mark_relDelegate(ushort n, short dx, short dy, double time);
        public delegate void timed_mark_relDelegate(short dx, short dy, double time);
        public delegate void n_set_laser_timingDelegate(ushort n, ushort halfperiod, ushort pulse1, ushort pulse2, ushort timebase);
        public delegate void set_laser_timingDelegate(ushort halfperiod, ushort pulse1, ushort pulse2, ushort timebase);
        public delegate void n_set_wobbelDelegate(ushort n, ushort amplitude, double frequency);
        public delegate void set_wobbelDelegate(ushort amplitude, double frequency);
        public delegate void n_set_wobbel_xyDelegate(ushort n, ushort long_wob, ushort trans_wob, double frequency);
        public delegate void set_wobbel_xyDelegate(ushort long_wob, ushort trans_wob, double frequency);
        public delegate void n_set_fly_xDelegate(ushort n, double kx);
        public delegate void set_fly_xDelegate(double kx);
        public delegate void n_set_fly_yDelegate(ushort n, double ky);
        public delegate void set_fly_yDelegate(double ky);
        public delegate void n_set_fly_rotDelegate(ushort n, double resolution);
        public delegate void set_fly_rotDelegate(double resolution);
        public delegate void n_fly_returnDelegate(ushort n, short x, short y);
        public delegate void fly_returnDelegate(short x, short y);
        public delegate void n_calculate_flyDelegate(ushort n, ushort direction, double distance);
        public delegate void calculate_flyDelegate(ushort direction, double distance);
        public delegate void n_write_io_port_listDelegate(ushort n, ushort value);
        public delegate void write_io_port_listDelegate(ushort value);
        public delegate void n_select_cor_table_listDelegate(ushort n, ushort heada, ushort headb);
        public delegate void select_cor_table_listDelegate(ushort heada, ushort headb);
        public delegate void n_set_waitDelegate(ushort n, ushort value);
        public delegate void set_waitDelegate(ushort value);
        public delegate void n_simulate_ext_startDelegate(ushort n, short delay, short encoder);
        public delegate void simulate_ext_startDelegate(short delay, short encoder);
        public delegate void n_write_da_x_listDelegate(ushort n, ushort x, ushort value);
        public delegate void write_da_x_listDelegate(ushort x, ushort value);
        public delegate void n_set_pixel_lineDelegate(ushort n, ushort pixelmode, ushort pixelperiod, double dx, double dy);
        public delegate void set_pixel_lineDelegate(ushort pixelmode, ushort pixelperiod, double dx, double dy);
        public delegate void n_set_pixelDelegate(ushort n, ushort pulswidth, ushort davalue, ushort adchannel);
        public delegate void set_pixelDelegate(ushort pulswidth, ushort davalue, ushort adchannel);
        public delegate void n_set_extstartpos_listDelegate(ushort n, ushort position);
        public delegate void set_extstartpos_listDelegate(ushort position);
        public delegate void n_laser_signal_on_listDelegate(ushort n);
        public delegate void laser_signal_on_listDelegate();
        public delegate void n_laser_signal_off_listDelegate(ushort n);
        public delegate void laser_signal_off_listDelegate();
        public delegate void n_set_firstpulse_killer_listDelegate(ushort n, ushort fpk);
        public delegate void set_firstpulse_killer_listDelegate(ushort fpk);
        public delegate void n_set_io_cond_listDelegate(ushort n, ushort mask_1, ushort mask_0, ushort mask_set);
        public delegate void set_io_cond_listDelegate(ushort mask_1, ushort mask_0, ushort mask_set);
        public delegate void n_clear_io_cond_listDelegate(ushort n, ushort mask_1, ushort mask_0, ushort mask_clear);
        public delegate void clear_io_cond_listDelegate(ushort mask_1, ushort mask_0, ushort mask_clear);
        public delegate void n_list_jump_condDelegate(ushort n, ushort mask_1, ushort mask_0, ushort position);
        public delegate void list_jump_condDelegate(ushort mask_1, ushort mask_0, ushort position);
        public delegate void n_list_call_condDelegate(ushort n, ushort mask_1, ushort mask_0, ushort position);
        public delegate void list_call_condDelegate(ushort mask_1, ushort mask_0, ushort position);
        public delegate ushort n_get_input_pointerDelegate(ushort n);
        public delegate ushort get_input_pointerDelegate();
        public delegate ushort rtc4_max_cardsDelegate();
        public delegate void n_get_statusDelegate(ushort n, out ushort busy, out ushort position);
        public delegate void get_statusDelegate(out ushort busy, out ushort position);
        public delegate ushort n_read_statusDelegate(ushort n);
        public delegate ushort read_statusDelegate();
        public delegate ushort n_get_startstop_infoDelegate(ushort n);
        public delegate ushort get_startstop_infoDelegate();
        public delegate ushort n_get_marking_infoDelegate(ushort n);
        public delegate ushort get_marking_infoDelegate();
        public delegate ushort get_dll_versionDelegate();
        public delegate void n_set_start_list_1Delegate(ushort n);
        public delegate void set_start_list_1Delegate();
        public delegate void n_set_start_list_2Delegate(ushort n);
        public delegate void set_start_list_2Delegate();
        public delegate void n_set_start_listDelegate(ushort n, ushort listno);
        public delegate void set_start_listDelegate(ushort listno);
        public delegate void n_execute_list_1Delegate(ushort n);
        public delegate void execute_list_1Delegate();
        public delegate void n_execute_list_2Delegate(ushort n);
        public delegate void execute_list_2Delegate();
        public delegate void n_execute_listDelegate(ushort n, ushort listno);
        public delegate void execute_listDelegate(ushort listno);
        public delegate void n_write_8bit_portDelegate(ushort n, ushort value);
        public delegate void write_8bit_portDelegate(ushort value);
        public delegate void n_write_io_portDelegate(ushort n, ushort value);
        public delegate void write_io_portDelegate(ushort value);
        public delegate int n_eth_statusDelegate(ushort n);
        public delegate int eth_statusDelegate();
        public delegate void n_auto_changeDelegate(ushort n);
        public delegate void auto_changeDelegate();
        public delegate void n_auto_change_posDelegate(ushort n, ushort start);
        public delegate void auto_change_posDelegate(ushort start);
        public delegate void aut_changeDelegate();
        public delegate void n_start_loopDelegate(ushort n);
        public delegate void start_loopDelegate();
        public delegate void n_quit_loopDelegate(ushort n);
        public delegate void quit_loopDelegate();
        public delegate void n_stop_executionDelegate(ushort n);
        public delegate void stop_executionDelegate();
        public delegate ushort n_read_io_portDelegate(ushort n);
        public delegate ushort read_io_portDelegate();
        public delegate void n_write_da_1Delegate(ushort n, ushort value);
        public delegate void write_da_1Delegate(ushort value);
        public delegate void n_write_da_2Delegate(ushort n, ushort value);
        public delegate void write_da_2Delegate(ushort value);
        public delegate void n_set_max_countsDelegate(ushort n, int counts);
        public delegate void set_max_countsDelegate(int counts);
        public delegate int n_get_countsDelegate(ushort n);
        public delegate int get_countsDelegate();
        public delegate void n_set_matrixDelegate(ushort n, double m11, double m12, double m21, double m22);
        public delegate void set_matrixDelegate(double m11, double m12, double m21, double m22);
        public delegate void n_set_offsetDelegate(ushort n, short xoffset, short yoffset);
        public delegate void set_offsetDelegate(short xoffset, short yoffset);
        public delegate void n_goto_xyzDelegate(ushort n, short x, short y, short z);
        public delegate void goto_xyzDelegate(short x, short y, short z);
        public delegate void n_goto_xyDelegate(ushort n, short x, short y);
        public delegate void goto_xyDelegate(short x, short y);
        public delegate ushort n_get_hex_versionDelegate(ushort n);
        public delegate ushort get_hex_versionDelegate();
        public delegate void n_disable_laserDelegate(ushort n);
        public delegate void disable_laserDelegate();
        public delegate void n_enable_laserDelegate(ushort n);
        public delegate void enable_laserDelegate();
        public delegate void n_stop_listDelegate(ushort n);
        public delegate void stop_listDelegate();
        public delegate void n_restart_listDelegate(ushort n);
        public delegate void restart_listDelegate();
        public delegate void n_get_xyz_posDelegate(ushort n, out short x, out short y, out short z);
        public delegate void get_xyz_posDelegate(out short x, out short y, out short z);
        public delegate void n_get_xy_posDelegate(ushort n, out short x, out short y);
        public delegate void get_xy_posDelegate(out short x, out short y);
        public delegate void n_select_listDelegate(ushort n, ushort list_2);
        public delegate void select_listDelegate(ushort list_2);
        public delegate void n_z_outDelegate(ushort n, short z);
        public delegate void z_outDelegate(short z);
        public delegate void n_set_firstpulse_killerDelegate(ushort n, ushort fpk);
        public delegate void set_firstpulse_killerDelegate(ushort fpk);
        public delegate void n_set_standbyDelegate(ushort n, ushort half_period, ushort pulse);
        public delegate void set_standbyDelegate(ushort half_period, ushort pulse);
        public delegate void n_laser_signal_onDelegate(ushort n);
        public delegate void laser_signal_onDelegate();
        public delegate void n_laser_signal_offDelegate(ushort n);
        public delegate void laser_signal_offDelegate();
        public delegate void n_set_delay_modeDelegate(ushort n, ushort varpoly, ushort directmove3d, ushort edgelevel, ushort minjumpdelay, ushort jumplengthlimit);
        public delegate void set_delay_modeDelegate(ushort varpoly, ushort directmove3d, ushort edgelevel, ushort minjumpdelay, ushort jumplengthlimit);
        public delegate void n_set_piso_controlDelegate(ushort n, ushort l1, ushort l2);
        public delegate void set_piso_controlDelegate(ushort l1, ushort l2);
        public delegate void n_select_statusDelegate(ushort n, ushort mode);
        public delegate void select_statusDelegate(ushort mode);
        public delegate void n_get_encoderDelegate(ushort n, out short zx, out short zy);
        public delegate void get_encoderDelegate(out short zx, out short zy);
        public delegate void n_select_cor_tableDelegate(ushort n, ushort heada, ushort headb);
        public delegate void select_cor_tableDelegate(ushort heada, ushort headb);
        public delegate void n_execute_at_pointerDelegate(ushort n, ushort position);
        public delegate void execute_at_pointerDelegate(ushort position);
        public delegate ushort n_get_head_statusDelegate(ushort n, ushort head);
        public delegate ushort get_head_statusDelegate(ushort head);
        public delegate void n_simulate_encoderDelegate(ushort n, ushort channel);
        public delegate void simulate_encoderDelegate(ushort channel);
        public delegate void n_release_waitDelegate(ushort n);
        public delegate void release_waitDelegate();
        public delegate ushort n_get_wait_statusDelegate(ushort n);
        public delegate ushort get_wait_statusDelegate();
        public delegate void n_set_laser_modeDelegate(ushort n, ushort mode);
        public delegate void set_laser_modeDelegate(ushort mode);
        public delegate void n_set_ext_start_delayDelegate(ushort n, short delay, short encoder);
        public delegate void set_ext_start_delayDelegate(short delay, short encoder);
        public delegate void n_home_positionDelegate(ushort n, short xhome, short yhome);
        public delegate void home_positionDelegate(short xhome, short yhome);
        public delegate void n_set_rot_centerDelegate(ushort n, int center_x, int center_y);
        public delegate void set_rot_centerDelegate(int center_x, int center_y);
        public delegate void n_dsp_startDelegate(ushort n);
        public delegate void dsp_startDelegate();
        public delegate void n_write_da_xDelegate(ushort n, ushort x, ushort value);
        public delegate void write_da_xDelegate(ushort x, ushort value);
        public delegate ushort n_read_ad_xDelegate(ushort n, ushort x);
        public delegate ushort read_ad_xDelegate(ushort x);
        public delegate ushort n_read_pixel_adDelegate(ushort n, ushort pos);
        public delegate ushort read_pixel_adDelegate(ushort pos);
        public delegate short n_get_z_distanceDelegate(ushort n, short x, short y, short z);
        public delegate short get_z_distanceDelegate(short x, short y, short z);
        public delegate ushort n_get_io_statusDelegate(ushort n);
        public delegate ushort get_io_statusDelegate();
        public delegate short load_corDelegate(string filename);
        public delegate short load_proDelegate(string filename);
        public delegate ushort n_get_serial_numberDelegate(ushort n);
        public delegate ushort get_serial_numberDelegate();
        public delegate int n_get_serial_number_32Delegate(ushort n);
        public delegate int get_serial_number_32Delegate();
        public delegate ushort n_get_rtc_versionDelegate(ushort n);
        public delegate ushort get_rtc_versionDelegate();
        public delegate short n_auto_calDelegate(ushort n, ushort head, ushort command);
        public delegate short auto_calDelegate(ushort head, ushort command);
        public delegate void n_set_hiDelegate(ushort n, double galvogainx, double galvogainy, short galvooffsetx, short galvooffsety, short head);
        public delegate void set_hiDelegate(double galvogainx, double galvogainy, short galvooffsetx, short galvooffsety, short head);
        public delegate void n_set_list_modeDelegate(ushort n, ushort mode);
        public delegate void set_list_modeDelegate(ushort mode);
        public delegate ushort n_get_list_spaceDelegate(ushort n);
        public delegate ushort get_list_spaceDelegate();
        public delegate void n_save_and_restart_timerDelegate(ushort n);
        public delegate void save_and_restart_timerDelegate();
        public delegate void n_set_ext_start_delay_listDelegate(ushort n, short delay, short encoder);
        public delegate void set_ext_start_delay_listDelegate(short delay, short encoder);
        public delegate double n_get_timeDelegate(ushort n);
        public delegate double get_timeDelegate();
        public delegate void get_hi_dataDelegate(out ushort x1, out ushort x2, out ushort y1, out ushort y2);
        public delegate short teachinDelegate(string filename, short xin, short yin, short zin, double ll0, out short xout, out short yout, out short zout);
        public delegate short getmemoryDelegate(ushort adr);
        public delegate void set_timeoutDelegate(uint timeout);
        public delegate void set_timeoutsDelegate(uint acquire_timeout_us, uint acquire_max_retries, uint send_recv_timeout_us, uint send_recv_max_retries, uint acqu_rel_min_intvl_ms);
        public delegate void get_timeoutsDelegate(out uint acquire_timeout_us, out uint acquire_max_retries, out uint send_recv_timeout_us, out uint send_recv_max_retries, out uint acqu_rel_min_intvl_ms);
        public delegate uint rs232_configDelegate(uint baudrate, uint parity, uint stopbits);
        public delegate uint n_rs232_configDelegate(ushort n, uint baudrate, uint parity, uint stopbits);
        public delegate uint rs232_write_dataDelegate(uint data);
        public delegate uint n_rs232_write_dataDelegate(ushort n, uint data);
        public delegate uint rs232_write_textDelegate(string text);
        public delegate uint n_rs232_write_textDelegate(ushort n, string text);
        public delegate uint rs232_read_dataDelegate(out uint data);
        public delegate uint n_rs232_read_dataDelegate(ushort n, out uint data);
        public delegate void n_eth_set_com_timeouts_autoDelegate(ushort cardno, double initial_timeout_ms, double sum_timeout_ms, double multiplicator, int mode);
        public delegate void eth_set_com_timeouts_autoDelegate(double initial_timeout_ms, double sum_timeout_ms, double multiplicator, int mode);
        public delegate void n_eth_get_com_timeouts_autoDelegate(ushort cardno, out double initial_timeout_ms, out double sum_timeout_ms, out double multiplicator, out int mode);
        public delegate void eth_get_com_timeouts_autoDelegate(out double initial_timeout_ms, out double sum_timeout_ms, out double multiplicator, out int mode);
        public delegate uint n_eth_watchdog_timer_configDelegate(ushort n, uint timer_ms);
        public delegate uint eth_watchdog_timer_configDelegate(uint timer_ms);
        public delegate uint n_eth_watchdog_timer_resetDelegate(ushort n);
        public delegate uint eth_watchdog_timer_resetDelegate();
        public delegate void n_eth_link_loss_configDelegate(ushort n, uint mode);
        public delegate void eth_link_loss_configDelegate(uint mode);
        public delegate uint n_eth_get_last_errorDelegate(ushort n);
        public delegate uint eth_get_last_errorDelegate();
        public delegate uint n_eth_get_errorDelegate(ushort n);
        public delegate uint eth_get_errorDelegate();
        public delegate uint n_eth_error_dumpDelegate(ushort n, [MarshalAs(UnmanagedType.LPArray, SizeConst=4)] uint[] dump);
        public delegate uint eth_error_dumpDelegate([MarshalAs(UnmanagedType.LPArray, SizeConst=4)] uint[] dump);
        #endregion

        #region DLLFunctionSummaries
        /// <summary>
        ///  uint get_driver_status();
        /// </summary>
        public static get_driver_statusDelegate get_driver_status;

        /// <summary>
        ///  uint get_net_dll_version();
        /// </summary>
        public static get_net_dll_versionDelegate get_net_dll_version;

        /// <summary>
        ///  uint acquire_rtc(uint card_no);
        /// </summary>
        public static acquire_rtcDelegate acquire_rtc;

        /// <summary>
        ///  uint release_rtc(uint card_no);
        /// </summary>
        public static release_rtcDelegate release_rtc;

        /// <summary>
        ///  void select_rtc(ushort card_no);
        /// </summary>
        public static select_rtcDelegate select_rtc;

        /// <summary>
        ///  uint assign_rtc(ushort search_no, ushort card_no);
        /// </summary>
        public static assign_rtcDelegate assign_rtc;

        /// <summary>
        ///  uint assign_rtc_by_ip(uint ip, ushort card_no);
        /// </summary>
        public static assign_rtc_by_ipDelegate assign_rtc_by_ip;

        /// <summary>
        ///  void remove_rtc(ushort card_no);
        /// </summary>
        public static remove_rtcDelegate remove_rtc;

        /// <summary>
        ///  uint convert_string_to_ip(string ip);
        /// </summary>
        public static convert_string_to_ipDelegate convert_string_to_ip;

        /// <summary>
        ///  void convert_ip_to_string(uint ip, IntPtr cpip);
        /// </summary>
        public static convert_ip_to_stringDelegate convert_ip_to_string;

        /// <summary>
        ///  void convert_mac_to_string(long mac, IntPtr cpmac);
        /// </summary>
        public static convert_mac_to_stringDelegate convert_mac_to_string;

        /// <summary>
        ///  uint rtc_search_cards(out ushort cards, uint ip, uint netmask);
        /// </summary>
        public static rtc_search_cardsDelegate rtc_search_cards;

        /// <summary>
        ///  long get_mac_address(ushort cardno);
        /// </summary>
        public static get_mac_addressDelegate get_mac_address;

        /// <summary>
        ///  uint get_ip_address(ushort cardno);
        /// </summary>
        public static get_ip_addressDelegate get_ip_address;

        /// <summary>
        ///  uint get_serial(ushort cardno);
        /// </summary>
        public static get_serialDelegate get_serial;

        /// <summary>
        ///  ushort get_connection_status(ushort cardno);
        /// </summary>
        public static get_connection_statusDelegate get_connection_status;

        /// <summary>
        ///  uint get_master_ip_address(ushort cardno);
        /// </summary>
        public static get_master_ip_addressDelegate get_master_ip_address;

        /// <summary>
        ///  uint get_master_id(ushort cardno, IntPtr id);
        /// </summary>
        public static get_master_idDelegate get_master_id;

        /// <summary>
        ///  uint set_static_ip(uint ip, uint netmask, uint gateway);
        /// </summary>
        public static set_static_ipDelegate set_static_ip;

        /// <summary>
        ///  uint get_static_ip(out uint ip, out uint netmask, out uint gateway);
        /// </summary>
        public static get_static_ipDelegate get_static_ip;

        /// <summary>
        ///  uint get_mcu_fw_version(ushort cardno);
        /// </summary>
        public static get_mcu_fw_versionDelegate get_mcu_fw_version;

        /// <summary>
        ///  uint get_nic_ip_count(out ushort count);
        /// </summary>
        public static get_nic_ip_countDelegate get_nic_ip_count;

        /// <summary>
        ///  void get_nic_ip(ushort count, out uint ip, out uint nm);
        /// </summary>
        public static get_nic_ipDelegate get_nic_ip;

        /// <summary>
        ///  void n_get_waveform(ushort n, ushort channel, ushort istop, short[] memptr);
        /// </summary>
        public static n_get_waveformDelegate n_get_waveform;

        /// <summary>
        ///  void get_waveform(ushort channel, ushort istop, short[] memptr);
        /// </summary>
        public static get_waveformDelegate get_waveform;

        /// <summary>
        ///  void n_measurement_status(ushort n, out ushort busy, out ushort position);
        /// </summary>
        public static n_measurement_statusDelegate n_measurement_status;

        /// <summary>
        ///  void measurement_status(out ushort busy, out ushort position);
        /// </summary>
        public static measurement_statusDelegate measurement_status;

        /// <summary>
        ///  void n_set_trigger(ushort n, ushort sampleperiod, ushort channel1, ushort channel2);
        /// </summary>
        public static n_set_triggerDelegate n_set_trigger;

        /// <summary>
        ///  void set_trigger(ushort sampleperiod, ushort signal1, ushort signal2);
        /// </summary>
        public static set_triggerDelegate set_trigger;

        /// <summary>
        ///  short n_get_value(ushort n, ushort signal);
        /// </summary>
        public static n_get_valueDelegate n_get_value;

        /// <summary>
        ///  short get_value(ushort signal);
        /// </summary>
        public static get_valueDelegate get_value;

        /// <summary>
        ///  void n_set_io_bit(ushort n, ushort mask1);
        /// </summary>
        public static n_set_io_bitDelegate n_set_io_bit;

        /// <summary>
        ///  void set_io_bit(ushort mask1);
        /// </summary>
        public static set_io_bitDelegate set_io_bit;

        /// <summary>
        ///  void n_clear_io_bit(ushort n, ushort mask0);
        /// </summary>
        public static n_clear_io_bitDelegate n_clear_io_bit;

        /// <summary>
        ///  void clear_io_bit(ushort mask0);
        /// </summary>
        public static clear_io_bitDelegate clear_io_bit;

        /// <summary>
        ///  void n_move_to(ushort n, ushort position);
        /// </summary>
        public static n_move_toDelegate n_move_to;

        /// <summary>
        ///  void move_to(ushort position);
        /// </summary>
        public static move_toDelegate move_to;

        /// <summary>
        ///  void n_control_command(ushort n, ushort head, ushort axis, ushort data);
        /// </summary>
        public static n_control_commandDelegate n_control_command;

        /// <summary>
        ///  void control_command(ushort head, ushort axis, ushort data);
        /// </summary>
        public static control_commandDelegate control_command;

        /// <summary>
        ///  void n_arc_rel(ushort n, short dx, short dy, double angle);
        /// </summary>
        public static n_arc_relDelegate n_arc_rel;

        /// <summary>
        ///  void arc_rel(short dx, short dy, double angle);
        /// </summary>
        public static arc_relDelegate arc_rel;

        /// <summary>
        ///  void n_arc_abs(ushort n, short x, short y, double angle);
        /// </summary>
        public static n_arc_absDelegate n_arc_abs;

        /// <summary>
        ///  void arc_abs(short x, short y, double angle);
        /// </summary>
        public static arc_absDelegate arc_abs;

        /// <summary>
        ///  void drilling(short pulsewidth, short relencoderdelay);
        /// </summary>
        public static drillingDelegate drilling;

        /// <summary>
        ///  void regulation();
        /// </summary>
        public static regulationDelegate regulation;

        /// <summary>
        ///  void flyline(short encoderdelay);
        /// </summary>
        public static flylineDelegate flyline;

        /// <summary>
        ///  void set_duty_cycle_table(ushort index, ushort dutycycle);
        /// </summary>
        public static set_duty_cycle_tableDelegate set_duty_cycle_table;

        /// <summary>
        ///  short n_load_varpolydelay(ushort n, string stbfilename, ushort tableno);
        /// </summary>
        public static n_load_varpolydelayDelegate n_load_varpolydelay;

        /// <summary>
        ///  short load_varpolydelay(string stbfilename, ushort tableno);
        /// </summary>
        public static load_varpolydelayDelegate load_varpolydelay;

        /// <summary>
        ///  short n_load_program_file(ushort n, string name);
        /// </summary>
        public static n_load_program_fileDelegate n_load_program_file;

        /// <summary>
        ///  short load_program_file(string name);
        /// </summary>
        public static load_program_fileDelegate load_program_file;

        /// <summary>
        ///  short n_load_correction_file(ushort n, string filename, short cortable, double kx, double ky, double phi, double xoffset, double yoffset);
        /// </summary>
        public static n_load_correction_fileDelegate n_load_correction_file;

        /// <summary>
        ///  short load_correction_file(string filename, short cortable, double kx, double ky, double phi, double xoffset, double yoffset);
        /// </summary>
        public static load_correction_fileDelegate load_correction_file;

        /// <summary>
        ///  short n_load_z_table(ushort n, double a, double b, double c);
        /// </summary>
        public static n_load_z_tableDelegate n_load_z_table;

        /// <summary>
        ///  short load_z_table(double a, double b, double c);
        /// </summary>
        public static load_z_tableDelegate load_z_table;

        /// <summary>
        ///  void n_list_nop(ushort n);
        /// </summary>
        public static n_list_nopDelegate n_list_nop;

        /// <summary>
        ///  void list_nop();
        /// </summary>
        public static list_nopDelegate list_nop;

        /// <summary>
        ///  void n_set_end_of_list(ushort n);
        /// </summary>
        public static n_set_end_of_listDelegate n_set_end_of_list;

        /// <summary>
        ///  void set_end_of_list();
        /// </summary>
        public static set_end_of_listDelegate set_end_of_list;

        /// <summary>
        ///  void n_jump_abs_3d(ushort n, short x, short y, short z);
        /// </summary>
        public static n_jump_abs_3dDelegate n_jump_abs_3d;

        /// <summary>
        ///  void jump_abs_3d(short x, short y, short z);
        /// </summary>
        public static jump_abs_3dDelegate jump_abs_3d;

        /// <summary>
        ///  void n_jump_abs(ushort n, short x, short y);
        /// </summary>
        public static n_jump_absDelegate n_jump_abs;

        /// <summary>
        ///  void jump_abs(short x, short y);
        /// </summary>
        public static jump_absDelegate jump_abs;

        /// <summary>
        ///  void n_mark_abs_3d(ushort n, short x, short y, short z);
        /// </summary>
        public static n_mark_abs_3dDelegate n_mark_abs_3d;

        /// <summary>
        ///  void mark_abs_3d(short x, short y, short z);
        /// </summary>
        public static mark_abs_3dDelegate mark_abs_3d;

        /// <summary>
        ///  void n_mark_abs(ushort n, short x, short y);
        /// </summary>
        public static n_mark_absDelegate n_mark_abs;

        /// <summary>
        ///  void mark_abs(short x, short y);
        /// </summary>
        public static mark_absDelegate mark_abs;

        /// <summary>
        ///  void n_jump_rel_3d(ushort n, short dx, short dy, short dz);
        /// </summary>
        public static n_jump_rel_3dDelegate n_jump_rel_3d;

        /// <summary>
        ///  void jump_rel_3d(short dx, short dy, short dz);
        /// </summary>
        public static jump_rel_3dDelegate jump_rel_3d;

        /// <summary>
        ///  void n_jump_rel(ushort n, short dx, short dy);
        /// </summary>
        public static n_jump_relDelegate n_jump_rel;

        /// <summary>
        ///  void jump_rel(short dx, short dy);
        /// </summary>
        public static jump_relDelegate jump_rel;

        /// <summary>
        ///  void n_mark_rel_3d(ushort n, short dx, short dy, short dz);
        /// </summary>
        public static n_mark_rel_3dDelegate n_mark_rel_3d;

        /// <summary>
        ///  void mark_rel_3d(short dx, short dy, short dz);
        /// </summary>
        public static mark_rel_3dDelegate mark_rel_3d;

        /// <summary>
        ///  void n_mark_rel(ushort n, short dx, short dy);
        /// </summary>
        public static n_mark_relDelegate n_mark_rel;

        /// <summary>
        ///  void mark_rel(short dx, short dy);
        /// </summary>
        public static mark_relDelegate mark_rel;

        /// <summary>
        ///  void n_write_8bit_port_list(ushort n, ushort value);
        /// </summary>
        public static n_write_8bit_port_listDelegate n_write_8bit_port_list;

        /// <summary>
        ///  void write_8bit_port_list(ushort value);
        /// </summary>
        public static write_8bit_port_listDelegate write_8bit_port_list;

        /// <summary>
        ///  void n_write_da_1_list(ushort n, ushort value);
        /// </summary>
        public static n_write_da_1_listDelegate n_write_da_1_list;

        /// <summary>
        ///  void write_da_1_list(ushort value);
        /// </summary>
        public static write_da_1_listDelegate write_da_1_list;

        /// <summary>
        ///  void n_write_da_2_list(ushort n, ushort value);
        /// </summary>
        public static n_write_da_2_listDelegate n_write_da_2_list;

        /// <summary>
        ///  void write_da_2_list(ushort value);
        /// </summary>
        public static write_da_2_listDelegate write_da_2_list;

        /// <summary>
        ///  void n_set_matrix_list(ushort n, ushort i, ushort j, double mij);
        /// </summary>
        public static n_set_matrix_listDelegate n_set_matrix_list;

        /// <summary>
        ///  void set_matrix_list(ushort i, ushort j, double mij);
        /// </summary>
        public static set_matrix_listDelegate set_matrix_list;

        /// <summary>
        ///  void n_set_offset_list(ushort n, short xoffset, short yoffset);
        /// </summary>
        public static n_set_offset_listDelegate n_set_offset_list;

        /// <summary>
        ///  void set_offset_list(short xoffset, short yoffset);
        /// </summary>
        public static set_offset_listDelegate set_offset_list;

        /// <summary>
        ///  void n_set_defocus_list(ushort n, short value);
        /// </summary>
        public static n_set_defocus_listDelegate n_set_defocus_list;

        /// <summary>
        ///  void set_defocus_list(short value);
        /// </summary>
        public static set_defocus_listDelegate set_defocus_list;

        /// <summary>
        ///  void n_set_defocus(ushort n, short value);
        /// </summary>
        public static n_set_defocusDelegate n_set_defocus;

        /// <summary>
        ///  void set_defocus(short value);
        /// </summary>
        public static set_defocusDelegate set_defocus;

        /// <summary>
        ///  void n_set_softstart_mode(ushort n, ushort mode, ushort number, ushort restartdelay);
        /// </summary>
        public static n_set_softstart_modeDelegate n_set_softstart_mode;

        /// <summary>
        ///  void set_softstart_mode(ushort mode, ushort number, ushort resetdelay);
        /// </summary>
        public static set_softstart_modeDelegate set_softstart_mode;

        /// <summary>
        ///  void n_set_softstart_level(ushort n, ushort index, ushort level);
        /// </summary>
        public static n_set_softstart_levelDelegate n_set_softstart_level;

        /// <summary>
        ///  void set_softstart_level(ushort index, ushort level);
        /// </summary>
        public static set_softstart_levelDelegate set_softstart_level;

        /// <summary>
        ///  void n_set_control_mode_list(ushort n, ushort mode);
        /// </summary>
        public static n_set_control_mode_listDelegate n_set_control_mode_list;

        /// <summary>
        ///  void set_control_mode_list(ushort mode);
        /// </summary>
        public static set_control_mode_listDelegate set_control_mode_list;

        /// <summary>
        ///  void n_set_control_mode(ushort n, ushort mode);
        /// </summary>
        public static n_set_control_modeDelegate n_set_control_mode;

        /// <summary>
        ///  void set_control_mode(ushort mode);
        /// </summary>
        public static set_control_modeDelegate set_control_mode;

        /// <summary>
        ///  void n_long_delay(ushort n, ushort value);
        /// </summary>
        public static n_long_delayDelegate n_long_delay;

        /// <summary>
        ///  void long_delay(ushort value);
        /// </summary>
        public static long_delayDelegate long_delay;

        /// <summary>
        ///  void n_laser_on_list(ushort n, ushort value);
        /// </summary>
        public static n_laser_on_listDelegate n_laser_on_list;

        /// <summary>
        ///  void laser_on_list(ushort value);
        /// </summary>
        public static laser_on_listDelegate laser_on_list;

        /// <summary>
        ///  void n_set_jump_speed(ushort n, double speed);
        /// </summary>
        public static n_set_jump_speedDelegate n_set_jump_speed;

        /// <summary>
        ///  void set_jump_speed(double speed);
        /// </summary>
        public static set_jump_speedDelegate set_jump_speed;

        /// <summary>
        ///  void n_set_mark_speed(ushort n, double speed);
        /// </summary>
        public static n_set_mark_speedDelegate n_set_mark_speed;

        /// <summary>
        ///  void set_mark_speed(double speed);
        /// </summary>
        public static set_mark_speedDelegate set_mark_speed;

        /// <summary>
        ///  void n_set_laser_delays(ushort n, short ondelay, short offdelay);
        /// </summary>
        public static n_set_laser_delaysDelegate n_set_laser_delays;

        /// <summary>
        ///  void set_laser_delays(short ondelay, short offdelay);
        /// </summary>
        public static set_laser_delaysDelegate set_laser_delays;

        /// <summary>
        ///  void n_set_scanner_delays(ushort n, ushort jumpdelay, ushort markdelay, ushort polydelay);
        /// </summary>
        public static n_set_scanner_delaysDelegate n_set_scanner_delays;

        /// <summary>
        ///  void set_scanner_delays(ushort jumpdelay, ushort markdelay, ushort polydelay);
        /// </summary>
        public static set_scanner_delaysDelegate set_scanner_delays;

        /// <summary>
        ///  void n_set_list_jump(ushort n, ushort position);
        /// </summary>
        public static n_set_list_jumpDelegate n_set_list_jump;

        /// <summary>
        ///  void set_list_jump(ushort position);
        /// </summary>
        public static set_list_jumpDelegate set_list_jump;

        /// <summary>
        ///  void n_set_input_pointer(ushort n, ushort pointer);
        /// </summary>
        public static n_set_input_pointerDelegate n_set_input_pointer;

        /// <summary>
        ///  void set_input_pointer(ushort pointer);
        /// </summary>
        public static set_input_pointerDelegate set_input_pointer;

        /// <summary>
        ///  void n_list_call(ushort n, ushort position);
        /// </summary>
        public static n_list_callDelegate n_list_call;

        /// <summary>
        ///  void list_call(ushort position);
        /// </summary>
        public static list_callDelegate list_call;

        /// <summary>
        ///  void n_list_return(ushort n);
        /// </summary>
        public static n_list_returnDelegate n_list_return;

        /// <summary>
        ///  void list_return();
        /// </summary>
        public static list_returnDelegate list_return;

        /// <summary>
        ///  void n_z_out_list(ushort n, short z);
        /// </summary>
        public static n_z_out_listDelegate n_z_out_list;

        /// <summary>
        ///  void z_out_list(short z);
        /// </summary>
        public static z_out_listDelegate z_out_list;

        /// <summary>
        ///  void n_set_standby_list(ushort n, ushort half_period, ushort pulse);
        /// </summary>
        public static n_set_standby_listDelegate n_set_standby_list;

        /// <summary>
        ///  void set_standby_list(ushort half_period, ushort pulse);
        /// </summary>
        public static set_standby_listDelegate set_standby_list;

        /// <summary>
        ///  void n_timed_jump_abs(ushort n, short x, short y, double time);
        /// </summary>
        public static n_timed_jump_absDelegate n_timed_jump_abs;

        /// <summary>
        ///  void timed_jump_abs(short x, short y, double time);
        /// </summary>
        public static timed_jump_absDelegate timed_jump_abs;

        /// <summary>
        ///  void n_timed_mark_abs(ushort n, short x, short y, double time);
        /// </summary>
        public static n_timed_mark_absDelegate n_timed_mark_abs;

        /// <summary>
        ///  void timed_mark_abs(short x, short y, double time);
        /// </summary>
        public static timed_mark_absDelegate timed_mark_abs;

        /// <summary>
        ///  void n_timed_jump_rel(ushort n, short dx, short dy, double time);
        /// </summary>
        public static n_timed_jump_relDelegate n_timed_jump_rel;

        /// <summary>
        ///  void timed_jump_rel(short dx, short dy, double time);
        /// </summary>
        public static timed_jump_relDelegate timed_jump_rel;

        /// <summary>
        ///  void n_timed_mark_rel(ushort n, short dx, short dy, double time);
        /// </summary>
        public static n_timed_mark_relDelegate n_timed_mark_rel;

        /// <summary>
        ///  void timed_mark_rel(short dx, short dy, double time);
        /// </summary>
        public static timed_mark_relDelegate timed_mark_rel;

        /// <summary>
        ///  void n_set_laser_timing(ushort n, ushort halfperiod, ushort pulse1, ushort pulse2, ushort timebase);
        /// </summary>
        public static n_set_laser_timingDelegate n_set_laser_timing;

        /// <summary>
        ///  void set_laser_timing(ushort halfperiod, ushort pulse1, ushort pulse2, ushort timebase);
        /// </summary>
        public static set_laser_timingDelegate set_laser_timing;

        /// <summary>
        ///  void n_set_wobbel(ushort n, ushort amplitude, double frequency);
        /// </summary>
        public static n_set_wobbelDelegate n_set_wobbel;

        /// <summary>
        ///  void set_wobbel(ushort amplitude, double frequency);
        /// </summary>
        public static set_wobbelDelegate set_wobbel;

        /// <summary>
        ///  void n_set_wobbel_xy(ushort n, ushort long_wob, ushort trans_wob, double frequency);
        /// </summary>
        public static n_set_wobbel_xyDelegate n_set_wobbel_xy;

        /// <summary>
        ///  void set_wobbel_xy(ushort long_wob, ushort trans_wob, double frequency);
        /// </summary>
        public static set_wobbel_xyDelegate set_wobbel_xy;

        /// <summary>
        ///  void n_set_fly_x(ushort n, double kx);
        /// </summary>
        public static n_set_fly_xDelegate n_set_fly_x;

        /// <summary>
        ///  void set_fly_x(double kx);
        /// </summary>
        public static set_fly_xDelegate set_fly_x;

        /// <summary>
        ///  void n_set_fly_y(ushort n, double ky);
        /// </summary>
        public static n_set_fly_yDelegate n_set_fly_y;

        /// <summary>
        ///  void set_fly_y(double ky);
        /// </summary>
        public static set_fly_yDelegate set_fly_y;

        /// <summary>
        ///  void n_set_fly_rot(ushort n, double resolution);
        /// </summary>
        public static n_set_fly_rotDelegate n_set_fly_rot;

        /// <summary>
        ///  void set_fly_rot(double resolution);
        /// </summary>
        public static set_fly_rotDelegate set_fly_rot;

        /// <summary>
        ///  void n_fly_return(ushort n, short x, short y);
        /// </summary>
        public static n_fly_returnDelegate n_fly_return;

        /// <summary>
        ///  void fly_return(short x, short y);
        /// </summary>
        public static fly_returnDelegate fly_return;

        /// <summary>
        ///  void n_calculate_fly(ushort n, ushort direction, double distance);
        /// </summary>
        public static n_calculate_flyDelegate n_calculate_fly;

        /// <summary>
        ///  void calculate_fly(ushort direction, double distance);
        /// </summary>
        public static calculate_flyDelegate calculate_fly;

        /// <summary>
        ///  void n_write_io_port_list(ushort n, ushort value);
        /// </summary>
        public static n_write_io_port_listDelegate n_write_io_port_list;

        /// <summary>
        ///  void write_io_port_list(ushort value);
        /// </summary>
        public static write_io_port_listDelegate write_io_port_list;

        /// <summary>
        ///  void n_select_cor_table_list(ushort n, ushort heada, ushort headb);
        /// </summary>
        public static n_select_cor_table_listDelegate n_select_cor_table_list;

        /// <summary>
        ///  void select_cor_table_list(ushort heada, ushort headb);
        /// </summary>
        public static select_cor_table_listDelegate select_cor_table_list;

        /// <summary>
        ///  void n_set_wait(ushort n, ushort value);
        /// </summary>
        public static n_set_waitDelegate n_set_wait;

        /// <summary>
        ///  void set_wait(ushort value);
        /// </summary>
        public static set_waitDelegate set_wait;

        /// <summary>
        ///  void n_simulate_ext_start(ushort n, short delay, short encoder);
        /// </summary>
        public static n_simulate_ext_startDelegate n_simulate_ext_start;

        /// <summary>
        ///  void simulate_ext_start(short delay, short encoder);
        /// </summary>
        public static simulate_ext_startDelegate simulate_ext_start;

        /// <summary>
        ///  void n_write_da_x_list(ushort n, ushort x, ushort value);
        /// </summary>
        public static n_write_da_x_listDelegate n_write_da_x_list;

        /// <summary>
        ///  void write_da_x_list(ushort x, ushort value);
        /// </summary>
        public static write_da_x_listDelegate write_da_x_list;

        /// <summary>
        ///  void n_set_pixel_line(ushort n, ushort pixelmode, ushort pixelperiod, double dx, double dy);
        /// </summary>
        public static n_set_pixel_lineDelegate n_set_pixel_line;

        /// <summary>
        ///  void set_pixel_line(ushort pixelmode, ushort pixelperiod, double dx, double dy);
        /// </summary>
        public static set_pixel_lineDelegate set_pixel_line;

        /// <summary>
        ///  void n_set_pixel(ushort n, ushort pulswidth, ushort davalue, ushort adchannel);
        /// </summary>
        public static n_set_pixelDelegate n_set_pixel;

        /// <summary>
        ///  void set_pixel(ushort pulswidth, ushort davalue, ushort adchannel);
        /// </summary>
        public static set_pixelDelegate set_pixel;

        /// <summary>
        ///  void n_set_extstartpos_list(ushort n, ushort position);
        /// </summary>
        public static n_set_extstartpos_listDelegate n_set_extstartpos_list;

        /// <summary>
        ///  void set_extstartpos_list(ushort position);
        /// </summary>
        public static set_extstartpos_listDelegate set_extstartpos_list;

        /// <summary>
        ///  void n_laser_signal_on_list(ushort n);
        /// </summary>
        public static n_laser_signal_on_listDelegate n_laser_signal_on_list;

        /// <summary>
        ///  void laser_signal_on_list();
        /// </summary>
        public static laser_signal_on_listDelegate laser_signal_on_list;

        /// <summary>
        ///  void n_laser_signal_off_list(ushort n);
        /// </summary>
        public static n_laser_signal_off_listDelegate n_laser_signal_off_list;

        /// <summary>
        ///  void laser_signal_off_list();
        /// </summary>
        public static laser_signal_off_listDelegate laser_signal_off_list;

        /// <summary>
        ///  void n_set_firstpulse_killer_list(ushort n, ushort fpk);
        /// </summary>
        public static n_set_firstpulse_killer_listDelegate n_set_firstpulse_killer_list;

        /// <summary>
        ///  void set_firstpulse_killer_list(ushort fpk);
        /// </summary>
        public static set_firstpulse_killer_listDelegate set_firstpulse_killer_list;

        /// <summary>
        ///  void n_set_io_cond_list(ushort n, ushort mask_1, ushort mask_0, ushort mask_set);
        /// </summary>
        public static n_set_io_cond_listDelegate n_set_io_cond_list;

        /// <summary>
        ///  void set_io_cond_list(ushort mask_1, ushort mask_0, ushort mask_set);
        /// </summary>
        public static set_io_cond_listDelegate set_io_cond_list;

        /// <summary>
        ///  void n_clear_io_cond_list(ushort n, ushort mask_1, ushort mask_0, ushort mask_clear);
        /// </summary>
        public static n_clear_io_cond_listDelegate n_clear_io_cond_list;

        /// <summary>
        ///  void clear_io_cond_list(ushort mask_1, ushort mask_0, ushort mask_clear);
        /// </summary>
        public static clear_io_cond_listDelegate clear_io_cond_list;

        /// <summary>
        ///  void n_list_jump_cond(ushort n, ushort mask_1, ushort mask_0, ushort position);
        /// </summary>
        public static n_list_jump_condDelegate n_list_jump_cond;

        /// <summary>
        ///  void list_jump_cond(ushort mask_1, ushort mask_0, ushort position);
        /// </summary>
        public static list_jump_condDelegate list_jump_cond;

        /// <summary>
        ///  void n_list_call_cond(ushort n, ushort mask_1, ushort mask_0, ushort position);
        /// </summary>
        public static n_list_call_condDelegate n_list_call_cond;

        /// <summary>
        ///  void list_call_cond(ushort mask_1, ushort mask_0, ushort position);
        /// </summary>
        public static list_call_condDelegate list_call_cond;

        /// <summary>
        ///  ushort n_get_input_pointer(ushort n);
        /// </summary>
        public static n_get_input_pointerDelegate n_get_input_pointer;

        /// <summary>
        ///  ushort get_input_pointer();
        /// </summary>
        public static get_input_pointerDelegate get_input_pointer;

        /// <summary>
        ///  ushort rtc4_max_cards();
        /// </summary>
        public static rtc4_max_cardsDelegate rtc4_max_cards;

        /// <summary>
        ///  void n_get_status(ushort n, out ushort busy, out ushort position);
        /// </summary>
        public static n_get_statusDelegate n_get_status;

        /// <summary>
        ///  void get_status(out ushort busy, out ushort position);
        /// </summary>
        public static get_statusDelegate get_status;

        /// <summary>
        ///  ushort n_read_status(ushort n);
        /// </summary>
        public static n_read_statusDelegate n_read_status;

        /// <summary>
        ///  ushort read_status();
        /// </summary>
        public static read_statusDelegate read_status;

        /// <summary>
        ///  ushort n_get_startstop_info(ushort n);
        /// </summary>
        public static n_get_startstop_infoDelegate n_get_startstop_info;

        /// <summary>
        ///  ushort get_startstop_info();
        /// </summary>
        public static get_startstop_infoDelegate get_startstop_info;

        /// <summary>
        ///  ushort n_get_marking_info(ushort n);
        /// </summary>
        public static n_get_marking_infoDelegate n_get_marking_info;

        /// <summary>
        ///  ushort get_marking_info();
        /// </summary>
        public static get_marking_infoDelegate get_marking_info;

        /// <summary>
        ///  ushort get_dll_version();
        /// </summary>
        public static get_dll_versionDelegate get_dll_version;

        /// <summary>
        ///  void n_set_start_list_1(ushort n);
        /// </summary>
        public static n_set_start_list_1Delegate n_set_start_list_1;

        /// <summary>
        ///  void set_start_list_1();
        /// </summary>
        public static set_start_list_1Delegate set_start_list_1;

        /// <summary>
        ///  void n_set_start_list_2(ushort n);
        /// </summary>
        public static n_set_start_list_2Delegate n_set_start_list_2;

        /// <summary>
        ///  void set_start_list_2();
        /// </summary>
        public static set_start_list_2Delegate set_start_list_2;

        /// <summary>
        ///  void n_set_start_list(ushort n, ushort listno);
        /// </summary>
        public static n_set_start_listDelegate n_set_start_list;

        /// <summary>
        ///  void set_start_list(ushort listno);
        /// </summary>
        public static set_start_listDelegate set_start_list;

        /// <summary>
        ///  void n_execute_list_1(ushort n);
        /// </summary>
        public static n_execute_list_1Delegate n_execute_list_1;

        /// <summary>
        ///  void execute_list_1();
        /// </summary>
        public static execute_list_1Delegate execute_list_1;

        /// <summary>
        ///  void n_execute_list_2(ushort n);
        /// </summary>
        public static n_execute_list_2Delegate n_execute_list_2;

        /// <summary>
        ///  void execute_list_2();
        /// </summary>
        public static execute_list_2Delegate execute_list_2;

        /// <summary>
        ///  void n_execute_list(ushort n, ushort listno);
        /// </summary>
        public static n_execute_listDelegate n_execute_list;

        /// <summary>
        ///  void execute_list(ushort listno);
        /// </summary>
        public static execute_listDelegate execute_list;

        /// <summary>
        ///  void n_write_8bit_port(ushort n, ushort value);
        /// </summary>
        public static n_write_8bit_portDelegate n_write_8bit_port;

        /// <summary>
        ///  void write_8bit_port(ushort value);
        /// </summary>
        public static write_8bit_portDelegate write_8bit_port;

        /// <summary>
        ///  void n_write_io_port(ushort n, ushort value);
        /// </summary>
        public static n_write_io_portDelegate n_write_io_port;

        /// <summary>
        ///  void write_io_port(ushort value);
        /// </summary>
        public static write_io_portDelegate write_io_port;

        /// <summary>
        ///  int n_eth_status(ushort n);
        /// </summary>
        public static n_eth_statusDelegate n_eth_status;

        /// <summary>
        ///  int eth_status();
        /// </summary>
        public static eth_statusDelegate eth_status;

        /// <summary>
        ///  void n_auto_change(ushort n);
        /// </summary>
        public static n_auto_changeDelegate n_auto_change;

        /// <summary>
        ///  void auto_change();
        /// </summary>
        public static auto_changeDelegate auto_change;

        /// <summary>
        ///  void n_auto_change_pos(ushort n, ushort start);
        /// </summary>
        public static n_auto_change_posDelegate n_auto_change_pos;

        /// <summary>
        ///  void auto_change_pos(ushort start);
        /// </summary>
        public static auto_change_posDelegate auto_change_pos;

        /// <summary>
        ///  void aut_change();
        /// </summary>
        public static aut_changeDelegate aut_change;

        /// <summary>
        ///  void n_start_loop(ushort n);
        /// </summary>
        public static n_start_loopDelegate n_start_loop;

        /// <summary>
        ///  void start_loop();
        /// </summary>
        public static start_loopDelegate start_loop;

        /// <summary>
        ///  void n_quit_loop(ushort n);
        /// </summary>
        public static n_quit_loopDelegate n_quit_loop;

        /// <summary>
        ///  void quit_loop();
        /// </summary>
        public static quit_loopDelegate quit_loop;

        /// <summary>
        ///  void n_stop_execution(ushort n);
        /// </summary>
        public static n_stop_executionDelegate n_stop_execution;

        /// <summary>
        ///  void stop_execution();
        /// </summary>
        public static stop_executionDelegate stop_execution;

        /// <summary>
        ///  ushort n_read_io_port(ushort n);
        /// </summary>
        public static n_read_io_portDelegate n_read_io_port;

        /// <summary>
        ///  ushort read_io_port();
        /// </summary>
        public static read_io_portDelegate read_io_port;

        /// <summary>
        ///  void n_write_da_1(ushort n, ushort value);
        /// </summary>
        public static n_write_da_1Delegate n_write_da_1;

        /// <summary>
        ///  void write_da_1(ushort value);
        /// </summary>
        public static write_da_1Delegate write_da_1;

        /// <summary>
        ///  void n_write_da_2(ushort n, ushort value);
        /// </summary>
        public static n_write_da_2Delegate n_write_da_2;

        /// <summary>
        ///  void write_da_2(ushort value);
        /// </summary>
        public static write_da_2Delegate write_da_2;

        /// <summary>
        ///  void n_set_max_counts(ushort n, int counts);
        /// </summary>
        public static n_set_max_countsDelegate n_set_max_counts;

        /// <summary>
        ///  void set_max_counts(int counts);
        /// </summary>
        public static set_max_countsDelegate set_max_counts;

        /// <summary>
        ///  int n_get_counts(ushort n);
        /// </summary>
        public static n_get_countsDelegate n_get_counts;

        /// <summary>
        ///  int get_counts();
        /// </summary>
        public static get_countsDelegate get_counts;

        /// <summary>
        ///  void n_set_matrix(ushort n, double m11, double m12, double m21, double m22);
        /// </summary>
        public static n_set_matrixDelegate n_set_matrix;

        /// <summary>
        ///  void set_matrix(double m11, double m12, double m21, double m22);
        /// </summary>
        public static set_matrixDelegate set_matrix;

        /// <summary>
        ///  void n_set_offset(ushort n, short xoffset, short yoffset);
        /// </summary>
        public static n_set_offsetDelegate n_set_offset;

        /// <summary>
        ///  void set_offset(short xoffset, short yoffset);
        /// </summary>
        public static set_offsetDelegate set_offset;

        /// <summary>
        ///  void n_goto_xyz(ushort n, short x, short y, short z);
        /// </summary>
        public static n_goto_xyzDelegate n_goto_xyz;

        /// <summary>
        ///  void goto_xyz(short x, short y, short z);
        /// </summary>
        public static goto_xyzDelegate goto_xyz;

        /// <summary>
        ///  void n_goto_xy(ushort n, short x, short y);
        /// </summary>
        public static n_goto_xyDelegate n_goto_xy;

        /// <summary>
        ///  void goto_xy(short x, short y);
        /// </summary>
        public static goto_xyDelegate goto_xy;

        /// <summary>
        ///  ushort n_get_hex_version(ushort n);
        /// </summary>
        public static n_get_hex_versionDelegate n_get_hex_version;

        /// <summary>
        ///  ushort get_hex_version();
        /// </summary>
        public static get_hex_versionDelegate get_hex_version;

        /// <summary>
        ///  void n_disable_laser(ushort n);
        /// </summary>
        public static n_disable_laserDelegate n_disable_laser;

        /// <summary>
        ///  void disable_laser();
        /// </summary>
        public static disable_laserDelegate disable_laser;

        /// <summary>
        ///  void n_enable_laser(ushort n);
        /// </summary>
        public static n_enable_laserDelegate n_enable_laser;

        /// <summary>
        ///  void enable_laser();
        /// </summary>
        public static enable_laserDelegate enable_laser;

        /// <summary>
        ///  void n_stop_list(ushort n);
        /// </summary>
        public static n_stop_listDelegate n_stop_list;

        /// <summary>
        ///  void stop_list();
        /// </summary>
        public static stop_listDelegate stop_list;

        /// <summary>
        ///  void n_restart_list(ushort n);
        /// </summary>
        public static n_restart_listDelegate n_restart_list;

        /// <summary>
        ///  void restart_list();
        /// </summary>
        public static restart_listDelegate restart_list;

        /// <summary>
        ///  void n_get_xyz_pos(ushort n, out short x, out short y, out short z);
        /// </summary>
        public static n_get_xyz_posDelegate n_get_xyz_pos;

        /// <summary>
        ///  void get_xyz_pos(out short x, out short y, out short z);
        /// </summary>
        public static get_xyz_posDelegate get_xyz_pos;

        /// <summary>
        ///  void n_get_xy_pos(ushort n, out short x, out short y);
        /// </summary>
        public static n_get_xy_posDelegate n_get_xy_pos;

        /// <summary>
        ///  void get_xy_pos(out short x, out short y);
        /// </summary>
        public static get_xy_posDelegate get_xy_pos;

        /// <summary>
        ///  void n_select_list(ushort n, ushort list_2);
        /// </summary>
        public static n_select_listDelegate n_select_list;

        /// <summary>
        ///  void select_list(ushort list_2);
        /// </summary>
        public static select_listDelegate select_list;

        /// <summary>
        ///  void n_z_out(ushort n, short z);
        /// </summary>
        public static n_z_outDelegate n_z_out;

        /// <summary>
        ///  void z_out(short z);
        /// </summary>
        public static z_outDelegate z_out;

        /// <summary>
        ///  void n_set_firstpulse_killer(ushort n, ushort fpk);
        /// </summary>
        public static n_set_firstpulse_killerDelegate n_set_firstpulse_killer;

        /// <summary>
        ///  void set_firstpulse_killer(ushort fpk);
        /// </summary>
        public static set_firstpulse_killerDelegate set_firstpulse_killer;

        /// <summary>
        ///  void n_set_standby(ushort n, ushort half_period, ushort pulse);
        /// </summary>
        public static n_set_standbyDelegate n_set_standby;

        /// <summary>
        ///  void set_standby(ushort half_period, ushort pulse);
        /// </summary>
        public static set_standbyDelegate set_standby;

        /// <summary>
        ///  void n_laser_signal_on(ushort n);
        /// </summary>
        public static n_laser_signal_onDelegate n_laser_signal_on;

        /// <summary>
        ///  void laser_signal_on();
        /// </summary>
        public static laser_signal_onDelegate laser_signal_on;

        /// <summary>
        ///  void n_laser_signal_off(ushort n);
        /// </summary>
        public static n_laser_signal_offDelegate n_laser_signal_off;

        /// <summary>
        ///  void laser_signal_off();
        /// </summary>
        public static laser_signal_offDelegate laser_signal_off;

        /// <summary>
        ///  void n_set_delay_mode(ushort n, ushort varpoly, ushort directmove3d, ushort edgelevel, ushort minjumpdelay, ushort jumplengthlimit);
        /// </summary>
        public static n_set_delay_modeDelegate n_set_delay_mode;

        /// <summary>
        ///  void set_delay_mode(ushort varpoly, ushort directmove3d, ushort edgelevel, ushort minjumpdelay, ushort jumplengthlimit);
        /// </summary>
        public static set_delay_modeDelegate set_delay_mode;

        /// <summary>
        ///  void n_set_piso_control(ushort n, ushort l1, ushort l2);
        /// </summary>
        public static n_set_piso_controlDelegate n_set_piso_control;

        /// <summary>
        ///  void set_piso_control(ushort l1, ushort l2);
        /// </summary>
        public static set_piso_controlDelegate set_piso_control;

        /// <summary>
        ///  void n_select_status(ushort n, ushort mode);
        /// </summary>
        public static n_select_statusDelegate n_select_status;

        /// <summary>
        ///  void select_status(ushort mode);
        /// </summary>
        public static select_statusDelegate select_status;

        /// <summary>
        ///  void n_get_encoder(ushort n, out short zx, out short zy);
        /// </summary>
        public static n_get_encoderDelegate n_get_encoder;

        /// <summary>
        ///  void get_encoder(out short zx, out short zy);
        /// </summary>
        public static get_encoderDelegate get_encoder;

        /// <summary>
        ///  void n_select_cor_table(ushort n, ushort heada, ushort headb);
        /// </summary>
        public static n_select_cor_tableDelegate n_select_cor_table;

        /// <summary>
        ///  void select_cor_table(ushort heada, ushort headb);
        /// </summary>
        public static select_cor_tableDelegate select_cor_table;

        /// <summary>
        ///  void n_execute_at_pointer(ushort n, ushort position);
        /// </summary>
        public static n_execute_at_pointerDelegate n_execute_at_pointer;

        /// <summary>
        ///  void execute_at_pointer(ushort position);
        /// </summary>
        public static execute_at_pointerDelegate execute_at_pointer;

        /// <summary>
        ///  ushort n_get_head_status(ushort n, ushort head);
        /// </summary>
        public static n_get_head_statusDelegate n_get_head_status;

        /// <summary>
        ///  ushort get_head_status(ushort head);
        /// </summary>
        public static get_head_statusDelegate get_head_status;

        /// <summary>
        ///  void n_simulate_encoder(ushort n, ushort channel);
        /// </summary>
        public static n_simulate_encoderDelegate n_simulate_encoder;

        /// <summary>
        ///  void simulate_encoder(ushort channel);
        /// </summary>
        public static simulate_encoderDelegate simulate_encoder;

        /// <summary>
        ///  void n_release_wait(ushort n);
        /// </summary>
        public static n_release_waitDelegate n_release_wait;

        /// <summary>
        ///  void release_wait();
        /// </summary>
        public static release_waitDelegate release_wait;

        /// <summary>
        ///  ushort n_get_wait_status(ushort n);
        /// </summary>
        public static n_get_wait_statusDelegate n_get_wait_status;

        /// <summary>
        ///  ushort get_wait_status();
        /// </summary>
        public static get_wait_statusDelegate get_wait_status;

        /// <summary>
        ///  void n_set_laser_mode(ushort n, ushort mode);
        /// </summary>
        public static n_set_laser_modeDelegate n_set_laser_mode;

        /// <summary>
        ///  void set_laser_mode(ushort mode);
        /// </summary>
        public static set_laser_modeDelegate set_laser_mode;

        /// <summary>
        ///  void n_set_ext_start_delay(ushort n, short delay, short encoder);
        /// </summary>
        public static n_set_ext_start_delayDelegate n_set_ext_start_delay;

        /// <summary>
        ///  void set_ext_start_delay(short delay, short encoder);
        /// </summary>
        public static set_ext_start_delayDelegate set_ext_start_delay;

        /// <summary>
        ///  void n_home_position(ushort n, short xhome, short yhome);
        /// </summary>
        public static n_home_positionDelegate n_home_position;

        /// <summary>
        ///  void home_position(short xhome, short yhome);
        /// </summary>
        public static home_positionDelegate home_position;

        /// <summary>
        ///  void n_set_rot_center(ushort n, int center_x, int center_y);
        /// </summary>
        public static n_set_rot_centerDelegate n_set_rot_center;

        /// <summary>
        ///  void set_rot_center(int center_x, int center_y);
        /// </summary>
        public static set_rot_centerDelegate set_rot_center;

        /// <summary>
        ///  void n_dsp_start(ushort n);
        /// </summary>
        public static n_dsp_startDelegate n_dsp_start;

        /// <summary>
        ///  void dsp_start();
        /// </summary>
        public static dsp_startDelegate dsp_start;

        /// <summary>
        ///  void n_write_da_x(ushort n, ushort x, ushort value);
        /// </summary>
        public static n_write_da_xDelegate n_write_da_x;

        /// <summary>
        ///  void write_da_x(ushort x, ushort value);
        /// </summary>
        public static write_da_xDelegate write_da_x;

        /// <summary>
        ///  ushort n_read_ad_x(ushort n, ushort x);
        /// </summary>
        public static n_read_ad_xDelegate n_read_ad_x;

        /// <summary>
        ///  ushort read_ad_x(ushort x);
        /// </summary>
        public static read_ad_xDelegate read_ad_x;

        /// <summary>
        ///  ushort n_read_pixel_ad(ushort n, ushort pos);
        /// </summary>
        public static n_read_pixel_adDelegate n_read_pixel_ad;

        /// <summary>
        ///  ushort read_pixel_ad(ushort pos);
        /// </summary>
        public static read_pixel_adDelegate read_pixel_ad;

        /// <summary>
        ///  short n_get_z_distance(ushort n, short x, short y, short z);
        /// </summary>
        public static n_get_z_distanceDelegate n_get_z_distance;

        /// <summary>
        ///  short get_z_distance(short x, short y, short z);
        /// </summary>
        public static get_z_distanceDelegate get_z_distance;

        /// <summary>
        ///  ushort n_get_io_status(ushort n);
        /// </summary>
        public static n_get_io_statusDelegate n_get_io_status;

        /// <summary>
        ///  ushort get_io_status();
        /// </summary>
        public static get_io_statusDelegate get_io_status;

        /// <summary>
        ///  short load_cor(string filename);
        /// </summary>
        public static load_corDelegate load_cor;

        /// <summary>
        ///  short load_pro(string filename);
        /// </summary>
        public static load_proDelegate load_pro;

        /// <summary>
        ///  ushort n_get_serial_number(ushort n);
        /// </summary>
        public static n_get_serial_numberDelegate n_get_serial_number;

        /// <summary>
        ///  ushort get_serial_number();
        /// </summary>
        public static get_serial_numberDelegate get_serial_number;

        /// <summary>
        ///  int n_get_serial_number_32(ushort n);
        /// </summary>
        public static n_get_serial_number_32Delegate n_get_serial_number_32;

        /// <summary>
        ///  int get_serial_number_32();
        /// </summary>
        public static get_serial_number_32Delegate get_serial_number_32;

        /// <summary>
        ///  ushort n_get_rtc_version(ushort n);
        /// </summary>
        public static n_get_rtc_versionDelegate n_get_rtc_version;

        /// <summary>
        ///  ushort get_rtc_version();
        /// </summary>
        public static get_rtc_versionDelegate get_rtc_version;

        /// <summary>
        ///  short n_auto_cal(ushort n, ushort head, ushort command);
        /// </summary>
        public static n_auto_calDelegate n_auto_cal;

        /// <summary>
        ///  short auto_cal(ushort head, ushort command);
        /// </summary>
        public static auto_calDelegate auto_cal;

        /// <summary>
        ///  void n_set_hi(ushort n, double galvogainx, double galvogainy, short galvooffsetx, short galvooffsety, short head);
        /// </summary>
        public static n_set_hiDelegate n_set_hi;

        /// <summary>
        ///  void set_hi(double galvogainx, double galvogainy, short galvooffsetx, short galvooffsety, short head);
        /// </summary>
        public static set_hiDelegate set_hi;

        /// <summary>
        ///  void n_set_list_mode(ushort n, ushort mode);
        /// </summary>
        public static n_set_list_modeDelegate n_set_list_mode;

        /// <summary>
        ///  void set_list_mode(ushort mode);
        /// </summary>
        public static set_list_modeDelegate set_list_mode;

        /// <summary>
        ///  ushort n_get_list_space(ushort n);
        /// </summary>
        public static n_get_list_spaceDelegate n_get_list_space;

        /// <summary>
        ///  ushort get_list_space();
        /// </summary>
        public static get_list_spaceDelegate get_list_space;

        /// <summary>
        ///  void n_save_and_restart_timer(ushort n);
        /// </summary>
        public static n_save_and_restart_timerDelegate n_save_and_restart_timer;

        /// <summary>
        ///  void save_and_restart_timer();
        /// </summary>
        public static save_and_restart_timerDelegate save_and_restart_timer;

        /// <summary>
        ///  void n_set_ext_start_delay_list(ushort n, short delay, short encoder);
        /// </summary>
        public static n_set_ext_start_delay_listDelegate n_set_ext_start_delay_list;

        /// <summary>
        ///  void set_ext_start_delay_list(short delay, short encoder);
        /// </summary>
        public static set_ext_start_delay_listDelegate set_ext_start_delay_list;

        /// <summary>
        ///  double n_get_time(ushort n);
        /// </summary>
        public static n_get_timeDelegate n_get_time;

        /// <summary>
        ///  double get_time();
        /// </summary>
        public static get_timeDelegate get_time;

        /// <summary>
        ///  void get_hi_data(out ushort x1, out ushort x2, out ushort y1, out ushort y2);
        /// </summary>
        public static get_hi_dataDelegate get_hi_data;

        /// <summary>
        ///  short teachin(string filename, short xin, short yin, short zin, double ll0, out short xout, out short yout, out short zout);
        /// </summary>
        public static teachinDelegate teachin;

        /// <summary>
        ///  short getmemory(ushort adr);
        /// </summary>
        public static getmemoryDelegate getmemory;

        /// <summary>
        ///  void set_timeout(uint timeout);
        /// </summary>
        public static set_timeoutDelegate set_timeout;

        /// <summary>
        ///  void set_timeouts(uint acquire_timeout_us, uint acquire_max_retries, uint send_recv_timeout_us, uint send_recv_max_retries, uint acqu_rel_min_intvl_ms);
        /// </summary>
        public static set_timeoutsDelegate set_timeouts;

        /// <summary>
        ///  void get_timeouts(out uint acquire_timeout_us, out uint acquire_max_retries, out uint send_recv_timeout_us, out uint send_recv_max_retries, out uint acqu_rel_min_intvl_ms);
        /// </summary>
        public static get_timeoutsDelegate get_timeouts;

        /// <summary>
        ///  uint rs232_config(uint baudrate, uint parity, uint stopbits);
        /// </summary>
        public static rs232_configDelegate rs232_config;

        /// <summary>
        ///  uint n_rs232_config(ushort n, uint baudrate, uint parity, uint stopbits);
        /// </summary>
        public static n_rs232_configDelegate n_rs232_config;

        /// <summary>
        ///  uint rs232_write_data(uint data);
        /// </summary>
        public static rs232_write_dataDelegate rs232_write_data;

        /// <summary>
        ///  uint n_rs232_write_data(ushort n, uint data);
        /// </summary>
        public static n_rs232_write_dataDelegate n_rs232_write_data;

        /// <summary>
        ///  uint rs232_write_text(string text);
        /// </summary>
        public static rs232_write_textDelegate rs232_write_text;

        /// <summary>
        ///  uint n_rs232_write_text(ushort n, string text);
        /// </summary>
        public static n_rs232_write_textDelegate n_rs232_write_text;

        /// <summary>
        ///  uint rs232_read_data(out uint data);
        /// </summary>
        public static rs232_read_dataDelegate rs232_read_data;

        /// <summary>
        ///  uint n_rs232_read_data(ushort n, out uint data);
        /// </summary>
        public static n_rs232_read_dataDelegate n_rs232_read_data;

        /// <summary>
        ///  void n_eth_set_com_timeouts_auto(ushort cardno, double initial_timeout_ms, double sum_timeout_ms, double multiplicator, int mode);
        /// </summary>
        public static n_eth_set_com_timeouts_autoDelegate n_eth_set_com_timeouts_auto;

        /// <summary>
        ///  void eth_set_com_timeouts_auto(double initial_timeout_ms, double sum_timeout_ms, double multiplicator, int mode);
        /// </summary>
        public static eth_set_com_timeouts_autoDelegate eth_set_com_timeouts_auto;

        /// <summary>
        ///  void n_eth_get_com_timeouts_auto(ushort cardno, out double initial_timeout_ms, out double sum_timeout_ms, out double multiplicator, out int mode);
        /// </summary>
        public static n_eth_get_com_timeouts_autoDelegate n_eth_get_com_timeouts_auto;

        /// <summary>
        ///  void eth_get_com_timeouts_auto(out double initial_timeout_ms, out double sum_timeout_ms, out double multiplicator, out int mode);
        /// </summary>
        public static eth_get_com_timeouts_autoDelegate eth_get_com_timeouts_auto;

        /// <summary>
        ///  uint n_eth_watchdog_timer_config(ushort n, uint timer_ms);
        /// </summary>
        public static n_eth_watchdog_timer_configDelegate n_eth_watchdog_timer_config;

        /// <summary>
        ///  uint eth_watchdog_timer_config(uint timer_ms);
        /// </summary>
        public static eth_watchdog_timer_configDelegate eth_watchdog_timer_config;

        /// <summary>
        ///  uint n_eth_watchdog_timer_reset(ushort n);
        /// </summary>
        public static n_eth_watchdog_timer_resetDelegate n_eth_watchdog_timer_reset;

        /// <summary>
        ///  uint eth_watchdog_timer_reset();
        /// </summary>
        public static eth_watchdog_timer_resetDelegate eth_watchdog_timer_reset;

        /// <summary>
        ///  void n_eth_link_loss_config(ushort n, uint mode);
        /// </summary>
        public static n_eth_link_loss_configDelegate n_eth_link_loss_config;

        /// <summary>
        ///  void eth_link_loss_config(uint mode);
        /// </summary>
        public static eth_link_loss_configDelegate eth_link_loss_config;

        /// <summary>
        ///  uint n_eth_get_last_error(ushort n);
        /// </summary>
        public static n_eth_get_last_errorDelegate n_eth_get_last_error;

        /// <summary>
        ///  uint eth_get_last_error();
        /// </summary>
        public static eth_get_last_errorDelegate eth_get_last_error;

        /// <summary>
        ///  uint n_eth_get_error(ushort n);
        /// </summary>
        public static n_eth_get_errorDelegate n_eth_get_error;

        /// <summary>
        ///  uint eth_get_error();
        /// </summary>
        public static eth_get_errorDelegate eth_get_error;

        /// <summary>
        ///  uint n_eth_error_dump(ushort n, uint[] dump);
        /// </summary>
        public static n_eth_error_dumpDelegate n_eth_error_dump;

        /// <summary>
        ///  uint eth_error_dump(uint[] dump);
        /// </summary>
        public static eth_error_dumpDelegate eth_error_dump;

        #endregion

        
        private static void ImportFunctions(String dll_name)
        {
            // Import functions and set them up as delegates.
            //
            #region DLLFunctionImport
                        
            // ARE: Kill old existing instance that might exist to enable loading new DLL if given
            FunctionImporter.Unload();
            FunctionImporter.Load(dll_name);
            get_driver_status = (get_driver_statusDelegate)FunctionImporter.Import<get_driver_statusDelegate>("get_driver_status");
            get_net_dll_version = (get_net_dll_versionDelegate)FunctionImporter.Import<get_net_dll_versionDelegate>("get_net_dll_version");
            acquire_rtc = (acquire_rtcDelegate)FunctionImporter.Import<acquire_rtcDelegate>("acquire_rtc");
            release_rtc = (release_rtcDelegate)FunctionImporter.Import<release_rtcDelegate>("release_rtc");
            select_rtc = (select_rtcDelegate)FunctionImporter.Import<select_rtcDelegate>("select_rtc");
            assign_rtc = (assign_rtcDelegate)FunctionImporter.Import<assign_rtcDelegate>("assign_rtc");
            assign_rtc_by_ip = (assign_rtc_by_ipDelegate)FunctionImporter.Import<assign_rtc_by_ipDelegate>("assign_rtc_by_ip");
            remove_rtc = (remove_rtcDelegate)FunctionImporter.Import<remove_rtcDelegate>("remove_rtc");
            convert_string_to_ip = (convert_string_to_ipDelegate)FunctionImporter.Import<convert_string_to_ipDelegate>("convert_string_to_ip");
            convert_ip_to_string = (convert_ip_to_stringDelegate)FunctionImporter.Import<convert_ip_to_stringDelegate>("convert_ip_to_string");
            convert_mac_to_string = (convert_mac_to_stringDelegate)FunctionImporter.Import<convert_mac_to_stringDelegate>("convert_mac_to_string");
            rtc_search_cards = (rtc_search_cardsDelegate)FunctionImporter.Import<rtc_search_cardsDelegate>("rtc_search_cards");
            get_mac_address = (get_mac_addressDelegate)FunctionImporter.Import<get_mac_addressDelegate>("get_mac_address");
            get_ip_address = (get_ip_addressDelegate)FunctionImporter.Import<get_ip_addressDelegate>("get_ip_address");
            get_serial = (get_serialDelegate)FunctionImporter.Import<get_serialDelegate>("get_serial");
            get_connection_status = (get_connection_statusDelegate)FunctionImporter.Import<get_connection_statusDelegate>("get_connection_status");
            get_master_ip_address = (get_master_ip_addressDelegate)FunctionImporter.Import<get_master_ip_addressDelegate>("get_master_ip_address");
            get_master_id = (get_master_idDelegate)FunctionImporter.Import<get_master_idDelegate>("get_master_id");
            set_static_ip = (set_static_ipDelegate)FunctionImporter.Import<set_static_ipDelegate>("set_static_ip");
            get_static_ip = (get_static_ipDelegate)FunctionImporter.Import<get_static_ipDelegate>("get_static_ip");
            get_mcu_fw_version = (get_mcu_fw_versionDelegate)FunctionImporter.Import<get_mcu_fw_versionDelegate>("get_mcu_fw_version");
            get_nic_ip_count = (get_nic_ip_countDelegate)FunctionImporter.Import<get_nic_ip_countDelegate>("get_nic_ip_count");
            get_nic_ip = (get_nic_ipDelegate)FunctionImporter.Import<get_nic_ipDelegate>("get_nic_ip");
            n_get_waveform = (n_get_waveformDelegate)FunctionImporter.Import<n_get_waveformDelegate>("n_get_waveform");
            get_waveform = (get_waveformDelegate)FunctionImporter.Import<get_waveformDelegate>("get_waveform");
            n_measurement_status = (n_measurement_statusDelegate)FunctionImporter.Import<n_measurement_statusDelegate>("n_measurement_status");
            measurement_status = (measurement_statusDelegate)FunctionImporter.Import<measurement_statusDelegate>("measurement_status");
            n_set_trigger = (n_set_triggerDelegate)FunctionImporter.Import<n_set_triggerDelegate>("n_set_trigger");
            set_trigger = (set_triggerDelegate)FunctionImporter.Import<set_triggerDelegate>("set_trigger");
            n_get_value = (n_get_valueDelegate)FunctionImporter.Import<n_get_valueDelegate>("n_get_value");
            get_value = (get_valueDelegate)FunctionImporter.Import<get_valueDelegate>("get_value");
            n_set_io_bit = (n_set_io_bitDelegate)FunctionImporter.Import<n_set_io_bitDelegate>("n_set_io_bit");
            set_io_bit = (set_io_bitDelegate)FunctionImporter.Import<set_io_bitDelegate>("set_io_bit");
            n_clear_io_bit = (n_clear_io_bitDelegate)FunctionImporter.Import<n_clear_io_bitDelegate>("n_clear_io_bit");
            clear_io_bit = (clear_io_bitDelegate)FunctionImporter.Import<clear_io_bitDelegate>("clear_io_bit");
            n_move_to = (n_move_toDelegate)FunctionImporter.Import<n_move_toDelegate>("n_move_to");
            move_to = (move_toDelegate)FunctionImporter.Import<move_toDelegate>("move_to");
            n_control_command = (n_control_commandDelegate)FunctionImporter.Import<n_control_commandDelegate>("n_control_command");
            control_command = (control_commandDelegate)FunctionImporter.Import<control_commandDelegate>("control_command");
            n_arc_rel = (n_arc_relDelegate)FunctionImporter.Import<n_arc_relDelegate>("n_arc_rel");
            arc_rel = (arc_relDelegate)FunctionImporter.Import<arc_relDelegate>("arc_rel");
            n_arc_abs = (n_arc_absDelegate)FunctionImporter.Import<n_arc_absDelegate>("n_arc_abs");
            arc_abs = (arc_absDelegate)FunctionImporter.Import<arc_absDelegate>("arc_abs");
            drilling = (drillingDelegate)FunctionImporter.Import<drillingDelegate>("drilling");
            regulation = (regulationDelegate)FunctionImporter.Import<regulationDelegate>("regulation");
            flyline = (flylineDelegate)FunctionImporter.Import<flylineDelegate>("flyline");
            set_duty_cycle_table = (set_duty_cycle_tableDelegate)FunctionImporter.Import<set_duty_cycle_tableDelegate>("set_duty_cycle_table");
            n_load_varpolydelay = (n_load_varpolydelayDelegate)FunctionImporter.Import<n_load_varpolydelayDelegate>("n_load_varpolydelay");
            load_varpolydelay = (load_varpolydelayDelegate)FunctionImporter.Import<load_varpolydelayDelegate>("load_varpolydelay");
            n_load_program_file = (n_load_program_fileDelegate)FunctionImporter.Import<n_load_program_fileDelegate>("n_load_program_file");
            load_program_file = (load_program_fileDelegate)FunctionImporter.Import<load_program_fileDelegate>("load_program_file");
            n_load_correction_file = (n_load_correction_fileDelegate)FunctionImporter.Import<n_load_correction_fileDelegate>("n_load_correction_file");
            load_correction_file = (load_correction_fileDelegate)FunctionImporter.Import<load_correction_fileDelegate>("load_correction_file");
            n_load_z_table = (n_load_z_tableDelegate)FunctionImporter.Import<n_load_z_tableDelegate>("n_load_z_table");
            load_z_table = (load_z_tableDelegate)FunctionImporter.Import<load_z_tableDelegate>("load_z_table");
            n_list_nop = (n_list_nopDelegate)FunctionImporter.Import<n_list_nopDelegate>("n_list_nop");
            list_nop = (list_nopDelegate)FunctionImporter.Import<list_nopDelegate>("list_nop");
            n_set_end_of_list = (n_set_end_of_listDelegate)FunctionImporter.Import<n_set_end_of_listDelegate>("n_set_end_of_list");
            set_end_of_list = (set_end_of_listDelegate)FunctionImporter.Import<set_end_of_listDelegate>("set_end_of_list");
            n_jump_abs_3d = (n_jump_abs_3dDelegate)FunctionImporter.Import<n_jump_abs_3dDelegate>("n_jump_abs_3d");
            jump_abs_3d = (jump_abs_3dDelegate)FunctionImporter.Import<jump_abs_3dDelegate>("jump_abs_3d");
            n_jump_abs = (n_jump_absDelegate)FunctionImporter.Import<n_jump_absDelegate>("n_jump_abs");
            jump_abs = (jump_absDelegate)FunctionImporter.Import<jump_absDelegate>("jump_abs");
            n_mark_abs_3d = (n_mark_abs_3dDelegate)FunctionImporter.Import<n_mark_abs_3dDelegate>("n_mark_abs_3d");
            mark_abs_3d = (mark_abs_3dDelegate)FunctionImporter.Import<mark_abs_3dDelegate>("mark_abs_3d");
            n_mark_abs = (n_mark_absDelegate)FunctionImporter.Import<n_mark_absDelegate>("n_mark_abs");
            mark_abs = (mark_absDelegate)FunctionImporter.Import<mark_absDelegate>("mark_abs");
            n_jump_rel_3d = (n_jump_rel_3dDelegate)FunctionImporter.Import<n_jump_rel_3dDelegate>("n_jump_rel_3d");
            jump_rel_3d = (jump_rel_3dDelegate)FunctionImporter.Import<jump_rel_3dDelegate>("jump_rel_3d");
            n_jump_rel = (n_jump_relDelegate)FunctionImporter.Import<n_jump_relDelegate>("n_jump_rel");
            jump_rel = (jump_relDelegate)FunctionImporter.Import<jump_relDelegate>("jump_rel");
            n_mark_rel_3d = (n_mark_rel_3dDelegate)FunctionImporter.Import<n_mark_rel_3dDelegate>("n_mark_rel_3d");
            mark_rel_3d = (mark_rel_3dDelegate)FunctionImporter.Import<mark_rel_3dDelegate>("mark_rel_3d");
            n_mark_rel = (n_mark_relDelegate)FunctionImporter.Import<n_mark_relDelegate>("n_mark_rel");
            mark_rel = (mark_relDelegate)FunctionImporter.Import<mark_relDelegate>("mark_rel");
            n_write_8bit_port_list = (n_write_8bit_port_listDelegate)FunctionImporter.Import<n_write_8bit_port_listDelegate>("n_write_8bit_port_list");
            write_8bit_port_list = (write_8bit_port_listDelegate)FunctionImporter.Import<write_8bit_port_listDelegate>("write_8bit_port_list");
            n_write_da_1_list = (n_write_da_1_listDelegate)FunctionImporter.Import<n_write_da_1_listDelegate>("n_write_da_1_list");
            write_da_1_list = (write_da_1_listDelegate)FunctionImporter.Import<write_da_1_listDelegate>("write_da_1_list");
            n_write_da_2_list = (n_write_da_2_listDelegate)FunctionImporter.Import<n_write_da_2_listDelegate>("n_write_da_2_list");
            write_da_2_list = (write_da_2_listDelegate)FunctionImporter.Import<write_da_2_listDelegate>("write_da_2_list");
            n_set_matrix_list = (n_set_matrix_listDelegate)FunctionImporter.Import<n_set_matrix_listDelegate>("n_set_matrix_list");
            set_matrix_list = (set_matrix_listDelegate)FunctionImporter.Import<set_matrix_listDelegate>("set_matrix_list");
            n_set_offset_list = (n_set_offset_listDelegate)FunctionImporter.Import<n_set_offset_listDelegate>("n_set_offset_list");
            set_offset_list = (set_offset_listDelegate)FunctionImporter.Import<set_offset_listDelegate>("set_offset_list");
            n_set_defocus_list = (n_set_defocus_listDelegate)FunctionImporter.Import<n_set_defocus_listDelegate>("n_set_defocus_list");
            set_defocus_list = (set_defocus_listDelegate)FunctionImporter.Import<set_defocus_listDelegate>("set_defocus_list");
            n_set_defocus = (n_set_defocusDelegate)FunctionImporter.Import<n_set_defocusDelegate>("n_set_defocus");
            set_defocus = (set_defocusDelegate)FunctionImporter.Import<set_defocusDelegate>("set_defocus");
            n_set_softstart_mode = (n_set_softstart_modeDelegate)FunctionImporter.Import<n_set_softstart_modeDelegate>("n_set_softstart_mode");
            set_softstart_mode = (set_softstart_modeDelegate)FunctionImporter.Import<set_softstart_modeDelegate>("set_softstart_mode");
            n_set_softstart_level = (n_set_softstart_levelDelegate)FunctionImporter.Import<n_set_softstart_levelDelegate>("n_set_softstart_level");
            set_softstart_level = (set_softstart_levelDelegate)FunctionImporter.Import<set_softstart_levelDelegate>("set_softstart_level");
            n_set_control_mode_list = (n_set_control_mode_listDelegate)FunctionImporter.Import<n_set_control_mode_listDelegate>("n_set_control_mode_list");
            set_control_mode_list = (set_control_mode_listDelegate)FunctionImporter.Import<set_control_mode_listDelegate>("set_control_mode_list");
            n_set_control_mode = (n_set_control_modeDelegate)FunctionImporter.Import<n_set_control_modeDelegate>("n_set_control_mode");
            set_control_mode = (set_control_modeDelegate)FunctionImporter.Import<set_control_modeDelegate>("set_control_mode");
            n_long_delay = (n_long_delayDelegate)FunctionImporter.Import<n_long_delayDelegate>("n_long_delay");
            long_delay = (long_delayDelegate)FunctionImporter.Import<long_delayDelegate>("long_delay");
            n_laser_on_list = (n_laser_on_listDelegate)FunctionImporter.Import<n_laser_on_listDelegate>("n_laser_on_list");
            laser_on_list = (laser_on_listDelegate)FunctionImporter.Import<laser_on_listDelegate>("laser_on_list");
            n_set_jump_speed = (n_set_jump_speedDelegate)FunctionImporter.Import<n_set_jump_speedDelegate>("n_set_jump_speed");
            set_jump_speed = (set_jump_speedDelegate)FunctionImporter.Import<set_jump_speedDelegate>("set_jump_speed");
            n_set_mark_speed = (n_set_mark_speedDelegate)FunctionImporter.Import<n_set_mark_speedDelegate>("n_set_mark_speed");
            set_mark_speed = (set_mark_speedDelegate)FunctionImporter.Import<set_mark_speedDelegate>("set_mark_speed");
            n_set_laser_delays = (n_set_laser_delaysDelegate)FunctionImporter.Import<n_set_laser_delaysDelegate>("n_set_laser_delays");
            set_laser_delays = (set_laser_delaysDelegate)FunctionImporter.Import<set_laser_delaysDelegate>("set_laser_delays");
            n_set_scanner_delays = (n_set_scanner_delaysDelegate)FunctionImporter.Import<n_set_scanner_delaysDelegate>("n_set_scanner_delays");
            set_scanner_delays = (set_scanner_delaysDelegate)FunctionImporter.Import<set_scanner_delaysDelegate>("set_scanner_delays");
            n_set_list_jump = (n_set_list_jumpDelegate)FunctionImporter.Import<n_set_list_jumpDelegate>("n_set_list_jump");
            set_list_jump = (set_list_jumpDelegate)FunctionImporter.Import<set_list_jumpDelegate>("set_list_jump");
            n_set_input_pointer = (n_set_input_pointerDelegate)FunctionImporter.Import<n_set_input_pointerDelegate>("n_set_input_pointer");
            set_input_pointer = (set_input_pointerDelegate)FunctionImporter.Import<set_input_pointerDelegate>("set_input_pointer");
            n_list_call = (n_list_callDelegate)FunctionImporter.Import<n_list_callDelegate>("n_list_call");
            list_call = (list_callDelegate)FunctionImporter.Import<list_callDelegate>("list_call");
            n_list_return = (n_list_returnDelegate)FunctionImporter.Import<n_list_returnDelegate>("n_list_return");
            list_return = (list_returnDelegate)FunctionImporter.Import<list_returnDelegate>("list_return");
            n_z_out_list = (n_z_out_listDelegate)FunctionImporter.Import<n_z_out_listDelegate>("n_z_out_list");
            z_out_list = (z_out_listDelegate)FunctionImporter.Import<z_out_listDelegate>("z_out_list");
            n_set_standby_list = (n_set_standby_listDelegate)FunctionImporter.Import<n_set_standby_listDelegate>("n_set_standby_list");
            set_standby_list = (set_standby_listDelegate)FunctionImporter.Import<set_standby_listDelegate>("set_standby_list");
            n_timed_jump_abs = (n_timed_jump_absDelegate)FunctionImporter.Import<n_timed_jump_absDelegate>("n_timed_jump_abs");
            timed_jump_abs = (timed_jump_absDelegate)FunctionImporter.Import<timed_jump_absDelegate>("timed_jump_abs");
            n_timed_mark_abs = (n_timed_mark_absDelegate)FunctionImporter.Import<n_timed_mark_absDelegate>("n_timed_mark_abs");
            timed_mark_abs = (timed_mark_absDelegate)FunctionImporter.Import<timed_mark_absDelegate>("timed_mark_abs");
            n_timed_jump_rel = (n_timed_jump_relDelegate)FunctionImporter.Import<n_timed_jump_relDelegate>("n_timed_jump_rel");
            timed_jump_rel = (timed_jump_relDelegate)FunctionImporter.Import<timed_jump_relDelegate>("timed_jump_rel");
            n_timed_mark_rel = (n_timed_mark_relDelegate)FunctionImporter.Import<n_timed_mark_relDelegate>("n_timed_mark_rel");
            timed_mark_rel = (timed_mark_relDelegate)FunctionImporter.Import<timed_mark_relDelegate>("timed_mark_rel");
            n_set_laser_timing = (n_set_laser_timingDelegate)FunctionImporter.Import<n_set_laser_timingDelegate>("n_set_laser_timing");
            set_laser_timing = (set_laser_timingDelegate)FunctionImporter.Import<set_laser_timingDelegate>("set_laser_timing");
            n_set_wobbel = (n_set_wobbelDelegate)FunctionImporter.Import<n_set_wobbelDelegate>("n_set_wobbel");
            set_wobbel = (set_wobbelDelegate)FunctionImporter.Import<set_wobbelDelegate>("set_wobbel");
            n_set_wobbel_xy = (n_set_wobbel_xyDelegate)FunctionImporter.Import<n_set_wobbel_xyDelegate>("n_set_wobbel_xy");
            set_wobbel_xy = (set_wobbel_xyDelegate)FunctionImporter.Import<set_wobbel_xyDelegate>("set_wobbel_xy");
            n_set_fly_x = (n_set_fly_xDelegate)FunctionImporter.Import<n_set_fly_xDelegate>("n_set_fly_x");
            set_fly_x = (set_fly_xDelegate)FunctionImporter.Import<set_fly_xDelegate>("set_fly_x");
            n_set_fly_y = (n_set_fly_yDelegate)FunctionImporter.Import<n_set_fly_yDelegate>("n_set_fly_y");
            set_fly_y = (set_fly_yDelegate)FunctionImporter.Import<set_fly_yDelegate>("set_fly_y");
            n_set_fly_rot = (n_set_fly_rotDelegate)FunctionImporter.Import<n_set_fly_rotDelegate>("n_set_fly_rot");
            set_fly_rot = (set_fly_rotDelegate)FunctionImporter.Import<set_fly_rotDelegate>("set_fly_rot");
            n_fly_return = (n_fly_returnDelegate)FunctionImporter.Import<n_fly_returnDelegate>("n_fly_return");
            fly_return = (fly_returnDelegate)FunctionImporter.Import<fly_returnDelegate>("fly_return");
            n_calculate_fly = (n_calculate_flyDelegate)FunctionImporter.Import<n_calculate_flyDelegate>("n_calculate_fly");
            calculate_fly = (calculate_flyDelegate)FunctionImporter.Import<calculate_flyDelegate>("calculate_fly");
            n_write_io_port_list = (n_write_io_port_listDelegate)FunctionImporter.Import<n_write_io_port_listDelegate>("n_write_io_port_list");
            write_io_port_list = (write_io_port_listDelegate)FunctionImporter.Import<write_io_port_listDelegate>("write_io_port_list");
            n_select_cor_table_list = (n_select_cor_table_listDelegate)FunctionImporter.Import<n_select_cor_table_listDelegate>("n_select_cor_table_list");
            select_cor_table_list = (select_cor_table_listDelegate)FunctionImporter.Import<select_cor_table_listDelegate>("select_cor_table_list");
            n_set_wait = (n_set_waitDelegate)FunctionImporter.Import<n_set_waitDelegate>("n_set_wait");
            set_wait = (set_waitDelegate)FunctionImporter.Import<set_waitDelegate>("set_wait");
            n_simulate_ext_start = (n_simulate_ext_startDelegate)FunctionImporter.Import<n_simulate_ext_startDelegate>("n_simulate_ext_start");
            simulate_ext_start = (simulate_ext_startDelegate)FunctionImporter.Import<simulate_ext_startDelegate>("simulate_ext_start");
            n_write_da_x_list = (n_write_da_x_listDelegate)FunctionImporter.Import<n_write_da_x_listDelegate>("n_write_da_x_list");
            write_da_x_list = (write_da_x_listDelegate)FunctionImporter.Import<write_da_x_listDelegate>("write_da_x_list");
            n_set_pixel_line = (n_set_pixel_lineDelegate)FunctionImporter.Import<n_set_pixel_lineDelegate>("n_set_pixel_line");
            set_pixel_line = (set_pixel_lineDelegate)FunctionImporter.Import<set_pixel_lineDelegate>("set_pixel_line");
            n_set_pixel = (n_set_pixelDelegate)FunctionImporter.Import<n_set_pixelDelegate>("n_set_pixel");
            set_pixel = (set_pixelDelegate)FunctionImporter.Import<set_pixelDelegate>("set_pixel");
            n_set_extstartpos_list = (n_set_extstartpos_listDelegate)FunctionImporter.Import<n_set_extstartpos_listDelegate>("n_set_extstartpos_list");
            set_extstartpos_list = (set_extstartpos_listDelegate)FunctionImporter.Import<set_extstartpos_listDelegate>("set_extstartpos_list");
            n_laser_signal_on_list = (n_laser_signal_on_listDelegate)FunctionImporter.Import<n_laser_signal_on_listDelegate>("n_laser_signal_on_list");
            laser_signal_on_list = (laser_signal_on_listDelegate)FunctionImporter.Import<laser_signal_on_listDelegate>("laser_signal_on_list");
            n_laser_signal_off_list = (n_laser_signal_off_listDelegate)FunctionImporter.Import<n_laser_signal_off_listDelegate>("n_laser_signal_off_list");
            laser_signal_off_list = (laser_signal_off_listDelegate)FunctionImporter.Import<laser_signal_off_listDelegate>("laser_signal_off_list");
            n_set_firstpulse_killer_list = (n_set_firstpulse_killer_listDelegate)FunctionImporter.Import<n_set_firstpulse_killer_listDelegate>("n_set_firstpulse_killer_list");
            set_firstpulse_killer_list = (set_firstpulse_killer_listDelegate)FunctionImporter.Import<set_firstpulse_killer_listDelegate>("set_firstpulse_killer_list");
            n_set_io_cond_list = (n_set_io_cond_listDelegate)FunctionImporter.Import<n_set_io_cond_listDelegate>("n_set_io_cond_list");
            set_io_cond_list = (set_io_cond_listDelegate)FunctionImporter.Import<set_io_cond_listDelegate>("set_io_cond_list");
            n_clear_io_cond_list = (n_clear_io_cond_listDelegate)FunctionImporter.Import<n_clear_io_cond_listDelegate>("n_clear_io_cond_list");
            clear_io_cond_list = (clear_io_cond_listDelegate)FunctionImporter.Import<clear_io_cond_listDelegate>("clear_io_cond_list");
            n_list_jump_cond = (n_list_jump_condDelegate)FunctionImporter.Import<n_list_jump_condDelegate>("n_list_jump_cond");
            list_jump_cond = (list_jump_condDelegate)FunctionImporter.Import<list_jump_condDelegate>("list_jump_cond");
            n_list_call_cond = (n_list_call_condDelegate)FunctionImporter.Import<n_list_call_condDelegate>("n_list_call_cond");
            list_call_cond = (list_call_condDelegate)FunctionImporter.Import<list_call_condDelegate>("list_call_cond");
            n_get_input_pointer = (n_get_input_pointerDelegate)FunctionImporter.Import<n_get_input_pointerDelegate>("n_get_input_pointer");
            get_input_pointer = (get_input_pointerDelegate)FunctionImporter.Import<get_input_pointerDelegate>("get_input_pointer");
            rtc4_max_cards = (rtc4_max_cardsDelegate)FunctionImporter.Import<rtc4_max_cardsDelegate>("rtc4_max_cards");
            n_get_status = (n_get_statusDelegate)FunctionImporter.Import<n_get_statusDelegate>("n_get_status");
            get_status = (get_statusDelegate)FunctionImporter.Import<get_statusDelegate>("get_status");
            n_read_status = (n_read_statusDelegate)FunctionImporter.Import<n_read_statusDelegate>("n_read_status");
            read_status = (read_statusDelegate)FunctionImporter.Import<read_statusDelegate>("read_status");
            n_get_startstop_info = (n_get_startstop_infoDelegate)FunctionImporter.Import<n_get_startstop_infoDelegate>("n_get_startstop_info");
            get_startstop_info = (get_startstop_infoDelegate)FunctionImporter.Import<get_startstop_infoDelegate>("get_startstop_info");
            n_get_marking_info = (n_get_marking_infoDelegate)FunctionImporter.Import<n_get_marking_infoDelegate>("n_get_marking_info");
            get_marking_info = (get_marking_infoDelegate)FunctionImporter.Import<get_marking_infoDelegate>("get_marking_info");
            get_dll_version = (get_dll_versionDelegate)FunctionImporter.Import<get_dll_versionDelegate>("get_dll_version");
            n_set_start_list_1 = (n_set_start_list_1Delegate)FunctionImporter.Import<n_set_start_list_1Delegate>("n_set_start_list_1");
            set_start_list_1 = (set_start_list_1Delegate)FunctionImporter.Import<set_start_list_1Delegate>("set_start_list_1");
            n_set_start_list_2 = (n_set_start_list_2Delegate)FunctionImporter.Import<n_set_start_list_2Delegate>("n_set_start_list_2");
            set_start_list_2 = (set_start_list_2Delegate)FunctionImporter.Import<set_start_list_2Delegate>("set_start_list_2");
            n_set_start_list = (n_set_start_listDelegate)FunctionImporter.Import<n_set_start_listDelegate>("n_set_start_list");
            set_start_list = (set_start_listDelegate)FunctionImporter.Import<set_start_listDelegate>("set_start_list");
            n_execute_list_1 = (n_execute_list_1Delegate)FunctionImporter.Import<n_execute_list_1Delegate>("n_execute_list_1");
            execute_list_1 = (execute_list_1Delegate)FunctionImporter.Import<execute_list_1Delegate>("execute_list_1");
            n_execute_list_2 = (n_execute_list_2Delegate)FunctionImporter.Import<n_execute_list_2Delegate>("n_execute_list_2");
            execute_list_2 = (execute_list_2Delegate)FunctionImporter.Import<execute_list_2Delegate>("execute_list_2");
            n_execute_list = (n_execute_listDelegate)FunctionImporter.Import<n_execute_listDelegate>("n_execute_list");
            execute_list = (execute_listDelegate)FunctionImporter.Import<execute_listDelegate>("execute_list");
            n_write_8bit_port = (n_write_8bit_portDelegate)FunctionImporter.Import<n_write_8bit_portDelegate>("n_write_8bit_port");
            write_8bit_port = (write_8bit_portDelegate)FunctionImporter.Import<write_8bit_portDelegate>("write_8bit_port");
            n_write_io_port = (n_write_io_portDelegate)FunctionImporter.Import<n_write_io_portDelegate>("n_write_io_port");
            write_io_port = (write_io_portDelegate)FunctionImporter.Import<write_io_portDelegate>("write_io_port");
            n_eth_status = (n_eth_statusDelegate)FunctionImporter.Import<n_eth_statusDelegate>("n_eth_status");
            eth_status = (eth_statusDelegate)FunctionImporter.Import<eth_statusDelegate>("eth_status");
            n_auto_change = (n_auto_changeDelegate)FunctionImporter.Import<n_auto_changeDelegate>("n_auto_change");
            auto_change = (auto_changeDelegate)FunctionImporter.Import<auto_changeDelegate>("auto_change");
            n_auto_change_pos = (n_auto_change_posDelegate)FunctionImporter.Import<n_auto_change_posDelegate>("n_auto_change_pos");
            auto_change_pos = (auto_change_posDelegate)FunctionImporter.Import<auto_change_posDelegate>("auto_change_pos");
            aut_change = (aut_changeDelegate)FunctionImporter.Import<aut_changeDelegate>("aut_change");
            n_start_loop = (n_start_loopDelegate)FunctionImporter.Import<n_start_loopDelegate>("n_start_loop");
            start_loop = (start_loopDelegate)FunctionImporter.Import<start_loopDelegate>("start_loop");
            n_quit_loop = (n_quit_loopDelegate)FunctionImporter.Import<n_quit_loopDelegate>("n_quit_loop");
            quit_loop = (quit_loopDelegate)FunctionImporter.Import<quit_loopDelegate>("quit_loop");
            n_stop_execution = (n_stop_executionDelegate)FunctionImporter.Import<n_stop_executionDelegate>("n_stop_execution");
            stop_execution = (stop_executionDelegate)FunctionImporter.Import<stop_executionDelegate>("stop_execution");
            n_read_io_port = (n_read_io_portDelegate)FunctionImporter.Import<n_read_io_portDelegate>("n_read_io_port");
            read_io_port = (read_io_portDelegate)FunctionImporter.Import<read_io_portDelegate>("read_io_port");
            n_write_da_1 = (n_write_da_1Delegate)FunctionImporter.Import<n_write_da_1Delegate>("n_write_da_1");
            write_da_1 = (write_da_1Delegate)FunctionImporter.Import<write_da_1Delegate>("write_da_1");
            n_write_da_2 = (n_write_da_2Delegate)FunctionImporter.Import<n_write_da_2Delegate>("n_write_da_2");
            write_da_2 = (write_da_2Delegate)FunctionImporter.Import<write_da_2Delegate>("write_da_2");
            n_set_max_counts = (n_set_max_countsDelegate)FunctionImporter.Import<n_set_max_countsDelegate>("n_set_max_counts");
            set_max_counts = (set_max_countsDelegate)FunctionImporter.Import<set_max_countsDelegate>("set_max_counts");
            n_get_counts = (n_get_countsDelegate)FunctionImporter.Import<n_get_countsDelegate>("n_get_counts");
            get_counts = (get_countsDelegate)FunctionImporter.Import<get_countsDelegate>("get_counts");
            n_set_matrix = (n_set_matrixDelegate)FunctionImporter.Import<n_set_matrixDelegate>("n_set_matrix");
            set_matrix = (set_matrixDelegate)FunctionImporter.Import<set_matrixDelegate>("set_matrix");
            n_set_offset = (n_set_offsetDelegate)FunctionImporter.Import<n_set_offsetDelegate>("n_set_offset");
            set_offset = (set_offsetDelegate)FunctionImporter.Import<set_offsetDelegate>("set_offset");
            n_goto_xyz = (n_goto_xyzDelegate)FunctionImporter.Import<n_goto_xyzDelegate>("n_goto_xyz");
            goto_xyz = (goto_xyzDelegate)FunctionImporter.Import<goto_xyzDelegate>("goto_xyz");
            n_goto_xy = (n_goto_xyDelegate)FunctionImporter.Import<n_goto_xyDelegate>("n_goto_xy");
            goto_xy = (goto_xyDelegate)FunctionImporter.Import<goto_xyDelegate>("goto_xy");
            n_get_hex_version = (n_get_hex_versionDelegate)FunctionImporter.Import<n_get_hex_versionDelegate>("n_get_hex_version");
            get_hex_version = (get_hex_versionDelegate)FunctionImporter.Import<get_hex_versionDelegate>("get_hex_version");
            n_disable_laser = (n_disable_laserDelegate)FunctionImporter.Import<n_disable_laserDelegate>("n_disable_laser");
            disable_laser = (disable_laserDelegate)FunctionImporter.Import<disable_laserDelegate>("disable_laser");
            n_enable_laser = (n_enable_laserDelegate)FunctionImporter.Import<n_enable_laserDelegate>("n_enable_laser");
            enable_laser = (enable_laserDelegate)FunctionImporter.Import<enable_laserDelegate>("enable_laser");
            n_stop_list = (n_stop_listDelegate)FunctionImporter.Import<n_stop_listDelegate>("n_stop_list");
            stop_list = (stop_listDelegate)FunctionImporter.Import<stop_listDelegate>("stop_list");
            n_restart_list = (n_restart_listDelegate)FunctionImporter.Import<n_restart_listDelegate>("n_restart_list");
            restart_list = (restart_listDelegate)FunctionImporter.Import<restart_listDelegate>("restart_list");
            n_get_xyz_pos = (n_get_xyz_posDelegate)FunctionImporter.Import<n_get_xyz_posDelegate>("n_get_xyz_pos");
            get_xyz_pos = (get_xyz_posDelegate)FunctionImporter.Import<get_xyz_posDelegate>("get_xyz_pos");
            n_get_xy_pos = (n_get_xy_posDelegate)FunctionImporter.Import<n_get_xy_posDelegate>("n_get_xy_pos");
            get_xy_pos = (get_xy_posDelegate)FunctionImporter.Import<get_xy_posDelegate>("get_xy_pos");
            n_select_list = (n_select_listDelegate)FunctionImporter.Import<n_select_listDelegate>("n_select_list");
            select_list = (select_listDelegate)FunctionImporter.Import<select_listDelegate>("select_list");
            n_z_out = (n_z_outDelegate)FunctionImporter.Import<n_z_outDelegate>("n_z_out");
            z_out = (z_outDelegate)FunctionImporter.Import<z_outDelegate>("z_out");
            n_set_firstpulse_killer = (n_set_firstpulse_killerDelegate)FunctionImporter.Import<n_set_firstpulse_killerDelegate>("n_set_firstpulse_killer");
            set_firstpulse_killer = (set_firstpulse_killerDelegate)FunctionImporter.Import<set_firstpulse_killerDelegate>("set_firstpulse_killer");
            n_set_standby = (n_set_standbyDelegate)FunctionImporter.Import<n_set_standbyDelegate>("n_set_standby");
            set_standby = (set_standbyDelegate)FunctionImporter.Import<set_standbyDelegate>("set_standby");
            n_laser_signal_on = (n_laser_signal_onDelegate)FunctionImporter.Import<n_laser_signal_onDelegate>("n_laser_signal_on");
            laser_signal_on = (laser_signal_onDelegate)FunctionImporter.Import<laser_signal_onDelegate>("laser_signal_on");
            n_laser_signal_off = (n_laser_signal_offDelegate)FunctionImporter.Import<n_laser_signal_offDelegate>("n_laser_signal_off");
            laser_signal_off = (laser_signal_offDelegate)FunctionImporter.Import<laser_signal_offDelegate>("laser_signal_off");
            n_set_delay_mode = (n_set_delay_modeDelegate)FunctionImporter.Import<n_set_delay_modeDelegate>("n_set_delay_mode");
            set_delay_mode = (set_delay_modeDelegate)FunctionImporter.Import<set_delay_modeDelegate>("set_delay_mode");
            n_set_piso_control = (n_set_piso_controlDelegate)FunctionImporter.Import<n_set_piso_controlDelegate>("n_set_piso_control");
            set_piso_control = (set_piso_controlDelegate)FunctionImporter.Import<set_piso_controlDelegate>("set_piso_control");
            n_select_status = (n_select_statusDelegate)FunctionImporter.Import<n_select_statusDelegate>("n_select_status");
            select_status = (select_statusDelegate)FunctionImporter.Import<select_statusDelegate>("select_status");
            n_get_encoder = (n_get_encoderDelegate)FunctionImporter.Import<n_get_encoderDelegate>("n_get_encoder");
            get_encoder = (get_encoderDelegate)FunctionImporter.Import<get_encoderDelegate>("get_encoder");
            n_select_cor_table = (n_select_cor_tableDelegate)FunctionImporter.Import<n_select_cor_tableDelegate>("n_select_cor_table");
            select_cor_table = (select_cor_tableDelegate)FunctionImporter.Import<select_cor_tableDelegate>("select_cor_table");
            n_execute_at_pointer = (n_execute_at_pointerDelegate)FunctionImporter.Import<n_execute_at_pointerDelegate>("n_execute_at_pointer");
            execute_at_pointer = (execute_at_pointerDelegate)FunctionImporter.Import<execute_at_pointerDelegate>("execute_at_pointer");
            n_get_head_status = (n_get_head_statusDelegate)FunctionImporter.Import<n_get_head_statusDelegate>("n_get_head_status");
            get_head_status = (get_head_statusDelegate)FunctionImporter.Import<get_head_statusDelegate>("get_head_status");
            n_simulate_encoder = (n_simulate_encoderDelegate)FunctionImporter.Import<n_simulate_encoderDelegate>("n_simulate_encoder");
            simulate_encoder = (simulate_encoderDelegate)FunctionImporter.Import<simulate_encoderDelegate>("simulate_encoder");
            n_release_wait = (n_release_waitDelegate)FunctionImporter.Import<n_release_waitDelegate>("n_release_wait");
            release_wait = (release_waitDelegate)FunctionImporter.Import<release_waitDelegate>("release_wait");
            n_get_wait_status = (n_get_wait_statusDelegate)FunctionImporter.Import<n_get_wait_statusDelegate>("n_get_wait_status");
            get_wait_status = (get_wait_statusDelegate)FunctionImporter.Import<get_wait_statusDelegate>("get_wait_status");
            n_set_laser_mode = (n_set_laser_modeDelegate)FunctionImporter.Import<n_set_laser_modeDelegate>("n_set_laser_mode");
            set_laser_mode = (set_laser_modeDelegate)FunctionImporter.Import<set_laser_modeDelegate>("set_laser_mode");
            n_set_ext_start_delay = (n_set_ext_start_delayDelegate)FunctionImporter.Import<n_set_ext_start_delayDelegate>("n_set_ext_start_delay");
            set_ext_start_delay = (set_ext_start_delayDelegate)FunctionImporter.Import<set_ext_start_delayDelegate>("set_ext_start_delay");
            n_home_position = (n_home_positionDelegate)FunctionImporter.Import<n_home_positionDelegate>("n_home_position");
            home_position = (home_positionDelegate)FunctionImporter.Import<home_positionDelegate>("home_position");
            n_set_rot_center = (n_set_rot_centerDelegate)FunctionImporter.Import<n_set_rot_centerDelegate>("n_set_rot_center");
            set_rot_center = (set_rot_centerDelegate)FunctionImporter.Import<set_rot_centerDelegate>("set_rot_center");
            n_dsp_start = (n_dsp_startDelegate)FunctionImporter.Import<n_dsp_startDelegate>("n_dsp_start");
            dsp_start = (dsp_startDelegate)FunctionImporter.Import<dsp_startDelegate>("dsp_start");
            n_write_da_x = (n_write_da_xDelegate)FunctionImporter.Import<n_write_da_xDelegate>("n_write_da_x");
            write_da_x = (write_da_xDelegate)FunctionImporter.Import<write_da_xDelegate>("write_da_x");
            n_read_ad_x = (n_read_ad_xDelegate)FunctionImporter.Import<n_read_ad_xDelegate>("n_read_ad_x");
            read_ad_x = (read_ad_xDelegate)FunctionImporter.Import<read_ad_xDelegate>("read_ad_x");
            n_read_pixel_ad = (n_read_pixel_adDelegate)FunctionImporter.Import<n_read_pixel_adDelegate>("n_read_pixel_ad");
            read_pixel_ad = (read_pixel_adDelegate)FunctionImporter.Import<read_pixel_adDelegate>("read_pixel_ad");
            n_get_z_distance = (n_get_z_distanceDelegate)FunctionImporter.Import<n_get_z_distanceDelegate>("n_get_z_distance");
            get_z_distance = (get_z_distanceDelegate)FunctionImporter.Import<get_z_distanceDelegate>("get_z_distance");
            n_get_io_status = (n_get_io_statusDelegate)FunctionImporter.Import<n_get_io_statusDelegate>("n_get_io_status");
            get_io_status = (get_io_statusDelegate)FunctionImporter.Import<get_io_statusDelegate>("get_io_status");
            load_cor = (load_corDelegate)FunctionImporter.Import<load_corDelegate>("load_cor");
            load_pro = (load_proDelegate)FunctionImporter.Import<load_proDelegate>("load_pro");
            n_get_serial_number = (n_get_serial_numberDelegate)FunctionImporter.Import<n_get_serial_numberDelegate>("n_get_serial_number");
            get_serial_number = (get_serial_numberDelegate)FunctionImporter.Import<get_serial_numberDelegate>("get_serial_number");
            n_get_serial_number_32 = (n_get_serial_number_32Delegate)FunctionImporter.Import<n_get_serial_number_32Delegate>("n_get_serial_number_32");
            get_serial_number_32 = (get_serial_number_32Delegate)FunctionImporter.Import<get_serial_number_32Delegate>("get_serial_number_32");
            n_get_rtc_version = (n_get_rtc_versionDelegate)FunctionImporter.Import<n_get_rtc_versionDelegate>("n_get_rtc_version");
            get_rtc_version = (get_rtc_versionDelegate)FunctionImporter.Import<get_rtc_versionDelegate>("get_rtc_version");
            n_auto_cal = (n_auto_calDelegate)FunctionImporter.Import<n_auto_calDelegate>("n_auto_cal");
            auto_cal = (auto_calDelegate)FunctionImporter.Import<auto_calDelegate>("auto_cal");
            n_set_hi = (n_set_hiDelegate)FunctionImporter.Import<n_set_hiDelegate>("n_set_hi");
            set_hi = (set_hiDelegate)FunctionImporter.Import<set_hiDelegate>("set_hi");
            n_set_list_mode = (n_set_list_modeDelegate)FunctionImporter.Import<n_set_list_modeDelegate>("n_set_list_mode");
            set_list_mode = (set_list_modeDelegate)FunctionImporter.Import<set_list_modeDelegate>("set_list_mode");
            n_get_list_space = (n_get_list_spaceDelegate)FunctionImporter.Import<n_get_list_spaceDelegate>("n_get_list_space");
            get_list_space = (get_list_spaceDelegate)FunctionImporter.Import<get_list_spaceDelegate>("get_list_space");
            n_save_and_restart_timer = (n_save_and_restart_timerDelegate)FunctionImporter.Import<n_save_and_restart_timerDelegate>("n_save_and_restart_timer");
            save_and_restart_timer = (save_and_restart_timerDelegate)FunctionImporter.Import<save_and_restart_timerDelegate>("save_and_restart_timer");
            n_set_ext_start_delay_list = (n_set_ext_start_delay_listDelegate)FunctionImporter.Import<n_set_ext_start_delay_listDelegate>("n_set_ext_start_delay_list");
            set_ext_start_delay_list = (set_ext_start_delay_listDelegate)FunctionImporter.Import<set_ext_start_delay_listDelegate>("set_ext_start_delay_list");
            n_get_time = (n_get_timeDelegate)FunctionImporter.Import<n_get_timeDelegate>("n_get_time");
            get_time = (get_timeDelegate)FunctionImporter.Import<get_timeDelegate>("get_time");
            get_hi_data = (get_hi_dataDelegate)FunctionImporter.Import<get_hi_dataDelegate>("get_hi_data");
            teachin = (teachinDelegate)FunctionImporter.Import<teachinDelegate>("teachin");
            getmemory = (getmemoryDelegate)FunctionImporter.Import<getmemoryDelegate>("getmemory");
            set_timeout = (set_timeoutDelegate)FunctionImporter.Import<set_timeoutDelegate>("set_timeout");
            set_timeouts = (set_timeoutsDelegate)FunctionImporter.Import<set_timeoutsDelegate>("set_timeouts");
            get_timeouts = (get_timeoutsDelegate)FunctionImporter.Import<get_timeoutsDelegate>("get_timeouts");
            rs232_config = (rs232_configDelegate)FunctionImporter.Import<rs232_configDelegate>("rs232_config");
            n_rs232_config = (n_rs232_configDelegate)FunctionImporter.Import<n_rs232_configDelegate>("n_rs232_config");
            rs232_write_data = (rs232_write_dataDelegate)FunctionImporter.Import<rs232_write_dataDelegate>("rs232_write_data");
            n_rs232_write_data = (n_rs232_write_dataDelegate)FunctionImporter.Import<n_rs232_write_dataDelegate>("n_rs232_write_data");
            rs232_write_text = (rs232_write_textDelegate)FunctionImporter.Import<rs232_write_textDelegate>("rs232_write_text");
            n_rs232_write_text = (n_rs232_write_textDelegate)FunctionImporter.Import<n_rs232_write_textDelegate>("n_rs232_write_text");
            rs232_read_data = (rs232_read_dataDelegate)FunctionImporter.Import<rs232_read_dataDelegate>("rs232_read_data");
            n_rs232_read_data = (n_rs232_read_dataDelegate)FunctionImporter.Import<n_rs232_read_dataDelegate>("n_rs232_read_data");
            n_eth_set_com_timeouts_auto = (n_eth_set_com_timeouts_autoDelegate)FunctionImporter.Import<n_eth_set_com_timeouts_autoDelegate>("n_eth_set_com_timeouts_auto");
            eth_set_com_timeouts_auto = (eth_set_com_timeouts_autoDelegate)FunctionImporter.Import<eth_set_com_timeouts_autoDelegate>("eth_set_com_timeouts_auto");
            n_eth_get_com_timeouts_auto = (n_eth_get_com_timeouts_autoDelegate)FunctionImporter.Import<n_eth_get_com_timeouts_autoDelegate>("n_eth_get_com_timeouts_auto");
            eth_get_com_timeouts_auto = (eth_get_com_timeouts_autoDelegate)FunctionImporter.Import<eth_get_com_timeouts_autoDelegate>("eth_get_com_timeouts_auto");
            n_eth_watchdog_timer_config = (n_eth_watchdog_timer_configDelegate)FunctionImporter.Import<n_eth_watchdog_timer_configDelegate>("n_eth_watchdog_timer_config");
            eth_watchdog_timer_config = (eth_watchdog_timer_configDelegate)FunctionImporter.Import<eth_watchdog_timer_configDelegate>("eth_watchdog_timer_config");
            n_eth_watchdog_timer_reset = (n_eth_watchdog_timer_resetDelegate)FunctionImporter.Import<n_eth_watchdog_timer_resetDelegate>("n_eth_watchdog_timer_reset");
            eth_watchdog_timer_reset = (eth_watchdog_timer_resetDelegate)FunctionImporter.Import<eth_watchdog_timer_resetDelegate>("eth_watchdog_timer_reset");
            n_eth_link_loss_config = (n_eth_link_loss_configDelegate)FunctionImporter.Import<n_eth_link_loss_configDelegate>("n_eth_link_loss_config");
            eth_link_loss_config = (eth_link_loss_configDelegate)FunctionImporter.Import<eth_link_loss_configDelegate>("eth_link_loss_config");
            n_eth_get_last_error = (n_eth_get_last_errorDelegate)FunctionImporter.Import<n_eth_get_last_errorDelegate>("n_eth_get_last_error");
            eth_get_last_error = (eth_get_last_errorDelegate)FunctionImporter.Import<eth_get_last_errorDelegate>("eth_get_last_error");
            n_eth_get_error = (n_eth_get_errorDelegate)FunctionImporter.Import<n_eth_get_errorDelegate>("n_eth_get_error");
            eth_get_error = (eth_get_errorDelegate)FunctionImporter.Import<eth_get_errorDelegate>("eth_get_error");
            n_eth_error_dump = (n_eth_error_dumpDelegate)FunctionImporter.Import<n_eth_error_dumpDelegate>("n_eth_error_dump");
            eth_error_dump = (eth_error_dumpDelegate)FunctionImporter.Import<eth_error_dumpDelegate>("eth_error_dump");
            #endregion
        }

        public static void SelectDLL(String dll_name)
        {
            ImportFunctions(dll_name);
        }

                
        // Notice that the static constructor is used to initialize any static data,
        //    or to perform a particular action that needs to be performed once only.
        //    It is called automatically before the first instance is created or any
        //    static members are referenced.
        static RTC4ethWrap()
        {
             try
             {
                   ImportFunctions((Marshal.SizeOf(typeof(IntPtr)) == 4) ? RTC4ethDLLx86 : RTC4ethDLLx64);
             } catch
             {
                   // We do not give an error here, because the user might want to use a non-standard
                   // DLL-name. Then the first call of ImportFunctions will always fail.
                   // In case of an unintentionally missing standard DLL, the user gets a different
                   // error message. This is ugly but there is no other way to keep the current way
                   // of using the Wrapper (keep API compatible).
                   return;
             }
        }

    }

}

