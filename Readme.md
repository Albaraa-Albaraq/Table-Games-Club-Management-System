# Table Games Club Management System

A full-stack solution for managing billiards, VIP billiards, foosball, and table tennis in clubs. The system allows you to track playing sessions, control fees, and manage operations smoothly.

---

## 🚀 Features
- Manage multiple table games (Billiards, VIP Billiards, Foosball, Tennis).
- Start, pause, resume, and end sessions.
- Set hourly or match-based fees dynamically.
- Live monitoring of tables via desktop app.
- RESTful API with Swagger documentation.
- SQL Server integration for data persistence.

---

## 🏛️ Architecture
The solution follows a **Layered Architecture**:

- **ClubManagement (UI Layer)**
  - Windows Forms application for table management.
  - Real-time session and fee control.
- **ClubManagementAPI (API Layer)**
  - ASP.NET Core RESTful API.
  - Swagger for easy documentation and testing.
- **ClubManagementBusinessLayer (Business Layer)**
  - Core logic for tables, sessions, and fees.
  - Implements OOP principles: Inheritance, Composition, Events & Delegates.
- **ClubManagementDataAccessLayer (Data Layer)**
  - Data access classes and helpers.
  - SQL Server as a database.

---

## 🛠️ Technologies Used
- **C# / .NET 7**
- **ASP.NET Core** (Web API)
- **Windows Forms** (Desktop UI)
- **Entity Framework Core** / ADO.NET
- **SQL Server**
- **Swagger / Swashbuckle**

---

## 🔍 OOP Concepts in Use
- **Inheritance:** All games inherit from a base `Table` class.
- **Composition:** Each table composes a `TableFees` object for fee management.
- **Events & Delegates:** Fees updates trigger events to refresh dues dynamically.
- **Abstraction & Encapsulation:** Clean interfaces and secure data handling.

---

## 📦 Getting Started
1. Clone the repository:
   ```bash
   git clone https://github.com/Albaraa-Albaraq/TableGamesClubManagement.git
   ```
2. Open the solution in Visual Studio.
3. Set `ClubManagementAPI` as the startup project and run it.
4. Launch `ClubManagement` (Windows Forms app) for the UI.

---

## 📸 Screenshots
![UI Screenshot](./assets/screenshot.png)

---

## 📄 License
This project is licensed under the MIT License.

