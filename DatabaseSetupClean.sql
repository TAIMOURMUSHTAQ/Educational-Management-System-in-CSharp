-- Educational Management System - Database Setup Script
-- Run this script in SQL Server Management Studio
-- Create the database
IF NOT EXISTS (
    SELECT
        name
    FROM
        sys.databases
    WHERE
        name = 'EducationalManagementDB'
) BEGIN CREATE DATABASE EducationalManagementDB;

END GO USE EducationalManagementDB;

GO
-- Create Admin Table
IF NOT EXISTS (
    SELECT
        *
    FROM
        sys.tables
    WHERE
        name = 'Admin'
) BEGIN
CREATE TABLE
    Admin (
        AdminId INT PRIMARY KEY IDENTITY (1, 1),
        Username NVARCHAR (50) NOT NULL UNIQUE,
        Password NVARCHAR (100) NOT NULL,
        FullName NVARCHAR (100),
        Email NVARCHAR (100),
        CreatedDate DATETIME DEFAULT GETDATE ()
    );

INSERT INTO
    Admin (Username, Password, FullName, Email)
VALUES
    (
        'admin',
        'admin123',
        'System Administrator',
        'admin@edu.com'
    );

END GO
-- Create Students Table
IF NOT EXISTS (
    SELECT
        *
    FROM
        sys.tables
    WHERE
        name = 'Students'
) BEGIN
CREATE TABLE
    Students (
        StudentId INT PRIMARY KEY IDENTITY (1, 1),
        StudentName NVARCHAR (100) NOT NULL,
        FatherName NVARCHAR (100) NOT NULL,
        Email NVARCHAR (100),
        Phone NVARCHAR (20),
        Address NVARCHAR (255),
        DateOfBirth DATE,
        Gender NVARCHAR (10),
        Class NVARCHAR (10) NOT NULL,
        Section NVARCHAR (5) NOT NULL,
        AdmissionDate DATE DEFAULT GETDATE (),
        CreatedDate DATETIME DEFAULT GETDATE ()
    );

END GO
-- Create Teachers Table
IF NOT EXISTS (
    SELECT
        *
    FROM
        sys.tables
    WHERE
        name = 'Teachers'
) BEGIN
CREATE TABLE
    Teachers (
        TeacherId INT PRIMARY KEY IDENTITY (1, 1),
        TeacherName NVARCHAR (100) NOT NULL,
        Email NVARCHAR (100),
        Phone NVARCHAR (20),
        Address NVARCHAR (255),
        Gender NVARCHAR (10),
        Subject NVARCHAR (50),
        Qualification NVARCHAR (100),
        Salary DECIMAL(10, 2),
        JoiningDate DATE DEFAULT GETDATE (),
        CreatedDate DATETIME DEFAULT GETDATE ()
    );

END GO
-- Create Attendance Table
IF NOT EXISTS (
    SELECT
        *
    FROM
        sys.tables
    WHERE
        name = 'Attendance'
) BEGIN
CREATE TABLE
    Attendance (
        AttendanceId INT PRIMARY KEY IDENTITY (1, 1),
        StudentId INT NOT NULL,
        AttendanceDate DATE NOT NULL,
        Status NVARCHAR (20) NOT NULL,
        CreatedDate DATETIME DEFAULT GETDATE (),
        FOREIGN KEY (StudentId) REFERENCES Students (StudentId) ON DELETE CASCADE
    );

END GO
-- Create Timetable Table
IF NOT EXISTS (
    SELECT
        *
    FROM
        sys.tables
    WHERE
        name = 'Timetable'
) BEGIN
CREATE TABLE
    Timetable (
        TimetableId INT PRIMARY KEY IDENTITY (1, 1),
        Class NVARCHAR (10) NOT NULL,
        Section NVARCHAR (5) NOT NULL,
        Day NVARCHAR (20) NOT NULL,
        Subject NVARCHAR (50) NOT NULL,
        TeacherId INT,
        StartTime TIME NOT NULL,
        EndTime TIME NOT NULL,
        CreatedDate DATETIME DEFAULT GETDATE (),
        FOREIGN KEY (TeacherId) REFERENCES Teachers (TeacherId) ON DELETE SET NULL
    );

END GO
-- Create ExamMarks Table
IF NOT EXISTS (
    SELECT
        *
    FROM
        sys.tables
    WHERE
        name = 'ExamMarks'
) BEGIN
CREATE TABLE
    ExamMarks (
        MarkId INT PRIMARY KEY IDENTITY (1, 1),
        StudentId INT NOT NULL,
        Subject NVARCHAR (50) NOT NULL,
        ObtainedMarks INT NOT NULL,
        TotalMarks INT NOT NULL DEFAULT 100,
        Grade NVARCHAR (5),
        ExamDate DATE DEFAULT GETDATE (),
        CreatedDate DATETIME DEFAULT GETDATE (),
        FOREIGN KEY (StudentId) REFERENCES Students (StudentId) ON DELETE CASCADE
    );

END GO
-- Insert Sample Students
IF NOT EXISTS (
    SELECT
        *
    FROM
        Students
) BEGIN
INSERT INTO
    Students (
        StudentName,
        FatherName,
        Email,
        Phone,
        Address,
        DateOfBirth,
        Gender,
        Class,
        Section
    )
