# Unit Conversion API

## Overview

This project is a RESTful Unit Conversion API built using ASP.NET Core 8 Web API. The application allows conversion between different units across multiple categories including Length, Weight, and Temperature.

The solution is designed using clean architecture principles, dependency injection, and the Strategy Pattern to support future extensibility.

---

## Features

* Length Conversion

  * Meter
  * Kilometer
  * Feet
  * Inch

* Weight Conversion

  * Kilogram
  * Gram
  * Pound

* Temperature Conversion

  * Celsius
  * Fahrenheit
  * Kelvin

* Centralized Exception Handling

* Dependency Injection

* Swagger/OpenAPI Documentation

* Unit Testing using xUnit

* Extensible Architecture for Future Unit Types

---

## Technologies Used

* ASP.NET Core 8 Web API
* C#
* Swagger / OpenAPI
* xUnit
* Dependency Injection
* Strategy Design Pattern

---

## Project Structure

UnitConversionApi
├── Controllers
├── Models
├── Services
├── Converters
├── Middleware
├── Constants

UnitConversionApi.Tests
├── LengthConverterTests
├── WeightConverterTests
├── TemperatureConverterTests

---

## Running the Application

1. Clone the repository

git clone <repository-url>

2. Navigate to solution directory

cd UnitConversionApi

3. Restore packages

dotnet restore

4. Build solution

dotnet build

5. Run application

dotnet run

---

## Swagger

After running the application, Swagger UI can be accessed at:

https://localhost:<port>/swagger

---

## Sample Request

POST /api/conversion

{
"value": 10,
"category": "length",
"fromUnit": "meter",
"toUnit": "feet"
}

Sample Response

{
"originalValue": 10,
"fromUnit": "meter",
"toUnit": "feet",
"convertedValue": 32.8084
}

---

## Design Decisions

* Strategy Pattern is used for implementing unit converters.
* Dependency Injection is used for service registration and resolution.
* Conversion logic is separated from API controllers for maintainability.
* Architecture is designed to support future unit categories with minimal changes.
* Centralized exception middleware provides consistent error responses.

---

## Unit Testing

Unit tests are implemented using xUnit for:

* Length Conversion
* Weight Conversion
* Temperature Conversion

All tests pass successfully.

---

## Author

Prajwal Khandge
