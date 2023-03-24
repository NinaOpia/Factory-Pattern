using System;
namespace FactoryPattern
{
	public interface IMakeable
	{
		public double Price { get; set; }

		public string AgeGroup { get; set; }

		public void PrintToyDetails();
    }
}

