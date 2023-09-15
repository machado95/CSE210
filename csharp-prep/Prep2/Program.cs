using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage: ");
        string Percentage = Console.ReadLine();
        int gradePercentage = int.Parse(Percentage);

        string letter = "";

        if (gradePercentage >= 90) {
            letter = "A";
        }
        else if (gradePercentage >= 80) {
            letter = "B";
        }
        else if (gradePercentage >= 70) {
            letter = "C";
        }
        else if (gradePercentage >= 60) {
            letter = "E";
        }
        else {
            letter = "F";
        }

        if (gradePercentage >= 70) {
            Console.WriteLine($"Your letter grade is {letter}. Congratulations, you passed out the course!");
        }
        else {
            Console.WriteLine($"Your letter grade is {letter}. You didn't pass out the course, but don't give up, you'll succeed next time!");
        }
    }
}