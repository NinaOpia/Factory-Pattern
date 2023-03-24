using System;
namespace FactoryPattern
{
    public class LudoCard : IMakeable
    {
        public double Price { get; set; } = 10.40;

        public string AgeGroup { get; set; } = "6+";

        public void PrintToyDetails()
        {
            Console.WriteLine($"Ludocard for Christmas is for age group: {AgeGroup}");
            Console.WriteLine($"It cost: ${Price}");
            Console.WriteLine($"It is a great gift!");
        }

    }
}

