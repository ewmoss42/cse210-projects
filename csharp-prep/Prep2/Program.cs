using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string grade = "";

        if (percent >= 93)
        {
            grade = "A";
        }
        else if (percent >= 90)
        {
            grade = "A-";
        }
        else if (percent >= 87)
        {
            grade = "B+";
        }
        else if (percent >= 83)
        {
            grade = "B";
        }
        else if (percent >= 80)
        {
            grade = "B-";
        }
        else if (percent >= 77)
        {
            grade = "C+";
        }
        else if (percent >= 73)
        {
            grade = "C";
        }
        else if (percent >= 70)
        {
            grade = "C-";
        }
        else if (percent >= 67)
        {
            grade = "D+";
        }
        else if (percent >= 63)
        {
            grade = "D";
        }
        else if (percent >= 60)
        {
            grade = "D-";
        }
        else 
        {
            grade = "F";
        }
        
        Console.WriteLine($"Your grade is {grade}");

        if (percent >= 70)
        {
            Console.WriteLine($"You Passed!");
        }
        else
        {
            Console.WriteLine($"You Failed, Better luck next time");
        }
    }
}