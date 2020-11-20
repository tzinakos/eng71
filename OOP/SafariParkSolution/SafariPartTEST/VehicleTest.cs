using NUnit.Framework;
using SafariPark;

namespace SafariPartTEST
{
    public class VehicleTest
    {
        [SetUp]
        public void Setup()
        {
        }

       

        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
            
        }

        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5,40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }
        [Test]
        [TestCase(5,0)]
        [TestCase(-2, 0)]
        public void WhenNumOfPassengerIsLargerThanCapacityOrANegativeNumberReturnZero(int passengers, int expected)
        {
            Vehicle v = new Vehicle(4, 20);
            v.NumPassengers = passengers;
            Assert.AreEqual(expected,v.NumPassengers);
        }
    }
}