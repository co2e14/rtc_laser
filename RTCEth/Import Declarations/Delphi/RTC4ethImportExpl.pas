unit RTC4ethImport;
{
  Delphi import declarations for the SCANLAB RTC4eth-DLL

  This file was automatically generated on 2022-01-21.
}

uses Windows, Dialogs;

interface

const 
{$IFDEF WIN64}
  RTC4ethDLL_Default = 'RTC4ethDLLx64.DLL';
{$ELSE}
  RTC4ethDLL_Default = 'RTC4ethDLL.DLL';
{$ENDIF}

type
  PInt = ^SmallInt;
  POutChar = PAnsiChar;
   GET_DRIVER_STATUS_TYPE = function : dword; stdcall; external RTC4DLL;
   GET_NET_DLL_VERSION_TYPE = function : dword; stdcall; external RTC4DLL;
   ACQUIRE_RTC_TYPE = function (card_no: dword): dword; stdcall;
   RELEASE_RTC_TYPE = function (card_no: dword): dword; stdcall;
   SELECT_RTC_TYPE = procedure(card_no: word); stdcall;
   ASSIGN_RTC_TYPE = function (search_no: word; card_no: word): dword; stdcall;
   ASSIGN_RTC_BY_IP_TYPE = function (ip: dword; card_no: word): dword; stdcall;
   REMOVE_RTC_TYPE = procedure(card_no: word); stdcall;
   CONVERT_STRING_TO_IP_TYPE = function (ip: pansichar): dword; stdcall;
   CONVERT_IP_TO_STRING_TYPE = procedure(ip: dword; cpIp: poutchar); stdcall;
   CONVERT_MAC_TO_STRING_TYPE = procedure(mac: int64; cpMac: poutchar); stdcall;
   RTC_SEARCH_CARDS_TYPE = function (var cards: word; ip: dword; netmask: dword): dword; stdcall;
   GET_MAC_ADDRESS_TYPE = function (cardNo: word): Int64; stdcall;
   GET_IP_ADDRESS_TYPE = function (cardNo: word): dword; stdcall;
   GET_SERIAL_TYPE = function (cardNo: word): dword; stdcall;
   GET_CONNECTION_STATUS_TYPE = function (cardNo: word): word; stdcall;
   GET_MASTER_IP_ADDRESS_TYPE = function (cardNo: word): dword; stdcall;
   GET_MASTER_ID_TYPE = function (cardNo: word; id: poutchar): dword; stdcall;
   SET_STATIC_IP_TYPE = function (ip: dword; netmask: dword; gateway: dword): dword; stdcall;
   GET_STATIC_IP_TYPE = function (var ip: dword; var netmask: dword; var gateway: dword): dword; stdcall;
   GET_MCU_FW_VERSION_TYPE = function (cardNo: word): dword; stdcall;
   GET_NIC_IP_COUNT_TYPE = function (var count: word): dword; stdcall;
   GET_NIC_IP_TYPE = procedure(count: word; var ip: dword; var nm: dword); stdcall;
   N_GET_WAVEFORM_TYPE = procedure(n: word; channel: word; istop: word; MemPtr: pint); stdcall;
   GET_WAVEFORM_TYPE = procedure(channel: word; istop: word; MemPtr: pint); stdcall;
   N_MEASUREMENT_STATUS_TYPE = procedure(n: word; var busy: wordbool; var position: word); stdcall;
   MEASUREMENT_STATUS_TYPE = procedure(var busy: wordbool; var position: word); stdcall;
   N_SET_TRIGGER_TYPE = procedure(n: word; sampleperiod: word; channel1: word; channel2: word); stdcall;
   SET_TRIGGER_TYPE = procedure(sampleperiod: word; signal1: word; signal2: word); stdcall;
   N_GET_VALUE_TYPE = function (n: word; signal: word): smallint; stdcall;
   GET_VALUE_TYPE = function (signal: word): smallint; stdcall;
   N_SET_IO_BIT_TYPE = procedure(n: word; mask1: word); stdcall;
   SET_IO_BIT_TYPE = procedure(mask1: word); stdcall;
   N_CLEAR_IO_BIT_TYPE = procedure(n: word; mask0: word); stdcall;
   CLEAR_IO_BIT_TYPE = procedure(mask0: word); stdcall;
   N_MOVE_TO_TYPE = procedure(n: word; position: word); stdcall;
   MOVE_TO_TYPE = procedure(position: word); stdcall;
   N_CONTROL_COMMAND_TYPE = procedure(n: word; head: word; axis: word; data: word); stdcall;
   CONTROL_COMMAND_TYPE = procedure(head: word; axis: word; data: word); stdcall;
   N_ARC_REL_TYPE = procedure(n: word; dx: smallint; dy: smallint; angle: double); stdcall;
   ARC_REL_TYPE = procedure(dx: smallint; dy: smallint; angle: double); stdcall;
   N_ARC_ABS_TYPE = procedure(n: word; x: smallint; y: smallint; angle: double); stdcall;
   ARC_ABS_TYPE = procedure(x: smallint; y: smallint; angle: double); stdcall;
   DRILLING_TYPE = procedure(PulseWidth: smallint; RelEncoderDelay: smallint); stdcall;
   REGULATION_TYPE = procedure; stdcall; external RTC4DLL;
   FLYLINE_TYPE = procedure(EncoderDelay: smallint); stdcall;
   SET_DUTY_CYCLE_TABLE_TYPE = procedure(index: word; dutycycle: word); stdcall;
   N_LOAD_VARPOLYDELAY_TYPE = function (n: word; stbFileName: pansichar; TableNo: word): smallint; stdcall;
   LOAD_VARPOLYDELAY_TYPE = function (stbFileName: pansichar; TableNo: word): smallint; stdcall;
   N_LOAD_PROGRAM_FILE_TYPE = function (n: word; name: pansichar): smallint; stdcall;
   LOAD_PROGRAM_FILE_TYPE = function (name: pansichar): smallint; stdcall;
   N_LOAD_CORRECTION_FILE_TYPE = function (n: word; FileName: pansichar; CorTable: smallint; Kx: double; Ky: double; Phi: double; Xoffset: double; Yoffset: double): smallint; stdcall;
   LOAD_CORRECTION_FILE_TYPE = function (FileName: pansichar; CorTable: smallint; Kx: double; Ky: double; Phi: double; Xoffset: double; Yoffset: double): smallint; stdcall;
   N_LOAD_Z_TABLE_TYPE = function (n: word; A: double; B: double; C: double): smallint; stdcall;
   LOAD_Z_TABLE_TYPE = function (A: double; B: double; C: double): smallint; stdcall;
   N_LIST_NOP_TYPE = procedure(n: word); stdcall;
   LIST_NOP_TYPE = procedure; stdcall; external RTC4DLL;
   N_SET_END_OF_LIST_TYPE = procedure(n: word); stdcall;
   SET_END_OF_LIST_TYPE = procedure; stdcall; external RTC4DLL;
   N_JUMP_ABS_3D_TYPE = procedure(n: word; x: smallint; y: smallint; z: smallint); stdcall;
   JUMP_ABS_3D_TYPE = procedure(x: smallint; y: smallint; z: smallint); stdcall;
   N_JUMP_ABS_TYPE = procedure(n: word; x: smallint; y: smallint); stdcall;
   JUMP_ABS_TYPE = procedure(x: smallint; y: smallint); stdcall;
   N_MARK_ABS_3D_TYPE = procedure(n: word; x: smallint; y: smallint; z: smallint); stdcall;
   MARK_ABS_3D_TYPE = procedure(x: smallint; y: smallint; z: smallint); stdcall;
   N_MARK_ABS_TYPE = procedure(n: word; x: smallint; y: smallint); stdcall;
   MARK_ABS_TYPE = procedure(x: smallint; y: smallint); stdcall;
   N_JUMP_REL_3D_TYPE = procedure(n: word; dx: smallint; dy: smallint; dz: smallint); stdcall;
   JUMP_REL_3D_TYPE = procedure(dx: smallint; dy: smallint; dz: smallint); stdcall;
   N_JUMP_REL_TYPE = procedure(n: word; dx: smallint; dy: smallint); stdcall;
   JUMP_REL_TYPE = procedure(dx: smallint; dy: smallint); stdcall;
   N_MARK_REL_3D_TYPE = procedure(n: word; dx: smallint; dy: smallint; dz: smallint); stdcall;
   MARK_REL_3D_TYPE = procedure(dx: smallint; dy: smallint; dz: smallint); stdcall;
   N_MARK_REL_TYPE = procedure(n: word; dx: smallint; dy: smallint); stdcall;
   MARK_REL_TYPE = procedure(dx: smallint; dy: smallint); stdcall;
   N_WRITE_8BIT_PORT_LIST_TYPE = procedure(n: word; value: word); stdcall;
   WRITE_8BIT_PORT_LIST_TYPE = procedure(value: word); stdcall;
   N_WRITE_DA_1_LIST_TYPE = procedure(n: word; value: word); stdcall;
   WRITE_DA_1_LIST_TYPE = procedure(value: word); stdcall;
   N_WRITE_DA_2_LIST_TYPE = procedure(n: word; value: word); stdcall;
   WRITE_DA_2_LIST_TYPE = procedure(value: word); stdcall;
   N_SET_MATRIX_LIST_TYPE = procedure(n: word; i: word; j: word; Mij: double); stdcall;
   SET_MATRIX_LIST_TYPE = procedure(i: word; j: word; Mij: double); stdcall;
   N_SET_OFFSET_LIST_TYPE = procedure(n: word; Xoffset: smallint; Yoffset: smallint); stdcall;
   SET_OFFSET_LIST_TYPE = procedure(Xoffset: smallint; Yoffset: smallint); stdcall;
   N_SET_DEFOCUS_LIST_TYPE = procedure(n: word; value: smallint); stdcall;
   SET_DEFOCUS_LIST_TYPE = procedure(value: smallint); stdcall;
   N_SET_DEFOCUS_TYPE = procedure(n: word; value: smallint); stdcall;
   SET_DEFOCUS_TYPE = procedure(value: smallint); stdcall;
   N_SET_SOFTSTART_MODE_TYPE = procedure(n: word; mode: word; number: word; restartdelay: word); stdcall;
   SET_SOFTSTART_MODE_TYPE = procedure(mode: word; number: word; resetdelay: word); stdcall;
   N_SET_SOFTSTART_LEVEL_TYPE = procedure(n: word; index: word; level: word); stdcall;
   SET_SOFTSTART_LEVEL_TYPE = procedure(index: word; level: word); stdcall;
   N_SET_CONTROL_MODE_LIST_TYPE = procedure(n: word; mode: word); stdcall;
   SET_CONTROL_MODE_LIST_TYPE = procedure(mode: word); stdcall;
   N_SET_CONTROL_MODE_TYPE = procedure(n: word; mode: word); stdcall;
   SET_CONTROL_MODE_TYPE = procedure(mode: word); stdcall;
   N_LONG_DELAY_TYPE = procedure(n: word; value: word); stdcall;
   LONG_DELAY_TYPE = procedure(value: word); stdcall;
   N_LASER_ON_LIST_TYPE = procedure(n: word; value: word); stdcall;
   LASER_ON_LIST_TYPE = procedure(value: word); stdcall;
   N_SET_JUMP_SPEED_TYPE = procedure(n: word; speed: double); stdcall;
   SET_JUMP_SPEED_TYPE = procedure(speed: double); stdcall;
   N_SET_MARK_SPEED_TYPE = procedure(n: word; speed: double); stdcall;
   SET_MARK_SPEED_TYPE = procedure(speed: double); stdcall;
   N_SET_LASER_DELAYS_TYPE = procedure(n: word; ondelay: smallint; offdelay: smallint); stdcall;
   SET_LASER_DELAYS_TYPE = procedure(ondelay: smallint; offdelay: smallint); stdcall;
   N_SET_SCANNER_DELAYS_TYPE = procedure(n: word; jumpdelay: word; markdelay: word; polydelay: word); stdcall;
   SET_SCANNER_DELAYS_TYPE = procedure(jumpdelay: word; markdelay: word; polydelay: word); stdcall;
   N_SET_LIST_JUMP_TYPE = procedure(n: word; position: word); stdcall;
   SET_LIST_JUMP_TYPE = procedure(position: word); stdcall;
   N_SET_INPUT_POINTER_TYPE = procedure(n: word; pointer: word); stdcall;
   SET_INPUT_POINTER_TYPE = procedure(pointer: word); stdcall;
   N_LIST_CALL_TYPE = procedure(n: word; position: word); stdcall;
   LIST_CALL_TYPE = procedure(position: word); stdcall;
   N_LIST_RETURN_TYPE = procedure(n: word); stdcall;
   LIST_RETURN_TYPE = procedure; stdcall; external RTC4DLL;
   N_Z_OUT_LIST_TYPE = procedure(n: word; z: smallint); stdcall;
   Z_OUT_LIST_TYPE = procedure(z: smallint); stdcall;
   N_SET_STANDBY_LIST_TYPE = procedure(n: word; half_period: word; pulse: word); stdcall;
   SET_STANDBY_LIST_TYPE = procedure(half_period: word; pulse: word); stdcall;
   N_TIMED_JUMP_ABS_TYPE = procedure(n: word; x: smallint; y: smallint; time: double); stdcall;
   TIMED_JUMP_ABS_TYPE = procedure(x: smallint; y: smallint; time: double); stdcall;
   N_TIMED_MARK_ABS_TYPE = procedure(n: word; x: smallint; y: smallint; time: double); stdcall;
   TIMED_MARK_ABS_TYPE = procedure(x: smallint; y: smallint; time: double); stdcall;
   N_TIMED_JUMP_REL_TYPE = procedure(n: word; dx: smallint; dy: smallint; time: double); stdcall;
   TIMED_JUMP_REL_TYPE = procedure(dx: smallint; dy: smallint; time: double); stdcall;
   N_TIMED_MARK_REL_TYPE = procedure(n: word; dx: smallint; dy: smallint; time: double); stdcall;
   TIMED_MARK_REL_TYPE = procedure(dx: smallint; dy: smallint; time: double); stdcall;
   N_SET_LASER_TIMING_TYPE = procedure(n: word; HalfPeriod: word; Pulse1: word; Pulse2: word; TimeBase: word); stdcall;
   SET_LASER_TIMING_TYPE = procedure(HalfPeriod: word; Pulse1: word; Pulse2: word; TimeBase: word); stdcall;
   N_SET_WOBBEL_TYPE = procedure(n: word; amplitude: word; frequency: double); stdcall;
   SET_WOBBEL_TYPE = procedure(amplitude: word; frequency: double); stdcall;
   N_SET_WOBBEL_XY_TYPE = procedure(n: word; long_wob: word; trans_wob: word; frequency: double); stdcall;
   SET_WOBBEL_XY_TYPE = procedure(long_wob: word; trans_wob: word; frequency: double); stdcall;
   N_SET_FLY_X_TYPE = procedure(n: word; kx: double); stdcall;
   SET_FLY_X_TYPE = procedure(kx: double); stdcall;
   N_SET_FLY_Y_TYPE = procedure(n: word; ky: double); stdcall;
   SET_FLY_Y_TYPE = procedure(ky: double); stdcall;
   N_SET_FLY_ROT_TYPE = procedure(n: word; resolution: double); stdcall;
   SET_FLY_ROT_TYPE = procedure(resolution: double); stdcall;
   N_FLY_RETURN_TYPE = procedure(n: word; x: smallint; y: smallint); stdcall;
   FLY_RETURN_TYPE = procedure(x: smallint; y: smallint); stdcall;
   N_CALCULATE_FLY_TYPE = procedure(n: word; direction: word; distance: double); stdcall;
   CALCULATE_FLY_TYPE = procedure(direction: word; distance: double); stdcall;
   N_WRITE_IO_PORT_LIST_TYPE = procedure(n: word; value: word); stdcall;
   WRITE_IO_PORT_LIST_TYPE = procedure(value: word); stdcall;
   N_SELECT_COR_TABLE_LIST_TYPE = procedure(n: word; HeadA: word; HeadB: word); stdcall;
   SELECT_COR_TABLE_LIST_TYPE = procedure(HeadA: word; HeadB: word); stdcall;
   N_SET_WAIT_TYPE = procedure(n: word; value: word); stdcall;
   SET_WAIT_TYPE = procedure(value: word); stdcall;
   N_SIMULATE_EXT_START_TYPE = procedure(n: word; delay: smallint; encoder: smallint); stdcall;
   SIMULATE_EXT_START_TYPE = procedure(delay: smallint; encoder: smallint); stdcall;
   N_WRITE_DA_X_LIST_TYPE = procedure(n: word; x: word; value: word); stdcall;
   WRITE_DA_X_LIST_TYPE = procedure(x: word; value: word); stdcall;
   N_SET_PIXEL_LINE_TYPE = procedure(n: word; PixelMode: word; PixelPeriod: word; dx: double; dy: double); stdcall;
   SET_PIXEL_LINE_TYPE = procedure(PixelMode: word; PixelPeriod: word; dx: double; dy: double); stdcall;
   N_SET_PIXEL_TYPE = procedure(n: word; PulsWidth: word; DAValue: word; ADChannel: word); stdcall;
   SET_PIXEL_TYPE = procedure(PulsWidth: word; DAValue: word; ADChannel: word); stdcall;
   N_SET_EXTSTARTPOS_LIST_TYPE = procedure(n: word; position: word); stdcall;
   SET_EXTSTARTPOS_LIST_TYPE = procedure(position: word); stdcall;
   N_LASER_SIGNAL_ON_LIST_TYPE = procedure(n: word); stdcall;
   LASER_SIGNAL_ON_LIST_TYPE = procedure; stdcall; external RTC4DLL;
   N_LASER_SIGNAL_OFF_LIST_TYPE = procedure(n: word); stdcall;
   LASER_SIGNAL_OFF_LIST_TYPE = procedure; stdcall; external RTC4DLL;
   N_SET_FIRSTPULSE_KILLER_LIST_TYPE = procedure(n: word; fpk: word); stdcall;
   SET_FIRSTPULSE_KILLER_LIST_TYPE = procedure(fpk: word); stdcall;
   N_SET_IO_COND_LIST_TYPE = procedure(n: word; mask_1: word; mask_0: word; mask_set: word); stdcall;
   SET_IO_COND_LIST_TYPE = procedure(mask_1: word; mask_0: word; mask_set: word); stdcall;
   N_CLEAR_IO_COND_LIST_TYPE = procedure(n: word; mask_1: word; mask_0: word; mask_clear: word); stdcall;
   CLEAR_IO_COND_LIST_TYPE = procedure(mask_1: word; mask_0: word; mask_clear: word); stdcall;
   N_LIST_JUMP_COND_TYPE = procedure(n: word; mask_1: word; mask_0: word; position: word); stdcall;
   LIST_JUMP_COND_TYPE = procedure(mask_1: word; mask_0: word; position: word); stdcall;
   N_LIST_CALL_COND_TYPE = procedure(n: word; mask_1: word; mask_0: word; position: word); stdcall;
   LIST_CALL_COND_TYPE = procedure(mask_1: word; mask_0: word; position: word); stdcall;
   N_GET_INPUT_POINTER_TYPE = function (n: word): word; stdcall;
   GET_INPUT_POINTER_TYPE = function : word; stdcall; external RTC4DLL;
   RTC4_MAX_CARDS_TYPE = function : word; stdcall; external RTC4DLL;
   N_GET_STATUS_TYPE = procedure(n: word; var busy: wordbool; var position: word); stdcall;
   GET_STATUS_TYPE = procedure(var busy: wordbool; var position: word); stdcall;
   N_READ_STATUS_TYPE = function (n: word): word; stdcall;
   READ_STATUS_TYPE = function : word; stdcall; external RTC4DLL;
   N_GET_STARTSTOP_INFO_TYPE = function (n: word): word; stdcall;
   GET_STARTSTOP_INFO_TYPE = function : word; stdcall; external RTC4DLL;
   N_GET_MARKING_INFO_TYPE = function (n: word): word; stdcall;
   GET_MARKING_INFO_TYPE = function : word; stdcall; external RTC4DLL;
   GET_DLL_VERSION_TYPE = function : word; stdcall; external RTC4DLL;
   N_SET_START_LIST_1_TYPE = procedure(n: word); stdcall;
   SET_START_LIST_1_TYPE = procedure; stdcall; external RTC4DLL;
   N_SET_START_LIST_2_TYPE = procedure(n: word); stdcall;
   SET_START_LIST_2_TYPE = procedure; stdcall; external RTC4DLL;
   N_SET_START_LIST_TYPE = procedure(n: word; ListNo: word); stdcall;
   SET_START_LIST_TYPE = procedure(ListNo: word); stdcall;
   N_EXECUTE_LIST_1_TYPE = procedure(n: word); stdcall;
   EXECUTE_LIST_1_TYPE = procedure; stdcall; external RTC4DLL;
   N_EXECUTE_LIST_2_TYPE = procedure(n: word); stdcall;
   EXECUTE_LIST_2_TYPE = procedure; stdcall; external RTC4DLL;
   N_EXECUTE_LIST_TYPE = procedure(n: word; ListNo: word); stdcall;
   EXECUTE_LIST_TYPE = procedure(ListNo: word); stdcall;
   N_WRITE_8BIT_PORT_TYPE = procedure(n: word; value: word); stdcall;
   WRITE_8BIT_PORT_TYPE = procedure(value: word); stdcall;
   N_WRITE_IO_PORT_TYPE = procedure(n: word; value: word); stdcall;
   WRITE_IO_PORT_TYPE = procedure(value: word); stdcall;
   N_ETH_STATUS_TYPE = function (n: word): longint; stdcall;
   ETH_STATUS_TYPE = function : longint; stdcall; external RTC4DLL;
   N_AUTO_CHANGE_TYPE = procedure(n: word); stdcall;
   AUTO_CHANGE_TYPE = procedure; stdcall; external RTC4DLL;
   N_AUTO_CHANGE_POS_TYPE = procedure(n: word; start: word); stdcall;
   AUTO_CHANGE_POS_TYPE = procedure(start: word); stdcall;
   AUT_CHANGE_TYPE = procedure; stdcall; external RTC4DLL;
   N_START_LOOP_TYPE = procedure(n: word); stdcall;
   START_LOOP_TYPE = procedure; stdcall; external RTC4DLL;
   N_QUIT_LOOP_TYPE = procedure(n: word); stdcall;
   QUIT_LOOP_TYPE = procedure; stdcall; external RTC4DLL;
   N_STOP_EXECUTION_TYPE = procedure(n: word); stdcall;
   STOP_EXECUTION_TYPE = procedure; stdcall; external RTC4DLL;
   N_READ_IO_PORT_TYPE = function (n: word): word; stdcall;
   READ_IO_PORT_TYPE = function : word; stdcall; external RTC4DLL;
   N_WRITE_DA_1_TYPE = procedure(n: word; value: word); stdcall;
   WRITE_DA_1_TYPE = procedure(value: word); stdcall;
   N_WRITE_DA_2_TYPE = procedure(n: word; value: word); stdcall;
   WRITE_DA_2_TYPE = procedure(value: word); stdcall;
   N_SET_MAX_COUNTS_TYPE = procedure(n: word; counts: longint); stdcall;
   SET_MAX_COUNTS_TYPE = procedure(counts: longint); stdcall;
   N_GET_COUNTS_TYPE = function (n: word): longint; stdcall;
   GET_COUNTS_TYPE = function : longint; stdcall; external RTC4DLL;
   N_SET_MATRIX_TYPE = procedure(n: word; M11: double; M12: double; M21: double; M22: double); stdcall;
   SET_MATRIX_TYPE = procedure(M11: double; M12: double; M21: double; M22: double); stdcall;
   N_SET_OFFSET_TYPE = procedure(n: word; Xoffset: smallint; Yoffset: smallint); stdcall;
   SET_OFFSET_TYPE = procedure(Xoffset: smallint; Yoffset: smallint); stdcall;
   N_GOTO_XYZ_TYPE = procedure(n: word; X: smallint; Y: smallint; Z: smallint); stdcall;
   GOTO_XYZ_TYPE = procedure(X: smallint; Y: smallint; Z: smallint); stdcall;
   N_GOTO_XY_TYPE = procedure(n: word; X: smallint; Y: smallint); stdcall;
   GOTO_XY_TYPE = procedure(X: smallint; Y: smallint); stdcall;
   N_GET_HEX_VERSION_TYPE = function (n: word): word; stdcall;
   GET_HEX_VERSION_TYPE = function : word; stdcall; external RTC4DLL;
   N_DISABLE_LASER_TYPE = procedure(n: word); stdcall;
   DISABLE_LASER_TYPE = procedure; stdcall; external RTC4DLL;
   N_ENABLE_LASER_TYPE = procedure(n: word); stdcall;
   ENABLE_LASER_TYPE = procedure; stdcall; external RTC4DLL;
   N_STOP_LIST_TYPE = procedure(n: word); stdcall;
   STOP_LIST_TYPE = procedure; stdcall; external RTC4DLL;
   N_RESTART_LIST_TYPE = procedure(n: word); stdcall;
   RESTART_LIST_TYPE = procedure; stdcall; external RTC4DLL;
   N_GET_XYZ_POS_TYPE = procedure(n: word; var X: smallint; var Y: smallint; var Z: smallint); stdcall;
   GET_XYZ_POS_TYPE = procedure(var X: smallint; var Y: smallint; var Z: smallint); stdcall;
   N_GET_XY_POS_TYPE = procedure(n: word; var X: smallint; var Y: smallint); stdcall;
   GET_XY_POS_TYPE = procedure(var X: smallint; var Y: smallint); stdcall;
   N_SELECT_LIST_TYPE = procedure(n: word; list_2: word); stdcall;
   SELECT_LIST_TYPE = procedure(list_2: word); stdcall;
   N_Z_OUT_TYPE = procedure(n: word; z: smallint); stdcall;
   Z_OUT_TYPE = procedure(z: smallint); stdcall;
   N_SET_FIRSTPULSE_KILLER_TYPE = procedure(n: word; fpk: word); stdcall;
   SET_FIRSTPULSE_KILLER_TYPE = procedure(fpk: word); stdcall;
   N_SET_STANDBY_TYPE = procedure(n: word; half_period: word; pulse: word); stdcall;
   SET_STANDBY_TYPE = procedure(half_period: word; pulse: word); stdcall;
   N_LASER_SIGNAL_ON_TYPE = procedure(n: word); stdcall;
   LASER_SIGNAL_ON_TYPE = procedure; stdcall; external RTC4DLL;
   N_LASER_SIGNAL_OFF_TYPE = procedure(n: word); stdcall;
   LASER_SIGNAL_OFF_TYPE = procedure; stdcall; external RTC4DLL;
   N_SET_DELAY_MODE_TYPE = procedure(n: word; VarPoly: word; DirectMove3D: word; EdgeLevel: word; MinJumpDelay: word; JumpLengthLimit: word); stdcall;
   SET_DELAY_MODE_TYPE = procedure(VarPoly: word; DirectMove3D: word; EdgeLevel: word; MinJumpDelay: word; JumpLengthLimit: word); stdcall;
   N_SET_PISO_CONTROL_TYPE = procedure(n: word; l1: word; l2: word); stdcall;
   SET_PISO_CONTROL_TYPE = procedure(l1: word; l2: word); stdcall;
   N_SELECT_STATUS_TYPE = procedure(n: word; mode: word); stdcall;
   SELECT_STATUS_TYPE = procedure(mode: word); stdcall;
   N_GET_ENCODER_TYPE = procedure(n: word; var Zx: smallint; var Zy: smallint); stdcall;
   GET_ENCODER_TYPE = procedure(var Zx: smallint; var Zy: smallint); stdcall;
   N_SELECT_COR_TABLE_TYPE = procedure(n: word; HeadA: word; HeadB: word); stdcall;
   SELECT_COR_TABLE_TYPE = procedure(HeadA: word; HeadB: word); stdcall;
   N_EXECUTE_AT_POINTER_TYPE = procedure(n: word; position: word); stdcall;
   EXECUTE_AT_POINTER_TYPE = procedure(position: word); stdcall;
   N_GET_HEAD_STATUS_TYPE = function (n: word; Head: word): word; stdcall;
   GET_HEAD_STATUS_TYPE = function (Head: word): word; stdcall;
   N_SIMULATE_ENCODER_TYPE = procedure(n: word; Channel: word); stdcall;
   SIMULATE_ENCODER_TYPE = procedure(Channel: word); stdcall;
   N_RELEASE_WAIT_TYPE = procedure(n: word); stdcall;
   RELEASE_WAIT_TYPE = procedure; stdcall; external RTC4DLL;
   N_GET_WAIT_STATUS_TYPE = function (n: word): word; stdcall;
   GET_WAIT_STATUS_TYPE = function : word; stdcall; external RTC4DLL;
   N_SET_LASER_MODE_TYPE = procedure(n: word; mode: word); stdcall;
   SET_LASER_MODE_TYPE = procedure(mode: word); stdcall;
   N_SET_EXT_START_DELAY_TYPE = procedure(n: word; delay: smallint; encoder: smallint); stdcall;
   SET_EXT_START_DELAY_TYPE = procedure(delay: smallint; encoder: smallint); stdcall;
   N_HOME_POSITION_TYPE = procedure(n: word; xhome: smallint; yhome: smallint); stdcall;
   HOME_POSITION_TYPE = procedure(xhome: smallint; yhome: smallint); stdcall;
   N_SET_ROT_CENTER_TYPE = procedure(n: word; center_x: longint; center_y: longint); stdcall;
   SET_ROT_CENTER_TYPE = procedure(center_x: longint; center_y: longint); stdcall;
   N_DSP_START_TYPE = procedure(n: word); stdcall;
   DSP_START_TYPE = procedure; stdcall; external RTC4DLL;
   N_WRITE_DA_X_TYPE = procedure(n: word; x: word; value: word); stdcall;
   WRITE_DA_X_TYPE = procedure(x: word; value: word); stdcall;
   N_READ_AD_X_TYPE = function (n: word; x: word): word; stdcall;
   READ_AD_X_TYPE = function (x: word): word; stdcall;
   N_READ_PIXEL_AD_TYPE = function (n: word; pos: word): word; stdcall;
   READ_PIXEL_AD_TYPE = function (pos: word): word; stdcall;
   N_GET_Z_DISTANCE_TYPE = function (n: word; x: smallint; y: smallint; z: smallint): smallint; stdcall;
   GET_Z_DISTANCE_TYPE = function (x: smallint; y: smallint; z: smallint): smallint; stdcall;
   N_GET_IO_STATUS_TYPE = function (n: word): word; stdcall;
   GET_IO_STATUS_TYPE = function : word; stdcall; external RTC4DLL;
   LOAD_COR_TYPE = function (FileName: pansichar): smallint; stdcall;
   LOAD_PRO_TYPE = function (FileName: pansichar): smallint; stdcall;
   N_GET_SERIAL_NUMBER_TYPE = function (n: word): word; stdcall;
   GET_SERIAL_NUMBER_TYPE = function : word; stdcall; external RTC4DLL;
   N_GET_SERIAL_NUMBER_32_TYPE = function (n: word): longint; stdcall;
   GET_SERIAL_NUMBER_32_TYPE = function : longint; stdcall; external RTC4DLL;
   N_GET_RTC_VERSION_TYPE = function (n: word): word; stdcall;
   GET_RTC_VERSION_TYPE = function : word; stdcall; external RTC4DLL;
   N_AUTO_CAL_TYPE = function (n: word; Head: word; command: word): Smallint; stdcall;
   AUTO_CAL_TYPE = function (Head: word; command: word): Smallint; stdcall;
   N_SET_HI_TYPE = procedure(n: word; GalvoGainX: double; GalvoGainY: double; GalvoOffsetX: smallint; GalvoOffsetY: smallint; Head: smallint); stdcall;
   SET_HI_TYPE = procedure(GalvoGainX: double; GalvoGainY: double; GalvoOffsetX: smallint; GalvoOffsetY: smallint; Head: smallint); stdcall;
   N_SET_LIST_MODE_TYPE = procedure(n: word; mode: word); stdcall;
   SET_LIST_MODE_TYPE = procedure(mode: word); stdcall;
   N_GET_LIST_SPACE_TYPE = function (n: word): word; stdcall;
   GET_LIST_SPACE_TYPE = function : word; stdcall; external RTC4DLL;
   N_SAVE_AND_RESTART_TIMER_TYPE = procedure(n: word); stdcall;
   SAVE_AND_RESTART_TIMER_TYPE = procedure; stdcall; external RTC4DLL;
   N_SET_EXT_START_DELAY_LIST_TYPE = procedure(n: word; delay: smallint; encoder: smallint); stdcall;
   SET_EXT_START_DELAY_LIST_TYPE = procedure(delay: smallint; encoder: smallint); stdcall;
   N_GET_TIME_TYPE = function (n: word): double; stdcall;
   GET_TIME_TYPE = function : double; stdcall; external RTC4DLL;
   GET_HI_DATA_TYPE = procedure(var x1: word; var x2: word; var y1: word; var y2: word); stdcall;
   TEACHIN_TYPE = function (FileName: pansichar; Xin: smallint; Yin: smallint; Zin: smallint; LL0: double; var Xout: smallint; var Yout: smallint; var Zout: smallint): SmallInt; stdcall;
   GETMEMORY_TYPE = function (adr: word): smallint; stdcall;
   SET_TIMEOUT_TYPE = procedure(timeout: dword); stdcall;
   SET_TIMEOUTS_TYPE = procedure(acquire_timeout_us: dword; acquire_max_retries: dword; send_recv_timeout_us: dword; send_recv_max_retries: dword; acqu_rel_min_intvl_ms: dword); stdcall;
   GET_TIMEOUTS_TYPE = procedure(var acquire_timeout_us: dword; var acquire_max_retries: dword; var send_recv_timeout_us: dword; var send_recv_max_retries: dword; var acqu_rel_min_intvl_ms: dword); stdcall;
   RS232_CONFIG_TYPE = function (baudrate: dword; parity: dword; stopbits: dword): dword; stdcall;
   N_RS232_CONFIG_TYPE = function (n: word; baudrate: dword; parity: dword; stopbits: dword): dword; stdcall;
   RS232_WRITE_DATA_TYPE = function (data: dword): dword; stdcall;
   N_RS232_WRITE_DATA_TYPE = function (n: word; data: dword): dword; stdcall;
   RS232_WRITE_TEXT_TYPE = function (text: pansichar): dword; stdcall;
   N_RS232_WRITE_TEXT_TYPE = function (n: word; text: pansichar): dword; stdcall;
   RS232_READ_DATA_TYPE = function (var data: dword): dword; stdcall;
   N_RS232_READ_DATA_TYPE = function (n: word; var data: dword): dword; stdcall;
   N_ETH_SET_COM_TIMEOUTS_AUTO_TYPE = procedure(cardNo: word; initial_timeout_ms: double; sum_timeout_ms: double; multiplicator: double; mode: longint); stdcall;
   ETH_SET_COM_TIMEOUTS_AUTO_TYPE = procedure(initial_timeout_ms: double; sum_timeout_ms: double; multiplicator: double; mode: longint); stdcall;
   N_ETH_GET_COM_TIMEOUTS_AUTO_TYPE = procedure(cardNo: word; var initial_timeout_ms: double; var sum_timeout_ms: double; var multiplicator: double; var mode: longint); stdcall;
   ETH_GET_COM_TIMEOUTS_AUTO_TYPE = procedure(var initial_timeout_ms: double; var sum_timeout_ms: double; var multiplicator: double; var mode: longint); stdcall;
   N_ETH_WATCHDOG_TIMER_CONFIG_TYPE = function (n: word; timer_ms: dword): dword; stdcall;
   ETH_WATCHDOG_TIMER_CONFIG_TYPE = function (timer_ms: dword): dword; stdcall;
   N_ETH_WATCHDOG_TIMER_RESET_TYPE = function (n: word): dword; stdcall;
   ETH_WATCHDOG_TIMER_RESET_TYPE = function : dword; stdcall; external RTC4DLL;
   N_ETH_LINK_LOSS_CONFIG_TYPE = procedure(n: word; mode: dword); stdcall;
   ETH_LINK_LOSS_CONFIG_TYPE = procedure(mode: dword); stdcall;
   N_ETH_GET_LAST_ERROR_TYPE = function (n: word): dword; stdcall;
   ETH_GET_LAST_ERROR_TYPE = function : dword; stdcall; external RTC4DLL;
   N_ETH_GET_ERROR_TYPE = function (n: word): dword; stdcall;
   ETH_GET_ERROR_TYPE = function : dword; stdcall; external RTC4DLL;
   N_ETH_ERROR_DUMP_TYPE = function (n: word; dump: pdword): dword; stdcall;
   ETH_ERROR_DUMP_TYPE = function (dump: pdword): dword; stdcall;
{$ENDREGION}

  // call this function first to load the RTC4 32 bit or 64 bit DLL
  // returns :
  //     0  = all DLL functions loaded
  //    -1  = DLL could not be loaded
  //    -2  = DLL already loaded
  function RTC4ethOpen: Integer;
  // call this function to unload the RTC4 DLL
  procedure RTC4ethClose;
  // select DLL name before RTC4ethOpen
  procedure RTC4selectDLL(file_name: String);


