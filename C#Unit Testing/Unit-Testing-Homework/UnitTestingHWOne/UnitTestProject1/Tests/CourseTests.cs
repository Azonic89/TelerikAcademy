namespace School.Tests
{
    using System;
    using School;
    using Entities;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void Course_ShouldNotThrowException_WhenInstaciatingNewObjectWithValidParams()
        {
            var course = new Course("DSA");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Course_ShouldThrowArgumentNullException_WhenPassingANullName()
        {
            var course = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Course_ShouldThrowArgumentNullException_WhenPassingAnEmptyStringName()
        {
            var course = new Course(string.Empty);
        }

        [TestMethod]
        public void Course_ShouldReturnNameCorreclty_WhenAValidIsPassed()
        {
            var course = new Course("DSA");

            Assert.AreEqual("DSA", course.Name);
        }

        [TestMethod]
        public void AddStudent_ShouldAddStudentsCorreclty_WhenUsingAddStudentMethod()
        {
            var course = new Course("DSA");
            var studentOne = new Student("Pesho Goshov", 99999);
            var studentTwo = new Student("Stamat Hinkov", 10000);

            course.AddStudent(studentOne);
            course.AddStudent(studentTwo);

            Assert.AreSame(studentOne, course.Students.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddStudent_ShouldThrowArgumentNullException_WhenNullStudentIsAdded()
        {
            var course = new Course("DSA");
            Student student = null;

            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddStudent_ShouldThrowInvalidOperationException_WhenAddingAnAlreadyExistingStudent()
        {
            var course = new Course("DSA");
            var student = new Student("Pesho Goshov", 99999);

            course.AddStudent(student);
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddStudent_ShouldThrowArgumentOutOfRangeExpception_WhenAddingMoreStudentsThanTheCourseMaxCapacity()
        {
            var course = new Course("DSA");

            for (int i = 0; i < 31; i++)
            {
                course.AddStudent(new Student(i.ToString(), 10000 + 1));
            }
        }

        [TestMethod]
        public void RemoveStudent_ShouldRemoveStudentsCorreclty_WhenValidStudentsArePassed()
        {
            var course = new Course("DSA");
            var studentOne = new Student("Pesho Goshov", 10000);
            var studentTwo = new Student("Stamat Edno", 10001);

            course.AddStudent(studentOne);
            course.AddStudent(studentTwo);
            course.RemoveStudent(studentTwo);

            Assert.AreEqual(1, course.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveStudent_ShouldThrowArgumentNullException_WhenTryingToRemoveNullStudent()
        {
            var course = new Course("DSA");
            Student student = null;

            course.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemoveStudent_ShouldThrowInvalidOperationException_WhenTryingToRemoveAnExistingStudent()
        {
            var course = new Course("DSA");
            var student = new Student("Pesho Goshov", 10000);

            course.RemoveStudent(student);
        }
    }
}
