using System;

class Program
{
    static void Main(string[] args)
    {
        /* ------- Preparation Material
        Console.WriteLine("Hello Prep1 World!");

        // Defined types
        int x = 5;
        Console.WriteLine("X = " + x);

        // Input and Output
        Console.Write("There will not be a newline after this. ");
        Console.WriteLine("Now it will place a new line.");
        Console.Write("What is your favorite color? ");
        string color = Console.ReadLine();
        Console.WriteLine("Your color is " + color);

        // Curly braces define blocks
        if (color == "blue")
        {
            Console.WriteLine("That's my favority too!");
        }

        // String Interpolation
        string school = "BYU-Idaho";
        Console.WriteLine($"I am studying at {school}.");
        */

        /* ---------- Assignment
        Prompt the user for their first name. Then, prompt them for their last name. Display the text back all on one line saying, "Your name is last-name, first-name, last-name"
        */
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();
        Console.Write("What is your last name? ");
    	string lname = Console.ReadLine();

        Console.WriteLine($"\nYour name is {lname}, {fname} {lname}.");
    }
}