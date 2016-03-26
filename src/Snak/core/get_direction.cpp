//
// get_direction.cpp for nibbler-direction in /home/lebour_a/Dropbox/Nibbler/corps
//
// Made by le bourblanc alexandre
// Login   <lebour_a@epitech.net>
//
// Started on  Tue Mar 18 21:23:56 2014 le bourblanc alexandre
// Last update Tue Apr  1 18:11:56 2014 le bourblanc alexandre
//

#include	"corps.hh"

void		Nibbler::getDirection_right()
{
  if (this->direction == 'l')
    this->direction = 'u';
  else if (direction == 'r')
    this->direction = 'd';
  else if (direction == 'd')
    this->direction = 'l';
  else
    this->direction = 'r';
}

void		Nibbler::getDirection_left()
{
  if (this->direction == 'l')
    this->direction = 'd';
  else if (this->direction == 'r')
    this->direction = 'u';
  else if (this->direction == 'd')
    this->direction = 'r';
  else
    this->direction = 'l';
}

void            Nibbler::getDirection(e_event   event)
{
  if (event == RIGHT)
    getDirection_right();
  else if (event == LEFT)
    getDirection_left();
}
