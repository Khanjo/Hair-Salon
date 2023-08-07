# _Hair Salon_

#### _C# / SQL Database basics code review for Epicodus, 07/28/2023_

#### By _**Joshua Khan**_

## Description

_Web application that allows user to add stylists for their hair salon and add clients to stylists_

## Setup/Installation Requirements

  1. Click on this [link to the project repository](https://github.com/Khanjo/Hair-Salon.git) on GitHub.  
  2. Click on the "Clone or download" button to copy the project.     
  3. If you know how to use the command line and Github, clone the project with `git clone`. Use "**Download ZIP**" if not.
  4. Extract the Zip to a folder of your choice and open with a code editor (i.e. vscode)
  5. Import the .sql file into a SQL Manager as a Database. In mySQL Workbench you import from self-contained file and select the .sql file
  6. Make sure your database matches this Schema:  

  DROP DATABASE IF EXISTS \`joshua_khan\`;  
  CREATE DATABASE \`joshua_khan\`;  
  USE \`joshua_khan\`;  

  CREATE TABLE `clients` (
  `ClientId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  `Description` varchar(255) DEFAULT NULL,
  `StylistId` int DEFAULT '0',
  PRIMARY KEY (`ClientId`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

  CREATE TABLE `stylists` (
  `StylistId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  `Specialty` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

  7. Create an appsettings.json file in the HairSalon directory and add the following code:
  {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=joshua_khan;uid=root;pwd=`your password`;"
    }
  }

  8. Navigate to the HairSalon directory by entering `cd` **Your Filepath/**`HairSalon`. Then enter `dotnet restore`, `dotnet build`, and `dotnet run` into the terminal.

## Known Bugs

_No known bugs_

## Support and contact details

_https://github.com/khanjo_

## Technologies Used

* C#
* .NET-Core 2.2
* ASP.NET Core MVC
* Entity Framework Core
* MySql
* Visual Studio Code
* GitHub

### License

[MIT License.](https://opensource.org/license/mit/)

Copyright (c) 2023 **_Joshua Khan_**