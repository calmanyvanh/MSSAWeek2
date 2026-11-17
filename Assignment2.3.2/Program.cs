/*
Design a tip calculator : enter the bill total, tip % and display grand total after adding tip.
Use the format specifiers to display currency, % symbol.
*/

class Program
{
    static void Main()
    {
        Console.WriteLine("Tip Calculator");
        Console.Write("Enter the bill total ($): ");
        decimal billTotal = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter the tip percentage (e.g., 0.25 for 25%): ");
        decimal tipPercentage = Convert.ToDecimal(Console.ReadLine());

        decimal tipAmount = billTotal * (tipPercentage);
        decimal grandTotal = billTotal + tipAmount;

        Console.WriteLine($"Tip Percentage: {tipPercentage:P}");
        Console.WriteLine($"Tip Amount: {tipAmount:C}");
        Console.WriteLine($"Grand Total: {grandTotal:C}");
    }
}

