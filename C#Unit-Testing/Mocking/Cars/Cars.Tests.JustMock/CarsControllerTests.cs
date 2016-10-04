namespace Cars.Tests.JustMock
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using Contracts;
    using Models;
    using Mocks;
    using System.Collections;
    using System.Collections.Generic;
    using Fake;

    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            : this(new JustMockCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        public void Add_ShouldAccessICarsRepositoryAddMethod()
        {
            var car = new Car();
            car.Make = "asd";
            car.Model = "ass";
            car.Id = 1;

            var fakeCarRepo = new Mock<ICarsRepository>();

            fakeCarRepo.Setup(cp => cp.GetById(It.IsAny<int>())).Returns(car);
            fakeCarRepo.Setup(cp => cp.Add(It.IsAny<Car>()));

            var controller = new CarsController(fakeCarRepo.Object);

            var actual = controller.Add(car);

            fakeCarRepo.Verify(repo => repo.Add(It.IsAny<Car>()), Times.Exactly(1));
        }

        [TestMethod]
        public void Add_CarParameterIsNull_ShouldThrowTheCorrectExceptionMessage()
        {
            var actual = false;

            Car car = null;
            var controller = new CarsController();

            try
            {
                controller.Add(car);
            }
            catch (ArgumentNullException ex)
            {

                actual = ex.Message.Contains("Car cannot be null");
            }

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Add_CarParameterMakeOrModelAreNull_ShouldThrowTheCorrectExceptionMessage()
        {
            var actual = false;

            Car car = new FakeCar();
            var controller = new CarsController();

            try
            {
                controller.Add(car);
            }
            catch (ArgumentNullException ex)
            {
                actual = ex.Message.Contains("Car make and model cannot be empty");
            }

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Details_ShouldAccesICarsRepositoryGetById()
        {
            var fakeCar = new Mock<Car>();

            var fakeCarRepo = new Mock<ICarsRepository>();
            fakeCarRepo.Setup(cp => cp.GetById(It.IsAny<int>())).Returns(fakeCar.Object);

            var controller = new CarsController(fakeCarRepo.Object);

            var output = controller.Details(101);

            fakeCarRepo.Verify(cp => cp.GetById(It.IsAny<int>()), Times.Exactly(1));
        }

        [TestMethod]
        public void Details_CarReturnedByGetByIdIsNull_ShouldThrowTheCorrectMessage()
        {
            var actual = false;

            Car car = null;

            var fakeCarRepo = new Mock<ICarsRepository>();
            fakeCarRepo.Setup(cp => cp.GetById(It.IsAny<int>())).Returns(car);

            var controller = new CarsController(fakeCarRepo.Object);

            try
            {
                var result = controller.Details(100);
            }
            catch (ArgumentNullException ex)
            {
                actual = ex.Message.Contains("Car could not be found");
            }

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Search_ShouldAccessICarsRepositorySearch()
        {
            var fakeCar = new Mock<Car>();

            var fakeCarRepo = new Mock<ICarsRepository>();
            fakeCarRepo.Setup(cp => cp.Search(It.IsAny<string>())).Returns(new List<Car>() { fakeCar.Object });

            var controller = new CarsController(fakeCarRepo.Object);

            var actual = controller.Search(string.Empty);

            fakeCarRepo.Verify(cp => cp.Search(It.IsAny<string>()), Times.Exactly(1));
        }

        [TestMethod]
        public void Sort_ParameterIsNotRecognized_ShouldThrowTheCorrectExceptionMessage()
        {
            var actual = false;

            var sortParameter = "random string";
            var controller = new CarsController();

            try
            {
                var result = controller.Sort(sortParameter);
            }
            catch (ArgumentException ex)
            {
                actual = ex.Message.Contains("Invalid sorting parameter");
            }

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Sort_ParamaterMakeShouldCallTheCorrectSortingMethod()
        {
            var sortParam = "make";

            var fakeCarRepo = new Mock<ICarsRepository>();
            fakeCarRepo.Setup(cp => cp.SortedByMake()).Returns(new List<Car>() { new Car() });

            var controller = new CarsController(fakeCarRepo.Object);

            var result = controller.Sort(sortParam);

            fakeCarRepo.Verify(cp => cp.SortedByMake(), Times.Exactly(1));

        }

        [TestMethod]
        public void Sort_ParameterYearShouldCallTheCorrectSortingMethod()
        {
            var sortParam = "year";

            var fakeCarRepo = new Mock<ICarsRepository>();
            fakeCarRepo.Setup(cp => cp.SortedByYear()).Returns(new List<Car>() { new Car() });

            var controller = new CarsController(fakeCarRepo.Object);

            var result = controller.Sort(sortParam);

            fakeCarRepo.Verify(cp => cp.SortedByYear(), Times.Exactly(1));
        }
        
        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}

