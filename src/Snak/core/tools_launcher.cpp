//
// tools_launcher.cpp for nibbler_tools in /home/lebour_a/Dropbox/Nibbler/corps
//
// Made by le bourblanc alexandre
// Login   <lebour_a@epitech.net>
//
// Started on  Tue Apr  1 20:27:37 2014 le bourblanc alexandre
// Last update Tue Apr  1 20:28:15 2014 le bourblanc alexandre
//

#include	"corps.hh"

int             convert_to_string(char *str)
{
  std::istringstream iss;
  int           nb;

  iss.str(str);
  iss >> nb;
  return (nb);
}

int             check_param(char *str)
{
  int           nb;

  nb = convert_to_string(str);
  if (nb < 6 || nb > 80)
    throw my_exception("Size is not adapt with our programm sorry =)");
  return (nb);
}

char            *return_str(std::string str)
{
  size_t size = str.size() + 1;
  char * buffer = new char[size];
  strncpy( buffer, str.c_str(), size );
  return (buffer);
}

std::string     return_res(std::string res)
{
  if (res == "1")
    res = "ncurse";
  else if (res == "2")
    res = "sfml";
  else if (res == "3")
    res = "opengl";
  else
    throw my_exception("Sorry bad choice :)\n");
  return (res);
}
