using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        GoalManager manager = new GoalManager();

        while (running)
        {
            Console.WriteLine("\n1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Choose goal type (1-Simple, 2-Eternal, 3-Checklist): ");
                    int goalType = int.Parse(Console.ReadLine());
                    Console.Write("Enter goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter points: ");
                    int points = int.Parse(Console.ReadLine());

                    if (goalType == 1)
                        manager.AddGoal(new Simple(name, points));
                    else if (goalType == 2)
                        manager.AddGoal(new Eternal(name, points));
                    else if (goalType == 3)
                    {
                        Console.Write("Enter times required: ");
                        int timesRequired = int.Parse(Console.ReadLine());
                        Console.Write("Enter bonus points: ");
                        int bonusPoints = int.Parse(Console.ReadLine());
                        manager.AddGoal(new Checklist(name, points, timesRequired, bonusPoints));
                    }
                    break;

                case 2:
                    manager.DisplayGoals();
                    Console.Write("Select goal to record: ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(goalIndex);
                    break;

                case 3:
                    manager.DisplayGoals();
                    break;

                case 4:
                    manager.DisplayScore();
                    break;

                case 5:
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    manager.Save(saveFile);
                    break;

                case 6:
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    manager.Load(loadFile);
                    break;

                case 7:
                    running = false;
                    break;
            }
        }
    }
}