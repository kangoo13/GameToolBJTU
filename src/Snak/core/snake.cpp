//
// snake.cpp for nibbler-snake in /home/lebour_a/Dropbox/Nibbler/corps
//
// Made by le bourblanc alexandre
// Login   <lebour_a@epitech.net>
//
// Started on  Tue Mar 18 14:59:09 2014 le bourblanc alexandre
// Last update Tue Mar 18 20:24:09 2014 le bourblanc alexandre
//

#include	"corps.hh"

Snake::Snake(int x, int y) : posX(x), posY(y)
{

}

Snake::~Snake()
{

}

int		Snake::getPosX() const
{
  return (this->posX);
}

int		Snake::getPosY() const
{
  return (this->posY);
}

void		Snake::setPosX(int x)
{
  this->posX = x;
}

void		Snake::setPosY(int y)
{
  this->posY = y;
}