var
{$REGION 'RTC4eth user functions'}
,
    get_driver_status: GET_DRIVER_STATUS_TYPE,
    get_net_dll_version: GET_NET_DLL_VERSION_TYPE,
    acquire_rtc: ACQUIRE_RTC_TYPE,
    release_rtc: RELEASE_RTC_TYPE,
    select_rtc: SELECT_RTC_TYPE,
    assign_rtc: ASSIGN_RTC_TYPE,
    assign_rtc_by_ip: ASSIGN_RTC_BY_IP_TYPE,
    remove_rtc: REMOVE_RTC_TYPE,
    convert_string_to_ip: CONVERT_STRING_TO_IP_TYPE,
    convert_ip_to_string: CONVERT_IP_TO_STRING_TYPE,
    convert_mac_to_string: CONVERT_MAC_TO_STRING_TYPE,
    rtc_search_cards: RTC_SEARCH_CARDS_TYPE,
    get_mac_address: GET_MAC_ADDRESS_TYPE,
    get_ip_address: GET_IP_ADDRESS_TYPE,
    get_serial: GET_SERIAL_TYPE,
    get_connection_status: GET_CONNECTION_STATUS_TYPE,
    get_master_ip_address: GET_MASTER_IP_ADDRESS_TYPE,
    get_master_id: GET_MASTER_ID_TYPE,
    set_static_ip: SET_STATIC_IP_TYPE,
    get_static_ip: GET_STATIC_IP_TYPE,
    get_mcu_fw_version: GET_MCU_FW_VERSION_TYPE,
    get_nic_ip_count: GET_NIC_IP_COUNT_TYPE,
    get_nic_ip: GET_NIC_IP_TYPE,
    n_get_waveform: N_GET_WAVEFORM_TYPE,
    get_waveform: GET_WAVEFORM_TYPE,
    n_measurement_status: N_MEASUREMENT_STATUS_TYPE,
    measurement_status: MEASUREMENT_STATUS_TYPE,
    n_set_trigger: N_SET_TRIGGER_TYPE,
    set_trigger: SET_TRIGGER_TYPE,
    n_get_value: N_GET_VALUE_TYPE,
    get_value: GET_VALUE_TYPE,
    n_set_io_bit: N_SET_IO_BIT_TYPE,
    set_io_bit: SET_IO_BIT_TYPE,
    n_clear_io_bit: N_CLEAR_IO_BIT_TYPE,
    clear_io_bit: CLEAR_IO_BIT_TYPE,
    n_move_to: N_MOVE_TO_TYPE,
    move_to: MOVE_TO_TYPE,
    n_control_command: N_CONTROL_COMMAND_TYPE,
    control_command: CONTROL_COMMAND_TYPE,
    n_arc_rel: N_ARC_REL_TYPE,
    arc_rel: ARC_REL_TYPE,
    n_arc_abs: N_ARC_ABS_TYPE,
    arc_abs: ARC_ABS_TYPE,
    drilling: DRILLING_TYPE,
    regulation: REGULATION_TYPE,
    flyline: FLYLINE_TYPE,
    set_duty_cycle_table: SET_DUTY_CYCLE_TABLE_TYPE,
    n_load_varpolydelay: N_LOAD_VARPOLYDELAY_TYPE,
    load_varpolydelay: LOAD_VARPOLYDELAY_TYPE,
    n_load_program_file: N_LOAD_PROGRAM_FILE_TYPE,
    load_program_file: LOAD_PROGRAM_FILE_TYPE,
    n_load_correction_file: N_LOAD_CORRECTION_FILE_TYPE,
    load_correction_file: LOAD_CORRECTION_FILE_TYPE,
    n_load_z_table: N_LOAD_Z_TABLE_TYPE,
    load_z_table: LOAD_Z_TABLE_TYPE,
    n_list_nop: N_LIST_NOP_TYPE,
    list_nop: LIST_NOP_TYPE,
    n_set_end_of_list: N_SET_END_OF_LIST_TYPE,
    set_end_of_list: SET_END_OF_LIST_TYPE,
    n_jump_abs_3d: N_JUMP_ABS_3D_TYPE,
    jump_abs_3d: JUMP_ABS_3D_TYPE,
    n_jump_abs: N_JUMP_ABS_TYPE,
    jump_abs: JUMP_ABS_TYPE,
    n_mark_abs_3d: N_MARK_ABS_3D_TYPE,
    mark_abs_3d: MARK_ABS_3D_TYPE,
    n_mark_abs: N_MARK_ABS_TYPE,
    mark_abs: MARK_ABS_TYPE,
    n_jump_rel_3d: N_JUMP_REL_3D_TYPE,
    jump_rel_3d: JUMP_REL_3D_TYPE,
    n_jump_rel: N_JUMP_REL_TYPE,
    jump_rel: JUMP_REL_TYPE,
    n_mark_rel_3d: N_MARK_REL_3D_TYPE,
    mark_rel_3d: MARK_REL_3D_TYPE,
    n_mark_rel: N_MARK_REL_TYPE,
    mark_rel: MARK_REL_TYPE,
    n_write_8bit_port_list: N_WRITE_8BIT_PORT_LIST_TYPE,
    write_8bit_port_list: WRITE_8BIT_PORT_LIST_TYPE,
    n_write_da_1_list: N_WRITE_DA_1_LIST_TYPE,
    write_da_1_list: WRITE_DA_1_LIST_TYPE,
    n_write_da_2_list: N_WRITE_DA_2_LIST_TYPE,
    write_da_2_list: WRITE_DA_2_LIST_TYPE,
    n_set_matrix_list: N_SET_MATRIX_LIST_TYPE,
    set_matrix_list: SET_MATRIX_LIST_TYPE,
    n_set_offset_list: N_SET_OFFSET_LIST_TYPE,
    set_offset_list: SET_OFFSET_LIST_TYPE,
    n_set_defocus_list: N_SET_DEFOCUS_LIST_TYPE,
    set_defocus_list: SET_DEFOCUS_LIST_TYPE,
    n_set_defocus: N_SET_DEFOCUS_TYPE,
    set_defocus: SET_DEFOCUS_TYPE,
    n_set_softstart_mode: N_SET_SOFTSTART_MODE_TYPE,
    set_softstart_mode: SET_SOFTSTART_MODE_TYPE,
    n_set_softstart_level: N_SET_SOFTSTART_LEVEL_TYPE,
    set_softstart_level: SET_SOFTSTART_LEVEL_TYPE,
    n_set_control_mode_list: N_SET_CONTROL_MODE_LIST_TYPE,
    set_control_mode_list: SET_CONTROL_MODE_LIST_TYPE,
    n_set_control_mode: N_SET_CONTROL_MODE_TYPE,
    set_control_mode: SET_CONTROL_MODE_TYPE,
    n_long_delay: N_LONG_DELAY_TYPE,
    long_delay: LONG_DELAY_TYPE,
    n_laser_on_list: N_LASER_ON_LIST_TYPE,
    laser_on_list: LASER_ON_LIST_TYPE,
    n_set_jump_speed: N_SET_JUMP_SPEED_TYPE,
    set_jump_speed: SET_JUMP_SPEED_TYPE,
    n_set_mark_speed: N_SET_MARK_SPEED_TYPE,
    set_mark_speed: SET_MARK_SPEED_TYPE,
    n_set_laser_delays: N_SET_LASER_DELAYS_TYPE,
    set_laser_delays: SET_LASER_DELAYS_TYPE,
    n_set_scanner_delays: N_SET_SCANNER_DELAYS_TYPE,
    set_scanner_delays: SET_SCANNER_DELAYS_TYPE,
    n_set_list_jump: N_SET_LIST_JUMP_TYPE,
    set_list_jump: SET_LIST_JUMP_TYPE,
    n_set_input_pointer: N_SET_INPUT_POINTER_TYPE,
    set_input_pointer: SET_INPUT_POINTER_TYPE,
    n_list_call: N_LIST_CALL_TYPE,
    list_call: LIST_CALL_TYPE,
    n_list_return: N_LIST_RETURN_TYPE,
    list_return: LIST_RETURN_TYPE,
    n_z_out_list: N_Z_OUT_LIST_TYPE,
    z_out_list: Z_OUT_LIST_TYPE,
    n_set_standby_list: N_SET_STANDBY_LIST_TYPE,
    set_standby_list: SET_STANDBY_LIST_TYPE,
    n_timed_jump_abs: N_TIMED_JUMP_ABS_TYPE,
    timed_jump_abs: TIMED_JUMP_ABS_TYPE,
    n_timed_mark_abs: N_TIMED_MARK_ABS_TYPE,
    timed_mark_abs: TIMED_MARK_ABS_TYPE,
    n_timed_jump_rel: N_TIMED_JUMP_REL_TYPE,
    timed_jump_rel: TIMED_JUMP_REL_TYPE,
    n_timed_mark_rel: N_TIMED_MARK_REL_TYPE,
    timed_mark_rel: TIMED_MARK_REL_TYPE,
    n_set_laser_timing: N_SET_LASER_TIMING_TYPE,
    set_laser_timing: SET_LASER_TIMING_TYPE,
    n_set_wobbel: N_SET_WOBBEL_TYPE,
    set_wobbel: SET_WOBBEL_TYPE,
    n_set_wobbel_xy: N_SET_WOBBEL_XY_TYPE,
    set_wobbel_xy: SET_WOBBEL_XY_TYPE,
    n_set_fly_x: N_SET_FLY_X_TYPE,
    set_fly_x: SET_FLY_X_TYPE,
    n_set_fly_y: N_SET_FLY_Y_TYPE,
    set_fly_y: SET_FLY_Y_TYPE,
    n_set_fly_rot: N_SET_FLY_ROT_TYPE,
    set_fly_rot: SET_FLY_ROT_TYPE,
    n_fly_return: N_FLY_RETURN_TYPE,
    fly_return: FLY_RETURN_TYPE,
    n_calculate_fly: N_CALCULATE_FLY_TYPE,
    calculate_fly: CALCULATE_FLY_TYPE,
    n_write_io_port_list: N_WRITE_IO_PORT_LIST_TYPE,
    write_io_port_list: WRITE_IO_PORT_LIST_TYPE,
    n_select_cor_table_list: N_SELECT_COR_TABLE_LIST_TYPE,
    select_cor_table_list: SELECT_COR_TABLE_LIST_TYPE,
    n_set_wait: N_SET_WAIT_TYPE,
    set_wait: SET_WAIT_TYPE,
    n_simulate_ext_start: N_SIMULATE_EXT_START_TYPE,
    simulate_ext_start: SIMULATE_EXT_START_TYPE,
    n_write_da_x_list: N_WRITE_DA_X_LIST_TYPE,
    write_da_x_list: WRITE_DA_X_LIST_TYPE,
    n_set_pixel_line: N_SET_PIXEL_LINE_TYPE,
    set_pixel_line: SET_PIXEL_LINE_TYPE,
    n_set_pixel: N_SET_PIXEL_TYPE,
    set_pixel: SET_PIXEL_TYPE,
    n_set_extstartpos_list: N_SET_EXTSTARTPOS_LIST_TYPE,
    set_extstartpos_list: SET_EXTSTARTPOS_LIST_TYPE,
    n_laser_signal_on_list: N_LASER_SIGNAL_ON_LIST_TYPE,
    laser_signal_on_list: LASER_SIGNAL_ON_LIST_TYPE,
    n_laser_signal_off_list: N_LASER_SIGNAL_OFF_LIST_TYPE,
    laser_signal_off_list: LASER_SIGNAL_OFF_LIST_TYPE,
    n_set_firstpulse_killer_list: N_SET_FIRSTPULSE_KILLER_LIST_TYPE,
    set_firstpulse_killer_list: SET_FIRSTPULSE_KILLER_LIST_TYPE,
    n_set_io_cond_list: N_SET_IO_COND_LIST_TYPE,
    set_io_cond_list: SET_IO_COND_LIST_TYPE,
    n_clear_io_cond_list: N_CLEAR_IO_COND_LIST_TYPE,
    clear_io_cond_list: CLEAR_IO_COND_LIST_TYPE,
    n_list_jump_cond: N_LIST_JUMP_COND_TYPE,
    list_jump_cond: LIST_JUMP_COND_TYPE,
    n_list_call_cond: N_LIST_CALL_COND_TYPE,
    list_call_cond: LIST_CALL_COND_TYPE,
    n_get_input_pointer: N_GET_INPUT_POINTER_TYPE,
    get_input_pointer: GET_INPUT_POINTER_TYPE,
    rtc4_max_cards: RTC4_MAX_CARDS_TYPE,
    n_get_status: N_GET_STATUS_TYPE,
    get_status: GET_STATUS_TYPE,
    n_read_status: N_READ_STATUS_TYPE,
    read_status: READ_STATUS_TYPE,
    n_get_startstop_info: N_GET_STARTSTOP_INFO_TYPE,
    get_startstop_info: GET_STARTSTOP_INFO_TYPE,
    n_get_marking_info: N_GET_MARKING_INFO_TYPE,
    get_marking_info: GET_MARKING_INFO_TYPE,
    get_dll_version: GET_DLL_VERSION_TYPE,
    n_set_start_list_1: N_SET_START_LIST_1_TYPE,
    set_start_list_1: SET_START_LIST_1_TYPE,
    n_set_start_list_2: N_SET_START_LIST_2_TYPE,
    set_start_list_2: SET_START_LIST_2_TYPE,
    n_set_start_list: N_SET_START_LIST_TYPE,
    set_start_list: SET_START_LIST_TYPE,
    n_execute_list_1: N_EXECUTE_LIST_1_TYPE,
    execute_list_1: EXECUTE_LIST_1_TYPE,
    n_execute_list_2: N_EXECUTE_LIST_2_TYPE,
    execute_list_2: EXECUTE_LIST_2_TYPE,
    n_execute_list: N_EXECUTE_LIST_TYPE,
    execute_list: EXECUTE_LIST_TYPE,
    n_write_8bit_port: N_WRITE_8BIT_PORT_TYPE,
    write_8bit_port: WRITE_8BIT_PORT_TYPE,
    n_write_io_port: N_WRITE_IO_PORT_TYPE,
    write_io_port: WRITE_IO_PORT_TYPE,
    n_eth_status: N_ETH_STATUS_TYPE,
    eth_status: ETH_STATUS_TYPE,
    n_auto_change: N_AUTO_CHANGE_TYPE,
    auto_change: AUTO_CHANGE_TYPE,
    n_auto_change_pos: N_AUTO_CHANGE_POS_TYPE,
    auto_change_pos: AUTO_CHANGE_POS_TYPE,
    aut_change: AUT_CHANGE_TYPE,
    n_start_loop: N_START_LOOP_TYPE,
    start_loop: START_LOOP_TYPE,
    n_quit_loop: N_QUIT_LOOP_TYPE,
    quit_loop: QUIT_LOOP_TYPE,
    n_stop_execution: N_STOP_EXECUTION_TYPE,
    stop_execution: STOP_EXECUTION_TYPE,
    n_read_io_port: N_READ_IO_PORT_TYPE,
    read_io_port: READ_IO_PORT_TYPE,
    n_write_da_1: N_WRITE_DA_1_TYPE,
    write_da_1: WRITE_DA_1_TYPE,
    n_write_da_2: N_WRITE_DA_2_TYPE,
    write_da_2: WRITE_DA_2_TYPE,
    n_set_max_counts: N_SET_MAX_COUNTS_TYPE,
    set_max_counts: SET_MAX_COUNTS_TYPE,
    n_get_counts: N_GET_COUNTS_TYPE,
    get_counts: GET_COUNTS_TYPE,
    n_set_matrix: N_SET_MATRIX_TYPE,
    set_matrix: SET_MATRIX_TYPE,
    n_set_offset: N_SET_OFFSET_TYPE,
    set_offset: SET_OFFSET_TYPE,
    n_goto_xyz: N_GOTO_XYZ_TYPE,
    goto_xyz: GOTO_XYZ_TYPE,
    n_goto_xy: N_GOTO_XY_TYPE,
    goto_xy: GOTO_XY_TYPE,
    n_get_hex_version: N_GET_HEX_VERSION_TYPE,
    get_hex_version: GET_HEX_VERSION_TYPE,
    n_disable_laser: N_DISABLE_LASER_TYPE,
    disable_laser: DISABLE_LASER_TYPE,
    n_enable_laser: N_ENABLE_LASER_TYPE,
    enable_laser: ENABLE_LASER_TYPE,
    n_stop_list: N_STOP_LIST_TYPE,
    stop_list: STOP_LIST_TYPE,
    n_restart_list: N_RESTART_LIST_TYPE,
    restart_list: RESTART_LIST_TYPE,
    n_get_xyz_pos: N_GET_XYZ_POS_TYPE,
    get_xyz_pos: GET_XYZ_POS_TYPE,
    n_get_xy_pos: N_GET_XY_POS_TYPE,
    get_xy_pos: GET_XY_POS_TYPE,
    n_select_list: N_SELECT_LIST_TYPE,
    select_list: SELECT_LIST_TYPE,
    n_z_out: N_Z_OUT_TYPE,
    z_out: Z_OUT_TYPE,
    n_set_firstpulse_killer: N_SET_FIRSTPULSE_KILLER_TYPE,
    set_firstpulse_killer: SET_FIRSTPULSE_KILLER_TYPE,
    n_set_standby: N_SET_STANDBY_TYPE,
    set_standby: SET_STANDBY_TYPE,
    n_laser_signal_on: N_LASER_SIGNAL_ON_TYPE,
    laser_signal_on: LASER_SIGNAL_ON_TYPE,
    n_laser_signal_off: N_LASER_SIGNAL_OFF_TYPE,
    laser_signal_off: LASER_SIGNAL_OFF_TYPE,
    n_set_delay_mode: N_SET_DELAY_MODE_TYPE,
    set_delay_mode: SET_DELAY_MODE_TYPE,
    n_set_piso_control: N_SET_PISO_CONTROL_TYPE,
    set_piso_control: SET_PISO_CONTROL_TYPE,
    n_select_status: N_SELECT_STATUS_TYPE,
    select_status: SELECT_STATUS_TYPE,
    n_get_encoder: N_GET_ENCODER_TYPE,
    get_encoder: GET_ENCODER_TYPE,
    n_select_cor_table: N_SELECT_COR_TABLE_TYPE,
    select_cor_table: SELECT_COR_TABLE_TYPE,
    n_execute_at_pointer: N_EXECUTE_AT_POINTER_TYPE,
    execute_at_pointer: EXECUTE_AT_POINTER_TYPE,
    n_get_head_status: N_GET_HEAD_STATUS_TYPE,
    get_head_status: GET_HEAD_STATUS_TYPE,
    n_simulate_encoder: N_SIMULATE_ENCODER_TYPE,
    simulate_encoder: SIMULATE_ENCODER_TYPE,
    n_release_wait: N_RELEASE_WAIT_TYPE,
    release_wait: RELEASE_WAIT_TYPE,
    n_get_wait_status: N_GET_WAIT_STATUS_TYPE,
    get_wait_status: GET_WAIT_STATUS_TYPE,
    n_set_laser_mode: N_SET_LASER_MODE_TYPE,
    set_laser_mode: SET_LASER_MODE_TYPE,
    n_set_ext_start_delay: N_SET_EXT_START_DELAY_TYPE,
    set_ext_start_delay: SET_EXT_START_DELAY_TYPE,
    n_home_position: N_HOME_POSITION_TYPE,
    home_position: HOME_POSITION_TYPE,
    n_set_rot_center: N_SET_ROT_CENTER_TYPE,
    set_rot_center: SET_ROT_CENTER_TYPE,
    n_dsp_start: N_DSP_START_TYPE,
    dsp_start: DSP_START_TYPE,
    n_write_da_x: N_WRITE_DA_X_TYPE,
    write_da_x: WRITE_DA_X_TYPE,
    n_read_ad_x: N_READ_AD_X_TYPE,
    read_ad_x: READ_AD_X_TYPE,
    n_read_pixel_ad: N_READ_PIXEL_AD_TYPE,
    read_pixel_ad: READ_PIXEL_AD_TYPE,
    n_get_z_distance: N_GET_Z_DISTANCE_TYPE,
    get_z_distance: GET_Z_DISTANCE_TYPE,
    n_get_io_status: N_GET_IO_STATUS_TYPE,
    get_io_status: GET_IO_STATUS_TYPE,
    load_cor: LOAD_COR_TYPE,
    load_pro: LOAD_PRO_TYPE,
    n_get_serial_number: N_GET_SERIAL_NUMBER_TYPE,
    get_serial_number: GET_SERIAL_NUMBER_TYPE,
    n_get_serial_number_32: N_GET_SERIAL_NUMBER_32_TYPE,
    get_serial_number_32: GET_SERIAL_NUMBER_32_TYPE,
    n_get_rtc_version: N_GET_RTC_VERSION_TYPE,
    get_rtc_version: GET_RTC_VERSION_TYPE,
    n_auto_cal: N_AUTO_CAL_TYPE,
    auto_cal: AUTO_CAL_TYPE,
    n_set_hi: N_SET_HI_TYPE,
    set_hi: SET_HI_TYPE,
    n_set_list_mode: N_SET_LIST_MODE_TYPE,
    set_list_mode: SET_LIST_MODE_TYPE,
    n_get_list_space: N_GET_LIST_SPACE_TYPE,
    get_list_space: GET_LIST_SPACE_TYPE,
    n_save_and_restart_timer: N_SAVE_AND_RESTART_TIMER_TYPE,
    save_and_restart_timer: SAVE_AND_RESTART_TIMER_TYPE,
    n_set_ext_start_delay_list: N_SET_EXT_START_DELAY_LIST_TYPE,
    set_ext_start_delay_list: SET_EXT_START_DELAY_LIST_TYPE,
    n_get_time: N_GET_TIME_TYPE,
    get_time: GET_TIME_TYPE,
    get_hi_data: GET_HI_DATA_TYPE,
    teachin: TEACHIN_TYPE,
    getmemory: GETMEMORY_TYPE,
    set_timeout: SET_TIMEOUT_TYPE,
    set_timeouts: SET_TIMEOUTS_TYPE,
    get_timeouts: GET_TIMEOUTS_TYPE,
    rs232_config: RS232_CONFIG_TYPE,
    n_rs232_config: N_RS232_CONFIG_TYPE,
    rs232_write_data: RS232_WRITE_DATA_TYPE,
    n_rs232_write_data: N_RS232_WRITE_DATA_TYPE,
    rs232_write_text: RS232_WRITE_TEXT_TYPE,
    n_rs232_write_text: N_RS232_WRITE_TEXT_TYPE,
    rs232_read_data: RS232_READ_DATA_TYPE,
    n_rs232_read_data: N_RS232_READ_DATA_TYPE,
    n_eth_set_com_timeouts_auto: N_ETH_SET_COM_TIMEOUTS_AUTO_TYPE,
    eth_set_com_timeouts_auto: ETH_SET_COM_TIMEOUTS_AUTO_TYPE,
    n_eth_get_com_timeouts_auto: N_ETH_GET_COM_TIMEOUTS_AUTO_TYPE,
    eth_get_com_timeouts_auto: ETH_GET_COM_TIMEOUTS_AUTO_TYPE,
    n_eth_watchdog_timer_config: N_ETH_WATCHDOG_TIMER_CONFIG_TYPE,
    eth_watchdog_timer_config: ETH_WATCHDOG_TIMER_CONFIG_TYPE,
    n_eth_watchdog_timer_reset: N_ETH_WATCHDOG_TIMER_RESET_TYPE,
    eth_watchdog_timer_reset: ETH_WATCHDOG_TIMER_RESET_TYPE,
    n_eth_link_loss_config: N_ETH_LINK_LOSS_CONFIG_TYPE,
    eth_link_loss_config: ETH_LINK_LOSS_CONFIG_TYPE,
    n_eth_get_last_error: N_ETH_GET_LAST_ERROR_TYPE,
    eth_get_last_error: ETH_GET_LAST_ERROR_TYPE,
    n_eth_get_error: N_ETH_GET_ERROR_TYPE,
    eth_get_error: ETH_GET_ERROR_TYPE,
    n_eth_error_dump: N_ETH_ERROR_DUMP_TYPE,
    eth_error_dump: ETH_ERROR_DUMP_TYPE;
{$ENDREGION}
implementation

