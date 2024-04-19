using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task20.Moduls;

namespace Task20._2.Moduls
{
    internal class Grass:Food
    {
        public string Name;
        public Grass(decimal calorie,string name):base(calorie)
        {
            Name = name;
        }
    }
}
