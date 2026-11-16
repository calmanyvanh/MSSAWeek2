//Assignment2.1.2
//Overloading: Write a simple Maths class ( don’t use the keyword Math, it will be a conflict with standard class from system).
//Write overloaded methods with logic and give choice to user to call different methods :
//a.Add(int num1, int num2)
//b.Add(decimal num1, decimal num2, decimal num3)
//c.Multiply(float num1, float num2)
//d.Multiply(float num1, float num2, float num3)
//Declare these methods as public and static.

class Calculator
{
    public void AddOrMultiply()
    {
        Console.WriteLine("Choose operation:");
        Console.WriteLine("1. Add two integers");
        Console.WriteLine("2. Add three decimals");
        Console.WriteLine("3. Multiply two floats");
        Console.WriteLine("4. Multiply three floats");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter first integer:");
                int int1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second integer:");
                int int2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Result: {Addition(int1, int2)}");
                break;

            case 2:
                Console.WriteLine("Enter first decimal:");
                decimal dec1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter second decimal:");
                decimal dec2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter third decimal:");
                decimal dec3 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine($"Result: {Addition(dec1, dec2, dec3)}");
                break;

            case 3:
                Console.WriteLine("Enter first float:");
                float float1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter second float:");
                float float2 = float.Parse(Console.ReadLine());
                Console.WriteLine($"Result: {Multiplication(float1, float2)}");
                break;

            case 4:
                Console.WriteLine("Enter first float:");
                float f1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter second float:");
                float f2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter third float:");
                float f3 = float.Parse(Console.ReadLine());
                Console.WriteLine($"Result: {Multiplication(f1, f2, f3)}");
                break;

        }
    }
    private double Addition(int num1, int num2)
    {
        return num1 + num2;
    }
    private decimal Addition(decimal num1, decimal num2, decimal num3)
    {
        return num1 + num2 + num3;
    }
    private float Multiplication(float num1, float num2)
    {
        return num1 * num2;
    }  
    private float Multiplication(float num1, float num2, float num3)
    {
        return num1 * num2 * num3;
    }
}
class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        calculator.AddOrMultiply();
    }
}