var
    RTC4ethDLLname: String = RTC4ethDLL_Default;
    LibHandleRTC4eth : HModule;


procedure RTC4selectDLL(file_name: String);
begin
   if file_name <> '' then
   begin
      RTC4ethDLLname = file_name;
   end;
end;
	
	
function RTC4ethOpen: Integer;
begin
  if LibHandleRTC4eth <> 0 then
  begin
     RTC4ethOpen := -2;
	 exit;
  end;

  if LibHandleRTC4eth = 0 then begin

    LibHandleRTC4eth := LoadLibrary(RTC4ethDLLname);
    if LibHandleRTC4eth = 0 then
    begin
       RTC4ethOpen := -1;
       exit;
    end;

    ImportFunctions(LibHandleRTC4eth);
end;


procedure RTC4ethClose;
begin
   if (LibHandleRTC4eth <> 0) then
   begin
      FreeLibrary(LibHandleRTC4eth);
      LibHandleRTC4eth := 0;
   end;
end;


procedure ImportError(func_name: String);
begin
   import_error := true;
   MessageDlg(dll_name_str + ': Missing Function: ' + func_name, mtError, [mbOK], 0);
end;


function ImportFunction(dll: HMODULE; func_name: String): FarProc;
begin
   Result := GetProcAddress(dll, PChar(func_name));
   if not Assigned(@Result) then
   begin
      ImportError(func_name);
      exit;
   end;
