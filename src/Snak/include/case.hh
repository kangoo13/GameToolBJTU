//
// case.hh for  in /home/kbidi_j/Dropbox/Nibbler/include
//
// Made by jeremy
// Login   <kbidi_j@epitech.net>
//
// Started on  Tue Mar 18 13:38:29 2014 jeremy
// Last update Tue Mar 18 15:23:02 2014 jeremy
//


#ifndef _CASE_H_
# define _CASE_H_

#include <iostream>

class Case
{
private:
  int   pos_x;
  int   pos_y;
  bool  food_;
  bool  snake_;
public:
  Case(int ,int );
  ~Case();
  void  setFood(bool );
  void  setSnake(bool );
  int   getPosX() const;
  int   getPosY() const;
  bool	getFood();
  bool	getSnake();
};

#endif /*!_CASE_H_*/
