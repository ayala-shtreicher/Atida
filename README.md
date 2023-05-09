Getting Started:
Clone the repository to your local machine:
git clone https://github.com/ayala-shtreicher/Atida

"# Atida webAPI"
Description:
This project is a web API built using the .NET Core framework and is designed to provide data and functionality related to the COVID-19 application (such as adding a user, vaccination details, infection and recovery) The API interacts with a database to retrieve and store information.

<!-- Installation Guide:
Install the required dependencies by navigating to the project directory and running the following command:
dotnet restore -->

Set up the database connection by modifying the appsettings.json file. Update the connection string with your database credentials and other relevant information.

Apply the database migrations to create the necessary tables by running the following command:
update-database

<!-- Start the API by running the following command:
dotnet run -->

The API will be available at http://localhost:7255.

API Endpoints:

GET /api/User
Retrieves a list of all users in the database.
[GetUsers](https://github.com/ayala-shtreicher/Atida/assets/118370887/0f924c75-b99d-4a6a-9112-b31ad4be2dbd)


GET /api/User/{tz}
Retrieves a user with this tz.
[GetUserByTz](https://github.com/ayala-shtreicher/Atida/assets/118370887/0043624c-d51f-43bf-a945-40be2316dbbd)


POST /api/User
Creates a new user entry in the database. Requires providing the user details in the request body.
[PostUser](https://github.com/ayala-shtreicher/Atida/assets/118370887/b5137475-c46a-4695-9cd4-4763f89a8f30)


GET /api/Vaccination
Retrieves a list of all vaccinations in the database.

POST /api/Vaccination
Creates a new vaccination entry in the database. Requires providing the vaccination details in the request body.

GET /api/SicknessDetails
Retrieves a list of all sicknessDetails in the database.

POST /api/SicknessDetails
Creates a new sicknessDetails entry in the database. Requires providing the sickness details in the request body.


GET /api/Image/{image name}
Retrieves a image from local folder.

POST /api/Image
Creates a new Image entry in the local folder. Requires providing the image details in the request body.

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


"# AtidaTwitter"
Description:
This project is a C# console application. The application allows users to choose between the different types of towers, their length and width, and operates functions according to their choice.
[Twitter](https://github.com/ayala-shtreicher/Atida/assets/118370887/621a6c0e-b7e1-40a0-9f25-04876101212a)

