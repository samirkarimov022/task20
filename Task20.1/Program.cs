using System.Reflection;
using Task20.Moduls;

namespace Task20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple(1.2m,"qubanin ag almasi",44,55);         
            Pineapple pineapple = new Pineapple(6.5m,"made in china",77,88);
            Orange orange = new Orange(2.5m,"made in china",77);
            Fruit[] basket = {apple, pineapple, orange};                    

            foreach (var fruit in basket)
            {
                Type fruitType = fruit.GetType();
                Console.WriteLine(" ");
                Console.WriteLine(fruitType.Name);
                FieldInfo[] fields = fruitType.GetFields();
                foreach (var item in fields)
                {
                    Console.WriteLine(item.GetValue(fruit));
                }

            }
     //--------------------------------------------------------------------------------------



        }
    }
}
