using System;
using System.Linq;
using Jayway.Cars.Domain;
using Jayway.Cars.Infrastructure.Ef;
using Jayway.Cars.Infrastructure.Ef.Dummy;
using NUnit.Framework;

namespace Jayway.Cars.IT
{
    [TestFixture]
    public class DatabaseQueryTest
    {
        private CarContext _ctx;

        [SetUp]
        public void Setup()
        {
            /*
             Watch out for multiple instances of CarContext() as a transaction of one CarContext might not be finished before another CarContext transaction starts, possibly resulting in corrupt data.
             */
            _ctx = new CarContext(new Tests.TestLogger());
            _ctx.Database.CreateIfNotExists();
            //ctx.ChangeTracker.DetectChanges(); ChangeTracker
            _ctx.Cars.Add(new Car() {Name = "TestCar"});
            
            _ctx.SaveChanges();
        }

        [Test]
        public void LoadACar()
        {
            //Arrange

            //Act
            var car = _ctx.Cars.SingleOrDefault(c => c.Id == 1); //NOTE: breakpoint in the right of the lamda
            
            //Assert
            Assert.IsNotNull(car);
            Assert.AreEqual(1, car.Id);
        }

        public void Demo()
        {
            Action a = () => Console.WriteLine("hej");
            Func<Car, bool> b = c => c.Id == 1;
            a.Invoke();
            a.Invoke();
            a.Invoke();
            a.Invoke();
            var result = b(new Car());

        }
    }
}