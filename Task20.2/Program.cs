using System.Reflection;
using Task20._2.Moduls;

namespace Task20._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cow cow = new Cow("Hollandiya");
            Lion lion = new Lion("Afrika",true);

            Animal[] animals = {cow, lion};
            foreach (var animal in animals)
            {
                if (animal is Lion lion1)
                {
                    Console.WriteLine(" ");
                    Grass grass = new Grass(1200, "grass");
                    Meat meat = new Meat(5000, "dana eti");

                    lion1.EatFood(meat);
                    lion1.EatFood(grass);
                    lion1.MakeSound();
                }
                if (animal is Cow cow1)
                {

                    Grass grass = new Grass(1200, "grass");
                    Meat meat = new Meat(5000, "dana eti");
                
                    cow1.EatFood(meat);
                    cow1.EatFood(grass);
                    cow1.MakeSound();
                    cow1.ProductMilk();
                }

                
            }

        }
    }
}
