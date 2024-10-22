using System.Net;

namespace Develop06;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager(){
        _goals = [];
        _score = 0;
    }

    public void Start(){
        DisplayPlayerInfo();
    }

    public void DisplayPlayerInfo(){
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalDetails(){
        int i = 1;
        string complete = " ";
        foreach (var goal in _goals)
        {
            if(goal.IsComplete())
                complete = "X";
            Console.WriteLine($"{i}. [{complete}] {goal.GetDetails()}");
            i++;
        }
    }

    public void CreateGoal(){
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
        }

        switch(goalType){
            case 1:
                var simpleGoal = new SimpleGoal("Name","Goal description", 10);
                _goals.Add(simpleGoal);
                break;
            case 2:
                break;
            case 3:
                break;
            default:
                Console.WriteLine("\nInvalid option! Please try again.\n");
                break;
        }

    }
}