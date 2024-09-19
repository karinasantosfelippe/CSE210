using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("Hello Prep4 World!");

        --------- Preparation Material
        // One more important thing to be aware of: Any file that uses Lists (or any other standard collection), must refer to that library at the top of the file. (This is so common that sometimes your settings for C# can be specified so that you do not not have include this, but it is important to know about it, in case you run into problems.)
        //      using System.Collections.Generic;

        List<int> numbers;
        numbers = new List<int>();

        List<string> words = new List<string>();
        words.Add("phone");
        words.Add("keyboard");
        words.Add("mouse");

        Console.WriteLine(words.Count);

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
        for (int i = 0; i < words.Count; i++)
        {
            Console.WriteLine(words[i]);
        }
        */
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int answer;
        do
        {
            Console.Write("Enter number: ");
            answer = int.Parse(Console.ReadLine());
            if (answer != 0)
                numbers.Add(answer);
        } while (answer != 0);

        int largest = numbers[0];
        int smallestPositive = -1;
        int sum = 0;
        foreach(int number in numbers)
        {
            sum += number;

            if(number > largest)
                largest = number;
            if(number > 0)
                if(smallestPositive == -1)
                    smallestPositive = number;
                else if(number < smallestPositive)
                    smallestPositive = number;
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {((float)sum) / numbers.Count}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {((smallestPositive > 0) ? smallestPositive : "")}");
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach(int number in numbers)
            Console.WriteLine(number);
    }
}