using NUnit.Framework;
using Lab_11_Exeptions;

namespace Lab_11_ExeptionTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(-1)]
        [TestCase(4)]
        public void WhenAnIllegalPositionSpecifiedAnddExeptionIsThrouwn(int pos)
        {
            var ex = Assert.Throws<System.ArgumentException>(() => Program.ChangeBeatle(pos, "George"));
            Assert.AreEqual($"Another kati cannot be added", ex.Message, "Crash");
        }
    }
}