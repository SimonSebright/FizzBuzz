using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz01
{
    static class FizzBuzzer
    {
        internal static string Eval(int v)
        {
            return v%15 == 0 ? "FizzBuzz":
                    v%3 == 0 ? "Fizz" : 
                        v%5 == 0 ? "Buzz" : 
                            v.ToString();
        }
    }
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void Singles()
        {
            Assert.AreEqual("1", FizzBuzzer.Eval(1));
            Assert.AreEqual("2", FizzBuzzer.Eval(2));
            Assert.AreEqual("Fizz", FizzBuzzer.Eval(3));
            Assert.AreEqual("4", FizzBuzzer.Eval(4));
            Assert.AreEqual("Buzz", FizzBuzzer.Eval(5));
        }
        [TestMethod]
        public void Multiples()
        {
            Assert.AreEqual("Fizz", FizzBuzzer.Eval(6));
            Assert.AreEqual("Buzz", FizzBuzzer.Eval(10));
        }
        [TestMethod]
        public void Combined()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzzer.Eval(15));
        }
    }
}
