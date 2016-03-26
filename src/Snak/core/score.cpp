//
// score.cpp for nibbler_score in /home/lebour_a/Dropbox/Nibbler/corps
//
// Made by le bourblanc alexandre
// Login   <lebour_a@epitech.net>
//
// Started on  Tue Apr  1 18:46:41 2014 le bourblanc alexandre
// Last update Wed Apr  2 16:45:29 2014 le bourblanc alexandre
//

#include	"corps.hh"

void            Nibbler::exit(int echap) const
{
  this->api->game_over();
  print_score();
  if (echap == 1)
    std::cout << "You kill the game ";
  else
    std::cout << "You lose during the game ";
  collision(1);
  if (this->score != 0)
    std::cout << " but you score " << this->score << " points good job :) play again :D" << std::endl;
  else
    std::cout << " You suck !! " << std::endl;
}


int             Nibbler::print_score() const
{
  std::ofstream objetfichier;
  std::string   pseudo;

  std::cout << "Please enter your nickname please : ";
  std::cin >> pseudo;
  objetfichier.open("scores.txt", std::ios::out | std::ios::app);
  if (objetfichier.bad())
    return (-1);
  objetfichier << pseudo << " has made : " << this->score << " points with the lib " << this->name_api << std::endl;
  objetfichier.close();
  return (0);
}

int		Nibbler::check_score()
{
  if (score <= 50)
    this->score_lvl = 10;
  else if (score <= 200)
    this->score_lvl = 20;
  else
    this->score_lvl = 50;
  return (this->score_lvl);
}
