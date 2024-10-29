using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckoutApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            Program.CheckoutProducts();
                 
            // Assert
            var result = sw.ToString().Trim();
            Assert.AreEqual("Your products have been checked out without any shipping fee.", result);
        }
    }
}
