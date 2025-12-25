-- =====================================================================
--  Educational Management System - Full Database Script
--  Generated: December 22, 2025
-- =====================================================================

-- Drop database if exists (uncomment if you want to reset)
-- DROP DATABASE IF EXISTS [EducationalManagementDB];

-- Create database
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'EducationalManagementDB')
    CREATE DATABASE [EducationalManagementDB];
GO

USE [EducationalManagementDB];
GO

-- =====================
-- Table: Admin
-- =====================
IF OBJECT_ID('Admin', 'U') IS NOT NULL DROP TABLE Admin;
CREATE TABLE Admin (
    AdminId INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL,
    Email NVARCHAR(100),
    CreatedAt DATETIME DEFAULT GETDATE()
);
GO

-- =====================
IF OBJECT_ID('Students', 'U') IS NOT NULL DROP TABLE Students;
CREATE TABLE Students (
    StudentId INT PRIMARY KEY IDENTITY(1,1),
    StudentName NVARCHAR(100) NOT NULL,
    FatherName NVARCHAR(100),
    Email NVARCHAR(100),
    Phone NVARCHAR(20),
    Address NVARCHAR(255),
    Gender NVARCHAR(10),
    Class NVARCHAR(20),
    Section NVARCHAR(10),
    DateOfBirth DATE,
    AdmissionDate DATE,
    CreatedAt DATETIME DEFAULT GETDATE()
);
GO

-- =====================
-- Table: Teachers
-- =====================
IF OBJECT_ID('Teachers', 'U') IS NOT NULL DROP TABLE Teachers;
CREATE TABLE Teachers (
    TeacherId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100),
    Phone NVARCHAR(20),
    Address NVARCHAR(255),
    Subject NVARCHAR(50),
    Qualification NVARCHAR(100),
    Salary DECIMAL(10,2),
    CreatedAt DATETIME DEFAULT GETDATE()
);
GO

-- =====================
IF OBJECT_ID('Attendance', 'U') IS NOT NULL DROP TABLE Attendance;
CREATE TABLE Attendance (
    AttendanceId INT PRIMARY KEY IDENTITY(1,1),
    StudentId INT NOT NULL,
    StudentName NVARCHAR(100),
    AttendanceDate DATETIME NOT NULL,
    Status NVARCHAR(20) NOT NULL,
    Class NVARCHAR(20),
    Section NVARCHAR(10),
    Remarks NVARCHAR(255),
    CreatedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (StudentId) REFERENCES Students(StudentId)
);
GO

-- =====================
-- Table: Timetable
-- =====================
IF OBJECT_ID('Timetable', 'U') IS NOT NULL DROP TABLE Timetable;
CREATE TABLE Timetable (
    TimetableId INT PRIMARY KEY IDENTITY(1,1),
    Class NVARCHAR(20) NOT NULL,
    Section NVARCHAR(10),
    Day NVARCHAR(20) NOT NULL,
    Subject NVARCHAR(50) NOT NULL,
    TeacherId INT,
    TeacherName NVARCHAR(100),
    StartTime TIME NOT NULL,
    EndTime TIME NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (TeacherId) REFERENCES Teachers(TeacherId)
);
GO

-- =====================
-- Sample Data
-- =====================

-- Admin
INSERT INTO Admin (Username, Password, Email) VALUES ('admin', 'admin123', 'admin@school.edu');
GO

-- Students
INSERT INTO Students (StudentName, FatherName, Email, Phone, Address, Gender, Class, Section, DateOfBirth, AdmissionDate) VALUES
('John Smith', 'Michael Smith', 'john.smith@email.com', '1234567890', '123 Main St', 'Male', '10', 'A', '2008-05-15', '2020-04-01'),
('Sarah Johnson', 'David Johnson', 'sarah.j@email.com', '0987654321', '456 Oak Ave', 'Female', '10', 'A', '2008-03-22', '2020-04-01'),
('Michael Brown', 'Robert Brown', 'michael.b@email.com', '5551234567', '789 Pine Rd', 'Male', '9', 'B', '2009-07-10', '2021-04-01'),
('Emily Davis', 'James Davis', 'emily.d@email.com', '5559876543', '321 Elm St', 'Female', '11', 'A', '2007-11-28', '2019-04-01'),
('David Wilson', 'Richard Wilson', 'david.w@email.com', '5554567890', '654 Maple Dr', 'Male', '12', 'B', '2006-09-05', '2018-04-01');
GO

-- Teachers
INSERT INTO Teachers (TeacherName, Email, Phone, Address, Gender, Subject, Qualification, Salary, JoiningDate) VALUES
('Mr. Robert Anderson', 'robert.a@school.edu', '5551112222', '100 Faculty Rd', 'Male', 'Mathematics', 'M.Sc. Mathematics', 55000, '2015-08-01'),
('Ms. Jennifer Martinez', 'jennifer.m@school.edu', '5552223333', '101 Faculty Rd', 'Female', 'English', 'M.A. English', 52000, '2016-09-01'),
('Dr. William Taylor', 'william.t@school.edu', '5553334444', '102 Faculty Rd', 'Male', 'Science', 'Ph.D. Physics', 60000, '2014-07-15'),
('Mrs. Linda Thomas', 'linda.t@school.edu', '5554445555', '103 Faculty Rd', 'Female', 'History', 'M.A. History', 50000, '2017-01-10'),
('Mr. James Jackson', 'james.j@school.edu', '5555556666', '104 Faculty Rd', 'Male', 'Computer Science', 'M.Tech CS', 58000, '2018-03-20');
GO

-- Attendance (empty, add as needed)
-- Timetable (empty, add as needed)

-- =====================
-- End of Script
-- =====================
