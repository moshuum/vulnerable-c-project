# Nuget Example 

This project is an example of a project using Nuget to manage its build.

The visual studio's `packages.config` at the Project folder(Example Project) that declare the dependency required to build.  
The package will be downloaded after the first execution of the project, after that you can find them at packages folder next to the Project folder.  

The dependencies are:  
- System.Data.SQLite.1.0.108.0  
 
 Package source:  
 nuget.org/packages/System.Data.SQLite/1.0.108  
 
 Target:
 Dotnet Version = 4.5.1
 
#### To build the projects (Windows):  
'Build' via Visual Studio  

#### To run the projects (Windows):
'Start' via Visual Studio  

#### Restoring packages via Nuget (not required):
nuget restore 'Example Project.sln' 

### Number of dependencies:  
- 1 Direct dependency 

#### Vulnerable Call Chain
'create table [tablename] as'

#### What's next?

### Version Matching: System.Data.SQLite 1.0.108.0 == Sqlitelib (3.22.0)
Search:  
`This ZIP archive contains all current source code for System.Data.SQLite 1.0.108.0 (3.22.0) and the extra files needed to run the unit test suite, combined into a single archive file. 
(sha1: fd1e3a3cdb0e6edb95ec7d3764c0075abe81f7fc)`
