using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzTests
{
    [TestClass]
    public class UnitTest
    {
        private Program _prog = new Program();
        public Program Prog
        {
            get { return _prog; }
            set { _prog = value; }
        }

        private string FizzBuzz(int num)
        {
            return Prog.FizzBuzz(num);
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual<string>("1", FizzBuzz(1));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual<string>("Fizz", FizzBuzz(3));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual<string>("Buzz", FizzBuzz(5));
        }
    }
}
