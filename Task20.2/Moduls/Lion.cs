using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task20.Moduls;

namespace Task20._2.Moduls
{
    internal class Lion : Animal
    {
        public bool IsPrideLider;
        public Lion(string breed ,bool isPrideLider):base(breed)
        {
            IsPrideLider = isPrideLider;
        }

        public override void EatFood(Food food)
        {
            if (food is Meat)
            {
                Console.WriteLine("yeyir");
            }
            else
            {
                Console.WriteLine("Yemir");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("nere cekir");
        }
    }
}
