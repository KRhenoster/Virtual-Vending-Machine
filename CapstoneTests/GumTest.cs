using Capstone.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTests
{
    [TestClass]
   public class GumTest
    {
        [TestMethod]
        public void GumHappyTest()
        {
            Gum c = new Gum("Chiclets", 0.75M, 5);
            string expected = "Chiclets";
            Assert.AreEqual(expected, c.ProductName);
            Assert.AreEqual(expected, c.ProductName);
            Assert.AreEqual(0.75M, c.Price);
        }

        [TestMethod]
        public void GumNotHappyTest()
        {
            Gum c = new Gum(null, 0.75M, 5);
            string expected = null;
            Assert.AreEqual(expected, c.ProductName);
            Assert.AreEqual(expected, c.ProductName);
            Assert.AreEqual(0.75M, c.Price);
        }


        [TestMethod]
        public void DrinkSoundTest()
        {
            Gum d = new Gum("Chew, Chew, Yum!", 3.60M, 5);
            Assert.AreEqual("Chew, Chew, Yum!", d.ProductName);
        }

    }
}
