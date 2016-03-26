//
// food.cpp for food in /home/lebour_a/Dropbox/Nibbler/corps
//
// Made by le bourblanc alexandre
// Login   <lebour_a@epitech.net>
//
// Started on  Tue Apr  1 18:44:33 2014 le bourblanc alexandre
// Last update Wed Apr  2 16:43:21 2014 le bourblanc alexandre
//

#include	"corps.hh"

void            Nibbler::putFood()
{
  int           food_randx;
  int           food_randy;

  food_randx = rand() % (this->width - 2);
  food_randy = rand() % (this->height - 2);
  food_randx == 0 ? food_randx++ : food_randx;
  food_randy == 0 ? food_randy++ : food_randy;
  for (unsigned int i = 0; i < this->snake.size(); i++)
    {
      if (snake[i]->getPosX() == food_randx && snake[i]->getPosY() == food_randy)
        continue;
    }
  this->map->getMap()[food_randx + food_randy]->setFood(true);
  this->api->display_food(food_randx, food_randy, this->foodx, this->foody);
  this->foodx = food_randx;
  this->foody = food_randy;
}

void            Nibbler::check_food()
{
  int           x;
  int           y;

  x = this->snake[0]->getPosX();
  y = this->snake[0]->getPosY();
  if (x == this->foodx && y == this->foody)
    {
      putFood();
      this->score += check_score();
      this->api->display_score(this->score);
      this->snake.push_back(new Snake(this->snake[this->snake.size() - 1]->getPosX(), this->snake[this->snake.size() - 1]->getPosY()));
    }
}

void		Nibbler::putBonus(int flag)
{
  int		bonus_randx;
  int		bonus_randy;

  bonus_randx = rand() % (this->width - 2);
  bonus_randy = rand() % (this->height - 2);
  bonus_randx == 0 ? bonus_randx++ : bonus_randx;
  bonus_randy == 0 ? bonus_randy++ : bonus_randy;
  for (unsigned int i = 0; i < this->snake.size(); i++)
    {
      if (snake[i]->getPosX() == bonus_randx && snake[i]->getPosY() == bonus_randy)
        continue;
    }
  if (flag == 0)
    {
      this->api->display_bonus(bonus_randx, bonus_randy, this->bonusx, this->bonusy);
      this->bonusx = bonus_randx;
      this->bonusy = bonus_randy;
    }
  else
    {
      bonus_randx = 0;
      bonus_randy = 0;
      this->api->display_bonus(99, 99, this->bonusx, this->bonusy);
    }
}

void		Nibbler::checkBonus()
{
  int           x;
  int           y;

  x = this->snake[0]->getPosX();
  y = this->snake[0]->getPosY();
  if (x == this->bonusx && y == this->bonusy)
    {
      this->score += 50 + this->score_lvl;
      this->api->display_score(this->score);
      putBonus(1);
    }
}
