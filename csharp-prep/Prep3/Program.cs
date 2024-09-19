using System;

class Program
{
    static void Main(string[] args)
    {
        /* 
        Console.WriteLine("Hello Prep3 World!");

        --------- Preparation Material

        // while loop
        string response = "yes";

        while (response == "yes")
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }

        // do-while loop
        string response;

        do
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes");

        // for loop
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        for (int i = 2; i <= 20; i = i + 2)
        {
            Console.WriteLine(i);
        }

        // foreach loop
        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }

        // random
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        */

        string answer;
        do{
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            int guess;
            int count = 0;

            do{
                count++;
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if(guess == magicNumber)
                    Console.WriteLine("You guessed it!");
                else if (guess < magicNumber)
                    Console.WriteLine("Higher");
                else
                    Console.WriteLine("Lower");
            }while (guess != magicNumber);

            Console.WriteLine($"Number of guesses: {count}");

            Console.WriteLine("Do you want to play again? (yes/no)");
            answer = Console.ReadLine();
        } while(answer == "yes");
    }
}