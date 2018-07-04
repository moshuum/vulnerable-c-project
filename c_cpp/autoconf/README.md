# Automake and Autoconf Example

This project is an example of a project using GNU Autoconf an to manage its build. This project uses a Makefile libraries.

`configure.ac` and `makefile.am` at the root directory that declare the library's directory to build and its dependency required. The library directory are:  
-  lib/sqlite 

The dependencies are:  
- sqlite version 3.22.0
 
#### To build the projects (short):
 ./setup

#### To clean the projects (short):
 ./cleanup

#### To build the projects (full):
1. libtoolize
2. aclocal
3. automake --add-missing
4. autoreconf
5. ./configure
6. make

#### To run the projects:
`./main`  

### Number of dependencies:  
- 1 direct dependency.  
- -- transitive dependency.  
- 2 vulnerabilities. 
  
#### Vulnerable Call Chain

#### What's next?

