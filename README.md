
# CityInfo API

The **CityInfo API** is a RESTful API built using ASP.NET Core 6, designed to provide information on cities and their points of interest. This project demonstrates the fundamentals of creating, configuring, and structuring an API with basic CRUD operations.

## Table of Contents

- [Features](#features)
- [Technologies](#technologies)
- [Installation](#installation)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Configuration](#configuration)
- [Testing](#testing)
- [License](#license)

## Features

- Provides information on cities and their associated points of interest.
- Built with REST principles, making it flexible and easy to consume.
- Includes a Postman collection for testing API endpoints.
- Configurable via `appsettings.json` files.

## Technologies

- **ASP.NET Core 6**
- **C#**
- **JSON** for data interchange
- **Postman** for API testing

## Installation

1. **Clone the repository**:

   ```bash
   git clone https://github.com/yourusername/CityInfo.git
   cd CityInfo
   ```

2. **Open the solution**:
   Open `CityInfo..sln` in Visual Studio or your preferred IDE with .NET Core support.

3. **Build and Run**:
   Ensure all dependencies are installed, and then run the project:

   ```bash
   dotnet run --project CityInfo.API
   ```

   The API should now be running at `http://localhost:5000` or `https://localhost:5001` for secure connections.

## Usage

### Running Locally

- Launch the project as described above.
- Use Postman or a similar tool to test the API endpoints.

### Configuration

You can configure the API using the `appsettings.json` or `appsettings.Development.json` files for different environments.

## API Endpoints

The API provides the following endpoints:

### Cities

- **GET /api/cities** - Retrieve a list of all cities.
- **GET /api/cities/{cityId}** - Retrieve details of a specific city by ID.

### Points of Interest

- **GET /api/cities/{cityId}/pointsofinterest** - Retrieve points of interest for a city.
- **GET /api/cities/{cityId}/pointsofinterest/{pointId}** - Retrieve details of a specific point of interest.
- **POST /api/cities/{cityId}/pointsofinterest** - Add a new point of interest to a city.
- **PUT /api/cities/{cityId}/pointsofinterest/{pointId}** - Update a specific point of interest.
- **DELETE /api/cities/{cityId}/pointsofinterest/{pointId}** - Delete a specific point of interest.

Refer to the included Postman collection, `ASP.NET Core 6 Web API Fundamentals.postman_collection.json`, for detailed testing of each endpoint.

## Testing

1. **Postman Collection**:
   Import the `ASP.NET Core 6 Web API Fundamentals.postman_collection.json` file into Postman.

2. Run the requests against your local instance of the API to ensure all endpoints work as expected.

## License

This project is licensed under the MIT License. See the LICENSE file for more details.
