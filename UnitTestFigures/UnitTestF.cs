using OriginalFigures;

namespace UnitTestFigures
{
    public class UnitTestFigures
    {
        [Fact]
        public void TestCircle()
        {
            IFigure c = new Circle(5);
            Assert.True(c.SquareCalc() == 25 * Math.PI);
        }

        [Fact]
        public void TestTraingle()
        {
            Traingle t = new Traingle(5, 4, 3);
            Assert.True(t.IsRectangular());
            Assert.True(t.SquareCalc() == 6);
            Assert.True(((IFigure)t).SquareCalc() == 6);
        }

        [Fact]
        public void TestTraingleException()
        {
            try
            {
                IFigure t = new Traingle(1, 2, 3);
            }
            catch
            {
                Assert.True(true);
            }
            
        }

        [Fact]
        public void TestTriangleIsRectangle()
        {
            Traingle t = new Traingle(5, 4, 3);
            Assert.True(t.IsRectangular());
        }
    }
}
