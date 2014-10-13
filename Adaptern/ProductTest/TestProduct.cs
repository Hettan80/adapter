using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductLib;

namespace ProductTest
{
   [TestClass]
   public class TestProduct
   {
      [TestMethod]
      public void TestarTest()
      {
         //Arrange
         string teststring = "Henrietta";
         string expectedResult = "tta";
         Product testProduct = new Product();
         Assert.AreEqual(expectedResult, testProduct.Test(teststring));
         //Act
         //Assert
      }
   }
}
