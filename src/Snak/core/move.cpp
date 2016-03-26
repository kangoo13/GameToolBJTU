//
// move.cpp for nibbler-move in /home/lebour_a/Dropbox/Nibbler/corps
//
// Made by le bourblanc alexandre
// Login   <lebour_a@epitech.net>
//
// Started on  Tue Mar 18 21:21:31 2014 le bourblanc alexandre
// Last update Tue Apr  1 13:04:41 2014 le bourblanc alexandre
//

#include	"corps.hh"

void		Nibbler::move_left()
{
  int		tmpx;
  int		tmpy;
  int		oldx;
  int		oldy;

  oldx = this->snake[0]->getPosX();
  oldy = this->snake[0]->getPosY();
  this->snake[0]->setPosX(this->snake[0]->getPosX() - 1);
  this->api->display_move(this->snake[0]->getPosX(), this->snake[0]->getPosY(), oldx, oldy);
  for (unsigned int i = 1; i < this->snake.size(); i++)
    {
      tmpx = this->snake[i]->getPosX();
      tmpy = this->snake[i]->getPosY();
      this->snake[i]->setPosX(oldx);
      this->snake[i]->setPosY(oldy);
      oldx = tmpx;
      oldy = tmpy;
      this->api->display_move(this->snake[i]->getPosX(), this->snake[i]->getPosY(), oldx, oldy);
    }
}

void		Nibbler::move_right()
{
  int		tmpx;
  int		tmpy;
  int		oldx;
  int		oldy;

  oldx = this->snake[0]->getPosX();
  oldy = this->snake[0]->getPosY();
  this->snake[0]->setPosX(this->snake[0]->getPosX() + 1);
  this->api->display_move(this->snake[0]->getPosX(), this->snake[0]->getPosY(), oldx, oldy);
  for (unsigned int i = 1; i < this->snake.size(); i++)
    {
      tmpx = this->snake[i]->getPosX();
      tmpy = this->snake[i]->getPosY();
      this->snake[i]->setPosX(oldx);
      this->snake[i]->setPosY(oldy);
      oldx = tmpx;
      oldy = tmpy;
      this->api->display_move(this->snake[i]->getPosX(), this->snake[i]->getPosY(), oldx, oldy);
    }
}

void		Nibbler::move_top()
{
  int		tmpx;
  int		tmpy;
  int		oldx;
  int		oldy;

  oldx = this->snake[0]->getPosX();
  oldy = this->snake[0]->getPosY();
  this->snake[0]->setPosY(this->snake[0]->getPosY() - 1);
  this->api->display_move(this->snake[0]->getPosX(), this->snake[0]->getPosY(), oldx, oldy);
  for (unsigned int i = 1; i < this->snake.size(); i++)
    {
      tmpx = this->snake[i]->getPosX();
      tmpy = this->snake[i]->getPosY();
      this->snake[i]->setPosX(oldx);
      this->snake[i]->setPosY(oldy);
      oldx = tmpx;
      oldy = tmpy;
      this->api->display_move(this->snake[i]->getPosX(), this->snake[i]->getPosY(), oldx, oldy);
    }
}

void		Nibbler::move_down()
{
  int		tmpx;
  int		tmpy;
  int		oldx;
  int		oldy;

  oldx = this->snake[0]->getPosX();
  oldy = this->snake[0]->getPosY();
  this->snake[0]->setPosY(this->snake[0]->getPosY() + 1);
  this->api->display_move(this->snake[0]->getPosX(), this->snake[0]->getPosY(), oldx, oldy);
  for (unsigned int i = 1; i < this->snake.size(); i++)
    {
      tmpx = this->snake[i]->getPosX();
      tmpy = this->snake[i]->getPosY();
      this->snake[i]->setPosX(oldx);
      this->snake[i]->setPosY(oldy);
      oldx = tmpx;
      oldy = tmpy;
      this->api->display_move(this->snake[i]->getPosX(), this->snake[i]->getPosY(), oldx, oldy);
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
