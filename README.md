# 🎓 Educational Management System

<div align="center">

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET_Framework_4.7.2-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)

**A comprehensive desktop application for managing educational institutions**

[Features](#-features) • [Screenshots](#-screenshots) • [Installation](#-installation) • [Database Setup](#-database-setup) • [Usage](#-usage) • [Project Structure](#-project-structure)

</div>

---

## 📋 Overview

The **Educational Management System** is a robust Windows Forms desktop application designed to streamline the administrative tasks of educational institutions. Built with C# and SQL Server using ADO.NET, this system provides an intuitive interface for managing students, teachers, attendance records, and class timetables.

### 🎯 Key Highlights

- ✅ **Modern UI Design** - Clean, attractive interface with color-coded modules
- ✅ **Secure Authentication** - Admin-only login system with database validation
- ✅ **Full CRUD Operations** - Create, Read, Update, Delete for all entities
- ✅ **Real-time Statistics** - Dashboard with live counts and metrics
- ✅ **Search & Filter** - Quick search functionality across all modules
- ✅ **Beginner-Friendly Code** - Well-structured, documented codebase

---

## ✨ Features

### 🔐 Login Module

- Secure admin authentication
- Password validation against SQL Server database
- Session management

### 📊 Dashboard

- Real-time statistics display
- Total Students count
- Total Teachers count
- Today's Attendance summary
- Active Timetable entries
- Quick navigation to all modules

### 👨‍🎓 Student Management

- Add new students with complete details
- View all students in a data grid
- Update student information
- Delete student records
- Search students by name or ID
- Fields: Student ID, Name, Email, Phone, Address, Class, Section, Date of Birth

### 👨‍🏫 Teacher Management

- Complete teacher profile management
- Subject assignment
- Contact information management
- Search and filter capabilities
- Fields: Teacher ID, Name, Email, Phone, Address, Subject, Qualification, Salary

### 📅 Attendance Management

- Mark daily attendance (Present/Absent/Late)
- Date-wise attendance tracking
- Student-wise attendance history
- Filter by date and status
- Attendance reports

### 🗓️ Timetable Management

- Class-wise timetable creation
- Day and time slot management
- Subject and teacher assignment
- Section-based scheduling
- Weekly timetable view

---

## 📸 Screenshots

### Login Screen

```
┌─────────────────────────────────────────────────────────┐
│                                                         │
│              🎓 EDUCATIONAL MANAGEMENT SYSTEM           │
│                                                         │
│         ┌─────────────────────────────────┐             │
│         │  👤 Username: [admin         ]  │             │
│         │  🔑 Password: [••••••••      ]  │             │
│         │                                 │             │
│         │        [ 🔓 LOGIN ]             │             │
│         └─────────────────────────────────┘             │
│                                                         │
│              Default: admin / admin123                  │
└─────────────────────────────────────────────────────────┘
```

### Dashboard

```
┌─────────────────────────────────────────────────────────────────────┐
│  📚 Educational Management System                    [Admin] [Exit] │
├─────────────┬───────────────────────────────────────────────────────┤
│             │                                                       │
│  📊 Dashboard│    ┌──────────┐  ┌──────────┐  ┌──────────┐         │
│             │    │ 👨‍🎓 125   │  │ 👨‍🏫 45    │  │ ✓ 98%   │         │
│  👨‍🎓 Students │    │ Students │  │ Teachers │  │ Present │         │
│             │    └──────────┘  └──────────┘  └──────────┘         │
│  👨‍🏫 Teachers │                                                     │
│             │    ┌──────────┐                                      │
│  📅 Attendance│   │ 🗓️ 32    │                                      │
│             │    │ Classes  │                                      │
│  🗓️ Timetable│    └──────────┘                                      │
│             │                                                       │
│  🚪 Logout   │                                                       │
└─────────────┴───────────────────────────────────────────────────────┘
```

### Student Management

```
┌─────────────────────────────────────────────────────────────────────┐
│  👨‍🎓 Student Management                               [Back] [Exit] │
├─────────────────────────────────────────────────────────────────────┤
│                                                                     │
│  Name: [________________]    Email: [________________]              │
│  Phone: [_______________]    Address: [______________]              │
│  Class: [___]  Section: [_]  DOB: [__/__/____]                     │
│                                                                     │
│  [➕ Add]  [✏️ Update]  [🗑️ Delete]  [🔄 Clear]                      │
│                                                                     │
│  🔍 Search: [________________]                                      │
│  ┌─────┬──────────┬─────────────────┬────────────┬───────┬───────┐ │
│  │ ID  │ Name     │ Email           │ Phone      │ Class │ Sec   │ │
│  ├─────┼──────────┼─────────────────┼────────────┼───────┼───────┤ │
│  │ 1   │ John Doe │ john@email.com  │ 1234567890 │ 10    │ A     │ │
│  │ 2   │ Jane Doe │ jane@email.com  │ 0987654321 │ 10    │ B     │ │
│  └─────┴──────────┴─────────────────┴────────────┴───────┴───────┘ │
└─────────────────────────────────────────────────────────────────────┘
```

---

## 🚀 Installation

### Prerequisites

Before running this application, ensure you have:

| Requirement    | Version | Download Link                                                               |
| -------------- | ------- | --------------------------------------------------------------------------- |
| Windows OS     | 10/11   | -                                                                           |
| .NET Framework | 4.7.2+  | [Download](https://dotnet.microsoft.com/download/dotnet-framework/net472)   |
| SQL Server     | 2017+   | [Download](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) |
| Visual Studio  | 2017+   | [Download](https://visualstudio.microsoft.com/)                             |

### Quick Start

1. **Clone the repository**

   ```bash
   git clone https://github.com/YOUR_USERNAME/Educational-Management-System.git
   cd Educational-Management-System
   ```

2. **Set up the database** (see [Database Setup](#-database-setup))

3. **Open the solution**

   ```
   Double-click: EducationalManagementSystem.sln
   ```

4. **Build and Run**
   ```
   Press F5 or click Start in Visual Studio
   ```

---

## 💾 Database Setup

### Step 1: Open SQL Server Management Studio (SSMS)

### Step 2: Execute the SQL Script

1. Open `DatabaseSetup.sql` from the project folder
2. Execute the entire script (press F5)

This will create:

- ✅ Database: `EducationalManagementDB`
- ✅ Tables: `Admin`, `Students`, `Teachers`, `Attendance`, `Timetable`
- ✅ Sample data for testing
- ✅ Default admin user

### Step 3: Verify Connection String

Check `App.config` for the connection string:

```xml
<connectionStrings>
  <add name="EMSConnection"
       connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=EducationalManagementDB;Integrated Security=True;TrustServerCertificate=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

> **Note:** Modify `Data Source` if your SQL Server instance name is different.

---

## 🔑 Usage

### Default Login Credentials

| Username | Password   |
| -------- | ---------- |
| `admin`  | `admin123` |

### Navigation

1. **Login** → Enter credentials → Click Login
2. **Dashboard** → View statistics → Click any module
3. **Manage Data** → Add/Edit/Delete records
4. **Logout** → Return to login screen

---

## 📁 Project Structure

```
EducationalManagementSystem/
│
├── 📄 EducationalManagementSystem.sln    # Solution file
├── 📄 EducationalManagementSystem.csproj # Project file
├── 📄 App.config                         # Configuration (connection string)
├── 📄 Program.cs                         # Application entry point
├── 📄 DatabaseSetup.sql                  # SQL script for database
├── 📄 README.md                          # This file
│
├── 📂 Forms/
│   ├── LoginForm.cs                      # Login screen
│   ├── DashboardForm.cs                  # Main dashboard
│   ├── StudentManagementForm.cs          # Student CRUD
│   ├── TeacherManagementForm.cs          # Teacher CRUD
│   ├── AttendanceForm.cs                 # Attendance management
│   └── TimetableForm.cs                  # Timetable management
│
├── 📂 Models/
│   └── Models.cs                         # Data models (Student, Teacher, etc.)
│
├── 📂 Utilities/
│   └── DatabaseHelper.cs                 # ADO.NET database helper
│
└── 📂 Properties/
    ├── AssemblyInfo.cs
    ├── Resources.resx
    └── Settings.settings
```

---

## 🛠️ Technologies Used

| Technology                    | Purpose                      |
| ----------------------------- | ---------------------------- |
| **C# (.NET Framework 4.7.2)** | Primary programming language |
| **Windows Forms**             | Desktop UI framework         |
| **SQL Server**                | Database management          |
| **ADO.NET**                   | Database connectivity        |
| **Visual Studio**             | IDE for development          |

---

## 📊 Database Schema

### Entity Relationship

```
┌─────────────┐     ┌─────────────┐     ┌─────────────┐
│   Admin     │     │  Students   │     │  Teachers   │
├─────────────┤     ├─────────────┤     ├─────────────┤
│ AdminId     │     │ StudentId   │     │ TeacherId   │
│ Username    │     │ Name        │     │ Name        │
│ Password    │     │ Email       │     │ Email       │
│ Email       │     │ Phone       │     │ Phone       │
│ CreatedAt   │     │ Address     │     │ Address     │
└─────────────┘     │ Class       │     │ Subject     │
                    │ Section     │     │ Qualification│
                    │ DOB         │     │ Salary      │
                    │ CreatedAt   │     │ CreatedAt   │
                    └──────┬──────┘     └─────────────┘
                           │
              ┌────────────┴────────────┐
              │                         │
        ┌─────┴─────┐            ┌──────┴──────┐
        │ Attendance│            │  Timetable  │
        ├───────────┤            ├─────────────┤
        │AttendanceId│           │ TimetableId │
        │ StudentId │            │ Class       │
        │ Date      │            │ Section     │
        │ Status    │            │ Day         │
        │ Remarks   │            │ Subject     │
        │ CreatedAt │            │ Teacher     │
        └───────────┘            │ StartTime   │
                                 │ EndTime     │
                                 │ CreatedAt   │
                                 └─────────────┘
```

---

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

---

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## 👨‍💻 Author

**Your Name**

- GitHub: [@your-username](https://github.com/your-username)

---

## 🙏 Acknowledgments

- Built as a semester project for educational purposes
- Inspired by modern educational management systems
- Thanks to all contributors and testers

---

<div align="center">

**⭐ If you found this project helpful, please give it a star! ⭐**

Made with ❤️ using C# and SQL Server

</div>
