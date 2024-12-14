-- ----------------------------------------------------------------------
-- Create the database
-- ----------------------------------------------------------------------

USE Master;
	DROP DATABASE IF EXISTS StudentGrades;
	CREATE DATABASE StudentGrades;
	ALTER DATABASE StudentGrades
		COLLATE Latin1_General_CI_AS;
	GO

-- ----------------------------------------------------------------------
-- Use the database
-- ----------------------------------------------------------------------

USE StudentGrades;

DROP TABLE IF EXISTS Students;
DROP TABLE IF EXISTS Professors;
DROP TABLE IF EXISTS Courses;
DROP TABLE IF EXISTS Quizzes;
DROP TABLE IF EXISTS Questions;
DROP TABLE IF EXISTS Enrollments;
DROP TABLE IF EXISTS QuizAttempts;
DROP TABLE IF EXISTS QuestionAttempts;

DROP PROCEDURE IF EXISTS spInsertNewStudent;
DROP PROCEDURE IF EXISTS spUpdateStudent;
DROP PROCEDURE IF EXISTS spDeleteStudent;

DROP PROCEDURE IF EXISTS spInsertNewProfessor;
DROP PROCEDURE IF EXISTS spUpdateProfessor;
DROP PROCEDURE IF EXISTS spDeleteProfessor;

DROP PROCEDURE IF EXISTS spInsertNewCourse;
DROP PROCEDURE IF EXISTS spUpdateCourse;
DROP PROCEDURE IF EXISTS spDeleteCourse;

DROP PROCEDURE IF EXISTS spInsertNewQuiz;
DROP PROCEDURE IF EXISTS spUpdateQuiz;
DROP PROCEDURE IF EXISTS spDeleteQuiz;

DROP PROCEDURE IF EXISTS spInsertNewQuestion;
DROP PROCEDURE IF EXISTS spUpdateQuestion;
DROP PROCEDURE IF EXISTS spDeleteQuestion;

DROP PROCEDURE IF EXISTS spInsertNewEnrollment;
DROP PROCEDURE IF EXISTS spUpdateEnrollment;
DROP PROCEDURE IF EXISTS spDeleteEnrollment;

DROP PROCEDURE IF EXISTS spInsertNewQuizAttempts;
DROP PROCEDURE IF EXISTS spUpdateQuizAttempts;
DROP PROCEDURE IF EXISTS spDeleteQuizAttempts;

DROP PROCEDURE IF EXISTS spInsertNewQuestionAttempts;
DROP PROCEDURE IF EXISTS spUpdateQuestionAttempts;
DROP PROCEDURE IF EXISTS spDeleteQuestionAttempts;

-- ----------------------------------------------------------------------
-- Create the tables
-- ----------------------------------------------------------------------

CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100) NOT NULL UNIQUE,
    Password INT NOT NULL,
    CONSTRAINT student_password_len_chk CHECK (Password BETWEEN 1000 AND 9999)
);

CREATE TABLE Professors (
    ProfessorID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100) NOT NULL UNIQUE,
    Password INT NOT NULL,
    CONSTRAINT professor_password_len_chk CHECK (Password BETWEEN 1000 AND 9999)
);

CREATE TABLE Courses (
    CourseID CHAR(8) PRIMARY KEY,
    ProfessorID INT,
    Name VARCHAR(50),
    FOREIGN KEY (ProfessorID) REFERENCES Professors(ProfessorID)
);

