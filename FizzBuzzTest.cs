using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz01
{
    static class FizzBuzzer
    {
        internal static string Eval(int n)
        {
            string Test(int test, int divisor, string whatIfDivisible)
            {
                return test % divisor == 0 ? whatIfDivisible : String.Empty;
            }

            var factors = new[]{ new { factor = 3, term = "Fizz" }, new { factor = 5, term = "Buzz" } };
            string factorterms = string.Empty;

            foreach (var factor in factors)
            {
                factorterms += Test(n, factor.factor, factor.term);
            }
            
            return String.IsNullOrEmpty(factorterms) ? n.ToString() : factorterms;
        }
    }
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void Numbers()
        {
            Assert.AreEqual("1", FizzBuzzer.Eval(1));
            Assert.AreEqual("2", FizzBuzzer.Eval(2));
            Assert.AreEqual("4", FizzBuzzer.Eval(4));
            Assert.AreEqual("7", FizzBuzzer.Eval(7));
        }
        [TestMethod]
        public void Singles()
        {
            Assert.AreEqual("Fizz", FizzBuzzer.Eval(3));
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
            Assert.AreEqual("FizzBuzz", FizzBuzzer.Eval(30));
        }
    }
}
