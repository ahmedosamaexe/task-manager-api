# TaskManager API

A RESTful API for task management with JWT-based authentication, built with ASP.NET Core 10 and Entity Framework Core.

## Features

- JWT-based authentication
- Per-user task CRUD
- BCrypt password hashing
- Swagger / OpenAPI
- EF Core migrations
- Authentication rate limiting
- Configurable CORS

## Configuration

Secrets and environment-specific settings should **not** be committed to source control.

The application expects:

- `ConnectionStrings:DefaultConnection`
- `JwtSettings:SecretKey` — at least 32 bytes
- `JwtSettings:Issuer`
- `JwtSettings:Audience`
- `JwtSettings:ExpiryInMinutes`
- `Cors:AllowedOrigins`

For local development, use .NET User Secrets or environment variables.

Example environment variables:

```text
ConnectionStrings__DefaultConnection=Server=localhost\\SQLEXPRESS;Database=TaskManagerDB;Trusted_Connection=True;TrustServerCertificate=True;
JwtSettings__SecretKey=<generate-a-long-random-secret>
JwtSettings__Issuer=TaskManagerAPI
JwtSettings__Audience=TaskManagerAPI
JwtSettings__ExpiryInMinutes=60
Cors__AllowedOrigins__0=https://localhost:3000
```

If no CORS origins are configured, cross-origin browser requests are denied.

## Getting started

### Prerequisites

- .NET 10 SDK
- SQL Server / SQL Server Express / LocalDB
- Git

### Database

Configure `ConnectionStrings:DefaultConnection`, then run:

```bash
dotnet ef database update
```

### Run

```bash
dotnet run
```

Swagger is available at `/swagger`.

## API endpoints

### Auth

- `POST /api/auth/register`
- `POST /api/auth/login`

### Tasks

- `GET /api/tasks`
- `GET /api/tasks/{id}`
- `POST /api/tasks`
- `PUT /api/tasks/{id}`
- `DELETE /api/tasks/{id}`

Protected task endpoints require:

```text
Authorization: Bearer {token}
```

Authentication endpoints are rate-limited to help reduce brute-force and abuse attempts.

## License

MIT License
