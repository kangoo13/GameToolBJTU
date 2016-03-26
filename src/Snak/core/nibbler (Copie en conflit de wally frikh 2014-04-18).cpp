//
// nibbler.cpp for nibbler in /home/lebour_a/Dropbox/Nibbler/corps
//
// Made by le bourblanc alexandre
// Login   <lebour_a@epitech.net>
//
// Started on  Tue Mar 18 15:07:33 2014 le bourblanc alexandre
// Last update Wed Mar 19 18:46:51 2014 le bourblanc alexandre
//

#include	"corps.hh"

Nibbler::Nibbler(int x, int y, IAPI *ap) : width(x), height(y), api(ap), score(0), direction('l')
{
  this->map = new Map(this->width, this->height);
  this->flag_play = 0;
  initNibbler();
  putFood();
}

Nibbler::~Nibbler()
{
}

void		Nibbler::initNibbler()
{
  for (unsigned int i = 0; i < 4; i++)
    this->snake.push_back(new Snake((this->width / 2) + i, this->height/2));
}

void		Nibbler::putFood()
{
  int		food_randx;
  int		food_randy;

  food_randx = rand() % this->width + 1;
  food_randy = rand() % this->height + 1;
  for (unsigned	int i = 0; i < this->snake.size(); i++)
    {
      if (snake[i]->getPosX() == food_randx && snake[i]->getPosY() == food_randy)
	continue;
    }
  this->map->getMap()[food_randx + food_randy]->setFood(true);
}

void		Nibbler::print()
{
  std::cout << "print" << std::endl;
  for (unsigned int i = 0; i < this->snake.size(); i++)
    {
      std::cout << "X ==== " << this->snake[i]->getPosX();
      std::cout << "  Y ==== " << this->snake[i]->getPosY() << std::endl;
    }
}

bool		Nibbler::collision()
{
  if ((snake[0]->getPosX() == 0 || snake[0]->getPosY() == 0)
      || (snake[0]->getPosX() == this->width || snake[0]->getPosY() == this->height))
    return true;
  for (unsigned int i = 1; i < this->snake.size(); i++)
    {
      if ((snake[0]->getPosX() == snake[i]->getPosX())
	  && (snake[0]->getPosY() == snake[i]->getPosY()))
	return true;
    }
  return false;
}

void		Nibbler::loop()
{
  bool		cond;

  cond = false;
  cond = cond;
  print();
  this->old_direction = 'l';
  this->direction = 'l';
  getDirection_right();
  move_perso();
  print();
  move();
  print();

  while (!collision())
    {
      std::cout << "boucle" << std::endl;
      int c = rand() % 4 + 1;
      if (c == 0)
      	this->direction = 'l';
      if (c == 1)
      	this->direction = 'r';
      if (c == 2)
      	this->direction = 'd';
      if (c == 3)
      	this->direction = 'u';
      move_perso();
      print();
      move();
      print();
      usleep(100000);
      std::cout << "direction == " << this->direction << std::endl;
      move();
    }
}
