namespace School.Tests
{
    using System;
    using School;
    using Entities;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void School_ShouldNotThrowException_WhenInstaciatingNewObjectWithValidParams()
        {
            var school = new School("Best School");
        }

        [TestMethod]
        public void School_ShouldReturnNamesCorreclty_WhenValidOnesArePassed()
        {
            var school = new School("Best School");

            Assert.AreSame("Best School", school.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void School_ShouldThrowArgumentNullException_WhenNullNameIsPassed()
        {
            var school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void School_ShouldThrowArgumentNullException_WhenEmptyNameIsPassed()
        {
            var school = new School(string.Empty);
        }

        [TestMethod]
        public void AddStudent_ShouldAddStudentsCorrectly_WhenValidStudentsArePassed()
        {
            var school = new School("Best School");
            var student = new Student("Pesho Goshov", 10000);

            school.AddStudent(student);

            Assert.AreSame(student, school.Students.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddStudent_ShouldThrowArgumentNullException_WhenTryingToAddNullStudent()
        {
            var school = new School("Best School");
            Student student = null;

            school.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddStudent_ShouldThrowInvalidOperationException_WhenTryingToAddAnExistingStudent()
        {
            var school = new School("Best School");
            var student = new Student("Pesho Goshov", 10000);

            school.AddStudent(student);
            school.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddStudent_ShouldThrowInvalidOperationException_WhenTryingToAddStudentsWithSameID()
        {
            var school = new School("Best School");
            var studentOne = new Student("Pesho Goshov", 10000);
            var studentTwo = new Student("Stamat Edno", 10000);

            school.AddStudent(studentOne);
            school.AddStudent(studentTwo);
        }

        [TestMethod]
        public void AddCourse_ShouldReturnNamesCorrectly_WhenValidCourseNamesArePassed()
        {
            var school = new School("Best School");
            var course = new Course("DSA");

            school.AddCourse(course);

            Assert.AreSame(course, school.Courses.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddCourse_ShouldThrowArgumentNullException_WhenNullCourseIsPassed()
        {
            var school = new School("Best School");
            Course course = null;

            school.AddCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddCourse_ShouldThrowInvalidOperationException_WhenTryingToAddAnExsistingCourse()
        {
            var school = new School("Best School");
            var course = new Course("DSA");

            school.AddCourse(course);
            school.AddCourse(course);
        }

        [TestMethod]
        public void RemoveStudent_ShouldRemoveCourseCorrectly_WhenTryingToRemoveValidStudents()
        {
            var school = new School("Best School");
            var studentOne = new Student("Gosho Peshov", 10000);
            var studentTwo = new Student("Stamat Edno", 10001);

            school.AddStudent(studentOne);
            school.AddStudent(studentTwo);
            school.RemoveStudent(studentTwo);

            Assert.IsTrue(school.Students.Count == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveStudent_ShouldThrowArgumentNullException_WhenTryingToRemoveNullStudent()
        {
            var school = new School("Best School");
            Student student = null;

            school.AddStudent(student);
            school.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemoveStudent_ShouldThrowInvalidOperationException_WhenTryingToRemoveNonExistantStudent()
        {
            var school = new School("Best School");
            var student = new Student("Gosho Peshov", 10000);

            school.RemoveStudent(student);
        }

        [TestMethod]
        public void RemoveCourse_ShouldRemoveCourseCorreclty_WhenValidCourseArePassed()
        {
            var school = new School("Best School");
            var courseOne = new Course("DSA");
            var courseTwo = new Course("OOP");

            school.AddCourse(courseOne);
            school.AddCourse(courseTwo);
            school.RemoveCourse(courseTwo);

            Assert.IsTrue(school.Courses.Count == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveCourse_ShouldThrowArgumentNullException_WhenTryingToRemoveNullCourse()
        {
            var school = new School("Best School");
            Course course = null;

            school.RemoveCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemoveCourse_ShouldThrowInvalidOperationException_WhenRemovingANonExistantCourse()
        {
            var school = new School("Best School");
            var course = new Course("DSA");

            school.RemoveCourse(course);
        }
    }
}
