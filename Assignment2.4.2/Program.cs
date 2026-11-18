/* 
Write a C# Sharp program to find the largest of three numbers.

Test Data :

Input the 1st number :25

Input the 2nd number :63

Input the 3rd number :10

Expected Output :

The 2nd Number is the greatest among three
*/

class Program
{
    static void Main()
    {
        int num1, num2, num3;
        Console.Write("Input the 1st number :");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the 2nd number :");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the 3rd number :");
        num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2 && num1 > num3)
            Console.WriteLine("The 1st Number is the greatest among the three");
        else if (num2 > num1 && num2 > num3)
            Console.WriteLine("The 2nd Number is the greatest among the three");
        else
            Console.WriteLine("The 3rd Number is the greatest among the three");
    }
}
