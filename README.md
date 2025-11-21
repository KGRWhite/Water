# Water
Backend to Sapling project

## Project Structure

This is a foundational .NET 9 backend for a React project, consisting of:

- **Water.API** - ASP.NET Core Web API project
- **Water.Domain** - Domain models and entities
- **Water.Data** - Entity Framework Core data access layer

## Technology Stack

- .NET 9
- Entity Framework Core 9.0
- SQL Server
- ASP.NET Core Web API

## Getting Started

### Prerequisites

- .NET 9 SDK
- SQL Server (LocalDB or full SQL Server)

### Building the Solution

```bash
dotnet build
```

### Running the API

```bash
cd Water.API
dotnet run
```

The API will be available at `http://localhost:5130`

### Database Setup

The connection string is configured in `Water.API/appsettings.json`. The default configuration uses SQL Server LocalDB:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=WaterDb;Trusted_Connection=true;TrustServerCertificate=true"
}
```

To create and apply migrations:

```bash
# From the Water.API directory
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## CORS Configuration

The API is configured to accept requests from React development servers:
- `http://localhost:3000` (Create React App)
- `http://localhost:5173` (Vite)

## Project Dependencies

- Water.API depends on Water.Data and Water.Domain
- Water.Data depends on Water.Domain

