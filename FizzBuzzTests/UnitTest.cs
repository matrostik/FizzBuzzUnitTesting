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

        [TestMethod]
        public void TestMethod1()
        {
            int expected = 1;
            int actual = Prog.FizzBuzz(1);
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int expected = 2;
            int actual = Prog.FizzBuzz(2);
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
