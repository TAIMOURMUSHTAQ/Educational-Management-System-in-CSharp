-- =============================================
-- Educational Management System - Database Setup Script
-- Run this script in SQL Server Management Studio
-- =============================================
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
-- =============================================
-- Create Admin Table
-- =============================================
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

-- Insert default admin user (Username: admin, Password: admin123)
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
-- =============================================
-- Create Students Table
-- =============================================
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
-- =============================================
-- Create Teachers Table
-- =============================================
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
-- =============================================
-- Create Attendance Table
-- =============================================
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
        Status NVARCHAR (20) NOT NULL, -- Present, Absent, Leave
        CreatedDate DATETIME DEFAULT GETDATE (),
        FOREIGN KEY (StudentId) REFERENCES Students (StudentId) ON DELETE CASCADE
    );

-- Create index for faster queries
CREATE INDEX IX_Attendance_Date ON Attendance (AttendanceDate);

CREATE INDEX IX_Attendance_StudentId ON Attendance (StudentId);

END GO
-- =============================================
-- Create Timetable Table
-- =============================================
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

-- Create index for faster queries
CREATE INDEX IX_Timetable_ClassSection ON Timetable (Class, Section);

CREATE INDEX IX_Timetable_Day ON Timetable (Day);

END GO
-- =============================================
-- Insert Sample Data
-- =============================================
-- Sample Students
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
        '0300-1234567',
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
        '0301-2345678',
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
        '0302-3456789',
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
        '0303-4567890',
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
        '0304-5678901',
        'Faisalabad, Pakistan',
        '2009-11-30',
        'Male',
        '11',
        'A'
    );

END GO
-- Sample Teachers
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
        '0305-1111111',
        'Lahore, Pakistan',
        'Male',
        'Mathematics',
        'PhD Mathematics',
        85000
    ),
    (
        'Ms. Ayesha Siddiqui',
        'ayesha@edu.com',
        '0306-2222222',
        'Karachi, Pakistan',
        'Female',
        'English',
        'MA English',
        65000
    ),
    (
        'Mr. Kamran Ali',
        'kamran@edu.com',
        '0307-3333333',
        'Islamabad, Pakistan',
        'Male',
        'Physics',
        'MSc Physics',
        70000
    ),
    (
        'Mrs. Sana Malik',
        'sana@edu.com',
        '0308-4444444',
        'Rawalpindi, Pakistan',
        'Female',
        'Chemistry',
        'MSc Chemistry',
        68000
    ),
    (
        'Mr. Faisal Ahmed',
        'faisal@edu.com',
        '0309-5555555',
        'Lahore, Pakistan',
        'Male',
        'Computer Science',
        'BS Computer Science',
        75000
    );

