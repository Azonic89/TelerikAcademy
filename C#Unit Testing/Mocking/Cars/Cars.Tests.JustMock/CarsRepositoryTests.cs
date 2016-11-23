namespace Cars.Tests.JustMock
{
    using NUnit.Framework;
    using Moq;
    using Contracts;
    using System.Collections.Generic;
    using Models;
    using System;
    using Fake;
    using System.Linq;
    [TestFixture]
    public class CarsRepositoryTests
    {
        [Test]
        public void Add_IDatabaseShouldBeAccessedEachTimeAddMethodIsCalled()
        {
            const int numberOfRunsSetting = 5;

            var mockDb = new Mock<IDatabase>();
            var stubCar = new Mock<Fake.FakeCar>();

            mockDb.SetupGet(db => db.Cars).Returns(new List<Car>());
            var carRepo = new CarsRepository(mockDb.Object);

            for (int i = 0; i < numberOfRunsSetting; i++)
            {
                carRepo.Add(stubCar.Object);
            }

            mockDb.Verify(db => db.Cars, Times.Exactly(numberOfRunsSetting));
        }

        [Test]
        public void Add_ShouldThrowException_IfCarParameterIsNull()
        {
            Car car = null;
            var carRepo = new CarsRepository();

            var ex = Assert.Throws<ArgumentException>(() => carRepo.Add(car));
            Assert.IsTrue(ex.Message.Contains("Null car cannot be added"));
        }

        [Test]
        public void Remove_ShouldThrowException_IfCarParameterIsNull()
        {
            Car car = null;
            var carRepo = new CarsRepository();

            var ex = Assert.Throws<ArgumentException>(() => carRepo.Remove(car));
            Assert.IsTrue(ex.Message.Contains("Null car cannot be removed"));
        }

        [Test]
        public void GetById_ShouldThrowException_IfIdCannotBeFound()
        {
            var fakeDb = new Mock<IDatabase>();
            fakeDb.SetupGet(cp => cp.Cars).Returns(new List<Car>() { });

            var carRepo = new CarsRepository(fakeDb.Object);

            var ex = Assert.Throws<ArgumentException>(() => carRepo.GetById(10));
            Assert.IsTrue(ex.Message.Contains("Car with such Id could not be found"));
        }

        [Test]
        public void SortedByMake_ShouldReturnACollectionSortedInAlphabeticalOrder()
        {
            var dbListOfCars = new List<Car>();
            for (int i = 0; i < 26; i++)
            {
                var newCar = new FakeCar();
                newCar.Make = ((char)('z' - i)).ToString();

                dbListOfCars.Add(newCar);
            }

            var mockDb = new Mock<IDatabase>();
            mockDb.SetupGet(db => db.Cars).Returns(dbListOfCars);

            var carRepo = new CarsRepository(mockDb.Object);

            var actualSortedList = carRepo.SortedByMake();
            var expected = "a";

            Assert.AreEqual(expected, (actualSortedList.First()).Make);
        }

        [Test]
        public void SortedByYear_ShouldReturnACollectionSortedInAlphabeticalOrder()
        {
            var dbListOfCars = new List<Car>();

            for (int i = 0; i <= 26; i++)
            {
                var newCar = new FakeCar();
                newCar.Year = 1990 + i;

                dbListOfCars.Add(newCar);
            }

            var mockDb = new Mock<IDatabase>();
            mockDb.SetupGet(db => db.Cars).Returns(dbListOfCars);

            var carRepo = new CarsRepository(mockDb.Object);

            var actualSortedList = carRepo.SortedByYear();
            var expected = 2016;

            Assert.AreEqual(expected, (actualSortedList.First()).Year);
        }
    }
}
