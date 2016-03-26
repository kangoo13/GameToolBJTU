//
// snake_sfml.hh for  in /home/kbidi_j/Dropbox/Nibbler/sfml
//
// Made by jeremy
// Login   <kbidi_j@epitech.net>
//
// Started on  Sat Mar 29 21:33:38 2014 jeremy
// Last update Wed Apr  2 15:22:47 2014 le bourblanc alexandre
//

#ifndef _SNAKE_SFML_H_
# define _SNAKE_SFML_H_

#include	"IAPI.hh"
#include	<SFML/Graphics.hpp>
#include	<SFML/Window.hpp>
#include	<SFML/System.hpp>
#include	<algorithm>
#include	<sstream>

using namespace sf;

class		snake_sfml : public	IAPI
{
private:
  RenderWindow		*window;
  RenderWindow		*win_scrore;
  Texture               img;
  Sprite		sprite;
  CircleShape		*snake;
  CircleShape		food;
  RectangleShape	*map;
  int			saveqx;
  int			saveqy;
  std::string			score;
  CircleShape		bonus;
  std::vector<CircleShape *>	list_snake;
public:
  snake_sfml();
  ~snake_sfml();
  std::string const  init_scene(int x, int y);
  void  display_snake(int x, int y);
  void  display_food(int x, int y, int oldx, int oldy);
  void  display_move(int x, int y, int oldx, int oldy);
  void  display_score(int score);
  void	display_bonus(int, int, int, int);
  void  game_over() const;
  int	get_event() const;
};

#endif /*!_SNAKE_SFML_H_*/
