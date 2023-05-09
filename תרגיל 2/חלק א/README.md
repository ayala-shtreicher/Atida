"# Atida webAPI"


Description:
This project is a web API built using the .NET Core framework and is designed to provide data and functionality related to the COVID-19 application (such as adding a user, vaccination details, infection and recovery) The API interacts with a database to retrieve and store information.

Change the contents of the variable to redirect the project download.

Apply the database migrations to create the necessary tables by running the following command in Package Manager Console (Please notice that the default project is Atida.context project): update-database.
and then run the webAPI project.

The API will be available at http://localhost:5204.

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


License: 
This project is licensed under the MIT License. You are free to use, modify, and distribute the codebase as per the terms of this license.

Acknowledgments: 
We would like to acknowledge the following resources and libraries that have been used in the development of this project:

.NET Core,
Entity Framework Core,
ASP.NET Core,
OpenAPI/Swagger,
GitHub. 

If you have any questions or need further assistance, 
please don't hesitate to reach out to me.
