# 🚘 DVLD - Driver & Vehicle License Department

A C# Windows Forms desktop application designed to simulate a **Driver & Vehicle License Department (DVLD)** system.

The project is being developed to manage people, drivers, users, applications, driving licenses, traffic violations, and other related services through an organized desktop application connected to a database.

The project is currently under development, with the first implemented modules focusing on the **Main Interface** and **People Management**.

---

# 📌 Project Overview

The **DVLD** system is designed to provide a centralized application for managing different operations related to drivers and vehicle licensing.

The system will include several modules such as:

* 👥 People Management
* 🚗 Drivers Management
* 👤 Users Management
* 📄 Applications Management
* 🪪 Driving Licenses
* ⚠️ Traffic Violations
* ⚙️ Account Settings
* And other related services

The project will be expanded gradually as new features and modules are implemented.

---

# 🖥️ Main Interface

The main interface provides the central navigation area of the application.

From the sidebar, the user can navigate between the main modules of the system:

* **People**
* **Drivers**
* **Users**
* **Applications**
* **Account Settings**

The main dashboard also provides the main visual identity of the DVLD system.

### 📸 Main Interface

![DVLD Main Interface](Screenshots/Main-Interface.png)

---

# 👥 People Management

The **People Management** module is the first major module implemented in the project.

It allows the system to display and manage people registered in the database.

The People screen displays information such as:

| Field       | Description                      |
| ----------- | -------------------------------- |
| PersonID    | Unique identifier for the person |
| NationalNo  | National identification number   |
| FirstName   | First name                       |
| SecondName  | Second name                      |
| ThirdName   | Third name                       |
| LastName    | Family name                      |
| Gender      | Person's gender                  |
| DateOfBirth | Date of birth                    |
| CountryName | Country                          |
| Phone       | Phone number                     |
| Email       | Email address                    |

---

# 🔎 People Filtering

The People Management screen contains a filtering option:

```text
Filter By:
```

This allows the user to filter the displayed people according to available criteria.

The records are displayed in a table that makes it easier to view and manage the information.

The system also displays the total number of records:

```text
# Records: 4
```

---

# ➕ People Management Interface

The People interface contains:

* People records table.
* Filtering option.
* Add Person button.
* Number of displayed records.
* Close button.
* Person information columns.

### 📸 Manage People

![Manage People](Screenshots/Manage-People.png)

---

# 🧩 Current Modules

## ✅ Implemented

### 👥 People

The People module currently provides the interface for displaying people records and filtering the available data.

---

## 🚧 In Development

The following modules are planned for the project:

### 🚗 Drivers

Management of registered drivers and their driver-related information.

### 👤 Users

Management of system users and their accounts.

### 📄 Applications

Management of different license and service applications.

### 🪪 Driving Licenses

Management of issued driving licenses and their related information.

### ⚠️ Traffic Violations

Management of traffic violations and related records.

### ⚙️ Account Settings

Management of application and user account settings.

---

# 🛠 Technologies Used

* C#
* .NET
* Windows Forms (WinForms)
* SQL Server
* ADO.NET
* Visual Studio

---

# 🗄️ Database

The application is connected to a database that stores the system's information.

The database will contain data related to:

* People
* Drivers
* Users
* Applications
* Licenses
* Violations
* Countries
* And other related entities.

The database structure will grow as additional DVLD modules are implemented.

---

# 🏗️ Application Structure

The project is being developed using a layered approach to separate different responsibilities.

The main parts include:

```text
DVLD
│
├── Presentation Layer
│   ├── Main Form
│   ├── People Forms
│   ├── Drivers Forms
│   ├── Users Forms
│   └── Applications Forms
│
├── Business Layer
│
├── Data Access Layer
│
├── Database
│
├── Screenshots
│   ├── Main-Interface.png
│   └── Manage-People.png
│
└── README.md
```

---

# 🔄 Current Application Workflow

```text
Start Application
        │
        ▼
   Main Interface
        │
        ├──────────────► People
        │                   │
        │                   ▼
        │             Display People
        │                   │
        │                   ▼
        │                Filter
        │
        ├──────────────► Drivers
        │
        ├──────────────► Users
        │
        ├──────────────► Applications
        │
        └──────────────► Account Settings
```

---

# 🎯 Project Goals

The main goal of this project is to build a complete desktop system for managing driver and vehicle licensing operations.

The project also provides practical experience in:

* C# Windows Forms development.
* Database-driven applications.
* SQL Server.
* ADO.NET.
* CRUD operations.
* Layered application architecture.
* Form navigation.
* Data filtering.
* User interface design.
* Managing relationships between different system entities.

---

# 📅 Development Progress

### Phase 1 — Main Interface & People Management

Currently implemented:

* ✅ Main application interface.
* ✅ Sidebar navigation.
* ✅ People Management screen.
* ✅ Display people records.
* ✅ Database integration.
* ✅ People filtering.
* ✅ Record counter.
* ✅ Add Person interface entry point.

Future development will continue by implementing the remaining DVLD modules.

---

# 🚀 Future Development

The project will continue to evolve by adding:

* Driver Management.
* User Management.
* License Applications.
* Local Driving Licenses.
* International Driving Licenses.
* License Renewal.
* License Replacement.
* Detained Licenses.
* Traffic Violations.
* Application Management.
* User Permissions.
* Additional filtering and searching.
* Reports and statistics.

---

# 📸 Screenshots

## Main Interface

![DVLD Main Interface](Screenshots/Main-Interface.png)

## People Management

![Manage People](Screenshots/Manage-People.png)

---

# 👨‍💻 Author

**Morad Mahmoud Ahmed Qiad Hashem**

Computer Science Student

---

# 📄 License

This project is developed for educational and learning purposes.

---

# ⭐ Project Status

🚧 **In Development**

The project is being developed gradually, with new modules and functionality being added over time.
