using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz01
{
    static class FizzBuzzer
    {
        internal static object Eval(int v)
        {
            return 1;
        }
    }
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void Start()
        {
            Assert.AreEqual(1, FizzBuzzer.Eval(1));
        }
    }
}
