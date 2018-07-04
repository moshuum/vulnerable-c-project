#include <iostream>
#include <sqlite3.h>

using namespace std;

int main(const int argc, const char** argv) {
  cout << "Hello world!" << endl;
  std::cout << "SQLite3 version " << sqlite3_libversion() << std::endl;
  return 0;
}
