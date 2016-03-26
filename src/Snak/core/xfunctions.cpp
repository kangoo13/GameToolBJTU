//
// xfunctions.cpp for nibbler-xfunc in /home/lebour_a/Dropbox/Nibbler/corps
//
// Made by le bourblanc alexandre
// Login   <lebour_a@epitech.net>
//
// Started on  Tue Mar 18 10:01:22 2014 le bourblanc alexandre
// Last update Tue Mar 18 10:39:08 2014 le bourblanc alexandre
//

#include	"corps.hh"

void            *xdlopen(const char *filename, int flag)
{
  void          *dlhandle;

  dlhandle = dlopen(filename, flag);
  try
    {
      if (dlhandle == NULL)
        throw my_exception(dlerror());
    }
  catch(const my_exception &e)
    {
      std::cerr << e.what() << std::endl;
      exit(1);
    }
  return (dlhandle);
}

void            *xdlsym(void *handle, const char *symbol)
{
  void                  *external_creator;

  external_creator = (dlsym(handle, symbol));
  try
    {
      if (external_creator == NULL)
        throw my_exception("Error on the loading of the lib.so");
    }
  catch(const my_exception &e)
    {
      std::cerr << e.what() << std::endl;
      exit(1);
    }
  return (external_creator);
}

int             xdlclose(void *handle)
{
  int           ret;

  ret = dlclose(handle);
  try
    {
      if (ret != 0)
        throw my_exception("Error on the dlcose function");
    }
  catch(const my_exception &e)
    {
      std::cerr << e.what() << std::endl;
    }
  return (ret);
}
