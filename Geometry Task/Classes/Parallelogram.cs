namespace GeometryTask.Classes;

public class Parallelogram : AbstractSquare
{
    private double _b;   
    private double _angle;

    public Parallelogram(double a, double b, double angle) : base(a)
    {
        _b = b;
        _angle = angle;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (A + _b);
    }

    public override double CalculateArea()
    {
        double angleInRadians = _angle * (Math.PI / 180);
        return A * _b * Math.Sin(angleInRadians);
    }
}
