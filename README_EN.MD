# QueuingSystem

<div align="center">

**A real-time queue management system for photography studios (Atelier) and personnel counters**

Built with **.NET 9**, **WinForms**, **SignalR**, and **Entity Framework Core**

</div>

---

## 📋 Overview

**QueuingSystem** is a desktop application designed to manage two types of queues in a business environment (e.g. a photography studio):

- **Atelier Queue** — scheduled photography appointments with date/time slots, duration, and status tracking
- **Personnel Queue** — walk-in, first-come-first-served queue for staff/personnel

The system supports multiple employees working simultaneously, with **real-time synchronization** across all connected clients via SignalR — so when one employee updates a queue, everyone else sees it instantly.

---

## ✨ Features

- 🔐 **Authentication** — secure login/register with SHA-256 password hashing
- 💾 **Remember Me** — encrypted token-based auto-login using Windows Data Protection API
- 🖼️ **Atelier Queue Management**
  - Create appointments with date, duration, and available time-slot detection
  - Filter by time frame, status, name, or phone number
  - Mark appointments as Done / Canceled / Pending
  - Attach notes to each appointment
- 👥 **Personnel Queue Management**
  - Add walk-in customers to a live queue
  - Estimated wait time calculation
  - Call next / complete current queue
- 📡 **Real-Time Updates** — powered by SignalR (online users, queue changes, employee changes broadcast instantly)
- 📊 **Statistics Dashboard** — per-employee queue counts and live online/offline status
- 🔔 **Toast Notifications & Sound Alerts** — desktop notification with audio alert on new queue calls
- 📅 **Persian (Jalali) Calendar Support** — dates displayed and entered in Shamsi format
- ✅ **FluentValidation** — clean, centralized validation rules for all DTOs
- 🌐 **RTL / Persian UI** — fully right-to-left interface with Persian labels and messages

<img width="998" height="568" alt="image" src="https://github.com/user-attachments/assets/08df51da-0adb-4d69-bc46-f390289e7b4f" />

---

## 🏗️ Architecture

The solution follows a clean, layered architecture:

```
QueuingSystem/
├── QueuingSystem.Client/       # WinForms desktop application (UI layer)
├── QueuingSystem.Business/     # Services, validators, business rules
├── QueuingSystem.Data/         # EF Core DbContext, repositories, configurations
├── QueuingSystem.Shared/       # DTOs, entities, enums, error/message handlers
└── QueuingSystem.SignalR/      # ASP.NET Core SignalR hub (real-time server)
```

| Layer | Responsibility |
|---|---|
| **Client** | WinForms UI, SignalR client connection, local state |
| **Business** | Service classes (`AtelierService`, `EmployeeService`, `PersonnelService`), FluentValidation validators |
| **Data** | EF Core `AppDbContext`, repository pattern, entity configurations |
| **Shared** | DTOs, entity models, `ResultModel<T>`, error/message code dictionaries |
| **SignalR** | ASP.NET Core hub broadcasting online users, queue changes, and employee updates |

---

## 🛠️ Tech Stack

| Category | Technology |
|---|---|
| Framework | .NET 9 |
| Desktop UI | Windows Forms |
| Real-time Communication | ASP.NET Core SignalR |
| ORM | Entity Framework Core 9 (SQL Server) |
| Validation | FluentValidation |
| Serialization | Newtonsoft.Json |
| Security | `ProtectedData` (DPAPI), SHA-256 hashing |

---

## 🚀 Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- SQL Server (LocalDB or full instance)
- Windows OS (WinForms client requirement)

### 1. Clone the repository

```bash
git clone https://github.com/sobhanrajabi31/QueuingSystem.git
cd QueuingSystem
```

### 2. Configure the database connection

The connection string is read from an environment variable:

```bash
setx QueuingSystemCS "Server=YOUR_SERVER;Database=QueuingSystemDb;Trusted_Connection=True;TrustServerCertificate=True;"
```

> ⚠️ Restart your IDE/terminal after setting the environment variable.

### 3. Apply migrations

```bash
cd QueuingSystem.Data
dotnet ef database update
```

### 4. Run the SignalR server

```bash
cd QueuingSystem.SignalR
dotnet run
```

The hub will be available at `http://localhost:5005/queueHub`.

### 5. Run the client

Open `QueuingSystem.Client.slnx` in Visual Studio and run the **QueuingSystem.Client** project, or:

```bash
cd QueuingSystem.Client
dotnet run
```

---

## 📁 Project Structure Highlights

- **`ResultModel<T>`** — a consistent success/failure response wrapper used across all service calls
- **`ErrorHandler` / `MessageHandler`** — centralized Persian-language error and success message dictionaries
- **`HubHandler`** — client-side SignalR wrapper handling reconnection, exceptions, and event dispatching
- **`AppState`** — static in-memory session state (current employee, role, authentication status)

---

## 📄 License

This project is licensed under the **MIT License** — see the [LICENSE](LICENSE) file for details.

---

<div align="center">

Made with ❤️ using .NET

</div>
