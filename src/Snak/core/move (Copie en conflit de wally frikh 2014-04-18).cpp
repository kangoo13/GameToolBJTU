//
// move.cpp for nibbler-move in /home/lebour_a/Dropbox/Nibbler/corps
//
// Made by le bourblanc alexandre
// Login   <lebour_a@epitech.net>
//
// Started on  Tue Mar 18 21:21:31 2014 le bourblanc alexandre
// Last update Wed Mar 19 16:39:35 2014 le bourblanc alexandre
//

#include	"corps.hh"

void            Nibbler::move_left()
{
  std::cout << "left" << std::endl;
  for (unsigned int i = 0; i < this->snake.size(); i++)
    {
      this->snake[i]->setPosX(this->snake[i]->getPosX() - 1);
      std::cout << "X ==== " << this->snake[i]->getPosX();
      std::cout << "  Y ==== " << this->snake[i]->getPosY() << std::endl;
    }
}

void            Nibbler::move_right()
{
  std::cout << "right" << std::endl;
  for (unsigned int i = 0; i < this->snake.size(); i++)
    {
      this->snake[i]->setPosX(this->snake[i]->getPosX() + 1);
      std::cout << "X ==== " << this->snake[i]->getPosX();
      std::cout << "  Y ==== " << this->snake[i]->getPosY() << std::endl;
    }
}

void            Nibbler::move_top()
{
  static	unsigned int stat = 0;
  int		flag;

  flag = 0;
  std::cout << "top" << std::endl;
  if (this->flag_play == 1)
    {
      for (unsigned int j = 0; j <= stat + 1; j++)
	{
	  this->snake[j]->setPosY(this->snake[j]->getPosY() - 1);
	  this->snake[j]->setPosX(this->snake[j]->getPosX());
	  flag++;
	}
      if (this->old_direction == 'l' && flag != 0)
	{
	  for (unsigned int j = flag; j < this->snake.size(); j++)
	    this->snake[j]->setPosX(this->snake[j]->getPosX() - 1);
	}
      else if (this->old_direction == 'r' && flag != 0)
	{
	  for (unsigned int j = flag; j < this->snake.size(); j++)
	    this->snake[j]->setPosX(this->snake[j]->getPosX() + 1);
	}
      stat++;
      if (stat == this->snake.size())
	stat = 0;
    }
  else
    {
      for (unsigned int i = 0; i < this->snake.size(); i++)
	this->snake[i]->setPosY(this->snake[i]->getPosY() - 1);
    }
}

void            Nibbler::move_down()
{
  static	unsigned int stat = 0;
  int		flag;

  flag = 0;
  std::cout << "down" << std::endl;
  if (this->flag_play == 1)
    {
      for (unsigned int j = 0; j <= stat + 1; j++)
        {
          this->snake[j]->setPosY(this->snake[j]->getPosY() + 1);
          this->snake[j]->setPosX(this->snake[j]->getPosX());
          flag++;
        }
      if (this->old_direction == 'l' && flag != 0)
        {
          for (unsigned int j = flag; j < this->snake.size(); j++)
            this->snake[j]->setPosX(this->snake[j]->getPosX() - 1);
        }
      else if (this->old_direction == 'r' && flag != 0)
        {
          for (unsigned int j = flag; j < this->snake.size(); j++)
            this->snake[j]->setPosX(this->snake[j]->getPosX() + 1);
        }
      stat++;
      if (stat == this->snake.size())
        stat = 0;
    }
  else
    {
      for (unsigned int i = 0; i < this->snake.size(); i++)
	this->snake[i]->setPosY(this->snake[i]->getPosY() + 1);
    }
}

void            Nibbler::move()
{
  if (this->direction == 'l')
    move_left();
  else if (this->direction == 'r')
    move_right();
  else if (this->direction == 'u')
    move_top();
  else if (this->direction == 'd')
    move_down();
}
