##
## Makefile for nibbler in /home/lebour_a/rendu/cpp_nibbler
## 
## Made by le bourblanc alexandre
## Login   <lebour_a@epitech.net>
## 
## Started on  Mon Mar 17 19:49:48 2014 le bourblanc alexandre
## Last update Sun Apr  6 17:38:57 2014 jeremy
##

NAME_NIBBLER    =       nibbler

SRC_EXE         =       core/main.cpp		\
			core/tools_launcher.cpp\
			core/xfunctions.cpp	\
			core/snake.cpp		\
			core/nibbler.cpp		\
			core/map.cpp		\
			core/case.cpp		\
			core/move.cpp		\
			core/get_direction.cpp	\
			core/food.cpp		\
			core/score.cpp		\

OBJ_EXE         =       $(SRC_EXE:.cpp=.o)

NAME_LIB        =       lib_nibbler_ncurse.so
SRC_LIB         =       ncurse/ncurse.cpp	\
			corps/map.cpp		\
			corps/case.cpp
OBJ_LIB         =       $(SRC_LIB:.cpp=.o)

NAME_LIB2       =       lib_nibbler_opengl.so
SRC_LIB2        =       opengl/opengl.cpp	\
			opengl/cube.cpp

OBJ_LIB2        =       $(SRC_LIB2:.cpp=.o)

NAME_LIB3       =       lib_nibbler_sfml.so
SRC_LIB3        =       sfml/sfml.cpp

OBJ_LIB3        =       $(SRC_LIB3:.cpp=.o)

CPPFLAGS        +=      -W -Wall -Wextra -fPIC -I include/
CC               =       clang++

all             :       $(NAME_LIB3) $(NAME_NIBBLER)

$(NAME_NIBBLER) :       $(OBJ_EXE)
			clang++ -o $(NAME_NIBBLER) $(OBJ_EXE) $(CPPFLAGS) -ldl

##$(NAME_LIB)     :       $(OBJ_LIB)
##			$(CC) -shared -o $(NAME_LIB) $(OBJ_LIB) $(CPPFLAGS) -lncurses

##$(NAME_LIB2)    :       $(OBJ_LIB2)
	##		$(CC) -shared -o $(NAME_LIB2) $(OBJ_LIB2) -L/usr/local/lib -lSDL -lGL -lGLU -lglu32 -lglu32 -onpengl32

$(NAME_LIB3)    :       $(OBJ_LIB3)
			clang++ -shared -o $(NAME_LIB3) $(OBJ_LIB3) -framework sfml-graphics -framework sfml-window -framework sfml-system

clean           :
			rm -f $(OBJ_LIB)
			rm -f $(OBJ_EXE)  $(OBJ_LIB2) $(OBJ_LIB3)

fclean          :       clean
			rm -f $(NAME_NIBBLER)
			rm -f $(NAME_LIB) $(NAME_LIB2) $(NAME_LIB3)

re              :       fclean all

.PHONY		:	re fclean all clean
