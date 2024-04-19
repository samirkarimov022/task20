using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20.Moduls
{
    abstract class Fruit
    {
        public decimal Price;

        public string Sort;
        protected Fruit(decimal price,string sort)
        {
            Price = price;
            Sort = sort;
        }
        public abstract void Taste();
    }
}
