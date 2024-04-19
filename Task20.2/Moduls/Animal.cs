using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task20.Moduls;

namespace Task20._2.Moduls
{
    internal abstract class Animal
    {
        public string Breed;
        protected Animal(string breed)
        {
            Breed = breed;
        }
        public abstract void MakeSound();
        public abstract void EatFood(Food food);
    }
}
