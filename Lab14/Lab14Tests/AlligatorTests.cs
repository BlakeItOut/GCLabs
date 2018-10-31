using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14.Tests
{
    [TestClass()]
    public class AlligatorTests
    {
        [TestMethod()]
        public void GetCountTest()
        {
            //count initialized to 1.
            Alligator target = new Alligator();
            var expected = 1;
            var actual = target.GetCount();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void GetCountStringTest()
        {
            //count initialized to 1.
            Alligator target = new Alligator();
            var expected = "1";
            var actual = target.GetCountString();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void IncrementCountTest()
        {
            //count initialized to 1.
            Alligator target = new Alligator();
            target.IncrementCount();
            var expected = 2;
            var actual = target.GetCount();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void ResetCountTest()
        {
            //count initialized to 1.
            Alligator target = new Alligator();
            target.IncrementCount();
            target.ResetCount();
            var expected = 1;
            var actual = target.GetCount();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            //count initialized to 1.
            Alligator target = new Alligator();
            var expected = "1 alligator";
            var actual = target.ToString();

            Assert.AreEqual(actual, expected);
        }
    }
}