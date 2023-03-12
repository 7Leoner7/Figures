using OriginalFigures;

Console.WriteLine("Какая фигура вам нужна:");
Console.WriteLine("T - triangle\nC - circle\n");
string FType = Console.ReadLine();
IFigure figure;
try
{
    switch (FType)
    {
        case "T":
            Console.WriteLine("Введите сторону A:");
            double a = 0; double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введите сторону B:");
            double b = 0; double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Введите сторону C:");
            double c = 0; double.TryParse(Console.ReadLine(), out c);
            figure = new Traingle(a, b, c);
            Console.WriteLine(((Traingle)figure).IsRectangular() ? "Треугольник прямоугольный" : " Треугольник не прямоугольный");
            break;
        case "C":
            Console.WriteLine("Введите радиус R:");
            double r = 0; double.TryParse(Console.ReadLine(), out r);
            figure = new Circle(r);
            break;
        default:
            throw new Exception();
    }
    Console.WriteLine($"Площадь фигуры = {figure.SquareCalc()}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
