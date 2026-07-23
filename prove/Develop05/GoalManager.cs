using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _hmgoals;
    private int _hmscore;

    public GoalManager()
    {
        _hmgoals = new List<Goal>();
        _hmscore = 0;
    }

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1") CreateGoal();
            else if (choice == "2") ListGoalDetails();
            else if (choice == "3") SaveGoals();
            else if (choice == "4") LoadGoals();
            else if (choice == "5") RecordEvent();
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_hmscore} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _hmgoals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_hmgoals[i].GetDetailsString().Split(')')[0]})"); 
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _hmgoals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_hmgoals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string hmtype = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string hmname = Console.ReadLine();
        Console.Write("What is a short description of it?(No commas) ");
        string hmdescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?(Max 100) ");
        int hmpoints = int.Parse(Console.ReadLine());

        if (hmtype == "1")
        {
            _hmgoals.Add(new SimpleGoal(hmname, hmdescription, hmpoints));
        }
        else if (hmtype == "2")
        {
            _hmgoals.Add(new EternalGoal(hmname, hmdescription, hmpoints));
        }
        else if (hmtype == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int hmtarget = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int hmbonus = int.Parse(Console.ReadLine());
            _hmgoals.Add(new ChecklistGoal(hmname, hmdescription, hmpoints, hmtarget, hmbonus));
        }
    }

    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Which goal did you accomplish? ");
        int hmindex = int.Parse(Console.ReadLine()) - 1;

        Goal hmgoal = _hmgoals[hmindex];

        if (hmgoal.Complete())
        {
            Console.WriteLine("This goal is already complete!");
            return;
        }

        hmgoal.RecordEvent();
        int hmpointsEarned = hmgoal.GetPoints();

        // Check if it was a checklist goal that just finished
        if (hmgoal is ChecklistGoal checklistGoal && checklistGoal.Complete())
        {
            hmpointsEarned += checklistGoal.GetBonus();
        }

        _hmscore += hmpointsEarned;

        Console.WriteLine($"Congratulations! You have earned {hmpointsEarned} points!");
        Console.WriteLine($"You now have {_hmscore} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string hmfilename = Console.ReadLine();

        using (StreamWriter hmoutputFile = new StreamWriter(hmfilename))
        {
            hmoutputFile.WriteLine(_hmscore);
            foreach (Goal hmgoal in _hmgoals)
            {
                hmoutputFile.WriteLine(hmgoal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string hmfilename = Console.ReadLine();

        string[] lines = File.ReadAllLines(hmfilename);
        
        _hmscore = int.Parse(lines[0]);
        _hmgoals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] hmparts = lines[i].Split(':');
            string hmtype = hmparts[0];
            string[] hmdetails = hmparts[1].Split(',');

            if (hmtype == "SimpleGoal")
            {
                _hmgoals.Add(new SimpleGoal(hmdetails[0], hmdetails[1], int.Parse(hmdetails[2]), bool.Parse(hmdetails[3])));
            }
            else if (hmtype == "EternalGoal")
            {
                _hmgoals.Add(new EternalGoal(hmdetails[0], hmdetails[1], int.Parse(hmdetails[2])));
            }
            else if (hmtype == "ChecklistGoal")
            {
                _hmgoals.Add(new ChecklistGoal(hmdetails[0], hmdetails[1], int.Parse(hmdetails[2]), int.Parse(hmdetails[4]), int.Parse(hmdetails[3]), int.Parse(hmdetails[5])));
            }
        }
    }
}