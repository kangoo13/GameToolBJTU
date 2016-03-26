//
// sfml.cpp for  in /home/kbidi_j/Dropbox/Nibbler/sfml
//
// Made by jeremy
// Login   <kbidi_j@epitech.net>
//
// Started on  Sat Mar 29 21:33:47 2014 jeremy
// Last update Wed Apr  2 17:13:56 2014 le bourblanc alexandre
//

# include	"snake_sfml.hh"

using namespace sf;


extern	"C"
{
  IAPI	*create_api()
  {
    return new snake_sfml();
  }
}

snake_sfml::snake_sfml() : food(8), score("0"), bonus(8)
{
  this->food.setFillColor(Color::Red);
  this->bonus.setFillColor(Color::Green);
}

snake_sfml::~snake_sfml()
{
}

std::string const snake_sfml::init_scene(int x, int y)
{
  this->win_scrore = new RenderWindow(VideoMode(200, 200), "Nibbler");
  this->window = new RenderWindow(VideoMode(1024, 1024), "Nibbler");
  this->map = new RectangleShape(Vector2f(10 * x, y * 10));
  this->window->setPosition(Vector2i(300, 0));
  this->win_scrore->setPosition(Vector2i(1400, 100));
  map->setPosition(10, 10);
  this->map->setFillColor(Color(70, 46, 1));
  this->map->setOutlineThickness(40);
  this->map->setOutlineColor(Color(96, 96, 96));
  return ("sfml");
}

void	snake_sfml::display_snake(int x, int y)
{
  this->snake = new CircleShape(10);
  this->snake->setFillColor(Color(199, 207, 0));
  this->snake->setPosition(x * 10, y * 10);
  this->list_snake.push_back(this->snake);
}

void	snake_sfml::display_food(int x, int y, int oldx, int oldy)
{
  oldx = oldx;
  oldy = oldy;
  this->food.setPosition(x * 10, y * 10);
}

void	snake_sfml::display_move(int x, int y, int oldx, int oldy)
{
  static unsigned int	i = 0;
  (void) oldx;
  (void) oldy;

  this->list_snake[i]->setPosition((x * 10), (y * 10));
  i++;
  if (i == this->list_snake.size())
    {
      this->saveqx = x * 10;
      this->saveqy = y * 10;
      i = 0;
    }
}

void	snake_sfml::display_score(int score)
{
  std::ostringstream	oss;

  CircleShape	*new_snake;
  new_snake = new CircleShape(10);
  new_snake->setFillColor(Color(199, 207, 0));
  new_snake->setPosition(this->saveqx, this->saveqy);
  this->list_snake.push_back(new_snake);
  oss << score;
  this->score = oss.str();
}

void	snake_sfml::display_bonus(int x, int y, int oldx, int oldy)
{
  oldx = oldx;
  oldy = oldy;
  if (x != 99)
    {
      this->bonus.setFillColor(Color::Green);
      this->bonus.setPosition(x * 10, y * 10);
    }
  else
    this->bonus.setFillColor(Color(70, 46, 1));
}
void	snake_sfml::game_over() const
{
  this->window->close();
  this->win_scrore->close();
}

int	snake_sfml::get_event() const
{
  Font	font;
  Event event;
  int           ret;

  ret = 0;
  while (this->window->pollEvent(event))
    {
      switch(event.type)
	{
	case Event::Closed:
	  ret = 3;
	  break;
	case Event::KeyPressed:
	  switch (event.key.code)
	    {
	    case Keyboard::Escape:
	      ret = 3;
	      break;
	    case Keyboard::Left:
	      ret = 1;
	      break;
	    case Keyboard::Right:
	      ret = 2;
	      break;
	    case Keyboard::Space:
	      ret = 5;
	      break;
	    default:
	      break;
	    }
	default:
	  break;
	}
    }
  font.loadFromFile("assets/arial.ttf");
  sf::Text	aff_score("Score : "+ this->score, font, 30);
  this->win_scrore->clear();
  this->window->clear();
  this->window->draw(*map);
  this->window->draw(food);
  this->window->draw(bonus);
  for(std::vector<CircleShape*>::const_iterator it = this->list_snake.begin(); it != this->list_snake.end(); it++)
    this->window->draw(*(*it));
  this->win_scrore->draw(aff_score);
  this->win_scrore->draw(aff_score);
  this->window->display();
  this->win_scrore->display();
  return ret;
}
