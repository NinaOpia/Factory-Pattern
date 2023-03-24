using System; 
namespace FactoryPattern
{
    public class Bikes : IMakeable
    {
        public double Price { get; set; } = 30.20;

        public string AgeGroup { get; set; } = "4+";

        public void PrintToyDetails()
        {
            Console.WriteLine($"Bike for Christmas is for age group: {AgeGroup}");
            Console.WriteLine($"It cost: ${Price}");
            Console.WriteLine($"Comes with training wheels!");
        }

    }
}

