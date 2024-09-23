
##Project Name
 Developer Assesment Project

##Description
* This project is a .Net Core web application that handling freelancer data using repository pattern and Entity Framework Core. For the data storage and retrival, this application utilizing MSSQL as the relational database management system (RDBMS). Implementation of
Dependency injection design pattern to streamline and manage the object creation and dependencies throughoutthe application. Function overriding applied to customize behaviour in derived class which benefit in terms of flexibility and code reuse.

##Project Structure
* HomeController.cs Handles HTTP Request related to the CRUD action of the freelancer data
* Program.cs: Contain application startup configuration and register the services that can be inject into the other parts of the applications.
* Repository.cs: Implementing the generic repository pattern
* Irepository.cs: Defines the interface for the generic repository.


##Features
* CRUD operation for freelancer data
* RESTful API endpoints
* Generic repository for data access
* Dependency Injection for loose coupling

##Prerequisites
* .NET 6.0 SDK or later
* SQL Server (for the database)
  
##API Endpoints
* GET /Home/GetFreelancer: Retrieve freelancer(s) based on the user input 
* POST /Home/RegisterFreelancer: Register a new freelancer
* PUT /Home/UpdateFreelancer: Update an existing freelancer
* DELETE /Home/DeleteFreelancer: Soft delete a freelancer
