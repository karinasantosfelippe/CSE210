namespace Develop06;

public class GoalManager
{
    private List<Goal> _goals = [];
    private int _score = 0;

    public void Start()
    {
        DisplayPlayerInfo();

        int selectedMenuOption = -1;
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine($"\t{(int)MenuOptions.CreateNewGoal}. Create New Goal");
            Console.WriteLine($"\t{(int)MenuOptions.ListGoals}. List Goals");
            Console.WriteLine($"\t{(int)MenuOptions.SaveGoals}. Save Goals");
            Console.WriteLine($"\t{(int)MenuOptions.LoadGoals}. Load Goals");
            Console.WriteLine($"\t{(int)MenuOptions.RecordEvent}. Record Event");
            Console.WriteLine($"\t{(int)MenuOptions.Quit}. Exit");
            Console.Write("Select an option: ");

            try
            {
                selectedMenuOption = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\nInvalid option! Please enter the number of the menu option.");
                continue;
            }

            switch (selectedMenuOption)
            {
                case (int)MenuOptions.CreateNewGoal:
                    CreateGoal();
                    break;
                case (int)MenuOptions.ListGoals:
                    ListGoalDetails();
                    break;
                case (int)MenuOptions.SaveGoals:
                    SaveGoals();
                    break;
                case (int)MenuOptions.LoadGoals:
                    break;
                case (int)MenuOptions.RecordEvent:
                    RecordEvent();
                    break;
                case (int)MenuOptions.Quit:
                    Console.WriteLine("\nAny unsaved changes will be lost.");
                    Console.Write("Are you sure you want to quit the program? ");
                    Console.WriteLine("[1] Yes [2] No");
                    if (Console.ReadLine() == "1")
                        quit = true;
                    continue;
                default:
                    Console.WriteLine("\nInvalid option! Please try again.");
                    continue;
            }

            DisplayPlayerInfo();
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }

    private void ListGoalNames()
    {
        int i = 1;
        int separateIndex = -1;
        foreach (var goal in _goals)
        {
            separateIndex = goal.GetDetails().IndexOf('(') - 1;
            Console.WriteLine($"{i}. {goal.GetDetails().Substring(0, separateIndex)}");
            i++;
        }
    }

    private void ListGoalDetails()
    {
        int i = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{i}. {(goal.IsComplete() ? "[x]" : "[ ]")} {goal.GetDetails()}");
            i++;
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");

        Console.Write("Which type of Goal would you like to create? ");
        int goalType = 0;
        try
        {
            goalType = int.Parse(Console.ReadLine());
        }
        catch (System.Exception)
        {
            Console.WriteLine("\nIvalid option! Please try again.\n");
            return;
        }

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case 1:
                _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
                break;
            case 2:
                _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, target, bonus));
                break;
            default:
                Console.WriteLine("\nInvalid option! Please try again.\n");
                break;
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        int points = _goals[goalIndex].RecordEvent();
        Console.WriteLine($"\nCongratulations! You have earned {points}!");

        _score += points;
        Console.WriteLine($"You now have {_score} points.");
    }

    private void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new(filename))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
                writer.WriteLine($"{goal.GetType()}:{goal.GetStringRepresentation()}");
        }
        Console.WriteLine("Progress saved.");
    }

    private void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            using (StreamReader reader = new(path: filename))
            {
                _score = int.Parse(reader.ReadLine());
                _goals.Clear();
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    if (type == nameof(SimpleGoal))
                    {
                        _goals.Add(new SimpleGoal(name, description, points));
                    }
                    else if (type == nameof(EternalGoal))
                    {
                        _goals.Add(new EternalGoal(name, description, points));
                    }
                    else if (type == nameof(ChecklistGoal))
                    {
                        int bonus = int.Parse(parts[4]);
                        int target = int.Parse(parts[5]);
                        int amountCompleted = int.Parse(parts[6]);
                        var checklistGoal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                        _goals.Add(checklistGoal);
                    }
                }
            }
            Console.WriteLine("Progress loaded.");
        }
        else
        {
            Console.WriteLine("No saved progress found.");
        }
    }
}