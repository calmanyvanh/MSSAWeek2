/* 
Write a C# Sharp program to read roll number, name and marks of three subjects and calculate the total, percentage and division. (May use a struct / class to represent the student)
Test Data :
Input the Roll Number of the student :784
Input the Name of the Student :James
Input the marks of Physics, Chemistry and Computer Application : 70 80 90
Expected Output :
Roll No : 784
Name of Student : James
Marks in Physics : 70
Marks in Chemistry : 80
Marks in Computer Application : 90
Total Marks = 240
Percentage = 80.00
Division = First
*/

class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public int PhysicsMarks { get; set; }
    public int ChemistryMarks { get; set; }
    public int ComputerApplicationMarks { get; set; }

    public int TotalMarks => PhysicsMarks + ChemistryMarks + ComputerApplicationMarks;

    public double Percentage => (TotalMarks / 300.0) * 100;

    public string Division
    {
        get
        {
            if (Percentage >= 80)
                return "First";
            else if (Percentage >= 70)
                return "Second";
            else if (Percentage >= 60)
                return "Third";
            else
                return "Fail";
        }
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        Console.Write("Input the Roll Number of the student: ");
        student.RollNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the Name of the Student: ");
        student.Name = Console.ReadLine();

        Console.Write("Input the marks of Physics: ");
        student.PhysicsMarks = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the marks of Chemistry: ");
        student.ChemistryMarks = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the marks of Computer Application: ");
        student.ComputerApplicationMarks = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nRoll No: {student.RollNumber}");
        Console.WriteLine($"Name of Student: {student.Name}");
        Console.WriteLine($"Marks in Physics: {student.PhysicsMarks}");
        Console.WriteLine($"Marks in Chemistry: {student.ChemistryMarks}");
        Console.WriteLine($"Marks in Computer Application: {student.ComputerApplicationMarks}");
        Console.WriteLine($"Total Marks = {student.TotalMarks}");
        Console.WriteLine($"Percentage = {student.Percentage:F2}");
        Console.WriteLine($"Division = {student.Division}");
    }
}
