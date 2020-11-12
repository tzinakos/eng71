using NUnit.Framework;
using Lab_05_Selection01;


namespace Lab_05_Selection_TEST
{
    public class SelectionTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [TestCase(76)]
        [TestCase(80)]
        public void Mark75AndOverPassesWithDistinction(int mark)
        {
            var testResult = Selection.Grade(mark);
            Assert.AreEqual("Pass With Distinction", testResult);
        }

        [Test]
        [TestCase(63)]
        [TestCase(68)]
        public void MarkBetween60And74InclusivePassesWithMerit(int mark)
        {
            var testResult = Selection.Grade(mark);
            Assert.AreEqual("Pass With Merit", testResult);
        }

        [Test]
        [TestCase(40)]
        [TestCase(59)]
        public void Mar40AndAboveAndBelow60Passes(int mark)
        {
            var testResult = Selection.Grade(mark);
            Assert.AreEqual("Pass", testResult);
        }
        [Test]
        [TestCase(39)]
        [TestCase(20)]
        public void MarUnder40Fails(int mark)
        {
            var testResult = Selection.Grade(mark);
            Assert.AreEqual("Fail", testResult);
        }
        [Test]
        [TestCase(5, "Error")]
        [TestCase(0, "Code Geen")]
        [TestCase(1, "Code Amber")]
        [TestCase(2, "Code Amber")]
        [TestCase(3, "Code Red")]
        public void DefoultIsReturningError(int level, string expected)
        {
            
            Assert.AreEqual(expected, Selection.Priority(level));
        }




    }
}