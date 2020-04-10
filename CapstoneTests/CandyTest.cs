using Capstone.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTests
{
    [TestClass]
    public class CandyTest
    {
        [TestMethod]
        public void CandyHappyTest()
        {
            Candy c = new Candy("Moonpie", 2.50M, 5);
            string expected = "Moonpie";
            Assert.AreEqual(expected, c.ProductName);
            Assert.AreEqual(expected, c.ProductName);
            Assert.AreEqual(2.50M, c.Price);
        }

        [TestMethod]
        public void CandyNotHappyTestEmpty()
        {
            Candy c = new Candy("", 2.50M, 5);
            string expected = "";
            Assert.AreEqual(expected, c.ProductName);
            Assert.AreEqual(expected, c.ProductName);
            Assert.AreEqual(2.50M, c.Price);
        }

        [TestMethod]
        public void CandyNotHappyTestNull()
        {
            Candy c = new Candy(null, 2.50M, 5);
            string expected = null;
            Assert.AreEqual(expected, c.ProductName);
            Assert.AreEqual(expected, c.ProductName);
            Assert.AreEqual(2.50M, c.Price);
        }


        [TestMethod]
        public void CandySoundTest()
        {
            Candy c = new Candy("Munch Munch, Yum", 2.50M, 5);
            Assert.AreEqual("Munch Munch, Yum", c.ProductName);
        }
    } 

}
