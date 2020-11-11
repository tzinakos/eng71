using NUnit.Framework;
using Lab_04_Methods_Testing;

namespace Lab_04_Methods_Testing_Test
{
    public class Tests
    {
        private int _result;
        private int _sum;
        [SetUp]
        public void Setup()
        {
            _result = Program.TricpleCalc(10, 2, 3, out int sum);
            _sum = sum;

        }

        [Test]

        public void ProductIsCorrect()
        {
            Assert.AreEqual(60, _result);
        }

        [Test]
        public void SumIsCorrect()
        {
            Assert.AreEqual(15,_sum);
        }

        [Test]
        [TestCase(1,2,3,6)]
        [TestCase(3,2,-3,-18)]
        public void ProductIsCorrectWithTestCase(int a, int b, int c, int expected)
        {
            var actual = Program.TricpleCalc(a,b,c, out int sum);
            
            Assert.AreEqual(expected,actual);
        }

        [Test]
        [TestCase(10, 2, 4, 16)]
        [TestCase(0,-3,7,4)]
        [TestCase(1, 2, 3, 6)]
        [TestCase(3, 2, -3, 2)]
        public void SumIsCorrectWithTestCase(int a, int b, int c, int expected)
        {
            var actual = Program.TricpleCalc(a, b, c, out int sum);

            Assert.AreEqual(expected, sum);
        }



    }
}