CREATE TABLE Quizzes (
    QuizID INT PRIMARY KEY,
    CourseID CHAR(8),
    Name VARCHAR(50),
    TotalMarks INT,
	StartTime DATETIME,
	EndTime DATETIME,
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

CREATE TABLE Questions (
    QuestionID INT PRIMARY KEY,
    QuizID INT,
    Marks INT,
    Question VARCHAR(255),
    FirstOption VARCHAR(50),
    SecondOption VARCHAR(50),
    ThirdOption VARCHAR(50),
    FourthOption VARCHAR(50),
    Answer VARCHAR(50),
    FOREIGN KEY (QuizID) REFERENCES Quizzes(QuizID)
);

CREATE TABLE Enrollments (
    EnrollmentID INT PRIMARY KEY,
    StudentID INT,
    CourseID CHAR(8),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

CREATE TABLE QuizAttempts (
    QuizAttemptID INT PRIMARY KEY,
    StudentID INT,
    QuizID INT,
    MarksObtained INT,
	AttemptTime DATETIME,
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (QuizID) REFERENCES Quizzes(QuizID)
);

CREATE TABLE QuestionAttempts (
    QuestionAttemptID INT PRIMARY KEY,
    QuizAttemptID INT,
    QuestionID INT,
    StudentAnswer VARCHAR(50),
    IsCorrect INT,
    FOREIGN KEY (QuizAttemptID) REFERENCES QuizAttempts(QuizAttemptID),
    FOREIGN KEY (QuestionID) REFERENCES Questions(QuestionID)
);

-- ----------------------------------------------------------------------
-- Insert data into the Students table
-- ----------------------------------------------------------------------

INSERT INTO Students (StudentID, FirstName, LastName, Email, Password) VALUES 
(1, 'John', 'Doe', 'john.doe@example.com', 1234),
(2, 'Jane', 'Smith', 'jane.smith@example.com', 5678),
(3, 'Alice', 'Brown', 'alice.brown@example.com', 2345),
(4, 'Bob', 'Johnson', 'bob.johnson@example.com', 6789),
(5, 'Charlie', 'Williams', 'charlie.williams@example.com', 3456),
(6, 'Emily', 'Jones', 'emily.jones@example.com', 7890),
(7, 'David', 'Garcia', 'david.garcia@example.com', 4567),
(8, 'Sophia', 'Martinez', 'sophia.martinez@example.com', 8901),
(9, 'Liam', 'Anderson', 'liam.anderson@example.com', 5678),
(10, 'Olivia', 'Thomas', 'olivia.thomas@example.com', 9012),
(11, 'Noah', 'Moore', 'noah.moore@example.com', 6789),
(12, 'Ava', 'Taylor', 'ava.taylor@example.com', 2345),
(13, 'Lucas', 'Lee', 'lucas.lee@example.com', 7890),
(14, 'Mia', 'Harris', 'mia.harris@example.com', 8901),
(15, 'Ethan', 'Clark', 'ethan.clark@example.com', 3456),
(16, 'Isabella', 'Robinson', 'isabella.robinson@example.com', 9012),
(17, 'Mason', 'Walker', 'mason.walker@example.com', 4567),
(18, 'Amelia', 'Perez', 'amelia.perez@example.com', 1234),
(19, 'Elijah', 'Hall', 'elijah.hall@example.com', 5678),
(20, 'Harper', 'Young', 'harper.young@example.com', 6789),
(21, 'James', 'Allen', 'james.allen@example.com', 2345),
(22, 'Charlotte', 'King', 'charlotte.king@example.com', 3456),
(23, 'Alexander', 'Wright', 'alexander.wright@example.com', 7890),
(24, 'Scarlett', 'Lopez', 'scarlett.lopez@example.com', 8901),
(25, 'Henry', 'Hill', 'henry.hill@example.com', 9012),
(26, 'Victoria', 'Scott', 'victoria.scott@example.com', 1234),
(27, 'Daniel', 'Green', 'daniel.green@example.com', 5678),
(28, 'Evelyn', 'Adams', 'evelyn.adams@example.com', 6789),
(29, 'Sebastian', 'Nelson', 'sebastian.nelson@example.com', 2345),
(30, 'Luna', 'Carter', 'luna.carter@example.com', 3456);

-- ----------------------------------------------------------------------
-- Insert data into the Professors table
-- ----------------------------------------------------------------------

INSERT INTO Professors (ProfessorID, FirstName, LastName, Email, Password) VALUES
(1, 'Clint', 'Macdonald', 'clint.macdonald@example.com', 1234),
(2, 'Emma', 'Johnson', 'emma.johnson@example.com', 5678),
(3, 'Liam', 'Brown', 'liam.brown@example.com', 2345),
(4, 'Sophia', 'Taylor', 'sophia.taylor@example.com', 6789),
(5, 'Noah', 'White', 'noah.white@example.com', 3456);

-- ----------------------------------------------------------------------
-- Insert data into the Courses table
-- ----------------------------------------------------------------------

INSERT INTO Courses (CourseID, ProfessorID, Name) VALUES 
('COMM2109', 2, 'IT Career Essentials'),  -- Professor Emma
('COSC2100', 1, 'Object-Oriented Programming 2'),  -- Professor Clint
('GNED0000', 3, 'General Education Elective'),  -- Professor Liam
('INFT2100', 4, 'Web Development Intermediate'),  -- Professor Sophia
('INFT2101', 5, 'Database Development 1'),  -- Professor Noah
('MGMT2107', 1, 'Systems Development 2');  -- Professor Clint

-- ----------------------------------------------------------------------
-- Insert data into the Quizzes table
-- ----------------------------------------------------------------------

INSERT INTO Quizzes (QuizID, CourseID, Name, TotalMarks, StartTime, EndTime) VALUES 
(1, 'COSC2100', 'Quiz 1: OOP Basics', 25, '2024-12-01 10:00:00', '2024-12-10 23:59:00');

-- ----------------------------------------------------------------------
-- Insert data into the Questions table
-- ----------------------------------------------------------------------

INSERT INTO Questions (QuestionID, QuizID, Marks, Question, FirstOption, SecondOption, ThirdOption, FourthOption, Answer) VALUES
(1, 1, 2, 'Select Correct Answer', 'Incorrect', 'Incorrect', 'Incorrect', 'Correct', 'Correct');

-- ----------------------------------------------------------------------
-- Insert data into the Enrollments table
-- ----------------------------------------------------------------------

INSERT INTO Enrollments (EnrollmentID, StudentID, CourseID) VALUES
(1, 1, 'COSC2100'),
(2, 1, 'COMM2109'),
(3, 1, 'GNED0000'),
(4, 1, 'INFT2100'),
(5, 1, 'INFT2101'),
(6, 1, 'MGMT2107');

-- ----------------------------------------------------------------------
-- Insert data into the QuizAttempts table
-- ----------------------------------------------------------------------

INSERT INTO QuizAttempts (QuizAttemptID, StudentID, QuizID, MarksObtained, AttemptTime) VALUES
(1, 1, 1, 20, '2024-12-01 12:00:00');

-- ----------------------------------------------------------------------
-- Insert data into the QuestionAttempts table
-- ----------------------------------------------------------------------

INSERT INTO QuestionAttempts (QuestionAttemptID, QuizAttemptID, QuestionID, StudentAnswer, IsCorrect) VALUES
(1, 1, 1, 'Correct', 1);

-- ----------------------------------------------------------------------
-- Stored Procedures for Students
-- ----------------------------------------------------------------------

GO
-- Insert procedure for Students
CREATE OR ALTER PROCEDURE spInsertNewStudent
    @StudentID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Email VARCHAR(100),
    @Password INT
AS
BEGIN
    INSERT INTO Students (StudentID, FirstName, LastName, Email, [Password])
    VALUES (@StudentID, @FirstName, @LastName, @Email, @Password);
END;
GO

-- Update procedure for Students
CREATE OR ALTER PROCEDURE spUpdateStudent
    @StudentID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Email VARCHAR(100),
    @Password INT
AS
BEGIN
    UPDATE Students
    SET FirstName = @FirstName, LastName = @LastName, Email = @Email, [Password] = @Password
    WHERE StudentID = @StudentID;
END;
GO

-- Delete procedure for Students
CREATE OR ALTER PROCEDURE spDeleteStudent
    @StudentID INT
AS
BEGIN
    DELETE FROM Students
    WHERE StudentID = @StudentID;
END;
GO

-- ----------------------------------------------------------------------
-- Stored Procedures for Professors
-- ----------------------------------------------------------------------

-- Insert procedure for Professors
CREATE OR ALTER PROCEDURE spInsertNewProfessor
    @ProfessorID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Email VARCHAR(100),
    @Password INT
AS
BEGIN
    INSERT INTO Professors (ProfessorID, FirstName, LastName, Email, [Password])
    VALUES (@ProfessorID, @FirstName, @LastName, @Email, @Password);
END;
GO

-- Update procedure for Professors
CREATE OR ALTER PROCEDURE spUpdateProfessor
    @ProfessorID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Email VARCHAR(100),
    @Password INT
AS
BEGIN
    UPDATE Professors
    SET FirstName = @FirstName, LastName = @LastName, Email = @Email, [Password] = @Password
    WHERE ProfessorID = @ProfessorID;
END;
GO

-- Delete procedure for Professors
CREATE OR ALTER PROCEDURE spDeleteProfessor
    @ProfessorID INT
AS
BEGIN
    DELETE FROM Professors
    WHERE ProfessorID = @ProfessorID;
END;
GO

-- ----------------------------------------------------------------------
-- Stored Procedures for Courses
-- ----------------------------------------------------------------------

-- Insert procedure for Courses
CREATE OR ALTER PROCEDURE spInsertNewCourse
    @CourseID CHAR(8),
    @ProfessorID INT,
    @Name VARCHAR(50)
AS
BEGIN
    INSERT INTO Courses (CourseID, ProfessorID, Name)
    VALUES (@CourseID, @ProfessorID, @Name);
END;
GO

-- Update procedure for Courses
CREATE OR ALTER PROCEDURE spUpdateCourse
    @CourseID CHAR(8),
    @ProfessorID INT,
    @Name VARCHAR(50)
AS
BEGIN
    UPDATE Courses
    SET ProfessorID = @ProfessorID, Name = @Name
    WHERE CourseID = @CourseID;
END;
GO

-- Delete procedure for Courses
CREATE OR ALTER PROCEDURE spDeleteCourse
    @CourseID CHAR(8)
AS
BEGIN
    DELETE FROM Courses
    WHERE CourseID = @CourseID;
END;
GO

-- ----------------------------------------------------------------------
-- Stored Procedures for Quizzes
-- ----------------------------------------------------------------------

-- Insert procedure for Quizzes
CREATE OR ALTER PROCEDURE spInsertNewQuiz
    @QuizID INT,
    @CourseID CHAR(8),
    @Name VARCHAR(50),
    @TotalMarks INT,
    @StartTime DATETIME,
    @EndTime DATETIME
AS
BEGIN
    INSERT INTO Quizzes (QuizID, CourseID, Name, TotalMarks, StartTime, EndTime)
    VALUES (@QuizID, @CourseID, @Name, @TotalMarks, @StartTime, @EndTime);
END;
GO

-- Update procedure for Quizzes
CREATE OR ALTER PROCEDURE spUpdateQuiz
    @QuizID INT,
    @CourseID CHAR(8),
    @Name VARCHAR(50),
    @TotalMarks INT,
    @StartTime DATETIME,
    @EndTime DATETIME
AS
BEGIN
    UPDATE Quizzes
    SET CourseID = @CourseID, Name = @Name, TotalMarks = @TotalMarks, StartTime = @StartTime, EndTime = @EndTime
    WHERE QuizID = @QuizID;
END;
GO

-- Delete procedure for Quizzes
CREATE OR ALTER PROCEDURE spDeleteQuiz
    @QuizID INT
AS
BEGIN
    DELETE FROM Quizzes
    WHERE QuizID = @QuizID;
END;
GO

-- ----------------------------------------------------------------------
-- Stored Procedures for Questions
-- ----------------------------------------------------------------------

-- Insert procedure for Questions
CREATE OR ALTER PROCEDURE spInsertNewQuestion
    @QuestionID INT,
    @QuizID INT,
    @Marks INT,
    @Question VARCHAR(255),
    @FirstOption VARCHAR(50),
    @SecondOption VARCHAR(50),
    @ThirdOption VARCHAR(50),
    @FourthOption VARCHAR(50),
    @Answer VARCHAR(50)
AS
BEGIN
    INSERT INTO Questions (QuestionID, QuizID, Marks, Question, FirstOption, SecondOption, ThirdOption, FourthOption, Answer)
    VALUES (@QuestionID, @QuizID, @Marks, @Question, @FirstOption, @SecondOption, @ThirdOption, @FourthOption, @Answer);
END;
GO

-- Update procedure for Questions
CREATE OR ALTER PROCEDURE spUpdateQuestion
    @QuestionID INT,
    @QuizID INT,
    @Marks INT,
    @Question VARCHAR(255),
    @FirstOption VARCHAR(50),
    @SecondOption VARCHAR(50),
    @ThirdOption VARCHAR(50),
    @FourthOption VARCHAR(50),
    @Answer VARCHAR(50)
AS
BEGIN
    UPDATE Questions
    SET QuizID = @QuizID, Marks = @Marks, Question = @Question, 
        FirstOption = @FirstOption, SecondOption = @SecondOption, 
        ThirdOption = @ThirdOption, FourthOption = @FourthOption, 
        Answer = @Answer
    WHERE QuestionID = @QuestionID;
END;
GO

-- Delete procedure for Questions
CREATE OR ALTER PROCEDURE spDeleteQuestion
    @QuestionID INT
AS
BEGIN
    DELETE FROM Questions
    WHERE QuestionID = @QuestionID;
END;
GO

-- ----------------------------------------------------------------------
-- Stored Procedures for Enrollments
-- ----------------------------------------------------------------------

-- Insert procedure for Enrollments
CREATE OR ALTER PROCEDURE spInsertNewEnrollment
    @EnrollmentID INT,
    @StudentID INT,
    @CourseID CHAR(8)
AS
BEGIN
    INSERT INTO Enrollments (EnrollmentID, StudentID, CourseID)
    VALUES (@EnrollmentID, @StudentID, @CourseID);
END;
GO

-- Update procedure for Enrollments
CREATE OR ALTER PROCEDURE spUpdateEnrollment
    @EnrollmentID INT,
    @StudentID INT,
    @CourseID CHAR(8)
AS
BEGIN
    UPDATE Enrollments
    SET StudentID = @StudentID, CourseID = @CourseID
    WHERE EnrollmentID = @EnrollmentID;
END;
GO

-- Delete procedure for Enrollments
CREATE OR ALTER PROCEDURE spDeleteEnrollment
    @EnrollmentID INT
AS
BEGIN
    DELETE FROM Enrollments
    WHERE EnrollmentID = @EnrollmentID;
END;
GO

-- ----------------------------------------------------------------------
-- Stored Procedures for QuizAttempts
-- ----------------------------------------------------------------------

-- Insert procedure for QuizAttempts
CREATE OR ALTER PROCEDURE spInsertNewQuizAttempts
    @QuizAttemptID INT,
    @StudentID INT,
    @QuizID INT,
    @MarksObtained INT,
    @AttemptTime DATETIME
AS
BEGIN
    INSERT INTO QuizAttempts (QuizAttemptID, StudentID, QuizID, MarksObtained, AttemptTime)
    VALUES (@QuizAttemptID, @StudentID, @QuizID, @MarksObtained, @AttemptTime);
END;
GO

-- Update procedure for QuizAttempts
CREATE OR ALTER PROCEDURE spUpdateQuizAttempts
    @QuizAttemptID INT,
    @StudentID INT,
    @QuizID INT,
    @MarksObtained INT,
    @AttemptTime DATETIME
AS
BEGIN
    UPDATE QuizAttempts
    SET StudentID = @StudentID, QuizID = @QuizID, MarksObtained = @MarksObtained, AttemptTime = @AttemptTime
    WHERE QuizAttemptID = @QuizAttemptID;
END;
GO

-- Delete procedure for QuizAttempts
CREATE OR ALTER PROCEDURE spDeleteQuizAttempts
    @QuizAttemptID INT
AS
BEGIN
    DELETE FROM QuizAttempts
    WHERE QuizAttemptID = @QuizAttemptID;
END;
GO

-- ----------------------------------------------------------------------
-- Stored Procedures for QuestionAttempts
-- ----------------------------------------------------------------------

-- Insert procedure for QuestionAttempts
CREATE OR ALTER PROCEDURE spInsertNewQuestionAttempts
    @QuestionAttemptID INT,
    @QuizAttemptID INT,
    @QuestionID INT,
    @StudentAnswer VARCHAR(50),
    @IsCorrect INT
AS
BEGIN
    INSERT INTO QuestionAttempts (QuestionAttemptID, QuizAttemptID, QuestionID, StudentAnswer, IsCorrect)
    VALUES (@QuestionAttemptID, @QuizAttemptID, @QuestionID, @StudentAnswer, @IsCorrect);
END;
GO

-- Update procedure for QuestionAttempts
CREATE OR ALTER PROCEDURE spUpdateQuestionAttempts
    @QuestionAttemptID INT,
    @QuizAttemptID INT,
    @QuestionID INT,
    @StudentAnswer VARCHAR(50),
    @IsCorrect INT
AS
BEGIN
    UPDATE QuestionAttempts
    SET QuizAttemptID = @QuizAttemptID, QuestionID = @QuestionID, 
        StudentAnswer = @StudentAnswer, IsCorrect = @IsCorrect
    WHERE QuestionAttemptID = @QuestionAttemptID;
END;
GO

-- Delete procedure for QuestionAttempts
CREATE OR ALTER PROCEDURE spDeleteQuestionAttempts
    @QuestionAttemptID INT
AS
BEGIN
    DELETE FROM QuestionAttempts
    WHERE QuestionAttemptID = @QuestionAttemptID;
END;
GO