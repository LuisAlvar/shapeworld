
dotnet new solution --name ShapeWorld
  - This is done on at the highest level

dotnet new console --name ShapeWorld.Client 

dotnet sln add **/*.csproj 
 - An application is a collection of projects, we are tell 
   microsoft to place the projects into one solution 

dotnet new console --name ShapeWorld 
dotnet build 

dotnet run --project ShapeWorld/ShapWorld.csproj

If private class Program, then the namespace only has access to it and not the 
dotnet framework. The compiler does not have access to the main function 

If there is no access modifier, then the CLR will infer the most restrictive 
modifier that will able the application to run 

dotnet new classlib --name ShapeWorld.Domain 

The solutionname.theprojectname 

dotnet sln add **/*.csproj

IN ORDER TO ADD REFERENCE LIKE SHAPE TO PROGRAM.cs
- This create a link
dotenet add ShapeWorld/ShapWorld.csproj reference ShapeWorld.Domain/ShapeWorld.Domain.csproj
dotnet build 


- virtual -> You can use the implemenation of the parent class or the subclass or child class
- abstract -> The parent class will not touch the implementation and handles it over to the child class

- new -> the class method is changing the implmenation from the parent class by 


(Shape) new Rectangle -> this is will throw an error if it is unable to cast
new Rectangle as Shape -> if it is unable to cast it set the object to null

triangle 
circle

cuda 
sphere

how would you find the longest word in a selntence where only whitespace matters?
==================================================================================
git init 
- git jobs is to categorize your code 
- history is kept inside refs folder in the .git folder 
- objects are only created once
- hooks: e.g sicky notes a set of task to complete if you do a task 

git config --local --list
- filemode: 

git config --global --list 
git config --global user.name 
git config --global user.email

touch .gitignore

=====
git add 
- we are add the local files to a repros
- But we have not yet saves the files to the local server
===
git commit --message ""
====
git log 
- who made the changes
====
install gitlens 
====
branchs 
- different tracing channels 
git branch 
======
git remote add pokemon https://github.com/LuisAlvar/shapeworld.git
- allows us to connect to github
- connect our local git to remote repro 
======
git push --set-upstream pokemon master
- we are going to push from local to remote
- upstream: we are treating github as a parent 
- we only od this one time 
- master locally should match master remotelly 
- NOW: after we just need to use git push 
=======
======================================
Testing 
=======================================
dotnet new xunit --name ShapWorld.Testing 
dotnet sln add **/*.csproj
====
Need to link them 
----
dotnet add ShapeWorld.Testing/ShapeWorld.Testing.csproj  reference ShapeWorld.Domain/ShapeWorld.Domain.csproj