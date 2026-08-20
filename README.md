# Reactivities

A clean-architecture ASP.NET Core Web API project structured into separate layers for the API, application logic, domain models, and persistence.

## Project Structure

```text
Reactivities/
├── API/
│   ├── Controllers/
│   ├── Properties/
│   ├── appsettings.json
│   ├── appsettings.Development.json
│   ├── API.csproj
│   ├── API.http
│   └── Program.cs
│
├── Application/
│   └── Application.csproj
│
├── Domain/
│   └── Domain.csproj
│
├── Persistence/
│   └── Persistence.csproj
│
└── Reactivities.slnx
```

The solution currently contains four projects: `API`, `Application`, `Domain`, and `Persistence`.

## Technologies

* C#
* .NET 10
* ASP.NET Core Web API
* Visual Studio Code
* .NET CLI

The development environment documented in the source uses .NET SDK `10.0.303` on Windows x64.

## Architecture

The project is organized into four main layers:

### API

Contains the ASP.NET Core Web API and controllers.

This is the entry point of the application and handles HTTP requests and responses.

### Application

Contains application-level logic, use cases, services, and business workflows.

### Domain

Contains the core domain models and business rules.

### Persistence

Contains data-access and database-related implementations.

This separation keeps the application's core logic independent from the API and infrastructure.

---

# Building the Project from Scratch

The following steps reproduce the project setup shown in the development session.

## 1. Create the project directory

Open PowerShell and navigate to the Laragon web directory:

```powershell
cd C:\
cd .\laragon\www\
```

Create the project folder:

```powershell
mkdir Reactivities
```

Enter the project directory:

```powershell
cd .\Reactivities\
```

The project was created under:

```text
C:\laragon\www\Reactivities
```

The source shows this directory being created before initializing the .NET solution.

---

## 2. Verify the .NET installation

Run:

```powershell
dotnet --info
```

You should see the installed .NET SDK and runtime information.

The environment used for this project has:

```text
.NET SDK: 10.0.303
OS: Windows
Architecture: x64
```

The system also has .NET 6, .NET 8, and .NET 10 SDK/runtime versions installed.

---

## 3. Check available project templates

Run:

```powershell
dotnet new list
```

This displays the available .NET templates, including:

```text
ASP.NET Core Web API
Class Library
Solution File
```

The source confirms that the `webapi`, `classlib`, and `sln` templates are available.

---

## 4. Create the solution

From the `Reactivities` directory, run:

```powershell
dotnet new sln
```

This creates:

```text
Reactivities.slnx
```

The solution was successfully created in the source setup.

---

## 5. Create the API project

Create an ASP.NET Core Web API project:

```powershell
dotnet new webapi -n API -controllers
```

This creates the `API` project with controller support.

The generated project contains files such as:

```text
API/
├── Controllers/
├── Properties/
├── API.csproj
├── API.http
├── appsettings.Development.json
├── appsettings.json
├── Program.cs
└── WeatherForecast.cs
```

The source confirms that the Web API template restored successfully and generated these files.

---

## 6. Create the Domain project

Run:

```powershell
dotnet new classlib -n Domain
```

This creates:

```text
Domain/
└── Domain.csproj
```

The source confirms successful creation and restore of the `Domain` class library.

---

## 7. Create the Application project

Run:

```powershell
dotnet new classlib -n Application
```

This creates:

```text
Application/
└── Application.csproj
```

The source confirms that the Application project was created successfully.

---

## 8. Create the Persistence project

Run:

```powershell
dotnet new classlib -n Persistence
```

This creates:

```text
Persistence/
└── Persistence.csproj
```

The source confirms that the Persistence project was created and restored successfully.

---

## 9. Add all projects to the solution

Add the API project:

```powershell
dotnet sln add .\API\
```

Add the Application project:

```powershell
dotnet sln add .\Application\
```

Add the Domain project:

```powershell
dotnet sln add .\Domain\
```

Add the Persistence project:

```powershell
dotnet sln add .\Persistence\
```

After these commands, the solution contains all four projects.

---

## 10. Open the project in Visual Studio Code

Run:

```powershell
code .
```

This opens the `Reactivities` directory in Visual Studio Code.

---

# Complete Setup Commands

For convenience, the complete initial setup can be performed with:

```powershell
cd C:\
cd .\laragon\www\

mkdir Reactivities
cd .\Reactivities\

dotnet --info

dotnet new sln

dotnet new webapi -n API -controllers
dotnet new classlib -n Domain
dotnet new classlib -n Application
dotnet new classlib -n Persistence

dotnet sln add .\API\
dotnet sln add .\Application\
dotnet sln add .\Domain\
dotnet sln add .\Persistence\

code .
```

---

# Expected Solution Structure

After completing the setup, the project should look like:

```text
Reactivities/
│
├── API/
│   ├── Controllers/
│   ├── Properties/
│   ├── API.csproj
│   ├── API.http
│   ├── appsettings.Development.json
│   ├── appsettings.json
│   ├── Program.cs
│   └── WeatherForecast.cs
│
├── Application/
│   └── Application.csproj
│
├── Domain/
│   └── Domain.csproj
│
├── Persistence/
│   └── Persistence.csproj
│
└── Reactivities.slnx
```

This matches the project structure shown after all four projects were created.

# Running the API

From the project directory, run:

```powershell
dotnet run --project .\API\
```

The ASP.NET Core API should then start using the configuration generated by the Web API template.

You can also use:

```powershell
dotnet build
```

to build the solution.

# Development Notes

At the time of setup, no `global.json` file existed in the project directory, so the installed SDK selected by the .NET CLI was being used.

The project currently serves as the initial foundation for a layered ASP.NET Core application. Additional implementation can be added to the Domain, Application, Persistence, and API layers as development progresses.
