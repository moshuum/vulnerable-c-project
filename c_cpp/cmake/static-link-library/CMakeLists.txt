cmake_minimum_required(VERSION 2.8.9)
project (cppexample)

add_executable(main src/main.cpp)
add_subdirectory (lib)


target_link_libraries(main sqlite3 pthread dl)

