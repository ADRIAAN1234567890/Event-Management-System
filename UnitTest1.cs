using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using RemoveCart;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
             // Arrange
            Cart c = new Cart();
            Product pro = new Product("Test Product", 100.00);
            c.AddProduct(pro);

            // Act
            bool result = c.RemoveProduct("Test Product");

            // Assert
            Assert.IsTrue(result, "The product should have been removed.");
            Assert.IsFalse(c.RemoveProduct("Test Product"), "Removing the product again should return false.");
        }
    

        [TestMethod]
        public void TestRemoveProduct_ProductNotInCart()
        {
            // Arrange
            Cart c = new Cart();

            // Act
            bool result = c.RemoveProduct("Nonexistent Product");

            // Assert
            Assert.IsFalse(result, "Removing a nonexistent product should return false.");
        }
    }
}

