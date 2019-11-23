using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace FizzBuzz01
{
    static class FizzBuzzer
    {
        internal static string Eval(int n)
        {
            var factors = new[] { new { divisor = 3, term = "Fizz" }, new { divisor = 5, term = "Buzz" } };
            IEnumerable<string> relevantFactorTerms = factors.Select((factor) => { return (n % factor.divisor == 0 ? factor.term : string.Empty); });
            string factorterms = String.Concat(relevantFactorTerms);
            return FirstNonEmpty(new object[] { factorterms, n });
        }

        internal static string FirstNonEmpty(object[] values)
        {
            foreach (object o in values)
            {
                string s = o.ToString();
                if (!String.IsNullOrEmpty(s))
                {
                    return s;
                }
            }

            throw new ArgumentException("FirstNonEmpty given collection with no empty strings");
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
