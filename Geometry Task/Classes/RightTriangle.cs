namespace GeometryTask.Classes;

public class RightAngledTriangle : AbstractTriangle
{
    public RightAngledTriangle(double a, double b) : base(a, b, Math.Sqrt(a * a + b * b))
    {
    }

    public override double CalculatePerimeter()
    {
        return A + B + C;
    }

    public override double CalculateArea()
    {
        return (A * B) / 2;
    }
}
