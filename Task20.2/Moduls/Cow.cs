using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task20.Moduls;

namespace Task20._2.Moduls
{
    internal class Cow : Animal
    {
        
        public Cow(string breed):base(breed)
        {
              
        }

        public override void EatFood(Food food)
        {
            if (food is Grass)
            {
                Console.WriteLine("yeyir");
            } 
            else 
            {
                Console.WriteLine("yemir");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("moo , moo");
        }

        public void ProductMilk()
        {
            Console.WriteLine("Milk Producted"); 
        }
    }
}
