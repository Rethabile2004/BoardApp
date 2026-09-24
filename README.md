# BoardApp

A simple ASP.NET Core MVC web application developed as part of a practical assessment. The project demonstrates the basic structure and configuration of an MVC application using .NET 8.

## Overview

BoardApp is built using the Model View Controller (MVC) architectural pattern provided by ASP.NET Core.

The project currently focuses on establishing the core MVC application structure, including controllers, views, models, routing, static files, and error handling.

## Technologies

![.NET](https://img.shields.io/badge/.NET%208-512BD4?style=flat\&logo=dotnet\&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-512BD4?style=flat\&logo=dotnet\&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=flat\&logo=csharp\&logoColor=white)
![MVC](https://img.shields.io/badge/Architecture-MVC-blue?style=flat)

## Project Structure

```text
BoardApp
│
├── Controllers
│   └── HomeController.cs
│
├── Models
│   └── ErrorViewModel.cs
│
├── Views
│   ├── Home
│   └── Shared
│
├── wwwroot
│   ├── css
│   ├── js
│   └── lib
│
├── Program.cs
└── BoardApp.csproj
```

## Features

### MVC Architecture

The application follows the standard ASP.NET Core MVC structure:

```text
Request
   ↓
Controller
   ↓
Model
   ↓
View
   ↓
Response
```

### Navigation

The application includes basic navigation between the available MVC views.

### Error Handling

The application includes a standard error-handling mechanism using `ErrorViewModel` and an error view.

### Static Files

CSS, JavaScript, and other static resources are served from the `wwwroot` directory.

## Getting Started

### Prerequisites

Make sure the following are installed:

* .NET 8 SDK
* Visual Studio 2022, Visual Studio Code, or another compatible IDE

### Clone the Repository

```bash
git clone https://github.com/Rethabile2004/BoardApp.git
cd BoardApp
```

### Run the Application

```bash
dotnet restore
dotnet run
```

The application will provide a local URL in the terminal. Open that URL in a web browser to access the application.

## Learning Objectives

This project provides practical experience with:

* ASP.NET Core MVC
* C#
* Controllers and actions
* Razor views
* Model binding
* MVC routing
* Dependency injection
* Static files
* Error handling
* .NET application configuration

## Project Status

This repository represents the current implementation of the BoardApp practical project. The application currently provides the foundational MVC structure and basic functionality required to build upon the project.

## Author

**Rethabile Eric Siase**

Advanced Diploma in Information Technology
Central University of Technology

## License

This project was created for educational purposes.
