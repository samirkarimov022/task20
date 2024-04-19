using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20.Moduls
{
    internal class Orange:Fruit
    {
        public decimal VitaminC;

        public Orange(decimal price,string sort, decimal vitaminC):base(price,sort)
        {
           
            VitaminC = vitaminC;
        }
        public override void Taste()
        {
            Console.WriteLine("portagal dadir");
        }
    }
}
