namespace GeometryTask.Classes;

public abstract class AbstractSquare
{
    private double _a;  

    protected double A  
    {
        get { return _a; }
    }

    public AbstractSquare(double a)
    {
        _a = a;
    }

    public abstract double CalculatePerimeter();
    public abstract double CalculateArea();
}