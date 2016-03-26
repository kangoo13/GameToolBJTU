//
// move_perso.cpp for move_perso.cpp in /home/lebour_a/Dropbox/Nibbler/corps
//
// Made by le bourblanc alexandre
// Login   <lebour_a@epitech.net>
//
// Started on  Wed Mar 19 10:32:22 2014 le bourblanc alexandre
// Last update Wed Mar 19 13:40:54 2014 le bourblanc alexandre
//

#include	"corps.hh"

void            Nibbler::move_perso_left()
{
  std::cout << "perso_left" << std::endl;
  for (unsigned int i = 0; i < this->snake.size(); i++)
    {
      this->snake[i]->setPosX(this->snake[i]->getPosX() - 1);
    }
  this->old_direction = 'l';
  this->flag_play = 1;
}

void            Nibbler::move_perso_right()
{
  std::cout << "perso_right" << std::endl;
  for (unsigned int i = 0; i < this->snake.size(); i++)
    {
      this->snake[i]->setPosX(this->snake[i]->getPosX() + 1);
    }
  this->old_direction = 'r';
  this->flag_play = 1;
}

void            Nibbler::move_perso_top()
{
  std::cout << "perso_top" << std::endl;
  for (unsigned int i = 0; i < this->snake.size(); i++)
    {
      if (i == 0)
	this->snake[i]->setPosY(this->snake[i]->getPosY() - 1);
      else
	{
	  if (this->old_direction == 'l')
	    this->snake[i]->setPosX(this->snake[i]->getPosX() - 1);
	  else if (this->old_direction == 'r')
	    this->snake[i]->setPosX(this->snake[i]->getPosX() + 1);
	}
    }
  this->flag_play = 1;
}

void            Nibbler::move_perso_down()
{
  std::cout << "perso_down" << std::endl;
  for (unsigned int i = 0; i < this->snake.size(); i++)
    {
      if (i == 0)
	this->snake[i]->setPosY(this->snake[i]->getPosY() + 1);
      else
	{
	  if (this->old_direction == 'l')
	    this->snake[i]->setPosX(this->snake[i]->getPosX() + 1);
	  else if (this->old_direction == 'r')
	    this->snake[i]->setPosX(this->snake[i]->getPosX() - 1);
	}
    }
  this->flag_play = 1;
}

void            Nibbler::move_perso()
{
  if (this->direction == 'l')
    move_perso_left();
  else if (this->direction == 'r')
    move_perso_right();
  else if (this->direction == 'u')
    move_perso_top();
  else if (this->direction == 'd')
    move_perso_down();
}
