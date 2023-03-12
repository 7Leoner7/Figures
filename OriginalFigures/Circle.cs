namespace OriginalFigures
{
    public class Circle : IFigure
    {
        protected double _R;

        public double Radius { get => _R; }

        public string Name { get => "circle"; }

        public Circle(double R) => _R = R;

        public double SquareCalc()
        {
            return Math.PI * _R * _R;
        }

        public override string ToString() { return Name; }
    }
}