END GO
-- Sample Timetable
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
    -- Class 10-A Schedule
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
        'Monday',
        'Computer Science',
        5,
        '01:00',
        '02:00'
    ),
    (
        '10',
        'A',
        'Tuesday',
        'Chemistry',
        4,
        '08:00',
        '09:00'
    ),
    (
        '10',
        'A',
        'Tuesday',
        'Computer Science',
        5,
        '09:00',
        '10:00'
    ),
    (
        '10',
        'A',
        'Tuesday',
        'Mathematics',
        1,
        '10:30',
        '11:30'
    ),
    (
        '10',
        'A',
        'Tuesday',
        'English',
        2,
        '11:30',
        '12:30'
    ),
    (
        '10',
        'A',
        'Tuesday',
        'Physics',
        3,
        '01:00',
        '02:00'
    ),
    (
        '10',
        'A',
        'Wednesday',
        'English',
        2,
        '08:00',
        '09:00'
    ),
    (
        '10',
        'A',
        'Wednesday',
        'Physics',
        3,
        '09:00',
        '10:00'
    ),
    (
        '10',
        'A',
        'Wednesday',
        'Chemistry',
        4,
        '10:30',
        '11:30'
    ),
    (
        '10',
        'A',
        'Wednesday',
        'Mathematics',
        1,
        '11:30',
        '12:30'
    ),
    (
        '10',
        'A',
        'Wednesday',
        'Computer Science',
        5,
        '01:00',
        '02:00'
    ),
    (
        '10',
        'A',
        'Thursday',
        'Physics',
        3,
        '08:00',
        '09:00'
    ),
    (
        '10',
        'A',
        'Thursday',
        'Mathematics',
        1,
        '09:00',
        '10:00'
    ),
    (
        '10',
        'A',
        'Thursday',
        'English',
        2,
        '10:30',
        '11:30'
    ),
    (
        '10',
        'A',
        'Thursday',
        'Computer Science',
        5,
        '11:30',
        '12:30'
    ),
    (
        '10',
        'A',
        'Thursday',
        'Chemistry',
        4,
        '01:00',
        '02:00'
    ),
    (
        '10',
        'A',
        'Friday',
        'Computer Science',
        5,
        '08:00',
        '09:00'
    ),
    (
        '10',
        'A',
        'Friday',
        'Chemistry',
        4,
        '09:00',
        '10:00'
    ),
    (
        '10',
        'A',
        'Friday',
        'Physics',
        3,
        '10:30',
        '11:30'
    ),
    (
        '10',
        'A',
        'Friday',
        'English',
        2,
        '11:30',
        '12:30'
    ),
    (
        '10',
        'A',
        'Friday',
        'Mathematics',
        1,
        '01:00',
        '02:00'
    ),
    -- Class 9-B Schedule
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
        'Monday',
        'Physics',
        3,
        '10:30',
        '11:30'
    ),
    (
        '9',
        'B',
        'Monday',
        'Chemistry',
        4,
        '11:30',
        '12:30'
    ),
    (
        '9',
        'B',
        'Tuesday',
        'English',
        2,
        '08:00',
        '09:00'
    ),
    (
        '9',
        'B',
        'Tuesday',
        'Mathematics',
        1,
        '09:00',
        '10:00'
    ),
    (
        '9',
        'B',
        'Tuesday',
        'Chemistry',
        4,
        '10:30',
        '11:30'
    ),
    (
        '9',
        'B',
        'Tuesday',
        'Physics',
        3,
        '11:30',
        '12:30'
    ),
    (
        '9',
        'B',
        'Wednesday',
        'Physics',
        3,
        '08:00',
        '09:00'
    ),
    (
        '9',
        'B',
        'Wednesday',
        'Chemistry',
        4,
        '09:00',
        '10:00'
    ),
    (
        '9',
        'B',
        'Wednesday',
        'English',
        2,
        '10:30',
        '11:30'
    ),
    (
        '9',
        'B',
        'Wednesday',
        'Mathematics',
        1,
        '11:30',
        '12:30'
    ),
    -- Class 8-C Schedule
    (
        '8',
        'C',
        'Monday',
        'Mathematics',
        1,
        '08:00',
        '09:00'
    ),
    (
        '8',
        'C',
        'Monday',
        'English',
        2,
        '09:00',
        '10:00'
    ),
    (
        '8',
        'C',
        'Monday',
        'Science',
        3,
        '10:30',
        '11:30'
    ),
    (
        '8',
        'C',
        'Tuesday',
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
        '8',
        'C',
        'Tuesday',
        'Science',
        3,
        '10:30',
        '11:30'
    ),
    -- Class 11-A Schedule
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
    ),
    (
        '11',
        'A',
        'Monday',
        'Computer Science',
        5,
        '11:30',
        '12:30'
    ),
    (
        '11',
        'A',
        'Tuesday',
        'Physics',
        3,
        '08:00',
        '09:00'
    ),
    (
        '11',
        'A',
        'Tuesday',
        'Chemistry',
        4,
        '09:00',
        '10:00'
    ),
    (
        '11',
        'A',
        'Tuesday',
        'Mathematics',
        1,
        '10:30',
        '11:30'
    ),
    (
        '11',
        'A',
        'Tuesday',
        'Computer Science',
        5,
        '11:30',
        '12:30'
    );

END GO
-- =============================================
-- Create ExamMarks Table
-- =============================================
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
        Percentage AS (
            CAST(ObtainedMarks AS DECIMAL(5, 2)) / TotalMarks * 100
        ),
        Grade NVARCHAR (5),
        ExamDate DATE DEFAULT GETDATE (),
        CreatedDate DATETIME DEFAULT GETDATE (),
        FOREIGN KEY (StudentId) REFERENCES Students (StudentId) ON DELETE CASCADE
    );

-- Insert Sample Exam Marks
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
    (3, 'Science', 88, 100, 'A'),
    (4, 'Mathematics', 68, 100, 'B'),
    (4, 'English', 75, 100, 'B+'),
    (4, 'Science', 71, 100, 'B'),
    (5, 'Mathematics', 90, 100, 'A+'),
    (5, 'Physics', 85, 100, 'A'),
    (5, 'Chemistry', 92, 100, 'A+');

END GO
-- =============================================
-- Print Success Message
-- =============================================
PRINT 'Database setup completed successfully!';

PRINT 'Default Admin Credentials:';

PRINT 'Username: admin';

PRINT 'Password: admin123';

GO