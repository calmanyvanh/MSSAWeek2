/*
Write a abstract base class: ‘Shape’ and add properties like id, name and color and method ‘calculate area’ .
Inherit circle shape from base class and add properties like radius. override calculate area logic for circle.
Inherit square class from shape and change the calculate area logic. Add property like side of square.
Take the input from user to select circle or square and display the calculated area . no hard coded values!
*/

abstract class Shape
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }

    public abstract double CalculateArea(int side1);
}

class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea(int side1)
    {
        return Math.PI * side1 * side1;
    }
}

class Square : Shape
{
    public double Side { get; set; }

    public override double CalculateArea(int side1)
    {
        return side1 * side1;
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Select shape to calculate area:");
        Console.WriteLine("1. Circle");
        Console.WriteLine("2. Square");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter radius of the circle:");
                int radius = Convert.ToInt32(Console.ReadLine());
                Circle circle = new Circle { Radius = radius };
                double circleArea = circle.CalculateArea(radius);
                Console.WriteLine($"Area of Circle: {circleArea}");
                break;

            case 2:
                Console.WriteLine("Enter side of the square:");
                int side = Convert.ToInt32(Console.ReadLine());
                Square square = new Square { Side = side };
                double squareArea = square.CalculateArea(side);
                Console.WriteLine($"Area of Square: {squareArea}");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}


