using System;

public class Circle
{
    public const double PI = 3.14;

    private double radius;

    
    public Circle(double r)
    {
        radius = r;
    }

    // Method to calculate area
    public double GetArea()
    {
        return PI * radius * radius;
    }

    // Method to calculate perimeter (circumference)
    public double GetPerimeter()
    {
        return 2 * PI * radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle c = new Circle(5);

        Console.WriteLine("Area: " + c.GetArea());
        Console.WriteLine("Perimeter: " + c.GetPerimeter());
        
        //Circle.PI = 4.14;  Trying to modify PI
        
        // The above line will cause a compilation error because PI is declared as 'const'.
    }
}