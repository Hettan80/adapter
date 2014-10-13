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
       public SomeExternalVendorProductAdapter(SomeExternalVendorProduct externalVendorProduct)
       {
          UnitPrice = externalVendorProduct.PricePerUnit;
          BarCode = externalVendorProduct.EanCode;
          Title = externalVendorProduct.Description;
       }
       public decimal UnitPrice {get; set;}
       public string BarCode { get; set; }
       public string Title { get; set; }
    }
}
