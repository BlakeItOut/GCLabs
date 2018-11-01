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
        public void LocatePrime_ReturnTheNthPrime_True()
        {
            var target = 6;
            var expected = 13;
            var actual = LocatePrime(target);
            Assert.Fail();
        }
    }
}