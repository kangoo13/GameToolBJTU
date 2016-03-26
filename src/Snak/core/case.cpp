//
// case.cpp for * in /home/kbidi_j/Dropbox/Nibbler/corps
//
// Made by jeremy
// Login   <kbidi_j@epitech.net>
//
// Started on  Tue Mar 18 13:48:50 2014 jeremy
// Last update Tue Mar 18 15:22:54 2014 jeremy
//


#include "case.hh"

Case::Case(int x, int y) : pos_x(x), pos_y(y), food_(false), snake_(false)
{

}

Case::~Case()
{

}

bool  Case::getFood()
{
  return this->food_;
}

bool  Case::getSnake()
{
  return this->snake_;
}

void	Case::setFood(bool food)
{
  this->food_ = food;
}

void	Case::setSnake(bool snake)
{
  this->snake_ = snake;
}

int	Case::getPosX() const
{
  return this->pos_x;
}

int	Case::getPosY() const
{
  return this->pos_y;
}
