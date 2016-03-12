# Makefile for the socket programming example
#

SRC_server = server.c
SRC_client = client.c

all : simple_server simple_client

simple_server: $(SRC_server)
	gcc -o server $(SRC_server)


simple_client: $(SRC_client)
	gcc -o client $(SRC_client)

clean:
	rm -f *.o server client