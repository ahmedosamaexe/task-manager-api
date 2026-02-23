# TaskManager API

> A production-ready RESTful API for managing tasks with JWT-based authentication, built with ASP.NET Core 10 and Entity Framework Core.

---

![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![JWT](https://img.shields.io/badge/JWT-000000?style=for-the-badge&logo=jsonwebtokens&logoColor=white)
![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=swagger&logoColor=black)

---

## ✨ Features

- 🔐 **JWT Authentication** — Secure token-based auth for all protected endpoints
- 📋 **Task CRUD** — Full Create, Read, Update, Delete operations on tasks
- 👤 **User Registration & Login** — Stateless auth with hashed passwords
- 📄 **Swagger UI** — Interactive API documentation out of the box
- 🏗️ **Clean Architecture** — Separated Controllers, Services, DTOs, Models, and Data layers
- ⚙️ **Entity Framework Core** — Code-first migrations with SQL Server

---

## 📁 Project Structure

```
TaskManagerAPI/
├── Controllers/
│   ├── AuthController.cs       # Registration & login endpoints
│   └── TasksController.cs      # Task CRUD endpoints
├── DTOs/
│   ├── LoginDto.cs
│   ├── RegisterDto.cs
│   ├── TaskCreateDto.cs
│   ├── TaskUpdateDto.cs
│   └── TaskResponseDto.cs
├── Data/
│   └── AppDbContext.cs         # EF Core database context
├── Middleware/
│   └── ...                     # Custom middleware
├── Migrations/                 # EF Core database migrations
├── Models/
│   ├── User.cs
│   └── TaskItem.cs
├── Services/
│   ├── IAuthService.cs
│   ├── AuthService.cs
│   ├── ITaskService.cs
│   └── TaskService.cs
├── appsettings.json
├── appsettings.Development.json
└── Program.cs
```

---

## 🚀 Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or SQL Server Express / LocalDB)
- [Git](https://git-scm.com/)

### Setup

1. **Clone the repository**

   ```bash
   git clone https://github.com/ahmedosamaexe/task-manager-api.git
   cd task-manager-api
   ```

2. **Configure the connection string**

   Open `appsettings.json` and update the `ConnectionStrings` section:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER;Database=TaskManagerDB;Trusted_Connection=True;TrustServerCertificate=True"
     }
   }
   ```

3. **Configure JWT settings**

   In `appsettings.json`, set your JWT secret:

   ```json
   {
     "Jwt": {
       "Key": "your-super-secret-key-at-least-32-characters",
       "Issuer": "TaskManagerAPI",
       "Audience": "TaskManagerAPI"
     }
   }
   ```

4. **Apply database migrations**

   ```bash
   dotnet ef database update
   ```

5. **Run the API**

   ```bash
   dotnet run
   ```

6. **Open Swagger UI**

   Navigate to `https://localhost:{port}/swagger` in your browser to explore and test the API interactively.

---

## 📡 API Endpoints

### Auth

| Method | Endpoint              | Description              | Auth Required |
|--------|-----------------------|--------------------------|:-------------:|
| POST   | `/api/auth/register`  | Register a new user      | ❌            |
| POST   | `/api/auth/login`     | Login and receive JWT    | ❌            |

### Tasks

| Method | Endpoint           | Description              | Auth Required |
|--------|--------------------|--------------------------|:-------------:|
| GET    | `/api/tasks`       | Get all tasks for user   | ✅            |
| GET    | `/api/tasks/{id}`  | Get a task by ID         | ✅            |
| POST   | `/api/tasks`       | Create a new task        | ✅            |
| PUT    | `/api/tasks/{id}`  | Update an existing task  | ✅            |
| DELETE | `/api/tasks/{id}`  | Delete a task            | ✅            |

---

## 🔐 Authentication

This API uses **JWT Bearer Tokens** for authentication.

### Step 1 — Register

```http
POST /api/auth/register
Content-Type: application/json

{
  "username": "ahmed",
  "email": "ahmed@example.com",
  "password": "YourPassword123!"
}
```

### Step 2 — Login

```http
POST /api/auth/login
Content-Type: application/json

{
  "email": "ahmed@example.com",
  "password": "YourPassword123!"
}
```

A successful login returns a JWT token:

```json
{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
}
```

### Step 3 — Use the Token

Include the token in the `Authorization` header for all protected requests:

```http
Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...
```

> **Swagger UI:** Click the **Authorize** button (🔒) at the top of the Swagger page and enter `Bearer <your_token>` to authenticate all requests directly from the browser.

---

## 👤 Author

**Ahmed Osama**

[![GitHub](https://img.shields.io/badge/GitHub-ahmedosamaexe-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/ahmedosamaexe)

---

## 📝 License

This project is open source and available under the [MIT License](LICENSE).
