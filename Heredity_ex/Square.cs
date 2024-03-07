namespace Heredity_ex
{
    internal class Square : Figure //heredity
    {
        public double calcArea()
        {
            double squareArea = base.Side * base.Side; //base it's equals to square class

            return squareArea;
        }

        /*
        public Square(double sideSquare) : base() // :base(constructor data) it's use in case of Figure have a constructor 
        { 
        }
        */
    }
}
