//
// corps.hh for nibbler in /home/lebour_a/Dropbox/Nibbler/include
//
// Made by le bourblanc alexandre
// Login   <lebour_a@epitech.net>
//
// Started on  Tue Mar 18 09:27:50 2014 le bourblanc alexandre
// Last update Wed Mar 19 13:05:03 2014 le bourblanc alexandre
//

#ifndef _CORPS_HH_
# define _CORPS_HH_

# include	<iostream>
# include	<dlfcn.h>
# include	<cstdlib>
# include	<string>
# include	<vector>
# include	<ctime>
# include	"my_exception.hpp"
# include	"IAPI.hh"
# include	"map.hh"

typedef	enum
  {
    RIGHT,
    LEFT,
    ESCAPE
  } e_event;

class		Snake
{
private:
  int		posX;
  int		posY;
  bool		head;
public:
  Snake(int x, int y);
  ~Snake();
  int		getPosX() const;
  int		getPosY() const;
  void		setPosY(int y);
  void		setPosX(int x);
};

class		Nibbler
{
private:
  int		width;
  int		height;
  Map		*map;
  IAPI		*api;
  int		score;
  int		flag_play;
  char		direction;
  char		old_direction;
  std::vector<Snake *> snake;
public:
  Nibbler(int x, int y, IAPI *api);
  ~Nibbler();
  // Nibbler(const Nibbler &);
  // Nibbler	&operator=(const Nibbler &);
  void	loop();
  void	putFood();
  void	initNibbler();
  bool	collision();

  /* ------------ MOVE -----------*/
  void	move();
  void	move_left();
  void	move_right();
  void	move_top();
  void	move_down();
  void	move_perso();
  void	move_perso_left();
  void	move_perso_right();
  void	move_perso_top();
  void	move_perso_down();

  /* --------- DIRECTION ------*/
  void	getDirection(e_event event);
  void	getDirection_right();
  void	getDirection_left();

  /* ------ AUTRE ----- */
  void	print();
};

void		*xdlopen(const char *filename, int flag);
void		*xdlsym(void *handle, const char *symbol);
int		xdlclose(void *handle);

#endif /*!_CORPS_HH_*/
