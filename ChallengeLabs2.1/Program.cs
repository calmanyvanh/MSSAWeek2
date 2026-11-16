/*
Write a C# Sharp program to read temperature in Fahrenheit and display a suitable message according to temperature state below :
Temp 0< 10 then Freezing weather
Temp 11-20 then Very Cold weather
Temp 21-35 then Cold weather
Temp 36-50 then Normal in Weather
Temp 51-65 then Its Hot
Temp 66-80 then Its Very Hot

Test Data : 67
Expected Output : Its very hot.
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        int temp = Convert.ToInt32(Console.ReadLine());
        if (temp < 10)
        {
            Console.WriteLine("Really freezing weather");
        }
        else if (temp >= 11 && temp <= 20)
        {
            Console.WriteLine("Freezing weather");
        }
        else if (temp >= 21 && temp <= 35)
        {
            Console.WriteLine("Still freezing weather");
        }
        else if (temp >= 36 && temp <= 50)
        {
            Console.WriteLine("Pretty cold weather");
        }
        else if (temp >= 51 && temp <= 65)
        {
            Console.WriteLine("Cold weather");
        }
        else if (temp >= 66 && temp <= 80)
        {
            Console.WriteLine("Moderate to warm weather");
        }
        else
        {
            Console.WriteLine("Temperature is above the defined range.");
        }
    }
}
