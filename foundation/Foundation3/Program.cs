/*
    Author: Karina Santos Felippe
*/

namespace Foundation3;

class Program
{
    static void Main(string[] args)
    {
        var date = DateTime.Now;

        List<Activity> activities =
        [
            new Running(date, 30, 3),
            new Cycling(date, 45, 12),
            new Swimming(date, 30, 20)
        ];

        foreach (Activity activity in activities)
            Console.WriteLine(activity.GetSummary());
    }
}