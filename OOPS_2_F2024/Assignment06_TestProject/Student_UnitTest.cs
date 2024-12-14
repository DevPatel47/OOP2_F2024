/*============================================================
 * Title    :   Assignment-6: Final Assignment
 * Name     :   Dev Mayurkumar Patel
 * Date     :   13 December 2024
 * Purpose  :   UnitTest File
 *===========================================================*/

/*
 * This code was developed with assistance from ChatGPT during a conversation on [insert today's date].
 * Summary of the collaboration:
 * 1. I provided the `FindStudentByEmail` and `GetStudent` methods and asked ChatGPT to create MSUnit test cases for them.
 * 2. ChatGPT created comprehensive MSUnit test cases for both methods, covering various scenarios, including valid inputs, invalid inputs, and edge cases.
 * 3. I then requested ChatGPT to consolidate the methods and test cases into a single file.
 * 4. I asked ChatGPT to add a new method, `FindStudentById`, and to write corresponding MSUnit test cases to ensure it worked as expected.
 * 5. ChatGPT included a mock `Student` class and a `Setup` method to simulate a test environment with a predefined list of students.
 * 
 * This final code combines all the methods I provided (`FindStudentByEmail`, `GetStudent`, `FindStudentById`) and their corresponding unit tests, ensuring all functionalities are validated.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

[TestClass]
public class StudentTests
{
    // Mock class for Student
    public class Student
    {
        public int StudentID { get; set; } 
        public string Email { get; set; }
        public string Name { get; set; }
        public int Password { get; set; }
    }

    // Mock collection to simulate the `students` list
    private static List<Student> students;

    // Method 1: Find a student by email
    public static Student FindStudentByEmail(string email)
    {
        foreach (Student student in students)
        {
            if (student.Email == email) return student;
        }
        return null;
    }

    // Method 2: Get a student by email and password
    public static Student GetStudent(string email, int password)
    {
        foreach (Student student in students)
        {
            if (student.Email == email && student.Password == password) return student;
        }
        return null;
    }

    // Method 3: Find a student by ID
    public static Student FindStudentById(int studentID)
    {
        foreach (Student student in students)
        {
            if (student.StudentID == studentID) return student;
        }
        return null;
    }

    [TestInitialize]
    public void Setup()
    {
        // Initialize the mock student list
        students = new List<Student>
        {
            new Student { StudentID = 1, Email = "john.doe@example.com", Name = "John Doe", Password = 1234 },
            new Student { StudentID = 2, Email = "jane.smith@example.com", Name = "Jane Smith", Password = 5678 },
            new Student { StudentID = 3, Email = "sam.green@example.com", Name = "Sam Green", Password = 9101 }
        };
    }

    // Tests for FindStudentByEmail
    [TestMethod]
    public void FindStudentByEmail_ExistingEmail_ReturnsStudent()
    {
        // Arrange
        string emailToSearch = "jane.smith@example.com";

        // Act
        Student result = FindStudentByEmail(emailToSearch);

        // Assert
        Assert.IsNotNull(result, "The method should return a student object.");
        Assert.AreEqual(emailToSearch, result.Email, "The email of the returned student should match the search email.");
        Assert.AreEqual("Jane Smith", result.Name, "The name of the returned student should match.");
    }

    [TestMethod]
    public void FindStudentByEmail_NonExistingEmail_ReturnsNull()
    {
        // Arrange
        string emailToSearch = "non.existing@example.com";

        // Act
        Student result = FindStudentByEmail(emailToSearch);

        // Assert
        Assert.IsNull(result, "The method should return null for a non-existing email.");
    }

    // Tests for GetStudent
    [TestMethod]
    public void GetStudent_ValidEmailAndPassword_ReturnsStudent()
    {
        // Arrange
        string emailToSearch = "jane.smith@example.com";
        int passwordToSearch = 5678;

        // Act
        Student result = GetStudent(emailToSearch, passwordToSearch);

        // Assert
        Assert.IsNotNull(result, "The method should return a student object for valid email and password.");
        Assert.AreEqual(emailToSearch, result.Email, "The email of the returned student should match the search email.");
    }

    [TestMethod]
    public void GetStudent_ValidEmailInvalidPassword_ReturnsNull()
    {
        // Arrange
        string emailToSearch = "jane.smith@example.com";
        int invalidPassword = 1111;

        // Act
        Student result = GetStudent(emailToSearch, invalidPassword);

        // Assert
        Assert.IsNull(result, "The method should return null for a valid email but an invalid password.");
    }

    // Tests for FindStudentById
    [TestMethod]
    public void FindStudentById_ExistingId_ReturnsStudent()
    {
        // Arrange
        int studentIdToSearch = 2;

        // Act
        Student result = FindStudentById(studentIdToSearch);

        // Assert
        Assert.IsNotNull(result, "The method should return a student object for an existing ID.");
        Assert.AreEqual(studentIdToSearch, result.StudentID, "The ID of the returned student should match the search ID.");
        Assert.AreEqual("Jane Smith", result.Name, "The name of the returned student should match.");
    }

    [TestMethod]
    public void FindStudentById_NonExistingId_ReturnsNull()
    {
        // Arrange
        int studentIdToSearch = 999;

        // Act
        Student result = FindStudentById(studentIdToSearch);

        // Assert
        Assert.IsNull(result, "The method should return null for a non-existing ID.");
    }

    [TestMethod]
    public void FindStudentById_NegativeId_ReturnsNull()
    {
        // Arrange
        int studentIdToSearch = -1;

        // Act
        Student result = FindStudentById(studentIdToSearch);

        // Assert
        Assert.IsNull(result, "The method should return null for a negative ID.");
    }
}
