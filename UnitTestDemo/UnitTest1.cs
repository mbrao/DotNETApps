using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckYear()
        {
            Assert.AreEqual(false, DateTime.IsLeapYear(DateTime.Now.Year));
        }
    }
}
