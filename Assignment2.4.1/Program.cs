/*
Write a program in C# Sharp to find the sum of all array elements.

Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 2
element - 1 : 5
element - 2 : 8
Expected Output :
Sum of all elements stored in the array is : 15
*/

class Program
{
    static void Main()
    {
        int n, sum = 0;
        Console.Write("Input the number of elements to be stored in the array: ");
        n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine($"Input {n} elements in the array: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"\nElement - {i} : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum += arr[i];
        }
        Console.WriteLine($"\nSum of all elements stored in the array is: {sum}");
    }
}