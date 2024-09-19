using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int userNumber = PromptUserNumber();
        int square = SquareNumber(userNumber);
        DisplayResult(name, square);
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        return int. Parse(Console.ReadLine());
    }

    static int SquareNumber(int input){
        return input * input;
    }

    static void DisplayResult(string userName, int squareNumber){
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
    }
}