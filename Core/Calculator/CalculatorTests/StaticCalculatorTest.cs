using NUnit.Framework;
using Calculator;

namespace CalculatorTests
{
    public class StaticCalculatorTest       
    {
       private double _addResult, _subtractResult, _multiplyResult, _divideResult, _moduleResult;

        [SetUp]
        public void Setup()
        {
            _addResult = CalculatorLib.Add(3, 5);           // Calls The CalculatorLib.Add Method with parameters of (3,5) and assigns the output to the _addResult variable.
            _subtractResult = CalculatorLib.Subtract(8, 8); // Calls The CalculatorLib.Subtract Method with parameters of (8,8) and assigns the output to the _subtractResult variable.
            _multiplyResult = CalculatorLib.Multiply(9, 2); // Calls The CalculatorLib.Multiply Method with parameters of (9,2) and assigns the output to the _multiplyResult variable.
            _divideResult = CalculatorLib.Divide(8, 2);     // Calls The CalculatorLib.Divide Method with parameters of (8,2) and assigns the output to the _divideResult variable.
           
        }
        // Creating Tests For the CalculatorLib.Add Method With Fixed Parameters: (3,5) Result Should Be 8
        [Test]   // |---Test Begins---|
        public void IsAddWorking()
        {
            Assert.AreEqual(8, _addResult);  // |-----Assert-----|
        }

        //Creating a Test for the CalculatorLib.Add Method with 4 Test Cases.
        [Test]                 // |---Test Begins---|
        [TestCase(4,5,9)]      // |Test Case No. 01.|
        [TestCase(-4,5,1)]     // |Test Case No. 02.|
        [TestCase(-3,-8,-11)]  // |Test Case No. 03.|
        [TestCase(232,-232,0)] // |Test Case No. 04.|
        public void IsAddWorkingWithTestCases(double a, double b, double expected) // This Method Will Be Tested 4 Times; One Time Per Test Case.
        {
            double testResult = CalculatorLib.Add(a, b); // |Arrange , Assert|
            Assert.AreEqual(expected, testResult);    // |-----Assert-----|
        }

        //Creating a Test for the Calculator.Subtract method with Fixed Parameters: (8,8) Result Should Be 0
        [Test]   // |---Test Begins---|
        public void IsSubtractWorking()
        {
            Assert.AreEqual(0, _subtractResult);  // |-----Assert-----|
        }

        //Creating a Test for the Calculator.Subtract Method with 5 Test Cases.
        [Test]                  // |---Test Begins---|
        [TestCase(4,3,1)]       // |Test Case No. 01.|
        [TestCase(6,-7,13)]     // |Test Case No. 02.|
        [TestCase(-13,20,-33)]  // |Test Case No. 03.|
        [TestCase(125,25,100)]  // |Test Case No. 04.|
        [TestCase(23,23,0)]     // |Test Case No. 05.|
        public void IsSubtractWorkingWithTestCases(double a, double b, double expected) // This Method Will Be Tested 5 Times; One Time Per Test Case.
        {
            double testResult = CalculatorLib.Subtract(a,b); // |Arrange , Assert|
            Assert.AreEqual(expected, testResult);        // |-----Assert-----|

        }

        //Creating a Test for the Calculator.Multiply Method With Fixed Parameters: (9,2) Result Should Be 18
        [Test]   // |---Test Begins---|
        public void IsMultiplyWorking()
        {
            Assert.AreEqual(18, _multiplyResult); // |-----Assert-----|
        }

        //Creating a Test for the Calculator.Multiply Method with 4 Test Cases. 
        [Test]                     // |---Test Begins---|
        [TestCase(4, 3, 12)]       // |Test Case No. 01.|
        [TestCase(6, -7, -42)]     // |Test Case No. 02.|
        [TestCase(-13, 20, -260)]  // |Test Case No. 03.|
        [TestCase(125, 25, 3125)]  // |Test Case No. 04.|
        public void IsMultiplyWorkingWithTestCases(double a, double b, double expected) // This Method Will Be Tested 4 Times; One Time Per Test Case.
        {
            double testResult = CalculatorLib.Multiply(a, b); // |Arrange , Assert|
            Assert.AreEqual(expected, testResult);         // |-----Assert-----|

        }

        //Creating a Test for the Calculator.Divide Method With Fixed Parameters: (8,2) Result Should Be 4
        [Test]   // |---Test Begins---|
        public void IsDivideWorking()
        {
            Assert.AreEqual(4, _divideResult); // |-----Assert-----|
        }

        //Creating a Test for the Calculator.Divide Method with 4 Test Cases.
        [Test]                    // |---Test Begins---|
        [TestCase(4, 3, 1)]       // |Test Case No. 01.|
        [TestCase(5, 6, 0)]       // |Test Case No. 02.|
        [TestCase(-13, -13, 1)]   // |Test Case No. 03.|
        [TestCase(125, 25, 5)]    // |Test Case No. 04.|
        public void IsDivideWorkingWithTestCases(double a, double b, double expected) // This Method Will Be Tested 4 Times; One Time Per Test Case.
        {
            double testResult = CalculatorLib.Divide(a, b); // |Arrange , Assert|
            Assert.AreEqual(expected, testResult);       // |-----Assert-----|

            Assert.Throws<System.ArgumentException>(() => CalculatorLib.Divide(3,0));
        }

        //Creating a Test for the Calculator.Module Method With Fixed Parameters: (6,6) Result Should Be 0.
        [Test]   // |---Test Begins---|
        public void IsModule()
        {
            Assert.AreEqual(0, _moduleResult); // |-----Assert-----|
        }

        //Creating a Test for the Calculator.Module Method with 4 Test Cases. 
        [Test]                    // |---Test Begins---|
        [TestCase(4, 3, 1)]       // |Test Case No. 01.|
        [TestCase(5, 6, 5)]       // |Test Case No. 02.|
        [TestCase(-13, -13, 0)]   // |Test Case No. 03.|
        [TestCase(125, 124, 1)]   // |Test Case No. 04.|
        //public void IsModuleWorkingWithTestCases(double a, double b, double expected) // This Method Will Be Tested 4 Times; One Time Per Test Case.
        //{
        //    double testResult = CalculatorLib.Module(a, b); // |Arrange , Assert|
        //    Assert.AreEqual(expected, testResult);       // |-----Assert-----|

        //}

    }
}