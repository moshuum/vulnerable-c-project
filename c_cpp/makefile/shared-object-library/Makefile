CC=g++

all: main

main:
	mkdir -p build
	$(CC) -o build/$@ src/main.cpp -Llib -lpthread -lsqlite3

clean:
	rm -rf project/build
