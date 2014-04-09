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
            
            string actual = Prog.FizzBuzz(1);
            Assert.AreEqual<string>("1", actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string actual = Prog.FizzBuzz(3);
            Assert.AreEqual<string>("Fizz", actual);
        }
    }
}
