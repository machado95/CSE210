using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();

        int number = 1;
        while (number != 0) {
            Console.Write("Enter number: ");
            string stringNumber = Console.ReadLine();
            number = int.Parse(stringNumber);
            if (number != 0) {
                numbers.Add(number);
            }
        }

        int sum = 0;
        foreach (int item in numbers) {
            sum = sum + item;
        }
        Console.WriteLine($"The sum is : {sum}");

        float average = ((float) sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largestNumber = numbers[0];
        for (int i = 0; i < numbers.Count; i++) {
            if (numbers[i] > largestNumber) {
                largestNumber = numbers[i];
            }
        }
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}