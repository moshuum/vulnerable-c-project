#include<iostream>
extern "C" { 
  #include <sqlite3.h>
}

int main(int argc, char *argv[]){

   std::cout << "Hello World!" << std::endl;
   std::cout << "SQLite3 version " << sqlite3_libversion() << std::endl;
   return 0;

}
