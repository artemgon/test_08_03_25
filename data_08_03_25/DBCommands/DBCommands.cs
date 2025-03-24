﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_08_03_25.DBCommands
{
    public class DbCommands
    {
        public static string CreateDbCommandWithNotExists(string dbName)
            => $"CREATE DATABASE IF NOT EXISTS {dbName}";

        public static string CreateTablesCommand() => @"
            CREATE TABLE Marks
            (
                Id INT PRIMARY KEY IDENTITY(1,1),
                Average INT NULL
            );

            CREATE TABLE MarksDetail
            (
                Id INT IDENTITY(1,1) PRIMARY KEY,
                MarkId INT FOREIGN KEY REFERENCES Marks(Id),
                Mark INT NOT NULL
            );

            CREATE TABLE Subjects
            (
                Id INT PRIMARY KEY IDENTITY(1,1),
                Name NVARCHAR(50) NOT NULL,
                MarkId INT FOREIGN KEY REFERENCES Marks(Id)
            );

            CREATE TABLE Students
            (
                Id INT PRIMARY KEY IDENTITY(1,1),
                Name NVARCHAR(50) NOT NULL,
                Surname NVARCHAR(50) NOT NULL,
                Course NVARCHAR(50) NOT NULL
            );
            
            CREATE TABLE StudentsSubjects
            (
                StudentId INT FOREIGN KEY REFERENCES Students(Id),
                SubjectId INT FOREIGN KEY REFERENCES Subjects(Id),
                PRIMARY KEY (StudentId, SubjectId)
            );";

        public static string DropTablesCommand()
            => @" DROP TABLE IF EXISTS StudentsSubjects;
                  DROP TABLE IF EXISTS Students;
                  DROP TABLE IF EXISTS Subjects;
                  DROP TABLE IF EXISTS MarksDetail;
                  DROP TABLE IF EXISTS Marks;";
    }
}
