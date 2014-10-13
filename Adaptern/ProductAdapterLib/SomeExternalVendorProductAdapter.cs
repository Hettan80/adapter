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
       private SomeExternalVendorProduct _externalVendorProduct;

       public SomeExternalVendorProductAdapter(SomeExternalVendorProduct externalVendorProduct)
       {
          this._externalVendorProduct = externalVendorProduct;
       }
       public decimal UnitPrice {get; set;}
       public string BarCode { get; set; }
       public string Title { get; set; }
    }
}
