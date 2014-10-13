using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
   public class SomeExternalVendorProduct
   {
      public int PricePerUnit
      {
         get { return 200; }
      }

      public string EanCode
      {
         get { return "###"; }
      }

      public string Description
      {
         get { return "ExternalProduct"; }
      }
   }
}
