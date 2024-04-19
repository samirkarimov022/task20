using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20.Moduls
{
    internal class Pineapple:Fruit
    {
        public decimal VitaminD;
        public decimal VitaminE;
        public Pineapple(decimal price, string sort, decimal vitaminD, decimal vitaminE) : base(price, sort)
        {
            VitaminD = vitaminD;
            VitaminE = vitaminE;
         
        }
        public override void Taste()
        {
            Console.WriteLine("ananas dadir");
        }
    }
}
