#include <iostream>
#include <sqlite3.h>
#include <boost/version.hpp>

int main()
{
  std::cout << "Hello World!" << std::endl;
  std::cout << "SQLite3 version " << sqlite3_libversion() << std::endl;

  std::cout << "Using Boost "     
          << BOOST_VERSION / 100000     << "."  // major version
          << BOOST_VERSION / 100 % 1000 << "."  // minor version
          << BOOST_VERSION % 100                // patch level
          << std::endl;



  return 0; // Success
}