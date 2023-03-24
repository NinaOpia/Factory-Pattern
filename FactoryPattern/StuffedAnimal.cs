using System;
namespace FactoryPattern
{
	public class StuffedAnimal : IMakeable
	{
        public double Price { get; set; } = 12.50;

        public string AgeGroup { get; set; } = "0+";

        public void PrintToyDetails()
        {
            Console.WriteLine($"Stuffed animal for Christmas is for age group: {AgeGroup}");
            Console.WriteLine($"It cost: ${Price}");
            Console.WriteLine($"It never goes out of style!");
        }
    }
}

