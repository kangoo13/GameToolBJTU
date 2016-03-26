//
// main.cpp for nibbler-corps in /home/lebour_a/rendu/cpp_nibbler/corps
//
// Made by le bourblanc alexandre
// Login   <lebour_a@epitech.net>
//
// Started on  Mon Mar 17 19:56:42 2014 le bourblanc alexandre
// Last update Tue Apr  1 20:33:29 2014 le bourblanc alexandre
//

#include	"corps.hh"
#include	"launcher.hh"

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

void		ask_param()
{
  std::string	path;
  std::string	res;
  int		width;
  int		height;

  path = "./lib_nibbler_";
  std::cout << "Hello and welcome in our beautiful game" << std::endl;
  std::cout << "What kind of libraries do you want : " << std::endl;
  std::cout << " - Lib ncurse classic but funny Press 1" << std::endl;
  std::cout << " - Lib sfml nice and easy Press 2" << std::endl;
  std::cout << " - Lib openGl 3D is ready ! Press 3" << std::endl;
  std::cin >> res;
  res = return_res(res);
  path += res;
  path += ".so";
  std::cout << "Now what do you want like width ? between 6 and 80" << std::endl;
  std::cin >> width;
  std::cout << "Now what do you want like height ? between 6 and 80" << std::endl;
  std::cin >> height;
  std::cout << "Good game :) " << std::endl;
  open_lib_graph(return_str(path), width, height);
}

int main(int ac, char *av[])
{
  int	width;
  int	height;

  srand(time(NULL));
  try
    {
      if (ac == 1)
	ask_param();
      else
	{
	  if (ac != 4)
	    throw my_exception("Usage: ./nibbler <height> <width> <lib_nibbler_name.so");
	  width = check_param(av[2]);
	  height = check_param(av[1]);
	  open_lib_graph(av[3], width, height);
	}
    }
  catch(const my_exception &e)
    {
      std::cerr << e.what() << std::endl;
      return (EXIT_FAILURE);
    }
  return (EXIT_SUCCESS);
}
