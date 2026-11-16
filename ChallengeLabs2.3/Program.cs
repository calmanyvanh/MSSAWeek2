/*
Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number.
Test Data
Enter a number: 6
Enter the desired width: 6
Expected Output:

666666

66666

6666

666

66

6
*/

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the desired width: ");
        int width = Convert.ToInt32(Console.ReadLine());
        for (int i = width; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(number);
            }
            Console.WriteLine("\n");
        }
    }
}