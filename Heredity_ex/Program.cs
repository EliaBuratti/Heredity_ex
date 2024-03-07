namespace Heredity_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueCalc = true;

            while (continueCalc)
            {
                Console.WriteLine("Write a side to calculate perimeter of square");
                Figure squareSide = new Figure();
                squareSide.Side = Convert.ToDouble(Console.ReadLine());//set method
                Console.WriteLine(squareSide.perimeterSquare());

                //test class with heredity
                Console.WriteLine("Write a side to calculate area of square");
                Square squareArea = new();
                squareArea.Side = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(squareArea.calcArea());

                //condition to select continue or stop execution
                Console.WriteLine("Do you want to calculate other dimension? (Y / N) ");
                continueCalc = Console.ReadLine().ToLower() == "y" ? true : false;
            };
        }
    }
}
