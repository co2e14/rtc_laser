'
'  Visual Basic .NET Import Declarations for the SCANLAB RTC4eth-DLL
'
'  This file was automatically generated on 2022-01-21.
'
'  Note:
'  If your application does not allow unsigned data types
'  (due to for example CLR compliancy) you can replace all
'  occurences of the UShort(UInteger) type with the Short(Integer)
'  type but you then need to make sure to interpret the returned
'  values correctly in your code!
'  For example get_status returns busy = 65535 as type UShort
'  and busy = -1 as type Short when the RTC is executing a list.
'

Option Strict Off
Option Explicit On

Imports System.Runtime.InteropServices

Module RTC4eth
    Declare Function get_driver_status Lib "RTC4ethDLL.DLL" () As UInteger
    Declare Function get_net_dll_version Lib "RTC4ethDLL.DLL" () As UInteger
    Declare Function acquire_rtc Lib "RTC4ethDLL.DLL" (ByVal card_no As UInteger) As UInteger
    Declare Function release_rtc Lib "RTC4ethDLL.DLL" (ByVal card_no As UInteger) As UInteger
    Declare Sub      select_rtc Lib "RTC4ethDLL.DLL" (ByVal card_no As UShort)
    Declare Function assign_rtc Lib "RTC4ethDLL.DLL" (ByVal search_no As UShort, ByVal card_no As UShort) As UInteger
    Declare Function assign_rtc_by_ip Lib "RTC4ethDLL.DLL" (ByVal ip As UInteger, ByVal card_no As UShort) As UInteger
    Declare Sub      remove_rtc Lib "RTC4ethDLL.DLL" (ByVal card_no As UShort)
    Declare Function convert_string_to_ip Lib "RTC4ethDLL.DLL" (ByVal ip As String) As UInteger
    Declare Sub      convert_ip_to_string Lib "RTC4ethDLL.DLL" (ByVal ip As UInteger, ByVal cpip As IntPtr)
    Declare Sub      convert_mac_to_string Lib "RTC4ethDLL.DLL" (ByVal mac As Long, ByVal cpmac As IntPtr)
    Declare Function rtc_search_cards Lib "RTC4ethDLL.DLL" (ByRef cards As UShort, ByVal ip As UInteger, ByVal netmask As UInteger) As UInteger
    Declare Function get_mac_address Lib "RTC4ethDLL.DLL" (ByVal cardno As UShort) As Long
    Declare Function get_ip_address Lib "RTC4ethDLL.DLL" (ByVal cardno As UShort) As UInteger
    Declare Function get_serial Lib "RTC4ethDLL.DLL" (ByVal cardno As UShort) As UInteger
    Declare Function get_connection_status Lib "RTC4ethDLL.DLL" (ByVal cardno As UShort) As UShort
    Declare Function get_master_ip_address Lib "RTC4ethDLL.DLL" (ByVal cardno As UShort) As UInteger
    Declare Function get_master_id Lib "RTC4ethDLL.DLL" (ByVal cardno As UShort, ByVal id As IntPtr) As UInteger
    Declare Function set_static_ip Lib "RTC4ethDLL.DLL" (ByVal ip As UInteger, ByVal netmask As UInteger, ByVal gateway As UInteger) As UInteger
    Declare Function get_static_ip Lib "RTC4ethDLL.DLL" (ByRef ip As UInteger, ByRef netmask As UInteger, ByRef gateway As UInteger) As UInteger
    Declare Function get_mcu_fw_version Lib "RTC4ethDLL.DLL" (ByVal cardno As UShort) As UInteger
    Declare Function get_nic_ip_count Lib "RTC4ethDLL.DLL" (ByRef count As UShort) As UInteger
    Declare Sub      get_nic_ip Lib "RTC4ethDLL.DLL" (ByVal count As UShort, ByRef ip As UInteger, ByRef nm As UInteger)
    Declare Sub      n_get_waveform Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal channel As UShort, ByVal istop As UShort, <MarshalAs(UnmanagedType.LPArray)> memptr As Short())
    Declare Sub      get_waveform Lib "RTC4ethDLL.DLL" (ByVal channel As UShort, ByVal istop As UShort, <MarshalAs(UnmanagedType.LPArray)> memptr As Short())
    Declare Sub      n_measurement_status Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByRef busy As UShort, ByRef position As UShort)
    Declare Sub      measurement_status Lib "RTC4ethDLL.DLL" (ByRef busy As UShort, ByRef position As UShort)
    Declare Sub      n_set_trigger Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal sampleperiod As UShort, ByVal channel1 As UShort, ByVal channel2 As UShort)
    Declare Sub      set_trigger Lib "RTC4ethDLL.DLL" (ByVal sampleperiod As UShort, ByVal signal1 As UShort, ByVal signal2 As UShort)
    Declare Function n_get_value Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal signal As UShort) As Short
    Declare Function get_value Lib "RTC4ethDLL.DLL" (ByVal signal As UShort) As Short
    Declare Sub      n_set_io_bit Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal mask1 As UShort)
    Declare Sub      set_io_bit Lib "RTC4ethDLL.DLL" (ByVal mask1 As UShort)
    Declare Sub      n_clear_io_bit Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal mask0 As UShort)
    Declare Sub      clear_io_bit Lib "RTC4ethDLL.DLL" (ByVal mask0 As UShort)
    Declare Sub      n_move_to Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal position As UShort)
    Declare Sub      move_to Lib "RTC4ethDLL.DLL" (ByVal position As UShort)
    Declare Sub      n_control_command Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal head As UShort, ByVal axis As UShort, ByVal data As UShort)
    Declare Sub      control_command Lib "RTC4ethDLL.DLL" (ByVal head As UShort, ByVal axis As UShort, ByVal data As UShort)
    Declare Sub      n_arc_rel Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal dx As Short, ByVal dy As Short, ByVal angle As Double)
    Declare Sub      arc_rel Lib "RTC4ethDLL.DLL" (ByVal dx As Short, ByVal dy As Short, ByVal angle As Double)
    Declare Sub      n_arc_abs Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal x As Short, ByVal y As Short, ByVal angle As Double)
    Declare Sub      arc_abs Lib "RTC4ethDLL.DLL" (ByVal x As Short, ByVal y As Short, ByVal angle As Double)
    Declare Sub      drilling Lib "RTC4ethDLL.DLL" (ByVal pulsewidth As Short, ByVal relencoderdelay As Short)
    Declare Sub      regulation Lib "RTC4ethDLL.DLL" ()
    Declare Sub      flyline Lib "RTC4ethDLL.DLL" (ByVal encoderdelay As Short)
    Declare Sub      set_duty_cycle_table Lib "RTC4ethDLL.DLL" (ByVal index As UShort, ByVal dutycycle As UShort)
    Declare Function n_load_varpolydelay Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal stbfilename As String, ByVal tableno As UShort) As Short
    Declare Function load_varpolydelay Lib "RTC4ethDLL.DLL" (ByVal stbfilename As String, ByVal tableno As UShort) As Short
    Declare Function n_load_program_file Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal name As String) As Short
    Declare Function load_program_file Lib "RTC4ethDLL.DLL" (ByVal name As String) As Short
    Declare Function n_load_correction_file Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal filename As String, ByVal cortable As Short, ByVal kx As Double, ByVal ky As Double, ByVal phi As Double, ByVal xoffset As Double, ByVal yoffset As Double) As Short
    Declare Function load_correction_file Lib "RTC4ethDLL.DLL" (ByVal filename As String, ByVal cortable As Short, ByVal kx As Double, ByVal ky As Double, ByVal phi As Double, ByVal xoffset As Double, ByVal yoffset As Double) As Short
    Declare Function n_load_z_table Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal a As Double, ByVal b As Double, ByVal c As Double) As Short
    Declare Function load_z_table Lib "RTC4ethDLL.DLL" (ByVal a As Double, ByVal b As Double, ByVal c As Double) As Short
    Declare Sub      n_list_nop Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      list_nop Lib "RTC4ethDLL.DLL" ()
    Declare Sub      n_set_end_of_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      set_end_of_list Lib "RTC4ethDLL.DLL" ()
    Declare Sub      n_jump_abs_3d Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal x As Short, ByVal y As Short, ByVal z As Short)
    Declare Sub      jump_abs_3d Lib "RTC4ethDLL.DLL" (ByVal x As Short, ByVal y As Short, ByVal z As Short)
    Declare Sub      n_jump_abs Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal x As Short, ByVal y As Short)
    Declare Sub      jump_abs Lib "RTC4ethDLL.DLL" (ByVal x As Short, ByVal y As Short)
    Declare Sub      n_mark_abs_3d Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal x As Short, ByVal y As Short, ByVal z As Short)
    Declare Sub      mark_abs_3d Lib "RTC4ethDLL.DLL" (ByVal x As Short, ByVal y As Short, ByVal z As Short)
    Declare Sub      n_mark_abs Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal x As Short, ByVal y As Short)
    Declare Sub      mark_abs Lib "RTC4ethDLL.DLL" (ByVal x As Short, ByVal y As Short)
    Declare Sub      n_jump_rel_3d Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal dx As Short, ByVal dy As Short, ByVal dz As Short)
    Declare Sub      jump_rel_3d Lib "RTC4ethDLL.DLL" (ByVal dx As Short, ByVal dy As Short, ByVal dz As Short)
    Declare Sub      n_jump_rel Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal dx As Short, ByVal dy As Short)
    Declare Sub      jump_rel Lib "RTC4ethDLL.DLL" (ByVal dx As Short, ByVal dy As Short)
    Declare Sub      n_mark_rel_3d Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal dx As Short, ByVal dy As Short, ByVal dz As Short)
    Declare Sub      mark_rel_3d Lib "RTC4ethDLL.DLL" (ByVal dx As Short, ByVal dy As Short, ByVal dz As Short)
    Declare Sub      n_mark_rel Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal dx As Short, ByVal dy As Short)
    Declare Sub      mark_rel Lib "RTC4ethDLL.DLL" (ByVal dx As Short, ByVal dy As Short)
    Declare Sub      n_write_8bit_port_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal value As UShort)
    Declare Sub      write_8bit_port_list Lib "RTC4ethDLL.DLL" (ByVal value As UShort)
    Declare Sub      n_write_da_1_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal value As UShort)
    Declare Sub      write_da_1_list Lib "RTC4ethDLL.DLL" (ByVal value As UShort)
    Declare Sub      n_write_da_2_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal value As UShort)
    Declare Sub      write_da_2_list Lib "RTC4ethDLL.DLL" (ByVal value As UShort)
    Declare Sub      n_set_matrix_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal i As UShort, ByVal j As UShort, ByVal mij As Double)
    Declare Sub      set_matrix_list Lib "RTC4ethDLL.DLL" (ByVal i As UShort, ByVal j As UShort, ByVal mij As Double)
    Declare Sub      n_set_offset_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal xoffset As Short, ByVal yoffset As Short)
    Declare Sub      set_offset_list Lib "RTC4ethDLL.DLL" (ByVal xoffset As Short, ByVal yoffset As Short)
    Declare Sub      n_set_defocus_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal value As Short)
    Declare Sub      set_defocus_list Lib "RTC4ethDLL.DLL" (ByVal value As Short)
    Declare Sub      n_set_defocus Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal value As Short)
    Declare Sub      set_defocus Lib "RTC4ethDLL.DLL" (ByVal value As Short)
    Declare Sub      n_set_softstart_mode Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal mode As UShort, ByVal number As UShort, ByVal restartdelay As UShort)
    Declare Sub      set_softstart_mode Lib "RTC4ethDLL.DLL" (ByVal mode As UShort, ByVal number As UShort, ByVal resetdelay As UShort)
    Declare Sub      n_set_softstart_level Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal index As UShort, ByVal level As UShort)
    Declare Sub      set_softstart_level Lib "RTC4ethDLL.DLL" (ByVal index As UShort, ByVal level As UShort)
    Declare Sub      n_set_control_mode_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal mode As UShort)
    Declare Sub      set_control_mode_list Lib "RTC4ethDLL.DLL" (ByVal mode As UShort)
    Declare Sub      n_set_control_mode Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal mode As UShort)
    Declare Sub      set_control_mode Lib "RTC4ethDLL.DLL" (ByVal mode As UShort)
    Declare Sub      n_long_delay Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal value As UShort)
    Declare Sub      long_delay Lib "RTC4ethDLL.DLL" (ByVal value As UShort)
    Declare Sub      n_laser_on_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal value As UShort)
    Declare Sub      laser_on_list Lib "RTC4ethDLL.DLL" (ByVal value As UShort)
    Declare Sub      n_set_jump_speed Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal speed As Double)
    Declare Sub      set_jump_speed Lib "RTC4ethDLL.DLL" (ByVal speed As Double)
    Declare Sub      n_set_mark_speed Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal speed As Double)
    Declare Sub      set_mark_speed Lib "RTC4ethDLL.DLL" (ByVal speed As Double)
    Declare Sub      n_set_laser_delays Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal ondelay As Short, ByVal offdelay As Short)
    Declare Sub      set_laser_delays Lib "RTC4ethDLL.DLL" (ByVal ondelay As Short, ByVal offdelay As Short)
    Declare Sub      n_set_scanner_delays Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal jumpdelay As UShort, ByVal markdelay As UShort, ByVal polydelay As UShort)
    Declare Sub      set_scanner_delays Lib "RTC4ethDLL.DLL" (ByVal jumpdelay As UShort, ByVal markdelay As UShort, ByVal polydelay As UShort)
    Declare Sub      n_set_list_jump Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal position As UShort)
    Declare Sub      set_list_jump Lib "RTC4ethDLL.DLL" (ByVal position As UShort)
    Declare Sub      n_set_input_pointer Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal pointer As UShort)
    Declare Sub      set_input_pointer Lib "RTC4ethDLL.DLL" (ByVal pointer As UShort)
    Declare Sub      n_list_call Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal position As UShort)
    Declare Sub      list_call Lib "RTC4ethDLL.DLL" (ByVal position As UShort)
    Declare Sub      n_list_return Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      list_return Lib "RTC4ethDLL.DLL" ()
    Declare Sub      n_z_out_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal z As Short)
    Declare Sub      z_out_list Lib "RTC4ethDLL.DLL" (ByVal z As Short)
    Declare Sub      n_set_standby_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal half_period As UShort, ByVal pulse As UShort)
    Declare Sub      set_standby_list Lib "RTC4ethDLL.DLL" (ByVal half_period As UShort, ByVal pulse As UShort)
    Declare Sub      n_timed_jump_abs Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal x As Short, ByVal y As Short, ByVal time As Double)
    Declare Sub      timed_jump_abs Lib "RTC4ethDLL.DLL" (ByVal x As Short, ByVal y As Short, ByVal time As Double)
    Declare Sub      n_timed_mark_abs Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal x As Short, ByVal y As Short, ByVal time As Double)
    Declare Sub      timed_mark_abs Lib "RTC4ethDLL.DLL" (ByVal x As Short, ByVal y As Short, ByVal time As Double)
    Declare Sub      n_timed_jump_rel Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal dx As Short, ByVal dy As Short, ByVal time As Double)
    Declare Sub      timed_jump_rel Lib "RTC4ethDLL.DLL" (ByVal dx As Short, ByVal dy As Short, ByVal time As Double)
    Declare Sub      n_timed_mark_rel Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal dx As Short, ByVal dy As Short, ByVal time As Double)
    Declare Sub      timed_mark_rel Lib "RTC4ethDLL.DLL" (ByVal dx As Short, ByVal dy As Short, ByVal time As Double)
    Declare Sub      n_set_laser_timing Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal halfperiod As UShort, ByVal pulse1 As UShort, ByVal pulse2 As UShort, ByVal timebase As UShort)
    Declare Sub      set_laser_timing Lib "RTC4ethDLL.DLL" (ByVal halfperiod As UShort, ByVal pulse1 As UShort, ByVal pulse2 As UShort, ByVal timebase As UShort)
    Declare Sub      n_set_wobbel Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal amplitude As UShort, ByVal frequency As Double)
    Declare Sub      set_wobbel Lib "RTC4ethDLL.DLL" (ByVal amplitude As UShort, ByVal frequency As Double)
    Declare Sub      n_set_wobbel_xy Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal long_wob As UShort, ByVal trans_wob As UShort, ByVal frequency As Double)
    Declare Sub      set_wobbel_xy Lib "RTC4ethDLL.DLL" (ByVal long_wob As UShort, ByVal trans_wob As UShort, ByVal frequency As Double)
    Declare Sub      n_set_fly_x Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal kx As Double)
    Declare Sub      set_fly_x Lib "RTC4ethDLL.DLL" (ByVal kx As Double)
    Declare Sub      n_set_fly_y Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal ky As Double)
    Declare Sub      set_fly_y Lib "RTC4ethDLL.DLL" (ByVal ky As Double)
    Declare Sub      n_set_fly_rot Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal resolution As Double)
    Declare Sub      set_fly_rot Lib "RTC4ethDLL.DLL" (ByVal resolution As Double)
    Declare Sub      n_fly_return Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal x As Short, ByVal y As Short)
    Declare Sub      fly_return Lib "RTC4ethDLL.DLL" (ByVal x As Short, ByVal y As Short)
    Declare Sub      n_calculate_fly Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal direction As UShort, ByVal distance As Double)
    Declare Sub      calculate_fly Lib "RTC4ethDLL.DLL" (ByVal direction As UShort, ByVal distance As Double)
    Declare Sub      n_write_io_port_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal value As UShort)
    Declare Sub      write_io_port_list Lib "RTC4ethDLL.DLL" (ByVal value As UShort)
    Declare Sub      n_select_cor_table_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal heada As UShort, ByVal headb As UShort)
    Declare Sub      select_cor_table_list Lib "RTC4ethDLL.DLL" (ByVal heada As UShort, ByVal headb As UShort)
    Declare Sub      n_set_wait Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal value As UShort)
    Declare Sub      set_wait Lib "RTC4ethDLL.DLL" (ByVal value As UShort)
    Declare Sub      n_simulate_ext_start Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal delay As Short, ByVal encoder As Short)
    Declare Sub      simulate_ext_start Lib "RTC4ethDLL.DLL" (ByVal delay As Short, ByVal encoder As Short)
    Declare Sub      n_write_da_x_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal x As UShort, ByVal value As UShort)
    Declare Sub      write_da_x_list Lib "RTC4ethDLL.DLL" (ByVal x As UShort, ByVal value As UShort)
    Declare Sub      n_set_pixel_line Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal pixelmode As UShort, ByVal pixelperiod As UShort, ByVal dx As Double, ByVal dy As Double)
    Declare Sub      set_pixel_line Lib "RTC4ethDLL.DLL" (ByVal pixelmode As UShort, ByVal pixelperiod As UShort, ByVal dx As Double, ByVal dy As Double)
    Declare Sub      n_set_pixel Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal pulswidth As UShort, ByVal davalue As UShort, ByVal adchannel As UShort)
    Declare Sub      set_pixel Lib "RTC4ethDLL.DLL" (ByVal pulswidth As UShort, ByVal davalue As UShort, ByVal adchannel As UShort)
    Declare Sub      n_set_extstartpos_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal position As UShort)
    Declare Sub      set_extstartpos_list Lib "RTC4ethDLL.DLL" (ByVal position As UShort)
    Declare Sub      n_laser_signal_on_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      laser_signal_on_list Lib "RTC4ethDLL.DLL" ()
    Declare Sub      n_laser_signal_off_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      laser_signal_off_list Lib "RTC4ethDLL.DLL" ()
    Declare Sub      n_set_firstpulse_killer_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal fpk As UShort)
    Declare Sub      set_firstpulse_killer_list Lib "RTC4ethDLL.DLL" (ByVal fpk As UShort)
    Declare Sub      n_set_io_cond_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal mask_1 As UShort, ByVal mask_0 As UShort, ByVal mask_set As UShort)
    Declare Sub      set_io_cond_list Lib "RTC4ethDLL.DLL" (ByVal mask_1 As UShort, ByVal mask_0 As UShort, ByVal mask_set As UShort)
    Declare Sub      n_clear_io_cond_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal mask_1 As UShort, ByVal mask_0 As UShort, ByVal mask_clear As UShort)
    Declare Sub      clear_io_cond_list Lib "RTC4ethDLL.DLL" (ByVal mask_1 As UShort, ByVal mask_0 As UShort, ByVal mask_clear As UShort)
    Declare Sub      n_list_jump_cond Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal mask_1 As UShort, ByVal mask_0 As UShort, ByVal position As UShort)
    Declare Sub      list_jump_cond Lib "RTC4ethDLL.DLL" (ByVal mask_1 As UShort, ByVal mask_0 As UShort, ByVal position As UShort)
    Declare Sub      n_list_call_cond Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal mask_1 As UShort, ByVal mask_0 As UShort, ByVal position As UShort)
    Declare Sub      list_call_cond Lib "RTC4ethDLL.DLL" (ByVal mask_1 As UShort, ByVal mask_0 As UShort, ByVal position As UShort)
    Declare Function n_get_input_pointer Lib "RTC4ethDLL.DLL" (ByVal n As UShort) As UShort
    Declare Function get_input_pointer Lib "RTC4ethDLL.DLL" () As UShort
    Declare Function rtc4_max_cards Lib "RTC4ethDLL.DLL" () As UShort
    Declare Sub      n_get_status Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByRef busy As UShort, ByRef position As UShort)
    Declare Sub      get_status Lib "RTC4ethDLL.DLL" (ByRef busy As UShort, ByRef position As UShort)
    Declare Function n_read_status Lib "RTC4ethDLL.DLL" (ByVal n As UShort) As UShort
    Declare Function read_status Lib "RTC4ethDLL.DLL" () As UShort
    Declare Function n_get_startstop_info Lib "RTC4ethDLL.DLL" (ByVal n As UShort) As UShort
    Declare Function get_startstop_info Lib "RTC4ethDLL.DLL" () As UShort
    Declare Function n_get_marking_info Lib "RTC4ethDLL.DLL" (ByVal n As UShort) As UShort
    Declare Function get_marking_info Lib "RTC4ethDLL.DLL" () As UShort
    Declare Function get_dll_version Lib "RTC4ethDLL.DLL" () As UShort
    Declare Sub      n_set_start_list_1 Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      set_start_list_1 Lib "RTC4ethDLL.DLL" ()
    Declare Sub      n_set_start_list_2 Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      set_start_list_2 Lib "RTC4ethDLL.DLL" ()
    Declare Sub      n_set_start_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal listno As UShort)
    Declare Sub      set_start_list Lib "RTC4ethDLL.DLL" (ByVal listno As UShort)
    Declare Sub      n_execute_list_1 Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      execute_list_1 Lib "RTC4ethDLL.DLL" ()
    Declare Sub      n_execute_list_2 Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      execute_list_2 Lib "RTC4ethDLL.DLL" ()
    Declare Sub      n_execute_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal listno As UShort)
    Declare Sub      execute_list Lib "RTC4ethDLL.DLL" (ByVal listno As UShort)
    Declare Sub      n_write_8bit_port Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal value As UShort)
    Declare Sub      write_8bit_port Lib "RTC4ethDLL.DLL" (ByVal value As UShort)
    Declare Sub      n_write_io_port Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal value As UShort)
    Declare Sub      write_io_port Lib "RTC4ethDLL.DLL" (ByVal value As UShort)
    Declare Function n_eth_status Lib "RTC4ethDLL.DLL" (ByVal n As UShort) As Integer
    Declare Function eth_status Lib "RTC4ethDLL.DLL" () As Integer
    Declare Sub      n_auto_change Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      auto_change Lib "RTC4ethDLL.DLL" ()
    Declare Sub      n_auto_change_pos Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal start As UShort)
    Declare Sub      auto_change_pos Lib "RTC4ethDLL.DLL" (ByVal start As UShort)
    Declare Sub      aut_change Lib "RTC4ethDLL.DLL" ()
    Declare Sub      n_start_loop Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      start_loop Lib "RTC4ethDLL.DLL" ()
    Declare Sub      n_quit_loop Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      quit_loop Lib "RTC4ethDLL.DLL" ()
    Declare Sub      n_stop_execution Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      stop_execution Lib "RTC4ethDLL.DLL" ()
    Declare Function n_read_io_port Lib "RTC4ethDLL.DLL" (ByVal n As UShort) As UShort
    Declare Function read_io_port Lib "RTC4ethDLL.DLL" () As UShort
    Declare Sub      n_write_da_1 Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal value As UShort)
    Declare Sub      write_da_1 Lib "RTC4ethDLL.DLL" (ByVal value As UShort)
    Declare Sub      n_write_da_2 Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal value As UShort)
    Declare Sub      write_da_2 Lib "RTC4ethDLL.DLL" (ByVal value As UShort)
    Declare Sub      n_set_max_counts Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal counts As Integer)
    Declare Sub      set_max_counts Lib "RTC4ethDLL.DLL" (ByVal counts As Integer)
    Declare Function n_get_counts Lib "RTC4ethDLL.DLL" (ByVal n As UShort) As Integer
    Declare Function get_counts Lib "RTC4ethDLL.DLL" () As Integer
    Declare Sub      n_set_matrix Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal m11 As Double, ByVal m12 As Double, ByVal m21 As Double, ByVal m22 As Double)
    Declare Sub      set_matrix Lib "RTC4ethDLL.DLL" (ByVal m11 As Double, ByVal m12 As Double, ByVal m21 As Double, ByVal m22 As Double)
    Declare Sub      n_set_offset Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal xoffset As Short, ByVal yoffset As Short)
    Declare Sub      set_offset Lib "RTC4ethDLL.DLL" (ByVal xoffset As Short, ByVal yoffset As Short)
    Declare Sub      n_goto_xyz Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal x As Short, ByVal y As Short, ByVal z As Short)
    Declare Sub      goto_xyz Lib "RTC4ethDLL.DLL" (ByVal x As Short, ByVal y As Short, ByVal z As Short)
    Declare Sub      n_goto_xy Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal x As Short, ByVal y As Short)
    Declare Sub      goto_xy Lib "RTC4ethDLL.DLL" (ByVal x As Short, ByVal y As Short)
    Declare Function n_get_hex_version Lib "RTC4ethDLL.DLL" (ByVal n As UShort) As UShort
    Declare Function get_hex_version Lib "RTC4ethDLL.DLL" () As UShort
    Declare Sub      n_disable_laser Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      disable_laser Lib "RTC4ethDLL.DLL" ()
    Declare Sub      n_enable_laser Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      enable_laser Lib "RTC4ethDLL.DLL" ()
    Declare Sub      n_stop_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      stop_list Lib "RTC4ethDLL.DLL" ()
    Declare Sub      n_restart_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      restart_list Lib "RTC4ethDLL.DLL" ()
    Declare Sub      n_get_xyz_pos Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByRef x As Short, ByRef y As Short, ByRef z As Short)
    Declare Sub      get_xyz_pos Lib "RTC4ethDLL.DLL" (ByRef x As Short, ByRef y As Short, ByRef z As Short)
    Declare Sub      n_get_xy_pos Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByRef x As Short, ByRef y As Short)
    Declare Sub      get_xy_pos Lib "RTC4ethDLL.DLL" (ByRef x As Short, ByRef y As Short)
    Declare Sub      n_select_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal list_2 As UShort)
    Declare Sub      select_list Lib "RTC4ethDLL.DLL" (ByVal list_2 As UShort)
    Declare Sub      n_z_out Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal z As Short)
    Declare Sub      z_out Lib "RTC4ethDLL.DLL" (ByVal z As Short)
    Declare Sub      n_set_firstpulse_killer Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal fpk As UShort)
    Declare Sub      set_firstpulse_killer Lib "RTC4ethDLL.DLL" (ByVal fpk As UShort)
    Declare Sub      n_set_standby Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal half_period As UShort, ByVal pulse As UShort)
    Declare Sub      set_standby Lib "RTC4ethDLL.DLL" (ByVal half_period As UShort, ByVal pulse As UShort)
    Declare Sub      n_laser_signal_on Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      laser_signal_on Lib "RTC4ethDLL.DLL" ()
    Declare Sub      n_laser_signal_off Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      laser_signal_off Lib "RTC4ethDLL.DLL" ()
    Declare Sub      n_set_delay_mode Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal varpoly As UShort, ByVal directmove3d As UShort, ByVal edgelevel As UShort, ByVal minjumpdelay As UShort, ByVal jumplengthlimit As UShort)
    Declare Sub      set_delay_mode Lib "RTC4ethDLL.DLL" (ByVal varpoly As UShort, ByVal directmove3d As UShort, ByVal edgelevel As UShort, ByVal minjumpdelay As UShort, ByVal jumplengthlimit As UShort)
    Declare Sub      n_set_piso_control Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal l1 As UShort, ByVal l2 As UShort)
    Declare Sub      set_piso_control Lib "RTC4ethDLL.DLL" (ByVal l1 As UShort, ByVal l2 As UShort)
    Declare Sub      n_select_status Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal mode As UShort)
    Declare Sub      select_status Lib "RTC4ethDLL.DLL" (ByVal mode As UShort)
    Declare Sub      n_get_encoder Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByRef zx As Short, ByRef zy As Short)
    Declare Sub      get_encoder Lib "RTC4ethDLL.DLL" (ByRef zx As Short, ByRef zy As Short)
    Declare Sub      n_select_cor_table Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal heada As UShort, ByVal headb As UShort)
    Declare Sub      select_cor_table Lib "RTC4ethDLL.DLL" (ByVal heada As UShort, ByVal headb As UShort)
    Declare Sub      n_execute_at_pointer Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal position As UShort)
    Declare Sub      execute_at_pointer Lib "RTC4ethDLL.DLL" (ByVal position As UShort)
    Declare Function n_get_head_status Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal head As UShort) As UShort
    Declare Function get_head_status Lib "RTC4ethDLL.DLL" (ByVal head As UShort) As UShort
    Declare Sub      n_simulate_encoder Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal channel As UShort)
    Declare Sub      simulate_encoder Lib "RTC4ethDLL.DLL" (ByVal channel As UShort)
    Declare Sub      n_release_wait Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      release_wait Lib "RTC4ethDLL.DLL" ()
    Declare Function n_get_wait_status Lib "RTC4ethDLL.DLL" (ByVal n As UShort) As UShort
    Declare Function get_wait_status Lib "RTC4ethDLL.DLL" () As UShort
    Declare Sub      n_set_laser_mode Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal mode As UShort)
    Declare Sub      set_laser_mode Lib "RTC4ethDLL.DLL" (ByVal mode As UShort)
    Declare Sub      n_set_ext_start_delay Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal delay As Short, ByVal encoder As Short)
    Declare Sub      set_ext_start_delay Lib "RTC4ethDLL.DLL" (ByVal delay As Short, ByVal encoder As Short)
    Declare Sub      n_home_position Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal xhome As Short, ByVal yhome As Short)
    Declare Sub      home_position Lib "RTC4ethDLL.DLL" (ByVal xhome As Short, ByVal yhome As Short)
    Declare Sub      n_set_rot_center Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal center_x As Integer, ByVal center_y As Integer)
    Declare Sub      set_rot_center Lib "RTC4ethDLL.DLL" (ByVal center_x As Integer, ByVal center_y As Integer)
    Declare Sub      n_dsp_start Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      dsp_start Lib "RTC4ethDLL.DLL" ()
    Declare Sub      n_write_da_x Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal x As UShort, ByVal value As UShort)
    Declare Sub      write_da_x Lib "RTC4ethDLL.DLL" (ByVal x As UShort, ByVal value As UShort)
    Declare Function n_read_ad_x Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal x As UShort) As UShort
    Declare Function read_ad_x Lib "RTC4ethDLL.DLL" (ByVal x As UShort) As UShort
    Declare Function n_read_pixel_ad Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal pos As UShort) As UShort
    Declare Function read_pixel_ad Lib "RTC4ethDLL.DLL" (ByVal pos As UShort) As UShort
    Declare Function n_get_z_distance Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal x As Short, ByVal y As Short, ByVal z As Short) As Short
    Declare Function get_z_distance Lib "RTC4ethDLL.DLL" (ByVal x As Short, ByVal y As Short, ByVal z As Short) As Short
    Declare Function n_get_io_status Lib "RTC4ethDLL.DLL" (ByVal n As UShort) As UShort
    Declare Function get_io_status Lib "RTC4ethDLL.DLL" () As UShort
    Declare Function load_cor Lib "RTC4ethDLL.DLL" (ByVal filename As String) As Short
    Declare Function load_pro Lib "RTC4ethDLL.DLL" (ByVal filename As String) As Short
    Declare Function n_get_serial_number Lib "RTC4ethDLL.DLL" (ByVal n As UShort) As UShort
    Declare Function get_serial_number Lib "RTC4ethDLL.DLL" () As UShort
    Declare Function n_get_serial_number_32 Lib "RTC4ethDLL.DLL" (ByVal n As UShort) As Integer
    Declare Function get_serial_number_32 Lib "RTC4ethDLL.DLL" () As Integer
    Declare Function n_get_rtc_version Lib "RTC4ethDLL.DLL" (ByVal n As UShort) As UShort
    Declare Function get_rtc_version Lib "RTC4ethDLL.DLL" () As UShort
    Declare Function n_auto_cal Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal head As UShort, ByVal command As UShort) As Short
    Declare Function auto_cal Lib "RTC4ethDLL.DLL" (ByVal head As UShort, ByVal command As UShort) As Short
    Declare Sub      n_set_hi Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal galvogainx As Double, ByVal galvogainy As Double, ByVal galvooffsetx As Short, ByVal galvooffsety As Short, ByVal head As Short)
    Declare Sub      set_hi Lib "RTC4ethDLL.DLL" (ByVal galvogainx As Double, ByVal galvogainy As Double, ByVal galvooffsetx As Short, ByVal galvooffsety As Short, ByVal head As Short)
    Declare Sub      n_set_list_mode Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal mode As UShort)
    Declare Sub      set_list_mode Lib "RTC4ethDLL.DLL" (ByVal mode As UShort)
    Declare Function n_get_list_space Lib "RTC4ethDLL.DLL" (ByVal n As UShort) As UShort
    Declare Function get_list_space Lib "RTC4ethDLL.DLL" () As UShort
    Declare Sub      n_save_and_restart_timer Lib "RTC4ethDLL.DLL" (ByVal n As UShort)
    Declare Sub      save_and_restart_timer Lib "RTC4ethDLL.DLL" ()
    Declare Sub      n_set_ext_start_delay_list Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal delay As Short, ByVal encoder As Short)
    Declare Sub      set_ext_start_delay_list Lib "RTC4ethDLL.DLL" (ByVal delay As Short, ByVal encoder As Short)
    Declare Function n_get_time Lib "RTC4ethDLL.DLL" (ByVal n As UShort) As Double
    Declare Function get_time Lib "RTC4ethDLL.DLL" () As Double
    Declare Sub      get_hi_data Lib "RTC4ethDLL.DLL" (ByRef x1 As UShort, ByRef x2 As UShort, ByRef y1 As UShort, ByRef y2 As UShort)
    Declare Function teachin Lib "RTC4ethDLL.DLL" (ByVal filename As String, ByVal xin As Short, ByVal yin As Short, ByVal zin As Short, ByVal ll0 As Double, ByRef xout As Short, ByRef yout As Short, ByRef zout As Short) As Short
    Declare Function getmemory Lib "RTC4ethDLL.DLL" (ByVal adr As UShort) As Short
    Declare Sub      set_timeout Lib "RTC4ethDLL.DLL" (ByVal timeout As UInteger)
    Declare Sub      set_timeouts Lib "RTC4ethDLL.DLL" (ByVal acquire_timeout_us As UInteger, ByVal acquire_max_retries As UInteger, ByVal send_recv_timeout_us As UInteger, ByVal send_recv_max_retries As UInteger, ByVal acqu_rel_min_intvl_ms As UInteger)
    Declare Sub      get_timeouts Lib "RTC4ethDLL.DLL" (ByRef acquire_timeout_us As UInteger, ByRef acquire_max_retries As UInteger, ByRef send_recv_timeout_us As UInteger, ByRef send_recv_max_retries As UInteger, ByRef acqu_rel_min_intvl_ms As UInteger)
    Declare Function rs232_config Lib "RTC4ethDLL.DLL" (ByVal baudrate As UInteger, ByVal parity As UInteger, ByVal stopbits As UInteger) As UInteger
    Declare Function n_rs232_config Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal baudrate As UInteger, ByVal parity As UInteger, ByVal stopbits As UInteger) As UInteger
    Declare Function rs232_write_data Lib "RTC4ethDLL.DLL" (ByVal data As UInteger) As UInteger
    Declare Function n_rs232_write_data Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal data As UInteger) As UInteger
    Declare Function rs232_write_text Lib "RTC4ethDLL.DLL" (ByVal text As String) As UInteger
    Declare Function n_rs232_write_text Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal text As String) As UInteger
    Declare Function rs232_read_data Lib "RTC4ethDLL.DLL" (ByRef data As UInteger) As UInteger
    Declare Function n_rs232_read_data Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByRef data As UInteger) As UInteger
    Declare Sub      n_eth_set_com_timeouts_auto Lib "RTC4ethDLL.DLL" (ByVal cardno As UShort, ByVal initial_timeout_ms As Double, ByVal sum_timeout_ms As Double, ByVal multiplicator As Double, ByVal mode As Integer)
    Declare Sub      eth_set_com_timeouts_auto Lib "RTC4ethDLL.DLL" (ByVal initial_timeout_ms As Double, ByVal sum_timeout_ms As Double, ByVal multiplicator As Double, ByVal mode As Integer)
    Declare Sub      n_eth_get_com_timeouts_auto Lib "RTC4ethDLL.DLL" (ByVal cardno As UShort, ByRef initial_timeout_ms As Double, ByRef sum_timeout_ms As Double, ByRef multiplicator As Double, ByRef mode As Integer)
    Declare Sub      eth_get_com_timeouts_auto Lib "RTC4ethDLL.DLL" (ByRef initial_timeout_ms As Double, ByRef sum_timeout_ms As Double, ByRef multiplicator As Double, ByRef mode As Integer)
    Declare Function n_eth_watchdog_timer_config Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal timer_ms As UInteger) As UInteger
    Declare Function eth_watchdog_timer_config Lib "RTC4ethDLL.DLL" (ByVal timer_ms As UInteger) As UInteger
    Declare Function n_eth_watchdog_timer_reset Lib "RTC4ethDLL.DLL" (ByVal n As UShort) As UInteger
    Declare Function eth_watchdog_timer_reset Lib "RTC4ethDLL.DLL" () As UInteger
    Declare Sub      n_eth_link_loss_config Lib "RTC4ethDLL.DLL" (ByVal n As UShort, ByVal mode As UInteger)
    Declare Sub      eth_link_loss_config Lib "RTC4ethDLL.DLL" (ByVal mode As UInteger)
    Declare Function n_eth_get_last_error Lib "RTC4ethDLL.DLL" (ByVal n As UShort) As UInteger
    Declare Function eth_get_last_error Lib "RTC4ethDLL.DLL" () As UInteger
    Declare Function n_eth_get_error Lib "RTC4ethDLL.DLL" (ByVal n As UShort) As UInteger
    Declare Function eth_get_error Lib "RTC4ethDLL.DLL" () As UInteger
    Declare Function n_eth_error_dump Lib "RTC4ethDLL.DLL" (ByVal n As UShort, <MarshalAs(UnmanagedType.LPArray)> dump As UInteger()) As UInteger
    Declare Function eth_error_dump Lib "RTC4ethDLL.DLL" (<MarshalAs(UnmanagedType.LPArray)> dump As UInteger()) As UInteger
End Module
