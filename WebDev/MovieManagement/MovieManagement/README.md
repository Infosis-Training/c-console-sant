#Entities/Class and objects to create

1. Movies
	Name, Code, Desc, Release Date, Length
2. Crew
	Name, Desc

#DB Connect
1. Setup ORM Tool (EF Core)
	- Code First Approach (Model is mainly used to connect to table, model name = table name and model type/property = column names/type)
	- Database first approach (DB already available, no model is used here for table name and columns)
 
 -- Install:
 > EntityFrameworkCore, 
 > EF SqlServer, 
 > EF Core Design

 2. install migration tool from terminal : 'dotnet tool install -g dotnet-ef'
 3. Create DB Context class and create a property for 'Table' as per model. Only one DBContext class will be made for whole project.
 4. Add DB Context entry & connection string in startup.cs
 5. add db migration from cmd "dotnet ef database update"
 6. lastly run cmd line update database script "dotnet ef database update"
