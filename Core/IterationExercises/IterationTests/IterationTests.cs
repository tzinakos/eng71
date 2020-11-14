using NUnit.Framework;
using IterationLib;

namespace IterationTests
{
    public class IterationTests
    {
        /**  Implement the static methods in IterationLib.Highest class so that they
         * pass the following tests.  Each method should use a different type of loop as indicated:
         * while, for, foreach and do while.
         * 
         * Add more tests for each method.  What happens when the array is empty?
         * When the array contains only negative numbers?  When all the array elements are the same?
         * 
         * You will find one of the loops will not not be suitable in all cases.  Which is it? 
         * You don't need to find a devious way to make it pass - just note that it is not a suitable for this problem.
         **/


        [Test]
        [TestCase(new int[]{ },int.MinValue)]
        [TestCase(new int[] { -10, -6, -22, -17, -3 }, -3)]
        [TestCase(new int[] { 10, 10, 10, 10, 10 }, 10)]
        [TestCase(new int[] { 10, 6, 22, 17, 3 }, 22)]
        public void HighestWhileLoopTest(int[]array, int expected)
        {
            
            var result = Highest.HighestWhileLoop(array);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(new int[] { }, int.MinValue)]
        [TestCase(new int[] { -10, -6, -22, -17, -3 }, -3)]
        [TestCase(new int[] { 10, 10, 10, 10, 10 }, 10)]
        [TestCase(new int[] { 10, 6, 22, 17, 3 }, 22)]
        public void HighestForLoopTest(int[] array, int expected)
        {
            
            var result = Highest.HighestForLoop(array);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(new int[] { }, int.MinValue)]
        [TestCase(new int[] { -10, -6, -22, -17, -3 }, -3)]
        [TestCase(new int[] { 10, 10, 10, 10, 10 }, 10)]
        [TestCase(new int[] { 10, 6, 22, 17, 3 }, 22)]
        public void HighestForEachLoopTest(int[] array, int expected)
        {
            
            var result = Highest.HighestForEachLoop(array);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(new int[] { }, int.MinValue)]
        [TestCase(new int[] { -10, -6, -22, -17, -3 }, -3)]
        [TestCase(new int[] { 10, 10, 10, 10, 10 }, 10)]
        [TestCase(new int[] { 10, 6, 22, 17, 3 }, 22)]
        public void HighestDoWhileLoopTest(int[] array, int expected)
        {
            
            var result = Highest.HighestDoWhileLoop(array);
            Assert.AreEqual(expected, result);
        }
    }
}