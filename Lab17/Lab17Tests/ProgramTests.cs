using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void LocatePrime_ReturnTheSmallNthPrime_True()
        {
            var target = 6;
            var expected = 13;
            var actual = Program.LocatePrime(target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LocatePrime_ReturnTheBigNthPrime_True()
        {
            var target = 1000;
            var expected = 7919;
            var actual = Program.LocatePrime(target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LocatePrime_ReturnTheWrongNthPrime_False()
        {
            var target = 5;
            var notExpected = 13;
            var actual = Program.LocatePrime(target);
            Assert.AreNotEqual(notExpected, actual);
        }

        [TestMethod()]
        public void CheckPrime_ReturnBoolIfPrime_True()
        {
            var target = 7;

            Assert.IsTrue(Program.CheckPrime(target));
        }

        [TestMethod()]
        public void GetUpTo100000ThPrime_ReturnArrayMin_True()
        {
            var expected = 2;
            var actual = Program.GetUpTo100000ThPrime().First();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetUpTo100000ThPrime_ReturnArrayMax_True()
        {
            var expected = 1299709;
            var actual = Program.GetUpTo100000ThPrime().Last();
            Assert.AreEqual(expected, actual);
        }
    }
}