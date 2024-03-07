namespace Heredity_ex
{
    internal class Figure // (double side, double baseFigure, double height) this is a constructor
    {
        private double side;
        private double baseFigure;
        private double height;


        // in this case is possible to edit or visualize params
        public double Side { get => side; set => side = value; }
        public double BaseFigure { get => baseFigure; set => baseFigure = value; }
        public double Height { get => height; set => height = value; }

        public double perimeterSquare()
        {
            double result = side * 4;
            return result;
        }

    }
}
