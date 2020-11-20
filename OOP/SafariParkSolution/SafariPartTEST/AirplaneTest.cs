using NUnit.Framework;
using SafariPark;

namespace SafariPartTEST
{
    public class AirplaneTest
    {
        [SetUp]
        public void Setup()
        {
        }

       

        [Test]
        [TestCase(500, 500, 1000)]
        [TestCase(300,300, 600)]
        public void WhenAirplaneAscendsItsAltitudeIncreases(int originalAltitude, int nextAltitude, int expected)
        {
            Airplane a = new Airplane(100);
            a.Ascend(originalAltitude);
            a.Ascend(nextAltitude);
            Assert.AreEqual(expected, a.Altitude);                       
        }

        [Test]
        [TestCase(500, 200, 300)]
        [TestCase(300, 100, 200)]
        public void WhenAirplaneDescendsAltitudeDecreases(int originalAltitude, int nextAltitude, int expected)
        {
            Airplane a = new Airplane(100);
            a.Ascend(originalAltitude);
            a.Descend(nextAltitude);
            Assert.AreEqual(expected, a.Altitude);

        }


        [Test]
        [TestCase(5, 500, 300, "ExtremeAirlines", 150)]
        [TestCase(7, 200, 100, "SafariAirlines", 200)]
        [TestCase(1, 250, 150, "JinoJets", 300)]
        public void WhenAirplaneMoves(int times, int ascendedAltitude, int descendedAltitude, string airlines, int passengers)
        {
            Airplane a = new Airplane(500, 100, airlines) {NumPassengers =passengers };
           
           
            a.Ascend(ascendedAltitude);
            a.Descend(descendedAltitude);

            Assert.AreEqual($"Moving along {times} times at an altitude of {a.Altitude} meters", a.Move(times));
            Assert.AreEqual(airlines, a.Airline);
            Assert.AreEqual(passengers, a.NumPassengers);
        }

    }
}