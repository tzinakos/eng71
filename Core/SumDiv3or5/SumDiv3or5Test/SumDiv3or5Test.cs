using NUnit.Framework;
using System;
using SumDiv3or5;

namespace SumDiv3or5Test

{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[TestCase(5, 8)]
		[TestCase(10, 33)]
		[TestCase(15, 60)]
		[TestCase(20, 98)]
		[TestCase(25, 168)]
		public void TestSumMethod(int a, int expected)
		{
			var actual = SumDiv3or5Calc.sumMethod(a);
			Assert.AreEqual(expected, actual);
		}

	}
}