VALUES
    (
        'Ahmed Khan',
        'Muhammad Khan',
        'ahmed@email.com',
        '03001234567',
        'Lahore, Pakistan',
        '2010-05-15',
        'Male',
        '10',
        'A'
    ),
    (
        'Sara Ali',
        'Ali Ahmed',
        'sara@email.com',
        '03012345678',
        'Karachi, Pakistan',
        '2011-03-20',
        'Female',
        '9',
        'B'
    ),
    (
        'Usman Malik',
        'Tariq Malik',
        'usman@email.com',
        '03023456789',
        'Islamabad, Pakistan',
        '2010-08-10',
        'Male',
        '10',
        'A'
    ),
    (
        'Fatima Zahra',
        'Hassan Raza',
        'fatima@email.com',
        '03034567890',
        'Rawalpindi, Pakistan',
        '2012-01-25',
        'Female',
        '8',
        'C'
    ),
    (
        'Bilal Hussain',
        'Hussain Shah',
        'bilal@email.com',
        '03045678901',
        'Faisalabad, Pakistan',
        '2009-11-30',
        'Male',
        '11',
        'A'
    );

END GO
-- Insert Sample Teachers
IF NOT EXISTS (
    SELECT
        *
    FROM
        Teachers
) BEGIN
INSERT INTO
    Teachers (
        TeacherName,
        Email,
        Phone,
        Address,
        Gender,
        Subject,
        Qualification,
        Salary
    )
VALUES
    (
        'Dr. Ahmad Raza',
        'ahmad.raza@edu.com',
        '03051111111',
        'Lahore, Pakistan',
        'Male',
        'Mathematics',
        'PhD Mathematics',
        85000
    ),
    (
        'Ms. Ayesha Siddiqui',
        'ayesha@edu.com',
        '03062222222',
        'Karachi, Pakistan',
        'Female',
        'English',
        'MA English',
        65000
    ),
    (
        'Mr. Kamran Ali',
        'kamran@edu.com',
        '03073333333',
        'Islamabad, Pakistan',
        'Male',
        'Physics',
        'MSc Physics',
        70000
    ),
    (
        'Mrs. Sana Malik',
        'sana@edu.com',
        '03084444444',
        'Rawalpindi, Pakistan',
        'Female',
        'Chemistry',
        'MSc Chemistry',
        68000
    ),
    (
        'Mr. Faisal Ahmed',
        'faisal@edu.com',
        '03095555555',
        'Lahore, Pakistan',
        'Male',
        'Computer Science',
        'BS Computer Science',
        75000
    );

END GO
-- Insert Sample Timetable
IF NOT EXISTS (
    SELECT
        *
    FROM
        Timetable
) BEGIN
INSERT INTO
    Timetable (
        Class,
        Section,
        Day,
        Subject,
        TeacherId,
        StartTime,
        EndTime
    )
VALUES
    (
        '10',
        'A',
        'Monday',
        'Mathematics',
        1,
        '08:00',
        '09:00'
    ),
    (
        '10',
        'A',
        'Monday',
        'English',
        2,
        '09:00',
        '10:00'
    ),
    (
        '10',
        'A',
        'Monday',
        'Physics',
        3,
        '10:30',
        '11:30'
    ),
    (
        '10',
        'A',
        'Monday',
        'Chemistry',
        4,
        '11:30',
        '12:30'
    ),
    (
        '10',
        'A',
        'Tuesday',
        'Computer Science',
        5,
        '08:00',
        '09:00'
    ),
    (
        '10',
        'A',
        'Tuesday',
        'Mathematics',
        1,
        '09:00',
        '10:00'
    ),
    (
        '10',
        'A',
        'Tuesday',
        'English',
        2,
        '10:30',
        '11:30'
    ),
    (
        '9',
        'B',
        'Monday',
        'Mathematics',
        1,
        '08:00',
        '09:00'
    ),
    (
        '9',
        'B',
        'Monday',
        'English',
        2,
        '09:00',
        '10:00'
    ),
    (
        '9',
        'B',
        'Tuesday',
        'Physics',
        3,
        '08:00',
        '09:00'
    ),
    (
        '8',
        'C',
        'Monday',
        'English',
        2,
        '08:00',
        '09:00'
    ),
    (
        '8',
        'C',
        'Tuesday',
        'Mathematics',
        1,
        '09:00',
        '10:00'
    ),
    (
        '11',
        'A',
        'Monday',
        'Mathematics',
        1,
        '08:00',
        '09:00'
    ),
    (
        '11',
        'A',
        'Monday',
        'Physics',
        3,
        '09:00',
        '10:00'
    ),
    (
        '11',
        'A',
        'Monday',
        'Chemistry',
        4,
        '10:30',
        '11:30'
    );

END GO
-- Insert Sample Exam Marks
IF NOT EXISTS (
    SELECT
        *
    FROM
        ExamMarks
) BEGIN
INSERT INTO
    ExamMarks (
        StudentId,
        Subject,
        ObtainedMarks,
        TotalMarks,
        Grade
    )
VALUES
    (1, 'Mathematics', 85, 100, 'A'),
    (1, 'English', 78, 100, 'B+'),
    (1, 'Science', 92, 100, 'A+'),
    (1, 'Physics', 76, 100, 'B+'),
    (1, 'Chemistry', 88, 100, 'A'),
    (2, 'Mathematics', 72, 100, 'B'),
    (2, 'English', 88, 100, 'A'),
    (2, 'Science', 79, 100, 'B+'),
    (3, 'Mathematics', 95, 100, 'A+'),
    (3, 'English', 82, 100, 'A'),
    (3, 'Science', 88, 100, 'A');

END GO PRINT 'Database setup completed successfully!';

PRINT 'Default Admin Credentials: admin / admin123';

PRINT 'Teacher Login: ahmad.raza@edu.com / 03051111111';

PRINT 'Student Login: ahmed@email.com / 03001234567';

GO