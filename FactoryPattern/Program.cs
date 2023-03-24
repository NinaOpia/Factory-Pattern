namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Pick out a toy you would like to purchase");
            Console.WriteLine("1 ==> Bike");
            Console.WriteLine("2 ==> Ludocard");
            Console.WriteLine("3 ==> Stuffed animal");

            var userInput =  int.Parse(Console.ReadLine());

            IMakeable instance = ToyFactory.MakeToy(userInput);
            instance.PrintToyDetails();

            //Bike bike1 = new Bike(); These two are the same as the two right above it.
            //bike1.PrintToyDetails();
        }
    }
}
