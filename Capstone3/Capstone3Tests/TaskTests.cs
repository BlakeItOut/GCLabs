using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone3.Tests
{
    [TestClass()]
    public class TaskTests
    {
        [TestMethod()]
        public void getDaysRemainingTest()
        {
            var target = new Task("test", "test", new DateTime(2018,10,31));
            var testToday = new DateTime(2018, 10, 25);
            var actual = target.getDaysRemaining(testToday);
            var expected = 6;
            Assert.AreEqual(expected, actual);
        }
    }
}