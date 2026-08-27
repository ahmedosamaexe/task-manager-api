# TaskManager API

A production-ready RESTful API for managing tasks with JWT-based authentication, built with ASP.NET Core 10 and Entity Framework Core.

---

Overview

This repository provides a minimal, secure API for user registration, authentication (JWT), and task management (CRUD). It follows clear separation of concerns with Controllers, Services, DTOs, Models, and Data access layers.

Key technologies: .NET 10, Entity Framework Core, SQL Server, JWT, Swagger

---

Features

- JWT-based authentication
- Task create, read, update, delete (per-user)
- User registration and login with hashed passwords
- Swagger / OpenAPI documentation
- Code-first EF Core migrations

---

Project structure

```
TaskManagerAPI/
├── Controllers/
├── DTOs/
├── Data/
├── Middleware/
├── Migrations/
├── Models/
├── Services/
├── appsettings.json
└── Program.cs
```

---

Getting started

Prerequisites

- .NET 10 SDK
- SQL Server (or SQL Server Express / LocalDB)
- Git

Setup

1. Clone the repository

```bash
git clone https://github.com/ahmedosamaexe/task-manager-api.git
cd task-manager-api
```

2. Configure the connection string in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=TaskManagerDB;Trusted_Connection=True;TrustServerCertificate=True"
  }
}
```

3. Configure JWT settings in `appsettings.json`:

```json
{
  "Jwt": {
    "Key": "your-super-secret-key-at-least-32-characters",
    "Issuer": "TaskManagerAPI",
    "Audience": "TaskManagerAPI"
  }
}
```

4. Apply database migrations

```bash
dotnet ef database update
```

5. Run the API

```bash
dotnet run
```

6. Open Swagger UI at `https://localhost:{port}/swagger` to inspect and test endpoints.

---

API endpoints (summary)

Auth

- POST /api/auth/register — Register a new user
- POST /api/auth/login — Authenticate and receive a JWT

Tasks

- GET /api/tasks — Get tasks for the authenticated user
- GET /api/tasks/{id} — Get a specific task
- POST /api/tasks — Create a new task
- PUT /api/tasks/{id} — Update a task
- DELETE /api/tasks/{id} — Delete a task

---

Authentication

This API uses JWT access tokens. Include the token in the Authorization header for protected requests:

```
Authorization: Bearer {token}
```

Use the Swagger UI Authorize control to set the token for testing.

---

Author

Ahmed Osama — https://github.com/ahmedosamaexe

---

License

MIT License — see the LICENSE file for details.


