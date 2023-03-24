using System;
namespace FactoryPattern
{
	public static class ToyFactory
	{
		public static IMakeable MakeToy(int choice)
		{ 
			switch (choice)
			{
				case 1:
					return new Bikes();
				case 2:
					return new LudoCard();
				case 3:
					return new StuffedAnimal();
				default:
					return new StuffedAnimal();

			}
		}
	}
}

