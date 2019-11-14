using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz01
{
    static class FizzBuzzer
    {
        internal static object Eval(int v)
        {
            return v == 3 ? (object)"Fizz" : v;
        }
    }
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void Start()
        {
            Assert.AreEqual(1, FizzBuzzer.Eval(1));
            Assert.AreEqual(2, FizzBuzzer.Eval(2));
            Assert.AreEqual("Fizz", FizzBuzzer.Eval(3));
        }
    }
}
