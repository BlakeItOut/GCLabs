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
    public class SheepTests
    {
        [TestMethod()]
        public void CloneTestShallowCopy()
        {
            Sheep original = new Sheep() { Name = "original" };
            Sheep clone = (Sheep)original.Clone();
            var expected = original.Name;
            var actual = clone.Name;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void CloneTestNotSamePointer()
        {
            Sheep original = new Sheep() { Name = "original" };
            Sheep clone = (Sheep)original.Clone();
            var expected = original;
            var actual = clone;
            Assert.AreNotEqual(actual, expected);
        }

        [TestMethod()]
        public void CloneTestUntetheredName()
        {
            Sheep original = new Sheep() { Name = "original" };
            Sheep clone = (Sheep)original.Clone();
            clone.Name = "clone";
            var expected = original.Name;
            var actual = clone.Name;
            Assert.AreNotEqual(actual, expected);
        }

        [TestMethod()]
        public void CloneTestUntetheredCount()
        {
            Sheep original = new Sheep();
            Sheep clone = (Sheep)original.Clone();
            clone.IncrementCount();
            var expected = original.GetCount();
            var actual = clone.GetCount();
            Assert.AreNotEqual(actual, expected);
        }

        [TestMethod()]
        public void GetCountTest()
        {
            //count initialized to 1.
            Sheep target = new Sheep();
            var expected = 1;
            var actual = target.GetCount();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void GetCountStringTest()
        {
            //count initialized to 1.
            Sheep target = new Sheep();
            var expected = "1";
            var actual = target.GetCountString();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void IncrementCountTest()
        {
            //count initialized to 1.
            Sheep target = new Sheep();
            target.IncrementCount();
            var expected = 2;
            var actual = target.GetCount();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void ResetCountTest()
        {
            //count initialized to 1.
            Sheep target = new Sheep();
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
            Sheep target = new Sheep() { Name = "target"};
            var expected = "1 target";
            var actual = target.ToString();

            Assert.AreEqual(actual, expected);
        }
    }
}