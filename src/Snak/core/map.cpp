//
// map.cpp for  in /home/kbidi_j/Dropbox/Nibbler/corps
//
// Made by jeremy
// Login   <kbidi_j@epitech.net>
//
// Started on  Tue Mar 18 12:46:31 2014 jeremy
// Last update Tue Mar 18 15:59:18 2014 jeremy
//

#include "map.hh"

Map::Map(int x, int y) : size_x(x), size_y(y)
{
  InitVector();
}

Map::~Map()
{
  std::vector<Case *>::iterator	it = this->map.begin();

  while (it != this->map.end())
    {
      delete *it;
      it++;
    }
}

void			Map::InitVector()
{
  int	y = 0;
  int	x;

  while (y <= this->size_y)
    {
      x = 0;
      while (x <= this->size_x)
	{
	  Case	*nc = new Case(x, y);
	  this->map.push_back(nc);
	  x++;
	}
      y++;
    }
}

std::vector<Case *>   Map::getMap() const
{
  return this->map;
}


int                   Map::getSize_x() const
{
  return this->size_x;
}

int                   Map::getSize_y() const
{
  return this->size_y;
}
