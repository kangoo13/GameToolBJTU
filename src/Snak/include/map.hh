/*
** map.h for  in /home/kbidi_j/Dropbox/Nibbler/include
**
** Made by jeremy
** Login   <kbidi_j@epitech.net>
**
** Started on  Tue Mar 18 12:22:19 2014 jeremy
// Last update Tue Mar 18 15:56:01 2014 jeremy
*/

#ifndef _MAP_H_
# define _MAP_H_

#include <iostream>
#include <vector>
#include <iterator>
#include "case.hh"

class Map
{
private:
  int	size_x;
  int	size_y;
  std::vector<Case *>	map;
public:
  Map(int, int);
  ~Map();
  void			InitVector();
  std::vector<Case *>	getMap() const;
  int			getSize_x() const;
  int			getSize_y() const;
};

#endif /*!_MAP_H_*/
