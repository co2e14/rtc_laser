from cffi import FFI
ffi = FFI()

with open('RTC6expl.h') as f:
    ffi.cdef(f.read())

C = ffi.dlopen('librtc6.so.38.0.1')  # Or whatever your .so file is named

# You can now use your C functions from Python like this:
C.RTC6open()