end;


procedure ImportFunctions(handle: HMODULE);
begin
{$REGION FunctionImportsRegion}
    @get_driver_status := ImportFunction(handle, 'get_driver_status');
    @get_net_dll_version := ImportFunction(handle, 'get_net_dll_version');
    @acquire_rtc := ImportFunction(handle, 'acquire_rtc');
    @release_rtc := ImportFunction(handle, 'release_rtc');
    @select_rtc := ImportFunction(handle, 'select_rtc');
    @assign_rtc := ImportFunction(handle, 'assign_rtc');
    @assign_rtc_by_ip := ImportFunction(handle, 'assign_rtc_by_ip');
    @remove_rtc := ImportFunction(handle, 'remove_rtc');
    @convert_string_to_ip := ImportFunction(handle, 'convert_string_to_ip');
    @convert_ip_to_string := ImportFunction(handle, 'convert_ip_to_string');
    @convert_mac_to_string := ImportFunction(handle, 'convert_mac_to_string');
    @rtc_search_cards := ImportFunction(handle, 'rtc_search_cards');
    @get_mac_address := ImportFunction(handle, 'get_mac_address');
    @get_ip_address := ImportFunction(handle, 'get_ip_address');
    @get_serial := ImportFunction(handle, 'get_serial');
    @get_connection_status := ImportFunction(handle, 'get_connection_status');
    @get_master_ip_address := ImportFunction(handle, 'get_master_ip_address');
    @get_master_id := ImportFunction(handle, 'get_master_id');
    @set_static_ip := ImportFunction(handle, 'set_static_ip');
    @get_static_ip := ImportFunction(handle, 'get_static_ip');
    @get_mcu_fw_version := ImportFunction(handle, 'get_mcu_fw_version');
    @get_nic_ip_count := ImportFunction(handle, 'get_nic_ip_count');
    @get_nic_ip := ImportFunction(handle, 'get_nic_ip');
    @n_get_waveform := ImportFunction(handle, 'n_get_waveform');
    @get_waveform := ImportFunction(handle, 'get_waveform');
    @n_measurement_status := ImportFunction(handle, 'n_measurement_status');
    @measurement_status := ImportFunction(handle, 'measurement_status');
    @n_set_trigger := ImportFunction(handle, 'n_set_trigger');
    @set_trigger := ImportFunction(handle, 'set_trigger');
    @n_get_value := ImportFunction(handle, 'n_get_value');
    @get_value := ImportFunction(handle, 'get_value');
    @n_set_io_bit := ImportFunction(handle, 'n_set_io_bit');
    @set_io_bit := ImportFunction(handle, 'set_io_bit');
    @n_clear_io_bit := ImportFunction(handle, 'n_clear_io_bit');
    @clear_io_bit := ImportFunction(handle, 'clear_io_bit');
    @n_move_to := ImportFunction(handle, 'n_move_to');
    @move_to := ImportFunction(handle, 'move_to');
    @n_control_command := ImportFunction(handle, 'n_control_command');
    @control_command := ImportFunction(handle, 'control_command');
    @n_arc_rel := ImportFunction(handle, 'n_arc_rel');
    @arc_rel := ImportFunction(handle, 'arc_rel');
    @n_arc_abs := ImportFunction(handle, 'n_arc_abs');
    @arc_abs := ImportFunction(handle, 'arc_abs');
    @drilling := ImportFunction(handle, 'drilling');
    @regulation := ImportFunction(handle, 'regulation');
    @flyline := ImportFunction(handle, 'flyline');
    @set_duty_cycle_table := ImportFunction(handle, 'set_duty_cycle_table');
    @n_load_varpolydelay := ImportFunction(handle, 'n_load_varpolydelay');
    @load_varpolydelay := ImportFunction(handle, 'load_varpolydelay');
    @n_load_program_file := ImportFunction(handle, 'n_load_program_file');
    @load_program_file := ImportFunction(handle, 'load_program_file');
    @n_load_correction_file := ImportFunction(handle, 'n_load_correction_file');
    @load_correction_file := ImportFunction(handle, 'load_correction_file');
    @n_load_z_table := ImportFunction(handle, 'n_load_z_table');
    @load_z_table := ImportFunction(handle, 'load_z_table');
    @n_list_nop := ImportFunction(handle, 'n_list_nop');
    @list_nop := ImportFunction(handle, 'list_nop');
    @n_set_end_of_list := ImportFunction(handle, 'n_set_end_of_list');
    @set_end_of_list := ImportFunction(handle, 'set_end_of_list');
    @n_jump_abs_3d := ImportFunction(handle, 'n_jump_abs_3d');
    @jump_abs_3d := ImportFunction(handle, 'jump_abs_3d');
    @n_jump_abs := ImportFunction(handle, 'n_jump_abs');
    @jump_abs := ImportFunction(handle, 'jump_abs');
    @n_mark_abs_3d := ImportFunction(handle, 'n_mark_abs_3d');
    @mark_abs_3d := ImportFunction(handle, 'mark_abs_3d');
    @n_mark_abs := ImportFunction(handle, 'n_mark_abs');
    @mark_abs := ImportFunction(handle, 'mark_abs');
    @n_jump_rel_3d := ImportFunction(handle, 'n_jump_rel_3d');
    @jump_rel_3d := ImportFunction(handle, 'jump_rel_3d');
    @n_jump_rel := ImportFunction(handle, 'n_jump_rel');
    @jump_rel := ImportFunction(handle, 'jump_rel');
    @n_mark_rel_3d := ImportFunction(handle, 'n_mark_rel_3d');
    @mark_rel_3d := ImportFunction(handle, 'mark_rel_3d');
    @n_mark_rel := ImportFunction(handle, 'n_mark_rel');
    @mark_rel := ImportFunction(handle, 'mark_rel');
    @n_write_8bit_port_list := ImportFunction(handle, 'n_write_8bit_port_list');
    @write_8bit_port_list := ImportFunction(handle, 'write_8bit_port_list');
    @n_write_da_1_list := ImportFunction(handle, 'n_write_da_1_list');
    @write_da_1_list := ImportFunction(handle, 'write_da_1_list');
    @n_write_da_2_list := ImportFunction(handle, 'n_write_da_2_list');
    @write_da_2_list := ImportFunction(handle, 'write_da_2_list');
    @n_set_matrix_list := ImportFunction(handle, 'n_set_matrix_list');
    @set_matrix_list := ImportFunction(handle, 'set_matrix_list');
    @n_set_offset_list := ImportFunction(handle, 'n_set_offset_list');
    @set_offset_list := ImportFunction(handle, 'set_offset_list');
    @n_set_defocus_list := ImportFunction(handle, 'n_set_defocus_list');
    @set_defocus_list := ImportFunction(handle, 'set_defocus_list');
    @n_set_defocus := ImportFunction(handle, 'n_set_defocus');
    @set_defocus := ImportFunction(handle, 'set_defocus');
    @n_set_softstart_mode := ImportFunction(handle, 'n_set_softstart_mode');
    @set_softstart_mode := ImportFunction(handle, 'set_softstart_mode');
    @n_set_softstart_level := ImportFunction(handle, 'n_set_softstart_level');
    @set_softstart_level := ImportFunction(handle, 'set_softstart_level');
    @n_set_control_mode_list := ImportFunction(handle, 'n_set_control_mode_list');
    @set_control_mode_list := ImportFunction(handle, 'set_control_mode_list');
    @n_set_control_mode := ImportFunction(handle, 'n_set_control_mode');
    @set_control_mode := ImportFunction(handle, 'set_control_mode');
    @n_long_delay := ImportFunction(handle, 'n_long_delay');
    @long_delay := ImportFunction(handle, 'long_delay');
    @n_laser_on_list := ImportFunction(handle, 'n_laser_on_list');
    @laser_on_list := ImportFunction(handle, 'laser_on_list');
    @n_set_jump_speed := ImportFunction(handle, 'n_set_jump_speed');
    @set_jump_speed := ImportFunction(handle, 'set_jump_speed');
    @n_set_mark_speed := ImportFunction(handle, 'n_set_mark_speed');
    @set_mark_speed := ImportFunction(handle, 'set_mark_speed');
    @n_set_laser_delays := ImportFunction(handle, 'n_set_laser_delays');
    @set_laser_delays := ImportFunction(handle, 'set_laser_delays');
    @n_set_scanner_delays := ImportFunction(handle, 'n_set_scanner_delays');
    @set_scanner_delays := ImportFunction(handle, 'set_scanner_delays');
    @n_set_list_jump := ImportFunction(handle, 'n_set_list_jump');
    @set_list_jump := ImportFunction(handle, 'set_list_jump');
    @n_set_input_pointer := ImportFunction(handle, 'n_set_input_pointer');
    @set_input_pointer := ImportFunction(handle, 'set_input_pointer');
    @n_list_call := ImportFunction(handle, 'n_list_call');
    @list_call := ImportFunction(handle, 'list_call');
    @n_list_return := ImportFunction(handle, 'n_list_return');
    @list_return := ImportFunction(handle, 'list_return');
    @n_z_out_list := ImportFunction(handle, 'n_z_out_list');
    @z_out_list := ImportFunction(handle, 'z_out_list');
    @n_set_standby_list := ImportFunction(handle, 'n_set_standby_list');
    @set_standby_list := ImportFunction(handle, 'set_standby_list');
    @n_timed_jump_abs := ImportFunction(handle, 'n_timed_jump_abs');
    @timed_jump_abs := ImportFunction(handle, 'timed_jump_abs');
    @n_timed_mark_abs := ImportFunction(handle, 'n_timed_mark_abs');
    @timed_mark_abs := ImportFunction(handle, 'timed_mark_abs');
    @n_timed_jump_rel := ImportFunction(handle, 'n_timed_jump_rel');
    @timed_jump_rel := ImportFunction(handle, 'timed_jump_rel');
    @n_timed_mark_rel := ImportFunction(handle, 'n_timed_mark_rel');
    @timed_mark_rel := ImportFunction(handle, 'timed_mark_rel');
    @n_set_laser_timing := ImportFunction(handle, 'n_set_laser_timing');
    @set_laser_timing := ImportFunction(handle, 'set_laser_timing');
    @n_set_wobbel := ImportFunction(handle, 'n_set_wobbel');
    @set_wobbel := ImportFunction(handle, 'set_wobbel');
    @n_set_wobbel_xy := ImportFunction(handle, 'n_set_wobbel_xy');
    @set_wobbel_xy := ImportFunction(handle, 'set_wobbel_xy');
    @n_set_fly_x := ImportFunction(handle, 'n_set_fly_x');
    @set_fly_x := ImportFunction(handle, 'set_fly_x');
    @n_set_fly_y := ImportFunction(handle, 'n_set_fly_y');
    @set_fly_y := ImportFunction(handle, 'set_fly_y');
    @n_set_fly_rot := ImportFunction(handle, 'n_set_fly_rot');
    @set_fly_rot := ImportFunction(handle, 'set_fly_rot');
    @n_fly_return := ImportFunction(handle, 'n_fly_return');
    @fly_return := ImportFunction(handle, 'fly_return');
    @n_calculate_fly := ImportFunction(handle, 'n_calculate_fly');
    @calculate_fly := ImportFunction(handle, 'calculate_fly');
    @n_write_io_port_list := ImportFunction(handle, 'n_write_io_port_list');
    @write_io_port_list := ImportFunction(handle, 'write_io_port_list');
    @n_select_cor_table_list := ImportFunction(handle, 'n_select_cor_table_list');
    @select_cor_table_list := ImportFunction(handle, 'select_cor_table_list');
    @n_set_wait := ImportFunction(handle, 'n_set_wait');
    @set_wait := ImportFunction(handle, 'set_wait');
    @n_simulate_ext_start := ImportFunction(handle, 'n_simulate_ext_start');
    @simulate_ext_start := ImportFunction(handle, 'simulate_ext_start');
    @n_write_da_x_list := ImportFunction(handle, 'n_write_da_x_list');
    @write_da_x_list := ImportFunction(handle, 'write_da_x_list');
    @n_set_pixel_line := ImportFunction(handle, 'n_set_pixel_line');
    @set_pixel_line := ImportFunction(handle, 'set_pixel_line');
    @n_set_pixel := ImportFunction(handle, 'n_set_pixel');
    @set_pixel := ImportFunction(handle, 'set_pixel');
    @n_set_extstartpos_list := ImportFunction(handle, 'n_set_extstartpos_list');
    @set_extstartpos_list := ImportFunction(handle, 'set_extstartpos_list');
    @n_laser_signal_on_list := ImportFunction(handle, 'n_laser_signal_on_list');
    @laser_signal_on_list := ImportFunction(handle, 'laser_signal_on_list');
    @n_laser_signal_off_list := ImportFunction(handle, 'n_laser_signal_off_list');
    @laser_signal_off_list := ImportFunction(handle, 'laser_signal_off_list');
    @n_set_firstpulse_killer_list := ImportFunction(handle, 'n_set_firstpulse_killer_list');
    @set_firstpulse_killer_list := ImportFunction(handle, 'set_firstpulse_killer_list');
    @n_set_io_cond_list := ImportFunction(handle, 'n_set_io_cond_list');
    @set_io_cond_list := ImportFunction(handle, 'set_io_cond_list');
    @n_clear_io_cond_list := ImportFunction(handle, 'n_clear_io_cond_list');
    @clear_io_cond_list := ImportFunction(handle, 'clear_io_cond_list');
    @n_list_jump_cond := ImportFunction(handle, 'n_list_jump_cond');
    @list_jump_cond := ImportFunction(handle, 'list_jump_cond');
    @n_list_call_cond := ImportFunction(handle, 'n_list_call_cond');
    @list_call_cond := ImportFunction(handle, 'list_call_cond');
    @n_get_input_pointer := ImportFunction(handle, 'n_get_input_pointer');
    @get_input_pointer := ImportFunction(handle, 'get_input_pointer');
    @rtc4_max_cards := ImportFunction(handle, 'rtc4_max_cards');
    @n_get_status := ImportFunction(handle, 'n_get_status');
    @get_status := ImportFunction(handle, 'get_status');
    @n_read_status := ImportFunction(handle, 'n_read_status');
    @read_status := ImportFunction(handle, 'read_status');
    @n_get_startstop_info := ImportFunction(handle, 'n_get_startstop_info');
    @get_startstop_info := ImportFunction(handle, 'get_startstop_info');
    @n_get_marking_info := ImportFunction(handle, 'n_get_marking_info');
    @get_marking_info := ImportFunction(handle, 'get_marking_info');
    @get_dll_version := ImportFunction(handle, 'get_dll_version');
    @n_set_start_list_1 := ImportFunction(handle, 'n_set_start_list_1');
    @set_start_list_1 := ImportFunction(handle, 'set_start_list_1');
    @n_set_start_list_2 := ImportFunction(handle, 'n_set_start_list_2');
    @set_start_list_2 := ImportFunction(handle, 'set_start_list_2');
    @n_set_start_list := ImportFunction(handle, 'n_set_start_list');
    @set_start_list := ImportFunction(handle, 'set_start_list');
    @n_execute_list_1 := ImportFunction(handle, 'n_execute_list_1');
    @execute_list_1 := ImportFunction(handle, 'execute_list_1');
    @n_execute_list_2 := ImportFunction(handle, 'n_execute_list_2');
    @execute_list_2 := ImportFunction(handle, 'execute_list_2');
    @n_execute_list := ImportFunction(handle, 'n_execute_list');
    @execute_list := ImportFunction(handle, 'execute_list');
    @n_write_8bit_port := ImportFunction(handle, 'n_write_8bit_port');
    @write_8bit_port := ImportFunction(handle, 'write_8bit_port');
    @n_write_io_port := ImportFunction(handle, 'n_write_io_port');
    @write_io_port := ImportFunction(handle, 'write_io_port');
    @n_eth_status := ImportFunction(handle, 'n_eth_status');
    @eth_status := ImportFunction(handle, 'eth_status');
    @n_auto_change := ImportFunction(handle, 'n_auto_change');
    @auto_change := ImportFunction(handle, 'auto_change');
    @n_auto_change_pos := ImportFunction(handle, 'n_auto_change_pos');
    @auto_change_pos := ImportFunction(handle, 'auto_change_pos');
    @aut_change := ImportFunction(handle, 'aut_change');
    @n_start_loop := ImportFunction(handle, 'n_start_loop');
    @start_loop := ImportFunction(handle, 'start_loop');
    @n_quit_loop := ImportFunction(handle, 'n_quit_loop');
    @quit_loop := ImportFunction(handle, 'quit_loop');
    @n_stop_execution := ImportFunction(handle, 'n_stop_execution');
    @stop_execution := ImportFunction(handle, 'stop_execution');
    @n_read_io_port := ImportFunction(handle, 'n_read_io_port');
    @read_io_port := ImportFunction(handle, 'read_io_port');
    @n_write_da_1 := ImportFunction(handle, 'n_write_da_1');
    @write_da_1 := ImportFunction(handle, 'write_da_1');
    @n_write_da_2 := ImportFunction(handle, 'n_write_da_2');
    @write_da_2 := ImportFunction(handle, 'write_da_2');
    @n_set_max_counts := ImportFunction(handle, 'n_set_max_counts');
    @set_max_counts := ImportFunction(handle, 'set_max_counts');
    @n_get_counts := ImportFunction(handle, 'n_get_counts');
    @get_counts := ImportFunction(handle, 'get_counts');
    @n_set_matrix := ImportFunction(handle, 'n_set_matrix');
    @set_matrix := ImportFunction(handle, 'set_matrix');
    @n_set_offset := ImportFunction(handle, 'n_set_offset');
    @set_offset := ImportFunction(handle, 'set_offset');
    @n_goto_xyz := ImportFunction(handle, 'n_goto_xyz');
    @goto_xyz := ImportFunction(handle, 'goto_xyz');
    @n_goto_xy := ImportFunction(handle, 'n_goto_xy');
    @goto_xy := ImportFunction(handle, 'goto_xy');
    @n_get_hex_version := ImportFunction(handle, 'n_get_hex_version');
    @get_hex_version := ImportFunction(handle, 'get_hex_version');
    @n_disable_laser := ImportFunction(handle, 'n_disable_laser');
    @disable_laser := ImportFunction(handle, 'disable_laser');
    @n_enable_laser := ImportFunction(handle, 'n_enable_laser');
    @enable_laser := ImportFunction(handle, 'enable_laser');
    @n_stop_list := ImportFunction(handle, 'n_stop_list');
    @stop_list := ImportFunction(handle, 'stop_list');
    @n_restart_list := ImportFunction(handle, 'n_restart_list');
    @restart_list := ImportFunction(handle, 'restart_list');
    @n_get_xyz_pos := ImportFunction(handle, 'n_get_xyz_pos');
    @get_xyz_pos := ImportFunction(handle, 'get_xyz_pos');
    @n_get_xy_pos := ImportFunction(handle, 'n_get_xy_pos');
    @get_xy_pos := ImportFunction(handle, 'get_xy_pos');
    @n_select_list := ImportFunction(handle, 'n_select_list');
    @select_list := ImportFunction(handle, 'select_list');
    @n_z_out := ImportFunction(handle, 'n_z_out');
    @z_out := ImportFunction(handle, 'z_out');
    @n_set_firstpulse_killer := ImportFunction(handle, 'n_set_firstpulse_killer');
    @set_firstpulse_killer := ImportFunction(handle, 'set_firstpulse_killer');
    @n_set_standby := ImportFunction(handle, 'n_set_standby');
    @set_standby := ImportFunction(handle, 'set_standby');
    @n_laser_signal_on := ImportFunction(handle, 'n_laser_signal_on');
    @laser_signal_on := ImportFunction(handle, 'laser_signal_on');
    @n_laser_signal_off := ImportFunction(handle, 'n_laser_signal_off');
    @laser_signal_off := ImportFunction(handle, 'laser_signal_off');
    @n_set_delay_mode := ImportFunction(handle, 'n_set_delay_mode');
    @set_delay_mode := ImportFunction(handle, 'set_delay_mode');
    @n_set_piso_control := ImportFunction(handle, 'n_set_piso_control');
    @set_piso_control := ImportFunction(handle, 'set_piso_control');
    @n_select_status := ImportFunction(handle, 'n_select_status');
    @select_status := ImportFunction(handle, 'select_status');
    @n_get_encoder := ImportFunction(handle, 'n_get_encoder');
    @get_encoder := ImportFunction(handle, 'get_encoder');
    @n_select_cor_table := ImportFunction(handle, 'n_select_cor_table');
    @select_cor_table := ImportFunction(handle, 'select_cor_table');
    @n_execute_at_pointer := ImportFunction(handle, 'n_execute_at_pointer');
    @execute_at_pointer := ImportFunction(handle, 'execute_at_pointer');
    @n_get_head_status := ImportFunction(handle, 'n_get_head_status');
    @get_head_status := ImportFunction(handle, 'get_head_status');
    @n_simulate_encoder := ImportFunction(handle, 'n_simulate_encoder');
    @simulate_encoder := ImportFunction(handle, 'simulate_encoder');
    @n_release_wait := ImportFunction(handle, 'n_release_wait');
    @release_wait := ImportFunction(handle, 'release_wait');
    @n_get_wait_status := ImportFunction(handle, 'n_get_wait_status');
    @get_wait_status := ImportFunction(handle, 'get_wait_status');
    @n_set_laser_mode := ImportFunction(handle, 'n_set_laser_mode');
    @set_laser_mode := ImportFunction(handle, 'set_laser_mode');
    @n_set_ext_start_delay := ImportFunction(handle, 'n_set_ext_start_delay');
    @set_ext_start_delay := ImportFunction(handle, 'set_ext_start_delay');
    @n_home_position := ImportFunction(handle, 'n_home_position');
    @home_position := ImportFunction(handle, 'home_position');
    @n_set_rot_center := ImportFunction(handle, 'n_set_rot_center');
    @set_rot_center := ImportFunction(handle, 'set_rot_center');
    @n_dsp_start := ImportFunction(handle, 'n_dsp_start');
    @dsp_start := ImportFunction(handle, 'dsp_start');
    @n_write_da_x := ImportFunction(handle, 'n_write_da_x');
    @write_da_x := ImportFunction(handle, 'write_da_x');
    @n_read_ad_x := ImportFunction(handle, 'n_read_ad_x');
    @read_ad_x := ImportFunction(handle, 'read_ad_x');
    @n_read_pixel_ad := ImportFunction(handle, 'n_read_pixel_ad');
    @read_pixel_ad := ImportFunction(handle, 'read_pixel_ad');
    @n_get_z_distance := ImportFunction(handle, 'n_get_z_distance');
    @get_z_distance := ImportFunction(handle, 'get_z_distance');
    @n_get_io_status := ImportFunction(handle, 'n_get_io_status');
    @get_io_status := ImportFunction(handle, 'get_io_status');
    @load_cor := ImportFunction(handle, 'load_cor');
    @load_pro := ImportFunction(handle, 'load_pro');
    @n_get_serial_number := ImportFunction(handle, 'n_get_serial_number');
    @get_serial_number := ImportFunction(handle, 'get_serial_number');
    @n_get_serial_number_32 := ImportFunction(handle, 'n_get_serial_number_32');
    @get_serial_number_32 := ImportFunction(handle, 'get_serial_number_32');
    @n_get_rtc_version := ImportFunction(handle, 'n_get_rtc_version');
    @get_rtc_version := ImportFunction(handle, 'get_rtc_version');
    @n_auto_cal := ImportFunction(handle, 'n_auto_cal');
    @auto_cal := ImportFunction(handle, 'auto_cal');
    @n_set_hi := ImportFunction(handle, 'n_set_hi');
    @set_hi := ImportFunction(handle, 'set_hi');
    @n_set_list_mode := ImportFunction(handle, 'n_set_list_mode');
    @set_list_mode := ImportFunction(handle, 'set_list_mode');
    @n_get_list_space := ImportFunction(handle, 'n_get_list_space');
    @get_list_space := ImportFunction(handle, 'get_list_space');
    @n_save_and_restart_timer := ImportFunction(handle, 'n_save_and_restart_timer');
    @save_and_restart_timer := ImportFunction(handle, 'save_and_restart_timer');
    @n_set_ext_start_delay_list := ImportFunction(handle, 'n_set_ext_start_delay_list');
    @set_ext_start_delay_list := ImportFunction(handle, 'set_ext_start_delay_list');
    @n_get_time := ImportFunction(handle, 'n_get_time');
    @get_time := ImportFunction(handle, 'get_time');
    @get_hi_data := ImportFunction(handle, 'get_hi_data');
    @teachin := ImportFunction(handle, 'teachin');
    @getmemory := ImportFunction(handle, 'getmemory');
    @set_timeout := ImportFunction(handle, 'set_timeout');
    @set_timeouts := ImportFunction(handle, 'set_timeouts');
    @get_timeouts := ImportFunction(handle, 'get_timeouts');
    @rs232_config := ImportFunction(handle, 'rs232_config');
    @n_rs232_config := ImportFunction(handle, 'n_rs232_config');
    @rs232_write_data := ImportFunction(handle, 'rs232_write_data');
    @n_rs232_write_data := ImportFunction(handle, 'n_rs232_write_data');
    @rs232_write_text := ImportFunction(handle, 'rs232_write_text');
    @n_rs232_write_text := ImportFunction(handle, 'n_rs232_write_text');
    @rs232_read_data := ImportFunction(handle, 'rs232_read_data');
    @n_rs232_read_data := ImportFunction(handle, 'n_rs232_read_data');
    @n_eth_set_com_timeouts_auto := ImportFunction(handle, 'n_eth_set_com_timeouts_auto');
    @eth_set_com_timeouts_auto := ImportFunction(handle, 'eth_set_com_timeouts_auto');
    @n_eth_get_com_timeouts_auto := ImportFunction(handle, 'n_eth_get_com_timeouts_auto');
    @eth_get_com_timeouts_auto := ImportFunction(handle, 'eth_get_com_timeouts_auto');
    @n_eth_watchdog_timer_config := ImportFunction(handle, 'n_eth_watchdog_timer_config');
    @eth_watchdog_timer_config := ImportFunction(handle, 'eth_watchdog_timer_config');
    @n_eth_watchdog_timer_reset := ImportFunction(handle, 'n_eth_watchdog_timer_reset');
    @eth_watchdog_timer_reset := ImportFunction(handle, 'eth_watchdog_timer_reset');
    @n_eth_link_loss_config := ImportFunction(handle, 'n_eth_link_loss_config');
    @eth_link_loss_config := ImportFunction(handle, 'eth_link_loss_config');
    @n_eth_get_last_error := ImportFunction(handle, 'n_eth_get_last_error');
    @eth_get_last_error := ImportFunction(handle, 'eth_get_last_error');
    @n_eth_get_error := ImportFunction(handle, 'n_eth_get_error');
    @eth_get_error := ImportFunction(handle, 'eth_get_error');
    @n_eth_error_dump := ImportFunction(handle, 'n_eth_error_dump');
    @eth_error_dump := ImportFunction(handle, 'eth_error_dump');
{$ENDREGION}
end;




end.