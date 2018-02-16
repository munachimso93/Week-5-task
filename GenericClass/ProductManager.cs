using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{

    public delegate void ItemFilter();
    public class ProductManager
    {
        public List<String> Stocks { get; set; } = new List<string>()
        {
            "Grand Square Bread",

            "tomato",
        };
    }
}
