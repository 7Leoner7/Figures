namespace OriginalFigures
{
    public class Traingle : IFigure
    {
        protected double[] sides;

        public Tuple<double, double, double> Sides { get => new Tuple<double, double, double>(sides[0], sides[1], sides[2]); }

        public string Name { get => "triangle"; }

        public Traingle(double a, double b, double c)
        {
            sides = new double[] { a, b, c };
            if (!IsTriangle())
                throw new ArgumentException("This is not a triangle!");
        }

        public Traingle(double[] sides)
        {
            this.sides = new double[] { sides[0], sides[1], sides[2] };
            if (!IsTriangle())
                throw new ArgumentException("This is not a triangle!");
        }

        protected bool IsTriangle()
        {
            double square = SquareCalc();
            return !((square == double.NaN)||(square == 0));
        }

        public bool IsRectangular()
        {
            double[] t_sides = new double[3] { sides[0], sides[1], sides[2] };
            Array.Sort(t_sides);
            return t_sides[0] * t_sides[0] + t_sides[1] * t_sides[1] - t_sides[2] * t_sides[2] == 0;
        }

        public double SquareCalc()
        {
            double p = (sides[0] + sides[1] + sides[2]) / 2;
            return Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
        }

        public override string ToString() { return Name; }
    }
}
