//
// IAPI.hh for nibbler-iapi in /home/lebour_a/Dropbox/Nibbler/include
//
// Made by le bourblanc alexandre
// Login   <lebour_a@epitech.net>
//
// Started on  Tue Mar 18 09:37:31 2014 le bourblanc alexandre
// Last update Wed Apr  2 13:39:03 2014 le bourblanc alexandre
//

#ifndef _IAPI_HH_
# define _IAPI_HH_

# include	<iostream>
# include       <SDL2/SDL.h>
# include       <SDL2/SDL_image.h>
//# include       <GL/gl.h>
//# include       <GL/glu.h>

class		IAPI
{
public:
  IAPI() {};
  virtual std::string const init_scene(int x, int y) = 0;
  virtual void	display_snake(int x, int y) = 0;
  virtual void  display_food(int x, int y, int oldx, int oldy) = 0;
  virtual void	display_move(int x, int y, int oldx, int oldy) = 0;
  virtual void	display_score(int score) = 0;
  virtual void  display_bonus(int x, int y, int oldx, int oldy) = 0;
  virtual void	game_over() const = 0;
  virtual int	get_event() const = 0;
  ~IAPI ();
};

#endif /*!_IAPI_HH_*/
