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
            string actual = Prog.FizzBuzz(num);
            return actual;
        }

        [TestMethod]
        public void TestMethod1()
        {

            string actual = FizzBuzz(1);
            Assert.AreEqual<string>("1", actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string actual = FizzBuzz(3);
            Assert.AreEqual<string>("Fizz", actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string actual = FizzBuzz(5);
            Assert.AreEqual<string>("Buzz", actual);
        }
    }
}
