================================================================================
            EDUCATIONAL MANAGEMENT SYSTEM - USER MANUAL
================================================================================
                    INSTALLATION & SETUP INSTRUCTIONS
================================================================================

Thank you for downloading Educational Management System!

This document will guide you through installing and running the application.

================================================================================
                         SYSTEM REQUIREMENTS
================================================================================

Minimum Requirements:
--------------------
• Operating System: Windows 10 or Windows 11
• RAM: 4 GB minimum
• Storage: 100 MB free space
• Display: 1024 x 768 resolution or higher

Software Requirements:
---------------------
• Microsoft .NET Framework 4.7.2 or higher
• Microsoft SQL Server (Express, Developer, or Full edition)

================================================================================
                    STEP-BY-STEP INSTALLATION
================================================================================

STEP 1: Install .NET Framework (if not installed)
-------------------------------------------------
1. Check if already installed:
   - Press Windows + R
   - Type: control
   - Go to Programs > Programs and Features
   - Look for "Microsoft .NET Framework 4.7.2" or higher

2. If not installed, download from:
   https://dotnet.microsoft.com/download/dotnet-framework/net472

3. Run the installer and follow prompts

STEP 2: Install SQL Server Express (if not installed)
------------------------------------------------------
1. Download SQL Server Express from:
   https://www.microsoft.com/en-us/sql-server/sql-server-downloads
   (Choose "Express" - it's FREE)

2. Run the installer
3. Choose "Basic" installation
4. Note your instance name (usually SQLEXPRESS)
5. Complete installation

STEP 3: Setup the Database
--------------------------
1. Open SQL Server Management Studio (SSMS)
   - If not installed, download from Microsoft

2. Connect to your SQL Server:
   - Server name: .\SQLEXPRESS (or your instance name)
   - Authentication: Windows Authentication
   - Click Connect

3. Open DatabaseSetup.sql:
   - File > Open > File
   - Navigate to and select "DatabaseSetup.sql"

4. Execute the script:
   - Press F5 or click Execute button
   - Wait for "Commands completed successfully"

5. Verify database created:
   - In Object Explorer, expand Databases
   - You should see "EducationalManagementDB"

STEP 4: Configure the Application (if needed)
---------------------------------------------
Only if your SQL Server instance name is different from ".\SQLEXPRESS":

1. Find "EducationalManagementSystem.exe.config"
2. Right-click > Open with > Notepad
3. Find this line:
   Data Source=.\SQLEXPRESS
4. Change SQLEXPRESS to your instance name
5. Save the file

STEP 5: Run the Application
---------------------------
1. Double-click "EducationalManagementSystem.exe"
2. The login screen will appear
3. Enter credentials:
   
   +---------------------------+
   |  Username:  admin         |
   |  Password:  admin123      |
   +---------------------------+

4. Click "Login"
5. Welcome to the Dashboard!

================================================================================
                         HOW TO USE THE SYSTEM
================================================================================

DASHBOARD
---------
The main screen shows:
• Total Students count
• Total Teachers count  
• Today's Attendance percentage
• Total Timetable entries

Click on sidebar buttons to navigate to different modules.

STUDENT MANAGEMENT
------------------
• ADD: Fill in all fields and click "Add" button
• UPDATE: Click a row in the grid, modify fields, click "Update"
• DELETE: Click a row in the grid, click "Delete"
• SEARCH: Type in the search box to filter students
• CLEAR: Reset all form fields

TEACHER MANAGEMENT
------------------
• Same operations as Student Management
• Manage teacher details including subject and salary

ATTENDANCE MANAGEMENT
---------------------
• Select a student from dropdown
• Choose date
• Select status (Present/Absent/Late)
• Add remarks if needed
• Click "Mark Attendance"
• Filter attendance by date or status

TIMETABLE MANAGEMENT
--------------------
• Enter class and section
• Select day of the week
• Enter subject name
• Enter teacher name
• Set start and end time
• Click "Add" to save

LOGOUT
------
• Click "Logout" button to return to login screen
• Click "Exit" to close the application

================================================================================
                         DEFAULT DATA
================================================================================

The database comes with sample data:

Default Admin:
• Username: admin
• Password: admin123

Sample Students:
• John Smith - Class 10-A
• Sarah Johnson - Class 10-A
• Michael Brown - Class 9-B
• Emily Davis - Class 11-A
• David Wilson - Class 12-B

Sample Teachers:
• Mr. Robert Anderson - Mathematics
• Ms. Jennifer Martinez - English
• Dr. William Taylor - Science
• Mrs. Linda Thomas - History
• Mr. James Jackson - Computer Science

================================================================================
                         TROUBLESHOOTING
================================================================================

PROBLEM: Application won't start
SOLUTION: 
• Make sure .NET Framework 4.7.2 is installed
• Try running as Administrator

PROBLEM: "Could not connect to database" error
SOLUTION:
• Check if SQL Server is running (Services > SQL Server)
• Verify database exists in SQL Server Management Studio
• Check connection string in .exe.config file

PROBLEM: Login fails with correct credentials
SOLUTION:
• Run DatabaseSetup.sql again
• Check if Admin table has the admin user

PROBLEM: Data not saving
SOLUTION:
• Check SQL Server is running
• Verify database connection
• Check for error messages

================================================================================
                         SUPPORT
================================================================================

For issues or questions:
• Check the README.md file
• Review the DEPLOYMENT_GUIDE.txt
• Contact the developer

================================================================================
                         VERSION INFORMATION
================================================================================

Application: Educational Management System
Version: 1.0.0
Framework: .NET Framework 4.7.2
Database: SQL Server
Build Date: December 2025

================================================================================
              Thank you for using Educational Management System!
================================================================================
