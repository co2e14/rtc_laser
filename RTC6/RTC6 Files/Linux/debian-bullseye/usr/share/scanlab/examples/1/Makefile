CXX = g++

all: runtest

LDFLAGS = -lrtc6 -lpthread

clean:
	rm -f example

librtc6.so: $(OBJs)
	$(CXX) $(SOFLAGS) -o $@ $(OBJs)

runtest: example
	./example

example: example.c
	$(CXX) example.c -o example $(LDFLAGS)
