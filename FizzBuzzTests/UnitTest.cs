using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var test_object = new Program();
            int expected = 1;
            int actual = test_object.FizzBuzz(1);
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
