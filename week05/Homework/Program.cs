using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment student1 = new Assignment("George Harrison", "Geometry");
        Console.WriteLine(student1.GetSummary());

        MathAssignment student2 = new MathAssignment("Michael Jackson", "Matricies", "4.5", "1-12");
        Console.WriteLine(student2.GetSummary());
        Console.WriteLine(student2.GetHomeworkList());

        WritingAssignment student3 = new WritingAssignment("Diana Washington", "Greek Mythology", "The Legend of the Amazonians");
        Console.WriteLine(student3.GetSummary());
        Console.WriteLine(student3.GetWritingInformation());
    }
}