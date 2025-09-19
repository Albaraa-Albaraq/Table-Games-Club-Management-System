Table Games Club Management System

A complete management solution for table games clubs.
This project streamlines the management of billiards, VIP billiards, foosball, and table tennis tables — helping staff save time, improve accuracy, and enhance the player experience.

🚀 Features

Track and control table usage in real time.

Start, pause, or end sessions with a single click.

Dynamic calculation of fees (per hour or per match).

Centralized fee configuration for each game type.

Desktop client for smooth daily operations.

RESTful API for integration and scalability.

🛠️ Tech Stack

Backend: ASP.NET Core 7 (C#), RESTful API, Swagger/OpenAPI.

Frontend: Windows Forms (C#).

Database: SQL Server (Entity Framework Core).

Architecture: Layered Architecture

UI Layer: Windows Forms desktop app with custom controls.

Business Layer: Core logic for tables, fees, and game sessions.

Data Access Layer: Data persistence, SQL Server integration.

API Layer: RESTful API exposing all operations.

OOP Concepts:

Inheritance & Abstraction (Table base class for all games).

Composition (linking TableFees to tables).

Events & Delegates for fee updates (FeesChanged).

Encapsulation for business logic.

📂 Project Structure
