using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_04_Methods_Testing;


namespace UnitTestProject1 
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void ProductUsCorrect(int a, int b, int c, int expected)
        {
            var actual = Program.TricpleCalcs(a, b, c, out int x);
                
                    Assert.AreEqual(expected, actual);
                
            
        }
    }
} 
