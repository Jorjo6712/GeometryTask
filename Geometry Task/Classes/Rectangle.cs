namespace GeometryTask.Classes;

public class Rectangle : AbstractSquare
{
    private double _b;
    
    public Rectangle(double a, double b) : base (a)
    {
        _b = b;
    }
    
    public override double CalculatePerimeter()
    {
        return 2 * (A + _b);
    }

    public override double CalculateArea()
    {
        return A * _b;
    }
}