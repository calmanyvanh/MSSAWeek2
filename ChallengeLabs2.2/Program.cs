/*
Write a C# Sharp program that takes userid and password as input (type string). 
After 3 wrong attempts, user will be rejected.
*/

class Program
{
    static void Main()
    {
        string correctUserId = "admin";
        string correctPassword = "password123";
        int attempts = 0;
        const int maxAttempts = 3;
        while (attempts < maxAttempts)
        {
            Console.Write("Enter User ID: ");
            string userId = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            if (userId == correctUserId && password == correctPassword)
            {
                Console.WriteLine("Access granted.");
                return;
            }
            else
            {
                attempts++;
                Console.WriteLine($"Incorrect User ID or Password. Attempts left: {maxAttempts - attempts}");
            }
        }
        Console.WriteLine("Access denied. You have exceeded the maximum number of attempts.");
    }
}