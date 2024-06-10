namespace GeometryTask.Classes;

public abstract class AbstractTriangle
{
    protected double A { get; }
    protected double B { get; }
    protected double C { get; }

    public AbstractTriangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public abstract double CalculatePerimeter();
    public abstract double CalculateArea();
}

