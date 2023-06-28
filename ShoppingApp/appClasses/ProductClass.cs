using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.appClasses
{
    public class ProductClass
    {
        public int PorductKey { get; set; }
        public string ProductDescription { get; set; }
        public string ProductPrice { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
    }
}
