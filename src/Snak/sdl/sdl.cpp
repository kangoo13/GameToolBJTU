//
// sdl.cpp for nibbler-sdl in /home/lebour_a/rendu/cpp_nibbler/sdl
//
// Made by le bourblanc alexandre
// Login   <lebour_a@epitech.net>
//
// Started on  Mon Mar 17 19:55:57 2014 le bourblanc alexandre
// Last update Tue Mar 18 10:59:18 2014 le bourblanc alexandre
//

# include	"snake_sdl.hh"

extern	"C"
{
  IAPI	*create_api()
  {
    return new snake_sdl();
  }
}

snake_sdl::snake_sdl()
{
  std::cout << "sdl" << std::endl;
}

snake_sdl::~snake_sdl()
{
}
