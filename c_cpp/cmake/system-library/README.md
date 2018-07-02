# CMake Example


This project is an example of a project using CMake to manage its build. The project uses cmake module.

`CMakeList.txt` at the root directory that declare the module's directory to build and its dependency required. The module directory are:  
-  cmake_modules  

The dependencies are:  
- sqlite  
 
#### To build the projects:
`./setup`  

#### To run the projects:
`./build/main`  

### Number of dependencies:  
- 1 direct dependency.  
- --- transitive dependency.  
- 2 vulnerabilities. 
  
#### Vulnerable Call Chain

#### What's next?



**Required library for compilation:**  
sudo apt-get install sqlite3 libsqlite3-dev  

