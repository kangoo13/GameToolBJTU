//
// my_exception.hpp for abstract_vm in /home/lebour_a/Dropbox/Epitech/abstract_vm
//
// Made by le bourblanc alexandre
// Login   <lebour_a@epitech.net>
//
// Started on  Mon Feb 24 10:16:41 2014 le bourblanc alexandre
// Last update Mon Feb 24 11:20:36 2014 jeremy
//

#ifndef			_MY_EXCEPTION_H_
# define		_MY_EXCEPTION_H_

#include <iostream>
#include <sstream>
#include <exception>

class	my_exception : public std::exception
{
private:
  std::string msg;
public:
  my_exception(const char *message)
  {
    std::ostringstream oss;

    oss << message;
    this->msg = oss.str();
  };

  virtual	~my_exception() throw() {};

  virtual	const char *what() const throw()
  {
    return (this->msg.c_str());
  };
};

#endif			/*!_MY_EXCEPTION_H_*/
