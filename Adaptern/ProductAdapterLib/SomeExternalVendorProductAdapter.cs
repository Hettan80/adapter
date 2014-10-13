using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductLib;

namespace ProductAdapterLib
{
    public class SomeExternalVendorProductAdapter : IProduct
    {
       private SomeExternalVendorProduct _someExternalVendorProduct;
       public SomeExternalVendorProductAdapter(SomeExternalVendorProduct someExternalVendorProduct)
       {
          _someExternalVendorProduct = someExternalVendorProduct;
       }
       public decimal UnitPrice
       {
          get { return _someExternalVendorProduct.PricePerUnit; }
       }
       public string BarCode
       {
          get { return _someExternalVendorProduct.EanCode; }
       }
       public string Title
       {
          get { return _someExternalVendorProduct.Description; }
       }
    }
}
