using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib 
{
   public class Product : IProduct
   {
      public decimal UnitPrice
      {
         get {return 250;}
      }

      public string BarCode
      {
         get { return "####"; }
      }

      public string Title
      {
         get { return "Product"; }
      }
   }
}
