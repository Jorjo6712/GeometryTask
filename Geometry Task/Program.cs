namespace GeometryTask;

using GeometryTask.Classes;

public class MainProgram
{
    public static void Main()
    { 
        
        // Square section
        double squareOneSideA = 10;
        double squareTwoSideA = 60;

        Square squareOne = new Square(squareOneSideA);
        Square squareTwo = new Square(squareTwoSideA);
        
        Console.WriteLine("Squares:");
        
        Console.WriteLine("");
     
        Console.WriteLine("1. " + squareOne.CalculatePerimeter() +" Perimeter");
        Console.WriteLine("2. " + squareTwo.CalculatePerimeter() +" Perimeter" );

        Console.WriteLine("");
        
        Console.WriteLine("1. " + squareOne.CalculateArea()+ " Area");
        Console.WriteLine("2. " + squareTwo.CalculateArea()+ " Area");
        
        Console.WriteLine("");
        
        // Rectangle section
        double rectangleOneSideA = 20;
        double rectangleOneSideB = 40;

        Rectangle rectangelOne = new Rectangle(rectangleOneSideA, rectangleOneSideB);
        
        Console.WriteLine("Rectangles:");
        
        Console.WriteLine("");
        
        Console.WriteLine("1. " + rectangelOne.CalculatePerimeter() +" Perimeter");

        Console.WriteLine("");
        
        Console.WriteLine("1. " + rectangelOne.CalculateArea()+ " Area");
        
        Console.WriteLine("");
        
        // Parallelogram section
        double parallelogramOneSideA = 50;
        double parallelogramOneSideB = 85;
        double parallelogramOneHeight = 15;

        Parallelogram parallelogramOne = new Parallelogram(parallelogramOneSideA, parallelogramOneSideB, parallelogramOneHeight);
        
        Console.WriteLine("Parallelogram:");
        
        Console.WriteLine("");
        
        Console.WriteLine("1. " + parallelogramOne.CalculatePerimeter() +" Perimeter");

        Console.WriteLine("");
        
        Console.WriteLine("1. " + parallelogramOne.CalculateArea()+ " Area");
    }
}