"# Atida"
 
 This project is a web API built using .NET Core framework and designed to provide data and functionality related to the Korona application. The API interacts with a database to retrieve and store information.
 
 Getting Started
To get started with this project, follow the steps below:

Clone the repository to your local machine:
git clone https://github.com/ayala-shtreicher/Atida/tree/main/Atida

Install the required dependencies by navigating to the project directory and running the following command:
dotnet restore

Set up the database connection by modifying the appsettings.json file. Update the connection string with your database credentials and other relevant information.

Apply the database migrations to create the necessary tables by running the following command:
update-database

Start the API by running the following command:
dotnet run

The API will be available at http://localhost:7255.

API Endpoints
The following endpoints are available in the Korona Web API:

GET /api/User
Retrieves a list of all users in the database.

GET /api/User/{tz}
Retrieves a user with this tz.

POST /api/User
Creates a new user entry in the database. Requires providing the user details in the request body.

GET /api/Vaccination
Retrieves a list of all vaccinations in the database.

POST /api/User
Creates a new vaccination entry in the database. Requires providing the user details in the request body.

GET /api/SicknessDetails
Retrieves a list of all sicknessDetails in the database.

POST /api/User
Creates a new sicknessDetails entry in the database. Requires providing the user details in the request body.

Database Schema
The databases schema for the Atida Web API includes the following tables:

User:
Id
FirstName
LastName
Tz
Address
DateOfBirth
Phone
MobilePhone

Vaccination:
Id
UserId
ReciveTime
Manufacturer

SicknessDetails:
Id
UserId
PositiveResultTime
RecoveryTime

Authentication and Authorization
This project does not implement any authentication or authorization mechanisms by default.

Contributing
Contributions to this project are welcome. 
If you encounter any issues or have suggestions for improvements, please open an issue on the repository's issue tracker.
You can also submit pull requests with proposed changes.
When contributing, please ensure that you follow the existing coding style and conventions used in the project.
Additionally, include appropriate unit tests for any new functionality or bug fixes.

License
This project is licensed under the MIT License. You are free to use, modify, and distribute the codebase as per the terms of this license.

Acknowledgments
We would like to acknowledge the following resources and libraries that have been used in the development of this project:

.NET Core
Entity Framework Core
ASP.NET Core
OpenAPI/Swagger
GitHub
Thank you for using the Korona Web API. If you have any questions or need further assistance, 
please don't hesitate to reach out to the project maintainers.


