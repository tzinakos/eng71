using NUnit.Framework;
using SafariPark;

namespace SafariPartTEST
{
    public class PersonTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Jino","Biba","Jino Biba")]
        [TestCase("",""," ")]
        public void GetFullNameTest(string fName, string lName, string expected)
        {
            var subject = new Person(fName, lName);
            var result = subject.GetFullName();
            Assert.AreEqual(expected, result);
            
        }

        [Test]
        public void AgeTest()
        {
            var subject = new Person("Paparas", "Arxidis");
            subject.Age = 35;
            Assert.AreEqual(35, subject.Age);
        }
    }
}