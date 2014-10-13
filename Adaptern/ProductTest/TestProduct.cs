using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductAdapterLib;
using ProductLib;

namespace ProductTest
{
   [TestClass]
   public class TestProduct
   {
      [TestMethod]
      public void ProductCorrectValueTest()
      {
         Product product = new Product();

         decimal expectedUnitPrice = 250;
         string expectedBarCode = "####";
         string expectedTitle = "Product";

         Assert.AreEqual(expectedUnitPrice, product.UnitPrice);
         Assert.AreEqual(expectedBarCode, product.BarCode);
         Assert.AreEqual(expectedTitle, product.Title);
      }

      [TestMethod]
      public void TestExternalProductAdapter()
      {
         SomeExternalVendorProduct externalProduct = new SomeExternalVendorProduct();
         IProduct testAdapterOutput = new SomeExternalVendorProductAdapter(externalProduct);

         decimal expectedUnitPrice = 200;
         string expectedBarCode = "###";
         string expectedTitle = "ExternalProduct";

         Assert.AreEqual(expectedUnitPrice, testAdapterOutput.UnitPrice);
         Assert.AreEqual(expectedBarCode, testAdapterOutput.BarCode);
         Assert.AreEqual(expectedTitle, testAdapterOutput.Title);
      }
   }
}
