using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11.Tests
{
    [TestClass()]
    public class ValidatorTests
    {
        [TestMethod()]
        public void promptUserTest()
        {
            string response = "horror";
            Categories expected = (Categories)Enum.Parse(typeof(Categories), Validator.promptUser("What category are you interested in?\n1=Animated\n2=Drama\n3=Horror\n4=Science Fiction\n", (str => Enum.TryParse(str, out expected)), response));
            Categories actual = Categories.horror;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void promptUserTest2()
        {
            string response = "animated";
            Categories expected = (Categories)Enum.Parse(typeof(Categories), Validator.promptUser("What category are you interested in?\n1=Animated\n2=Drama\n3=Horror\n4=Science Fiction\n", (str => Enum.TryParse(str, out expected)), response));
            Categories actual = Categories.horror;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod()]
        public void promptContinueTest()
        {
            string response = "n";
            Assert.IsTrue(Validator.promptContinue(response));
        }

        [TestMethod()]
        public void promptContinueTest2()
        {
            string response = "y";
            Assert.IsFalse(Validator.promptContinue(response));
        }
    }
}