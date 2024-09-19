using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        /* -------- Assignment
        Write a program that determines the letter grade for a course according to the following scale:
            A >= 90
            B >= 80
            C >= 70
            D >= 60
            F < 60
        
        Start by completing the core requirements, then when that part is complete, if you have time, see if you can complete some of the stretch challenges as well.
        Please work through the requirements in order rather than jumping ahead to more complicated steps, to ensure that everyone is following the concepts.

        --------- Core Requirements
        1. Ask the user for their grade percentage, then write a series of if-elif-else statements to print out the appropriate letter grade. (At this point, you'll have a separate print statement for each grade letter in the appropriate block.)
        
        2. Assume that you must have at least a 70 to pass the class. After determining the letter grade and printing it out. Add a separate if statement to determine if the user passed the course, and if so display a message to congratulate them. If not, display a different message to encourage them for next time.

        3. Change your code from the first part, so that instead of printing the letter grade in the body of each if, elif, or else block, instead create a new variable called letter and then in each block, set this variable to the appropriate value. Finally, after the whole series of if-elif-else statements, have a single print statement that prints the letter grade once.

        --------- Stretch Challenge
        1. Add to your code the ability to include a "+" or "-" next to the letter grade, such as B+ or A-. For each grade, you'll know it is a "+" if the last digit is >= 7. You'll know it is a minus if the last digit is < 3 and otherwise it has no sign.
        After your logic to determine the grade letter, add another section to determine the sign. Save this sign into a variable. Then, display both the grade letter and the sign in one print statement.
        Hint: To get the last digit, you could divide the number by 10, and get the remainder. You might review the standard math operators and find the one that does division and gives you the remainder.
        At this point, don't worry about the exceptional cases of A+, F+, or F-.

        2. Recognize that there is no A+ grade, only A and A-. Add some additional logic to your program to detect this case and handle it correctly.

        3. Similarly, recognize that there is no F+ or F- grades, only F. Add additional logic to your program to detect these cases and handle them correctly.
        */

        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int gpercentage = int.Parse(answer);

        // Preventig error
        if (gpercentage < 0 || gpercentage > 100)
        {
            Console.WriteLine("Invalid score.");
        }
        else {
            string letter = "F";

            if (gpercentage >= 90){
                letter = "A";
            }
            else if(gpercentage >= 80){
                letter = "B";
            }
            else if(gpercentage >= 70){
                letter = "C";
            }
            else if(gpercentage >= 60){
                letter = "D";
            }
            
            string gsign = "";
            if(letter != "F"){
                int lastDigit = gpercentage % 10;

                if (lastDigit >= 7 && letter != "A"){
                    gsign = "+";
                } else if(lastDigit < 3 && gpercentage < 100){
                    gsign = "-";
                }
            }

            Console.WriteLine($"Your grade is: {letter}{gsign}");
            
            if (gpercentage >= 70)
            {
                Console.WriteLine("You passed!");
            }
            else
            {
                Console.WriteLine("Sorry, you didn't passed. Keep pushing forward—you’ve got this! Next time will be even better!");
            }
        }
    }
}