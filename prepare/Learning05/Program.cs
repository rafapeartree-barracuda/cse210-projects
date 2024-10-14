using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment student1 = new Assignment("Rafael Roberto", "Programming with Classes");
        Console.WriteLine(student1.GetSummary());

        MathAssignment student2 = new MathAssignment("Roberto Pereira", "Fractions", "7.3", "8-19");
        Console.WriteLine(student2.GetSummary());
        Console.WriteLine(student2.GetHomeworkList());

        WritingAssignment student3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(student3.GetSummary());
        Console.WriteLine(student3.GetWritingInformation());
    }
}