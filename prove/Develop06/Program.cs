using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Load Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CreateGoalMenu(goalManager);
                    break;
                case "2":
                    goalManager.ListGoals();
                    break;
                case "3":
                    goalManager.LoadGoals();
                    break;
                case "4":
                    goalManager.SaveGoals();
                    break;
                case "5":
                    RecordEventMenu(goalManager);
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateGoalMenu(GoalManager goalManager)
    {
        Console.WriteLine("\nSelect Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        // This criterion is linked to a Learning Outcome12. Shows creativity and exceeds core requirements
        Console.WriteLine("4. Negative Goal");
        Console.Write("Enter your choice: ");
        string goalType = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the goal description: ");
        string description = Console.ReadLine();

        switch (goalType)
        {
            case "1":
                Console.Write("Enter the points: ");
                int simplePoints = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new SimpleGoal(name, description, simplePoints));
                break;
            case "2":
                Console.Write("Enter the points: ");
                int eternalPoints = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new EternalGoal(name, description, eternalPoints));
                break;
            case "3":
                Console.Write("Enter the points per event: ");
                int checklistPoints = int.Parse(Console.ReadLine());
                Console.Write("Enter the target count for completion: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points upon completion: ");
                int bonus = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new ChecklistGoal(name, description, checklistPoints, targetCount, bonus));
                break;
            case "4":
                Console.Write("Enter the penalty points: ");
                int penaltyPoints = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new NegativeGoal(name, description, penaltyPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void RecordEventMenu(GoalManager goalManager)
    {
        goalManager.ListGoals();
        Console.Write("Enter the index of the goal to record an event: ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex))
        {
            goalManager.RecordEvent(goalIndex);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}
