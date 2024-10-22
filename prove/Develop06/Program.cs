/*
    Author: Karina Santos Felippe
    Exceeding requirements: the exceeding requirements are described in the README file, section "exceeding requirements".
    https://github.com/karinasantosfelippe/CSE210/tree/main/prove/Develop06#exceeding-requirements
*/

namespace Develop06;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new();

        // default value to intiate the menu
        int selectedMenuOption = -1;
        // looping while the selected options is not quit
        while (selectedMenuOption != (int)MenuOptions.Quit)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine($"\t{(int)MenuOptions.CreateNewGoal}. Create New Goal");
            Console.WriteLine($"\t{(int)MenuOptions.ListGoals}. List Goals");
            Console.WriteLine($"\t{(int)MenuOptions.SaveGoals}. Save Goals");
            Console.WriteLine($"\t{(int)MenuOptions.LoadGoals}. Load Goals");
            Console.WriteLine($"\t{(int)MenuOptions.RecordEvent}. Record Event");
            Console.WriteLine($"\t{(int)MenuOptions.Quit}. Exit");
            Console.Write("Select an option: ");

            try{
                selectedMenuOption = int.Parse(Console.ReadLine());
            } catch{
                Console.WriteLine("\nInvalid option! Please enter the number of the menu option.");
                continue;
            }

            switch (selectedMenuOption)
            {
                case (int)MenuOptions.CreateNewGoal:
                    manager.CreateGoal();
                    break;
                case (int)MenuOptions.ListGoals:
                    manager.ListGoalDetails();
                    break;
                case (int)MenuOptions.SaveGoals:
                    Console.WriteLine((int)MenuOptions.SaveGoals);
                    break;
                case (int)MenuOptions.LoadGoals:
                    Console.WriteLine((int)MenuOptions.LoadGoals);
                    break;
                case (int)MenuOptions.RecordEvent:
                    Console.WriteLine((int)MenuOptions.RecordEvent);
                    break;
                case (int)MenuOptions.Quit:
                    Console.WriteLine("\nAny unsaved changes will be lost.");
                    Console.Write("Are you sure you want to quit the program? ");
                    Console.WriteLine("[1] Yes [2] No");
                    if(Console.ReadLine() == "2")
                        selectedMenuOption = 0;
                    continue;
                default:
                    Console.WriteLine("\nInvalid option! Please try again.");
                    continue;
            }
            
            Console.WriteLine("Finally");
        }
    }
}
// Author: Karina Santos Felippe