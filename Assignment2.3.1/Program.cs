/*
Assignment2.3.1
Write a console application to create a text file and save your basic details like name, age, address ( use dummy data). 
Read the details from same file and print on console.
*/

class Program
{
    static void Main()
    {
        string [] details = { "Name: Joe", "Age: 30", "Address: 1 Main St, City, MD" };

        string filePath = "BasicDetails.txt";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Basic Details:");
            writer.WriteLine("Name: Joe");
            writer.WriteLine("Age: 30");
            writer.WriteLine("Address: 1 Main St, City, MD");
        }

        try
        {
            using StreamReader reader = new(filePath);

            string text = reader.ReadToEnd();

            Console.WriteLine(text);
        }

        catch (IOException e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}
