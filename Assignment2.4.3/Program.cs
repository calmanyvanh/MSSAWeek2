/*
Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.

Test Data :

Input the value for X coordinate :7

Input the value for Y coordinate :9

Expected Output :

The coordinate point (7,9) lies in the First quadrant.

Copilot reccommendation:
class Program
{
    static void Main()
    {
        Console.Write("Input the value for X coordinate: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the value for Y coordinate: ");
        int y = Convert.ToInt32(Console.ReadLine());
        if (x > 0 && y > 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
        }
        else if (x == 0 && y != 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies on the Y-axis.");
        }
        else if (y == 0 && x != 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies on the X-axis.");
        }
        else
        {
            Console.WriteLine($"The coordinate point ({x},{y}) is at the origin.");
        }
    }
}
*/

class Program
{
    static void Main()
    {
        Console.Write("Input the value for X coordinate: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the value for Y coordinate: ");
        int y = Convert.ToInt32(Console.ReadLine());

        switch (Console.ReadLine())
        {
            case var _ when x > 0 && y > 0:
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
                break;
            case var _ when x < 0 && y > 0:
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
                break;
            case var _ when x < 0 && y < 0:
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
                break;
            case var _ when x > 0 && y < 0:
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
                break;
            case var _ when x == 0 && y != 0:
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the Y-axis.");
                break;
            case var _ when x != 0 && y == 0:
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the X-axis.");
                break;
            default:
                Console.WriteLine($"The coordinate point ({x},{y}) is at the origin.");
                break;
        }
    }
}

