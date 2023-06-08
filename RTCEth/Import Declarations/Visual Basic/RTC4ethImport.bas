REM
REM  Visual Basic Import Declarations for the SCANLAB RTC4eth-DLL
REM
REM  This file was automatically generated on 2022-01-21.
REM

Declare Function get_driver_status Lib "RTC4ethDLL.DLL" () As Long
Declare Function get_net_dll_version Lib "RTC4ethDLL.DLL" () As Long
Declare Function acquire_rtc Lib "RTC4ethDLL.DLL" (ByVal card_no As Long) As Long
Declare Function release_rtc Lib "RTC4ethDLL.DLL" (ByVal card_no As Long) As Long
Declare Sub      select_rtc Lib "RTC4ethDLL.DLL" (ByVal card_no As Integer)
Declare Function assign_rtc Lib "RTC4ethDLL.DLL" (ByVal search_no As Integer, ByVal card_no As Integer) As Long
Declare Function assign_rtc_by_ip Lib "RTC4ethDLL.DLL" (ByVal ip As Long, ByVal card_no As Integer) As Long
Declare Sub      remove_rtc Lib "RTC4ethDLL.DLL" (ByVal card_no As Integer)
Declare Function convert_string_to_ip Lib "RTC4ethDLL.DLL" (ByVal ip As String) As Long
Declare Sub      convert_ip_to_string Lib "RTC4ethDLL.DLL" (ByVal ip As Long, ByVal cpip As String)
Declare Sub      convert_mac_to_string Lib "RTC4ethDLL.DLL" (ByVal mac As Currency, ByVal cpmac As String)
Declare Function rtc_search_cards Lib "RTC4ethDLL.DLL" (cards As Integer, ByVal ip As Long, ByVal netmask As Long) As Long
Declare Function get_mac_address Lib "RTC4ethDLL.DLL" (ByVal cardno As Integer) As Int64
Declare Function get_ip_address Lib "RTC4ethDLL.DLL" (ByVal cardno As Integer) As Long
Declare Function get_serial Lib "RTC4ethDLL.DLL" (ByVal cardno As Integer) As Long
Declare Function get_connection_status Lib "RTC4ethDLL.DLL" (ByVal cardno As Integer) As Integer
Declare Function get_master_ip_address Lib "RTC4ethDLL.DLL" (ByVal cardno As Integer) As Long
Declare Function get_master_id Lib "RTC4ethDLL.DLL" (ByVal cardno As Integer, ByVal id As String) As Long
Declare Function set_static_ip Lib "RTC4ethDLL.DLL" (ByVal ip As Long, ByVal netmask As Long, ByVal gateway As Long) As Long
Declare Function get_static_ip Lib "RTC4ethDLL.DLL" (ip As Long, netmask As Long, gateway As Long) As Long
Declare Function get_mcu_fw_version Lib "RTC4ethDLL.DLL" (ByVal cardno As Integer) As Long
Declare Function get_nic_ip_count Lib "RTC4ethDLL.DLL" (count As Integer) As Long
Declare Sub      get_nic_ip Lib "RTC4ethDLL.DLL" (ByVal count As Integer, ip As Long, nm As Long)
Declare Sub      n_get_waveform Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal channel As Integer, ByVal istop As Integer, ByVal memptr As pint)
Declare Sub      get_waveform Lib "RTC4ethDLL.DLL" (ByVal channel As Integer, ByVal istop As Integer, ByVal memptr As pint)
Declare Sub      n_measurement_status Lib "RTC4ethDLL.DLL" (ByVal n As Integer, busy As Integer, position As Integer)
Declare Sub      measurement_status Lib "RTC4ethDLL.DLL" (busy As Integer, position As Integer)
Declare Sub      n_set_trigger Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal sampleperiod As Integer, ByVal channel1 As Integer, ByVal channel2 As Integer)
Declare Sub      set_trigger Lib "RTC4ethDLL.DLL" (ByVal sampleperiod As Integer, ByVal signal1 As Integer, ByVal signal2 As Integer)
Declare Function n_get_value Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal signal As Integer) As Integer
Declare Function get_value Lib "RTC4ethDLL.DLL" (ByVal signal As Integer) As Integer
Declare Sub      n_set_io_bit Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal mask1 As Integer)
Declare Sub      set_io_bit Lib "RTC4ethDLL.DLL" (ByVal mask1 As Integer)
Declare Sub      n_clear_io_bit Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal mask0 As Integer)
Declare Sub      clear_io_bit Lib "RTC4ethDLL.DLL" (ByVal mask0 As Integer)
Declare Sub      n_move_to Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal position As Integer)
Declare Sub      move_to Lib "RTC4ethDLL.DLL" (ByVal position As Integer)
Declare Sub      n_control_command Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal head As Integer, ByVal axis As Integer, ByVal data As Integer)
Declare Sub      control_command Lib "RTC4ethDLL.DLL" (ByVal head As Integer, ByVal axis As Integer, ByVal data As Integer)
Declare Sub      n_arc_rel Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal angle As Double)
Declare Sub      arc_rel Lib "RTC4ethDLL.DLL" (ByVal dx As Integer, ByVal dy As Integer, ByVal angle As Double)
Declare Sub      n_arc_abs Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal x As Integer, ByVal y As Integer, ByVal angle As Double)
Declare Sub      arc_abs Lib "RTC4ethDLL.DLL" (ByVal x As Integer, ByVal y As Integer, ByVal angle As Double)
Declare Sub      drilling Lib "RTC4ethDLL.DLL" (ByVal pulsewidth As Integer, ByVal relencoderdelay As Integer)
Declare Sub      regulation Lib "RTC4ethDLL.DLL" ()
Declare Sub      flyline Lib "RTC4ethDLL.DLL" (ByVal encoderdelay As Integer)
Declare Sub      set_duty_cycle_table Lib "RTC4ethDLL.DLL" (ByVal index As Integer, ByVal dutycycle As Integer)
Declare Function n_load_varpolydelay Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal stbfilename As String, ByVal tableno As Integer) As Integer
Declare Function load_varpolydelay Lib "RTC4ethDLL.DLL" (ByVal stbfilename As String, ByVal tableno As Integer) As Integer
Declare Function n_load_program_file Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal name As String) As Integer
Declare Function load_program_file Lib "RTC4ethDLL.DLL" (ByVal name As String) As Integer
Declare Function n_load_correction_file Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal filename As String, ByVal cortable As Integer, ByVal kx As Double, ByVal ky As Double, ByVal phi As Double, ByVal xoffset As Double, ByVal yoffset As Double) As Integer
Declare Function load_correction_file Lib "RTC4ethDLL.DLL" (ByVal filename As String, ByVal cortable As Integer, ByVal kx As Double, ByVal ky As Double, ByVal phi As Double, ByVal xoffset As Double, ByVal yoffset As Double) As Integer
Declare Function n_load_z_table Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal a As Double, ByVal b As Double, ByVal c As Double) As Integer
Declare Function load_z_table Lib "RTC4ethDLL.DLL" (ByVal a As Double, ByVal b As Double, ByVal c As Double) As Integer
Declare Sub      n_list_nop Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      list_nop Lib "RTC4ethDLL.DLL" ()
Declare Sub      n_set_end_of_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      set_end_of_list Lib "RTC4ethDLL.DLL" ()
Declare Sub      n_jump_abs_3d Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal x As Integer, ByVal y As Integer, ByVal z As Integer)
Declare Sub      jump_abs_3d Lib "RTC4ethDLL.DLL" (ByVal x As Integer, ByVal y As Integer, ByVal z As Integer)
Declare Sub      n_jump_abs Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal x As Integer, ByVal y As Integer)
Declare Sub      jump_abs Lib "RTC4ethDLL.DLL" (ByVal x As Integer, ByVal y As Integer)
Declare Sub      n_mark_abs_3d Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal x As Integer, ByVal y As Integer, ByVal z As Integer)
Declare Sub      mark_abs_3d Lib "RTC4ethDLL.DLL" (ByVal x As Integer, ByVal y As Integer, ByVal z As Integer)
Declare Sub      n_mark_abs Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal x As Integer, ByVal y As Integer)
Declare Sub      mark_abs Lib "RTC4ethDLL.DLL" (ByVal x As Integer, ByVal y As Integer)
Declare Sub      n_jump_rel_3d Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal dz As Integer)
Declare Sub      jump_rel_3d Lib "RTC4ethDLL.DLL" (ByVal dx As Integer, ByVal dy As Integer, ByVal dz As Integer)
Declare Sub      n_jump_rel Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal dx As Integer, ByVal dy As Integer)
Declare Sub      jump_rel Lib "RTC4ethDLL.DLL" (ByVal dx As Integer, ByVal dy As Integer)
Declare Sub      n_mark_rel_3d Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal dz As Integer)
Declare Sub      mark_rel_3d Lib "RTC4ethDLL.DLL" (ByVal dx As Integer, ByVal dy As Integer, ByVal dz As Integer)
Declare Sub      n_mark_rel Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal dx As Integer, ByVal dy As Integer)
Declare Sub      mark_rel Lib "RTC4ethDLL.DLL" (ByVal dx As Integer, ByVal dy As Integer)
Declare Sub      n_write_8bit_port_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal value As Integer)
Declare Sub      write_8bit_port_list Lib "RTC4ethDLL.DLL" (ByVal value As Integer)
Declare Sub      n_write_da_1_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal value As Integer)
Declare Sub      write_da_1_list Lib "RTC4ethDLL.DLL" (ByVal value As Integer)
Declare Sub      n_write_da_2_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal value As Integer)
Declare Sub      write_da_2_list Lib "RTC4ethDLL.DLL" (ByVal value As Integer)
Declare Sub      n_set_matrix_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal i As Integer, ByVal j As Integer, ByVal mij As Double)
Declare Sub      set_matrix_list Lib "RTC4ethDLL.DLL" (ByVal i As Integer, ByVal j As Integer, ByVal mij As Double)
Declare Sub      n_set_offset_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal xoffset As Integer, ByVal yoffset As Integer)
Declare Sub      set_offset_list Lib "RTC4ethDLL.DLL" (ByVal xoffset As Integer, ByVal yoffset As Integer)
Declare Sub      n_set_defocus_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal value As Integer)
Declare Sub      set_defocus_list Lib "RTC4ethDLL.DLL" (ByVal value As Integer)
Declare Sub      n_set_defocus Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal value As Integer)
Declare Sub      set_defocus Lib "RTC4ethDLL.DLL" (ByVal value As Integer)
Declare Sub      n_set_softstart_mode Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal mode As Integer, ByVal number As Integer, ByVal restartdelay As Integer)
Declare Sub      set_softstart_mode Lib "RTC4ethDLL.DLL" (ByVal mode As Integer, ByVal number As Integer, ByVal resetdelay As Integer)
Declare Sub      n_set_softstart_level Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal index As Integer, ByVal level As Integer)
Declare Sub      set_softstart_level Lib "RTC4ethDLL.DLL" (ByVal index As Integer, ByVal level As Integer)
Declare Sub      n_set_control_mode_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal mode As Integer)
Declare Sub      set_control_mode_list Lib "RTC4ethDLL.DLL" (ByVal mode As Integer)
Declare Sub      n_set_control_mode Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal mode As Integer)
Declare Sub      set_control_mode Lib "RTC4ethDLL.DLL" (ByVal mode As Integer)
Declare Sub      n_long_delay Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal value As Integer)
Declare Sub      long_delay Lib "RTC4ethDLL.DLL" (ByVal value As Integer)
Declare Sub      n_laser_on_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal value As Integer)
Declare Sub      laser_on_list Lib "RTC4ethDLL.DLL" (ByVal value As Integer)
Declare Sub      n_set_jump_speed Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal speed As Double)
Declare Sub      set_jump_speed Lib "RTC4ethDLL.DLL" (ByVal speed As Double)
Declare Sub      n_set_mark_speed Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal speed As Double)
Declare Sub      set_mark_speed Lib "RTC4ethDLL.DLL" (ByVal speed As Double)
Declare Sub      n_set_laser_delays Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal ondelay As Integer, ByVal offdelay As Integer)
Declare Sub      set_laser_delays Lib "RTC4ethDLL.DLL" (ByVal ondelay As Integer, ByVal offdelay As Integer)
Declare Sub      n_set_scanner_delays Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal jumpdelay As Integer, ByVal markdelay As Integer, ByVal polydelay As Integer)
Declare Sub      set_scanner_delays Lib "RTC4ethDLL.DLL" (ByVal jumpdelay As Integer, ByVal markdelay As Integer, ByVal polydelay As Integer)
Declare Sub      n_set_list_jump Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal position As Integer)
Declare Sub      set_list_jump Lib "RTC4ethDLL.DLL" (ByVal position As Integer)
Declare Sub      n_set_input_pointer Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal pointer As Integer)
Declare Sub      set_input_pointer Lib "RTC4ethDLL.DLL" (ByVal pointer As Integer)
Declare Sub      n_list_call Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal position As Integer)
Declare Sub      list_call Lib "RTC4ethDLL.DLL" (ByVal position As Integer)
Declare Sub      n_list_return Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      list_return Lib "RTC4ethDLL.DLL" ()
Declare Sub      n_z_out_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal z As Integer)
Declare Sub      z_out_list Lib "RTC4ethDLL.DLL" (ByVal z As Integer)
Declare Sub      n_set_standby_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal half_period As Integer, ByVal pulse As Integer)
Declare Sub      set_standby_list Lib "RTC4ethDLL.DLL" (ByVal half_period As Integer, ByVal pulse As Integer)
Declare Sub      n_timed_jump_abs Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal x As Integer, ByVal y As Integer, ByVal time As Double)
Declare Sub      timed_jump_abs Lib "RTC4ethDLL.DLL" (ByVal x As Integer, ByVal y As Integer, ByVal time As Double)
Declare Sub      n_timed_mark_abs Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal x As Integer, ByVal y As Integer, ByVal time As Double)
Declare Sub      timed_mark_abs Lib "RTC4ethDLL.DLL" (ByVal x As Integer, ByVal y As Integer, ByVal time As Double)
Declare Sub      n_timed_jump_rel Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal time As Double)
Declare Sub      timed_jump_rel Lib "RTC4ethDLL.DLL" (ByVal dx As Integer, ByVal dy As Integer, ByVal time As Double)
Declare Sub      n_timed_mark_rel Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal time As Double)
Declare Sub      timed_mark_rel Lib "RTC4ethDLL.DLL" (ByVal dx As Integer, ByVal dy As Integer, ByVal time As Double)
Declare Sub      n_set_laser_timing Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal halfperiod As Integer, ByVal pulse1 As Integer, ByVal pulse2 As Integer, ByVal timebase As Integer)
Declare Sub      set_laser_timing Lib "RTC4ethDLL.DLL" (ByVal halfperiod As Integer, ByVal pulse1 As Integer, ByVal pulse2 As Integer, ByVal timebase As Integer)
Declare Sub      n_set_wobbel Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal amplitude As Integer, ByVal frequency As Double)
Declare Sub      set_wobbel Lib "RTC4ethDLL.DLL" (ByVal amplitude As Integer, ByVal frequency As Double)
Declare Sub      n_set_wobbel_xy Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal long_wob As Integer, ByVal trans_wob As Integer, ByVal frequency As Double)
Declare Sub      set_wobbel_xy Lib "RTC4ethDLL.DLL" (ByVal long_wob As Integer, ByVal trans_wob As Integer, ByVal frequency As Double)
Declare Sub      n_set_fly_x Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal kx As Double)
Declare Sub      set_fly_x Lib "RTC4ethDLL.DLL" (ByVal kx As Double)
Declare Sub      n_set_fly_y Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal ky As Double)
Declare Sub      set_fly_y Lib "RTC4ethDLL.DLL" (ByVal ky As Double)
Declare Sub      n_set_fly_rot Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal resolution As Double)
Declare Sub      set_fly_rot Lib "RTC4ethDLL.DLL" (ByVal resolution As Double)
Declare Sub      n_fly_return Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal x As Integer, ByVal y As Integer)
Declare Sub      fly_return Lib "RTC4ethDLL.DLL" (ByVal x As Integer, ByVal y As Integer)
Declare Sub      n_calculate_fly Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal direction As Integer, ByVal distance As Double)
Declare Sub      calculate_fly Lib "RTC4ethDLL.DLL" (ByVal direction As Integer, ByVal distance As Double)
Declare Sub      n_write_io_port_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal value As Integer)
Declare Sub      write_io_port_list Lib "RTC4ethDLL.DLL" (ByVal value As Integer)
Declare Sub      n_select_cor_table_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal heada As Integer, ByVal headb As Integer)
Declare Sub      select_cor_table_list Lib "RTC4ethDLL.DLL" (ByVal heada As Integer, ByVal headb As Integer)
Declare Sub      n_set_wait Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal value As Integer)
Declare Sub      set_wait Lib "RTC4ethDLL.DLL" (ByVal value As Integer)
Declare Sub      n_simulate_ext_start Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal delay As Integer, ByVal encoder As Integer)
Declare Sub      simulate_ext_start Lib "RTC4ethDLL.DLL" (ByVal delay As Integer, ByVal encoder As Integer)
Declare Sub      n_write_da_x_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal x As Integer, ByVal value As Integer)
Declare Sub      write_da_x_list Lib "RTC4ethDLL.DLL" (ByVal x As Integer, ByVal value As Integer)
Declare Sub      n_set_pixel_line Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal pixelmode As Integer, ByVal pixelperiod As Integer, ByVal dx As Double, ByVal dy As Double)
Declare Sub      set_pixel_line Lib "RTC4ethDLL.DLL" (ByVal pixelmode As Integer, ByVal pixelperiod As Integer, ByVal dx As Double, ByVal dy As Double)
Declare Sub      n_set_pixel Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal pulswidth As Integer, ByVal davalue As Integer, ByVal adchannel As Integer)
Declare Sub      set_pixel Lib "RTC4ethDLL.DLL" (ByVal pulswidth As Integer, ByVal davalue As Integer, ByVal adchannel As Integer)
Declare Sub      n_set_extstartpos_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal position As Integer)
Declare Sub      set_extstartpos_list Lib "RTC4ethDLL.DLL" (ByVal position As Integer)
Declare Sub      n_laser_signal_on_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      laser_signal_on_list Lib "RTC4ethDLL.DLL" ()
Declare Sub      n_laser_signal_off_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      laser_signal_off_list Lib "RTC4ethDLL.DLL" ()
Declare Sub      n_set_firstpulse_killer_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal fpk As Integer)
Declare Sub      set_firstpulse_killer_list Lib "RTC4ethDLL.DLL" (ByVal fpk As Integer)
Declare Sub      n_set_io_cond_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal mask_1 As Integer, ByVal mask_0 As Integer, ByVal mask_set As Integer)
Declare Sub      set_io_cond_list Lib "RTC4ethDLL.DLL" (ByVal mask_1 As Integer, ByVal mask_0 As Integer, ByVal mask_set As Integer)
Declare Sub      n_clear_io_cond_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal mask_1 As Integer, ByVal mask_0 As Integer, ByVal mask_clear As Integer)
Declare Sub      clear_io_cond_list Lib "RTC4ethDLL.DLL" (ByVal mask_1 As Integer, ByVal mask_0 As Integer, ByVal mask_clear As Integer)
Declare Sub      n_list_jump_cond Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal mask_1 As Integer, ByVal mask_0 As Integer, ByVal position As Integer)
Declare Sub      list_jump_cond Lib "RTC4ethDLL.DLL" (ByVal mask_1 As Integer, ByVal mask_0 As Integer, ByVal position As Integer)
Declare Sub      n_list_call_cond Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal mask_1 As Integer, ByVal mask_0 As Integer, ByVal position As Integer)
Declare Sub      list_call_cond Lib "RTC4ethDLL.DLL" (ByVal mask_1 As Integer, ByVal mask_0 As Integer, ByVal position As Integer)
Declare Function n_get_input_pointer Lib "RTC4ethDLL.DLL" (ByVal n As Integer) As Integer
Declare Function get_input_pointer Lib "RTC4ethDLL.DLL" () As Integer
Declare Function rtc4_max_cards Lib "RTC4ethDLL.DLL" () As Integer
Declare Sub      n_get_status Lib "RTC4ethDLL.DLL" (ByVal n As Integer, busy As Integer, position As Integer)
Declare Sub      get_status Lib "RTC4ethDLL.DLL" (busy As Integer, position As Integer)
Declare Function n_read_status Lib "RTC4ethDLL.DLL" (ByVal n As Integer) As Integer
Declare Function read_status Lib "RTC4ethDLL.DLL" () As Integer
Declare Function n_get_startstop_info Lib "RTC4ethDLL.DLL" (ByVal n As Integer) As Integer
Declare Function get_startstop_info Lib "RTC4ethDLL.DLL" () As Integer
Declare Function n_get_marking_info Lib "RTC4ethDLL.DLL" (ByVal n As Integer) As Integer
Declare Function get_marking_info Lib "RTC4ethDLL.DLL" () As Integer
Declare Function get_dll_version Lib "RTC4ethDLL.DLL" () As Integer
Declare Sub      n_set_start_list_1 Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      set_start_list_1 Lib "RTC4ethDLL.DLL" ()
Declare Sub      n_set_start_list_2 Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      set_start_list_2 Lib "RTC4ethDLL.DLL" ()
Declare Sub      n_set_start_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal listno As Integer)
Declare Sub      set_start_list Lib "RTC4ethDLL.DLL" (ByVal listno As Integer)
Declare Sub      n_execute_list_1 Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      execute_list_1 Lib "RTC4ethDLL.DLL" ()
Declare Sub      n_execute_list_2 Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      execute_list_2 Lib "RTC4ethDLL.DLL" ()
Declare Sub      n_execute_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal listno As Integer)
Declare Sub      execute_list Lib "RTC4ethDLL.DLL" (ByVal listno As Integer)
Declare Sub      n_write_8bit_port Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal value As Integer)
Declare Sub      write_8bit_port Lib "RTC4ethDLL.DLL" (ByVal value As Integer)
Declare Sub      n_write_io_port Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal value As Integer)
Declare Sub      write_io_port Lib "RTC4ethDLL.DLL" (ByVal value As Integer)
Declare Function n_eth_status Lib "RTC4ethDLL.DLL" (ByVal n As Integer) As Long
Declare Function eth_status Lib "RTC4ethDLL.DLL" () As Long
Declare Sub      n_auto_change Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      auto_change Lib "RTC4ethDLL.DLL" ()
Declare Sub      n_auto_change_pos Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal start As Integer)
Declare Sub      auto_change_pos Lib "RTC4ethDLL.DLL" (ByVal start As Integer)
Declare Sub      aut_change Lib "RTC4ethDLL.DLL" ()
Declare Sub      n_start_loop Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      start_loop Lib "RTC4ethDLL.DLL" ()
Declare Sub      n_quit_loop Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      quit_loop Lib "RTC4ethDLL.DLL" ()
Declare Sub      n_stop_execution Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      stop_execution Lib "RTC4ethDLL.DLL" ()
Declare Function n_read_io_port Lib "RTC4ethDLL.DLL" (ByVal n As Integer) As Integer
Declare Function read_io_port Lib "RTC4ethDLL.DLL" () As Integer
Declare Sub      n_write_da_1 Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal value As Integer)
Declare Sub      write_da_1 Lib "RTC4ethDLL.DLL" (ByVal value As Integer)
Declare Sub      n_write_da_2 Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal value As Integer)
Declare Sub      write_da_2 Lib "RTC4ethDLL.DLL" (ByVal value As Integer)
Declare Sub      n_set_max_counts Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal counts As Long)
Declare Sub      set_max_counts Lib "RTC4ethDLL.DLL" (ByVal counts As Long)
Declare Function n_get_counts Lib "RTC4ethDLL.DLL" (ByVal n As Integer) As Long
Declare Function get_counts Lib "RTC4ethDLL.DLL" () As Long
Declare Sub      n_set_matrix Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal m11 As Double, ByVal m12 As Double, ByVal m21 As Double, ByVal m22 As Double)
Declare Sub      set_matrix Lib "RTC4ethDLL.DLL" (ByVal m11 As Double, ByVal m12 As Double, ByVal m21 As Double, ByVal m22 As Double)
Declare Sub      n_set_offset Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal xoffset As Integer, ByVal yoffset As Integer)
Declare Sub      set_offset Lib "RTC4ethDLL.DLL" (ByVal xoffset As Integer, ByVal yoffset As Integer)
Declare Sub      n_goto_xyz Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal x As Integer, ByVal y As Integer, ByVal z As Integer)
Declare Sub      goto_xyz Lib "RTC4ethDLL.DLL" (ByVal x As Integer, ByVal y As Integer, ByVal z As Integer)
Declare Sub      n_goto_xy Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal x As Integer, ByVal y As Integer)
Declare Sub      goto_xy Lib "RTC4ethDLL.DLL" (ByVal x As Integer, ByVal y As Integer)
Declare Function n_get_hex_version Lib "RTC4ethDLL.DLL" (ByVal n As Integer) As Integer
Declare Function get_hex_version Lib "RTC4ethDLL.DLL" () As Integer
Declare Sub      n_disable_laser Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      disable_laser Lib "RTC4ethDLL.DLL" ()
Declare Sub      n_enable_laser Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      enable_laser Lib "RTC4ethDLL.DLL" ()
Declare Sub      n_stop_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      stop_list Lib "RTC4ethDLL.DLL" ()
Declare Sub      n_restart_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      restart_list Lib "RTC4ethDLL.DLL" ()
Declare Sub      n_get_xyz_pos Lib "RTC4ethDLL.DLL" (ByVal n As Integer, x As Integer, y As Integer, z As Integer)
Declare Sub      get_xyz_pos Lib "RTC4ethDLL.DLL" (x As Integer, y As Integer, z As Integer)
Declare Sub      n_get_xy_pos Lib "RTC4ethDLL.DLL" (ByVal n As Integer, x As Integer, y As Integer)
Declare Sub      get_xy_pos Lib "RTC4ethDLL.DLL" (x As Integer, y As Integer)
Declare Sub      n_select_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal list_2 As Integer)
Declare Sub      select_list Lib "RTC4ethDLL.DLL" (ByVal list_2 As Integer)
Declare Sub      n_z_out Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal z As Integer)
Declare Sub      z_out Lib "RTC4ethDLL.DLL" (ByVal z As Integer)
Declare Sub      n_set_firstpulse_killer Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal fpk As Integer)
Declare Sub      set_firstpulse_killer Lib "RTC4ethDLL.DLL" (ByVal fpk As Integer)
Declare Sub      n_set_standby Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal half_period As Integer, ByVal pulse As Integer)
Declare Sub      set_standby Lib "RTC4ethDLL.DLL" (ByVal half_period As Integer, ByVal pulse As Integer)
Declare Sub      n_laser_signal_on Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      laser_signal_on Lib "RTC4ethDLL.DLL" ()
Declare Sub      n_laser_signal_off Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      laser_signal_off Lib "RTC4ethDLL.DLL" ()
Declare Sub      n_set_delay_mode Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal varpoly As Integer, ByVal directmove3d As Integer, ByVal edgelevel As Integer, ByVal minjumpdelay As Integer, ByVal jumplengthlimit As Integer)
Declare Sub      set_delay_mode Lib "RTC4ethDLL.DLL" (ByVal varpoly As Integer, ByVal directmove3d As Integer, ByVal edgelevel As Integer, ByVal minjumpdelay As Integer, ByVal jumplengthlimit As Integer)
Declare Sub      n_set_piso_control Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal l1 As Integer, ByVal l2 As Integer)
Declare Sub      set_piso_control Lib "RTC4ethDLL.DLL" (ByVal l1 As Integer, ByVal l2 As Integer)
Declare Sub      n_select_status Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal mode As Integer)
Declare Sub      select_status Lib "RTC4ethDLL.DLL" (ByVal mode As Integer)
Declare Sub      n_get_encoder Lib "RTC4ethDLL.DLL" (ByVal n As Integer, zx As Integer, zy As Integer)
Declare Sub      get_encoder Lib "RTC4ethDLL.DLL" (zx As Integer, zy As Integer)
Declare Sub      n_select_cor_table Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal heada As Integer, ByVal headb As Integer)
Declare Sub      select_cor_table Lib "RTC4ethDLL.DLL" (ByVal heada As Integer, ByVal headb As Integer)
Declare Sub      n_execute_at_pointer Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal position As Integer)
Declare Sub      execute_at_pointer Lib "RTC4ethDLL.DLL" (ByVal position As Integer)
Declare Function n_get_head_status Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal head As Integer) As Integer
Declare Function get_head_status Lib "RTC4ethDLL.DLL" (ByVal head As Integer) As Integer
Declare Sub      n_simulate_encoder Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal channel As Integer)
Declare Sub      simulate_encoder Lib "RTC4ethDLL.DLL" (ByVal channel As Integer)
Declare Sub      n_release_wait Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      release_wait Lib "RTC4ethDLL.DLL" ()
Declare Function n_get_wait_status Lib "RTC4ethDLL.DLL" (ByVal n As Integer) As Integer
Declare Function get_wait_status Lib "RTC4ethDLL.DLL" () As Integer
Declare Sub      n_set_laser_mode Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal mode As Integer)
Declare Sub      set_laser_mode Lib "RTC4ethDLL.DLL" (ByVal mode As Integer)
Declare Sub      n_set_ext_start_delay Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal delay As Integer, ByVal encoder As Integer)
Declare Sub      set_ext_start_delay Lib "RTC4ethDLL.DLL" (ByVal delay As Integer, ByVal encoder As Integer)
Declare Sub      n_home_position Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal xhome As Integer, ByVal yhome As Integer)
Declare Sub      home_position Lib "RTC4ethDLL.DLL" (ByVal xhome As Integer, ByVal yhome As Integer)
Declare Sub      n_set_rot_center Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal center_x As Long, ByVal center_y As Long)
Declare Sub      set_rot_center Lib "RTC4ethDLL.DLL" (ByVal center_x As Long, ByVal center_y As Long)
Declare Sub      n_dsp_start Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      dsp_start Lib "RTC4ethDLL.DLL" ()
Declare Sub      n_write_da_x Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal x As Integer, ByVal value As Integer)
Declare Sub      write_da_x Lib "RTC4ethDLL.DLL" (ByVal x As Integer, ByVal value As Integer)
Declare Function n_read_ad_x Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal x As Integer) As Integer
Declare Function read_ad_x Lib "RTC4ethDLL.DLL" (ByVal x As Integer) As Integer
Declare Function n_read_pixel_ad Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal pos As Integer) As Integer
Declare Function read_pixel_ad Lib "RTC4ethDLL.DLL" (ByVal pos As Integer) As Integer
Declare Function n_get_z_distance Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal x As Integer, ByVal y As Integer, ByVal z As Integer) As Integer
Declare Function get_z_distance Lib "RTC4ethDLL.DLL" (ByVal x As Integer, ByVal y As Integer, ByVal z As Integer) As Integer
Declare Function n_get_io_status Lib "RTC4ethDLL.DLL" (ByVal n As Integer) As Integer
Declare Function get_io_status Lib "RTC4ethDLL.DLL" () As Integer
Declare Function load_cor Lib "RTC4ethDLL.DLL" (ByVal filename As String) As Integer
Declare Function load_pro Lib "RTC4ethDLL.DLL" (ByVal filename As String) As Integer
Declare Function n_get_serial_number Lib "RTC4ethDLL.DLL" (ByVal n As Integer) As Integer
Declare Function get_serial_number Lib "RTC4ethDLL.DLL" () As Integer
Declare Function n_get_serial_number_32 Lib "RTC4ethDLL.DLL" (ByVal n As Integer) As Long
Declare Function get_serial_number_32 Lib "RTC4ethDLL.DLL" () As Long
Declare Function n_get_rtc_version Lib "RTC4ethDLL.DLL" (ByVal n As Integer) As Integer
Declare Function get_rtc_version Lib "RTC4ethDLL.DLL" () As Integer
Declare Function n_auto_cal Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal head As Integer, ByVal command As Integer) As Integer
Declare Function auto_cal Lib "RTC4ethDLL.DLL" (ByVal head As Integer, ByVal command As Integer) As Integer
Declare Sub      n_set_hi Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal galvogainx As Double, ByVal galvogainy As Double, ByVal galvooffsetx As Integer, ByVal galvooffsety As Integer, ByVal head As Integer)
Declare Sub      set_hi Lib "RTC4ethDLL.DLL" (ByVal galvogainx As Double, ByVal galvogainy As Double, ByVal galvooffsetx As Integer, ByVal galvooffsety As Integer, ByVal head As Integer)
Declare Sub      n_set_list_mode Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal mode As Integer)
Declare Sub      set_list_mode Lib "RTC4ethDLL.DLL" (ByVal mode As Integer)
Declare Function n_get_list_space Lib "RTC4ethDLL.DLL" (ByVal n As Integer) As Integer
Declare Function get_list_space Lib "RTC4ethDLL.DLL" () As Integer
Declare Sub      n_save_and_restart_timer Lib "RTC4ethDLL.DLL" (ByVal n As Integer)
Declare Sub      save_and_restart_timer Lib "RTC4ethDLL.DLL" ()
Declare Sub      n_set_ext_start_delay_list Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal delay As Integer, ByVal encoder As Integer)
Declare Sub      set_ext_start_delay_list Lib "RTC4ethDLL.DLL" (ByVal delay As Integer, ByVal encoder As Integer)
Declare Function n_get_time Lib "RTC4ethDLL.DLL" (ByVal n As Integer) As Double
Declare Function get_time Lib "RTC4ethDLL.DLL" () As Double
Declare Sub      get_hi_data Lib "RTC4ethDLL.DLL" (x1 As Integer, x2 As Integer, y1 As Integer, y2 As Integer)
Declare Function teachin Lib "RTC4ethDLL.DLL" (ByVal filename As String, ByVal xin As Integer, ByVal yin As Integer, ByVal zin As Integer, ByVal ll0 As Double, xout As Integer, yout As Integer, zout As Integer) As Integer
Declare Function getmemory Lib "RTC4ethDLL.DLL" (ByVal adr As Integer) As Integer
Declare Sub      set_timeout Lib "RTC4ethDLL.DLL" (ByVal timeout As Long)
Declare Sub      set_timeouts Lib "RTC4ethDLL.DLL" (ByVal acquire_timeout_us As Long, ByVal acquire_max_retries As Long, ByVal send_recv_timeout_us As Long, ByVal send_recv_max_retries As Long, ByVal acqu_rel_min_intvl_ms As Long)
Declare Sub      get_timeouts Lib "RTC4ethDLL.DLL" (acquire_timeout_us As Long, acquire_max_retries As Long, send_recv_timeout_us As Long, send_recv_max_retries As Long, acqu_rel_min_intvl_ms As Long)
Declare Function rs232_config Lib "RTC4ethDLL.DLL" (ByVal baudrate As Long, ByVal parity As Long, ByVal stopbits As Long) As Long
Declare Function n_rs232_config Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal baudrate As Long, ByVal parity As Long, ByVal stopbits As Long) As Long
Declare Function rs232_write_data Lib "RTC4ethDLL.DLL" (ByVal data As Long) As Long
Declare Function n_rs232_write_data Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal data As Long) As Long
Declare Function rs232_write_text Lib "RTC4ethDLL.DLL" (ByVal text As String) As Long
Declare Function n_rs232_write_text Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal text As String) As Long
Declare Function rs232_read_data Lib "RTC4ethDLL.DLL" (data As Long) As Long
Declare Function n_rs232_read_data Lib "RTC4ethDLL.DLL" (ByVal n As Integer, data As Long) As Long
Declare Sub      n_eth_set_com_timeouts_auto Lib "RTC4ethDLL.DLL" (ByVal cardno As Integer, ByVal initial_timeout_ms As Double, ByVal sum_timeout_ms As Double, ByVal multiplicator As Double, ByVal mode As Long)
Declare Sub      eth_set_com_timeouts_auto Lib "RTC4ethDLL.DLL" (ByVal initial_timeout_ms As Double, ByVal sum_timeout_ms As Double, ByVal multiplicator As Double, ByVal mode As Long)
Declare Sub      n_eth_get_com_timeouts_auto Lib "RTC4ethDLL.DLL" (ByVal cardno As Integer, initial_timeout_ms As Double, sum_timeout_ms As Double, multiplicator As Double, mode As Long)
Declare Sub      eth_get_com_timeouts_auto Lib "RTC4ethDLL.DLL" (initial_timeout_ms As Double, sum_timeout_ms As Double, multiplicator As Double, mode As Long)
Declare Function n_eth_watchdog_timer_config Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal timer_ms As Long) As Long
Declare Function eth_watchdog_timer_config Lib "RTC4ethDLL.DLL" (ByVal timer_ms As Long) As Long
Declare Function n_eth_watchdog_timer_reset Lib "RTC4ethDLL.DLL" (ByVal n As Integer) As Long
Declare Function eth_watchdog_timer_reset Lib "RTC4ethDLL.DLL" () As Long
Declare Sub      n_eth_link_loss_config Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal mode As Long)
Declare Sub      eth_link_loss_config Lib "RTC4ethDLL.DLL" (ByVal mode As Long)
Declare Function n_eth_get_last_error Lib "RTC4ethDLL.DLL" (ByVal n As Integer) As Long
Declare Function eth_get_last_error Lib "RTC4ethDLL.DLL" () As Long
Declare Function n_eth_get_error Lib "RTC4ethDLL.DLL" (ByVal n As Integer) As Long
Declare Function eth_get_error Lib "RTC4ethDLL.DLL" () As Long
Declare Function n_eth_error_dump Lib "RTC4ethDLL.DLL" (ByVal n As Integer, ByVal dump As pdword) As Long
Declare Function eth_error_dump Lib "RTC4ethDLL.DLL" (ByVal dump As pdword) As Long
