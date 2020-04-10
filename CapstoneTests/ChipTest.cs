using Capstone.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTests
{
    [TestClass]
    public class ChipTest
    {
        [TestMethod]
        public void ChipHappyTest()
        {
            Chip c = new Chip("Stackers", 1.45M, 5);
            string expected = "Stackers";
            Assert.AreEqual(expected, c.ProductName);
            Assert.AreEqual(expected, c.ProductName);
            Assert.AreEqual(1.45M, c.Price);
        }

        [TestMethod]
        public void ChipNotHappyTest()
        {
            Chip c = new Chip(null, 1.45M, 5);
            string expected = null;
            Assert.AreEqual(expected, c.ProductName);
            Assert.AreEqual(expected, c.ProductName);
            Assert.AreEqual(1.45M, c.Price);
        }

        [TestMethod]
        public void CandySoundTest()
        {
            Chip c = new Chip("Crunch, Crunch, Yum!", 2.50M, 5);
            Assert.AreEqual("Crunch, Crunch, Yum!", c.ProductName);
        }

    }
}
