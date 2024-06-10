namespace GeometryTask.Classes;

public class Square : AbstractSquare
{
    public Square(double a) : base(a) { }

    public override double CalculatePerimeter()
    {
        return 4 * A;
    }

    public override double CalculateArea()
    {
        return A * A; 
    }
}