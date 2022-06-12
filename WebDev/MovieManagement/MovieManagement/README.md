#Entities/Class and objects to create

1. Movies
	Name, Code, Desc, Release Date, Length
2. Crew
	Name, Desc

#DB Connect
1. Setup ORM Tool (EF Core)
	- Code First Approach (Model is mainly used to connect to table and colums names)
	- Database first approach (DB already available, no model is used here for table name and columns)
 
 -- Install:
 > EntityFrameworkCore, 
 > EF SqlServer, 
 > EF Core Design

 2. Create DB Context class and create a property as per model name
 3. install migration tool from terminal : 'dotnet tool install -g dotnet-ef'