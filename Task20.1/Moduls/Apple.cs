using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20.Moduls
{
    internal class Apple:Fruit
    {
       
        public decimal VitaminA;
        public decimal VitaminB;
        
        public Apple(decimal price , string sort, decimal vitaminA, decimal vitaminB):base(price,sort) 
        {
            
            VitaminA = vitaminA;
            VitaminB = vitaminB;
        }
        public override void Taste()
        {
            Console.WriteLine("alma dadir");
        }
    }
}
