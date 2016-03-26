//
// main.cpp for nibbler-corps in /home/lebour_a/rendu/cpp_nibbler/corps
//
// Made by le bourblanc alexandre
// Login   <lebour_a@epitech.net>
//
// Started on  Mon Mar 17 19:56:42 2014 le bourblanc alexandre
// Last update Tue Mar 18 20:27:12 2014 le bourblanc alexandre
//

#include "corps.hh"

int		convert_to_string(char *str)
{
  std::istringstream iss;
  int		nb;

  iss.str(str);
  iss >> nb;
  return (nb);
}

int		check_param(char *str)
{
  int		nb;

  nb = convert_to_string(str);
  if (nb < 6 || nb > 250)
    throw my_exception("Size is not adapt with our programm sorry =)");
  return (nb - 1);
}

void		open_lib_graph(char *path, int width, int height)
{
  void		*dlhandle;
  IAPI		*api;
  IAPI*		(*external_creator)();
  Nibbler	*nibbler;

  dlhandle = xdlopen(path, RTLD_LAZY);
  external_creator = reinterpret_cast<IAPI* (*)()>(xdlsym(dlhandle, "create_api"));
  api = external_creator();
  nibbler = new Nibbler(width, height, api);
  nibbler->loop();
  xdlclose(dlhandle);
}

int main(int ac, char *av[])
{
  int	width;
  int	height;

  srand(time(NULL));
  try
    {
      if (ac != 4)
	throw my_exception("Usage: ./nibbler <height> <width> <lib_nibbler_name.so");
      width = check_param(av[2]);
      height = check_param(av[1]);
    }
  catch(const my_exception &e)
    {
      std::cerr << e.what() << std::endl;
      exit(1);
    }
  open_lib_graph(av[3], width, height);
  return (EXIT_SUCCESS);
}
