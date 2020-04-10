using Capstone.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTests
{
    [TestClass]
   public class DrinkTest
    {
        [TestMethod]
        public void DrinkHappyTest()
        {
            Drink d = new Drink("Heavy", 3.60M , 5);
            string expected = "Heavy";
            Assert.AreEqual(expected, d.ProductName);
            Assert.AreEqual(3.60M, d.Price);
        }

        [TestMethod]
        public void DrinkNotHappyTest()
        {
            Drink d = new Drink(null, 3.60M, 5);
            string expected = null;
            Assert.AreEqual(expected, d.ProductName);
            Assert.AreEqual(3.60M, d.Price);
        }

        [TestMethod]
        public void DrinkSoundTest()
        {
            Drink d = new Drink("Glug, Glug, Yum!", 3.60M, 5);
            Assert.AreEqual("Glug, Glug, Yum!", d.ProductName);
        }
    }
}
