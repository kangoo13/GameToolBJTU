//
// nibbler.cpp for nibbler in /home/lebour_a/Dropbox/Nibbler/corps
//
// Made by le bourblanc alexandre
// Login   <lebour_a@epitech.net>
//
// Started on  Tue Mar 18 15:07:33 2014 le bourblanc alexandre
// Last update Sun Apr  6 16:21:10 2014 le bourblanc alexandre
//

#include	"corps.hh"
#include	<fstream>

Nibbler::Nibbler(int x, int y, IAPI *ap) : width(x), height(y), api(ap), score(0), direction('l'), foodx(0), foody(0), delay(0), bonusx(99), bonusy(99)
{
  this->map = new Map(this->width, this->height);
  this->name_api = this->api->init_scene(this->width, this->height);
  initNibbler();
  putFood();
}

Nibbler::~Nibbler()
{
  delete this->map;
}

void		Nibbler::initNibbler()
{
  for (unsigned int i = 0; i < 4; i++)
    {
      this->snake.push_back(new Snake((this->width / 2) + i, this->height/2));
      this->api->display_snake(this->snake[i]->getPosX(), this->snake[i]->getPosY());
    }
  this->foodx = this->snake[0]->getPosX() - 1;
  this->foody = this->snake[0]->getPosY();
}

bool		Nibbler::collision(int flag) const
{
  if ((snake[0]->getPosX() == 0 || snake[0]->getPosY() == 0)
      || (snake[0]->getPosX() == this->width - 1|| snake[0]->getPosY() == this->height - 2))
    {
      if (flag == 1)
	std::cout << "with a collision with wall !!";
      return true;
    }
  for (unsigned int i = 1; i < this->snake.size(); i++)
    {
      if ((snake[0]->getPosX() == snake[i]->getPosX())
	  && (snake[0]->getPosY() == snake[i]->getPosY()))
	{
	  if (flag == 1)
	    std::cout << "with a collision with a part of your snake !!";
	  return true;
	}
    }
  return false;
}

void		Nibbler::check_usleep(int score) const
{
  if (this->delay == 0)
    {
      if (score < 30)
	usleep(60000);
      else if (score < 100)
	usleep(40000);
      else if (score < 500)
	usleep(30000);
      else
	usleep(10000);
    }
  else
    usleep(20000);
}

int		Nibbler::check_event()
{
  int		c;

  c = this->api->get_event();
  if (c == 1)
    getDirection_left();
  else if (c == 2)
    getDirection_right();
  else if (c == 5)
    {
      this->delay = 1;
      return (5);
    }
  if (c == 3)
    return (1);
  return (0);
}

void		Nibbler::loop()
{
  int		i;
  int		j;
  int		exit_flag;
  int		tmp;

  exit_flag = 0;
  j = 0;
  i = 0;
  this->direction = 'l';
  // this->snake[0]->setPosX(1);
  // this->snake[0]->setPosY(1);
  while (!collision(0))
    {
      tmp = check_event();
      if (j == 20)
	putBonus(0);
      if (j == 60)
	{
	  putBonus(1);
	  j = 0;
	}
      if(tmp == 1)
	break;
      if (tmp == 5)
	i = 0;
      move();
      check_food();
      checkBonus();
      check_usleep(this->score);
      i++;
      j++;
      if (i == 20)
	this->delay = 0;
    }
  exit(exit_flag);
}
