namespace GeometryTask.Classes;

public class Trapezoid : AbstractSquare
{
    private double _b;
    private double _c;
    private double _d;

    public Trapezoid(double a, double b, double c, double d) : base(a)
    {
        _b = b;
        _c = c;
        _d = d;
    }

    public override double CalculatePerimeter()
    {
        return A + _b + _c + _d;
    }

    public override double CalculateArea()
    {
        double s = (A + _b + _c + _d) / 2;

        double height = (2 / (A - _c)) * Math.Sqrt((s - A) * (s - _c) * (s - _c - _b + A) * (s - _c - _d + A));

        return ((A + _c) / 2) * height;
    }
}

