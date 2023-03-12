namespace OriginalFigures
{
    public interface IFigure
    {
        /// <summary>
        /// Возвращает название фигуры
        /// </summary>
        /// <returns></returns>
        abstract public string Name { get; }

        /// <summary>
        /// Возвращает площадь фигуры
        /// </summary>
        /// <returns></returns>
        abstract public double SquareCalc();
    }
}
