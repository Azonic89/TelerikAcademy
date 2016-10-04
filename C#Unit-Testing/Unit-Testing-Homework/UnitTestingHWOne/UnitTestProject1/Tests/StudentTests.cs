namespace School.Tests
{
    using System;
    using School;
    using Entities;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void Student_ShouldNotThrowAndException_WhenInstaciantingAValidObject()
        {
            var student = new Student("Pesho Goshov", 10000);
        }

        [TestMethod]
        public void Student_ShouldReturnNamesCorrectly_WhenValidNamesArePassed()
        {
            var student = new Student("Pesho Goshov", 10000);

            Assert.AreSame("Pesho Goshov", student.Name);
        }

        [TestMethod]
        public void Student_ShouldReturnIDCorreclty_WhenValidIDsArePassed()
        {
            var student = new Student("Pesho Goshov", 10000);

            Assert.AreEqual(10000, student.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Student_ShouldThrowArgumentNullException_WhenNullNamesArePassed()
        {
            var student = new Student(null, 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Student_ShouldThrowArgumentNullException_WhenEmptyNamesArePassed()
        {
            var student = new Student(string.Empty, 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Student_ShouldThrowInvalidOperationException_WhenPassingLowerIDThanMinValidOne()
        {
            var student = new Student("Pesho Goshov", 15);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Student_ShouldThrowInvalidOperationException_WhenPassingHigherIDThanMaxValidOne()
        {
            var student = new Student("Pesho Goshov", 100000);
        }

        [TestMethod]
        public void AttendCourse_ShouldNotThrowException_WhenAttendingCourse()
        {
            var student = new Student("Pesho Goshov", 10000);
            var course = new Course("DSA");

            student.AttendCourse(course);
        }

        [TestMethod]
        public void LeaveCourse_ShouldNotThrowException_WhenLeavingCourse()
        {
            var student = new Student("Pesho Goshov", 10000);
            var course = new Course("DSA");

            student.AttendCourse(course);
            student.LeaveCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AttendCourse_ShouldThrowArgumentNullException_WhenTryingToAttendNullCourse()
        {
            var student = new Student("Pesho Goshov", 10000);
            Course course = null;

            student.AttendCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LeaveCourse_ShouldThrowArgumentNullException_WhenTryingToLeaveNullCourse()
        {
            var student = new Student("Pesho Goshov", 10000);
            Course course = null;

            student.LeaveCourse(course);
        }
    }
}
