from cffi import FFI
ffibuilder = FFI()

# Provide the C source code and the header file
with open('RTC6expl.c') as f:
    ffibuilder.set_source('_rtc', f.read())

with open('RTC6expl.h') as f:
    ffibuilder.cdef(f.read())

if __name__ == "__main__":
    ffibuilder.compile(verbose=True)
