using System;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        int totalPoints=0;
        List<OGGoal> myGoals=new();
        int choice=0;
        //Main MENU
        while (choice!=6)
        {
        Console.WriteLine("Welcome to my goal program please select from the options below:");
        Console.WriteLine("1. Display Goals");
        Console.WriteLine("2. Create Goal");
        Console.WriteLine("3. Complete a Goal");
        Console.WriteLine("4. Load my goals from a file");
        Console.WriteLine("5. Save my goals to a file");
        Console.WriteLine("6. Quite my Program");
        choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                //showing my goals
                    foreach (OGGoal goal in myGoals)
                    {
                        goal.Display();
                    }
                    break;
                //Creating a new goal
                case 2:
                Console.WriteLine("What type of goal do you want to make?");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                int goaltype=int.Parse(Console.ReadLine());
                string name="";
                string description="";
                int points=0;
                OGGoal tempgoal;
                switch (goaltype)
                    {
                        case 1:
                        //simple goal
                        Console.WriteLine("What is the name of your goal?");
                        name=Console.ReadLine();
                        Console.WriteLine("What are some specifics of your goal?");
                        description=Console.ReadLine();
                        Console.WriteLine("How many points will you get for completing this goal?");
                        points=int.Parse(Console.ReadLine());
                        tempgoal=new SimpleGoal(name, description, points);
                        myGoals.Add(tempgoal);
                        break;
                        case 2:
                        //eternal goal
                        Console.WriteLine("What is the name of your goal?");
                        name=Console.ReadLine();
                        Console.WriteLine("What are some specifics of your goal?");
                        description=Console.ReadLine();
                        Console.WriteLine("How many points will you get for completing this goal?");
                        points=int.Parse(Console.ReadLine());
                        tempgoal=new EternalGoal(name, description, points);
                        myGoals.Add(tempgoal);
                        break;
                        case 3:
                        //checklist goal
                        Console.WriteLine("What is the name of your goal?");
                        name=Console.ReadLine();
                        Console.WriteLine("What are some specifics of your goal?");
                        description=Console.ReadLine();
                        Console.WriteLine("How many points will you get for completing this goal?");
                        points=int.Parse(Console.ReadLine());
                        Console.WriteLine("How many times until this is completed?");
                        int completion=int.Parse(Console.ReadLine());
                        Console.WriteLine("How many bonus points will you recieve when you complete your goal 100%?");
                        int bonus=int.Parse(Console.ReadLine());
                        tempgoal=new ChecklistGoal(name, description, points, completion, 0, bonus);
                        myGoals.Add(tempgoal);
                        break;
                    }
                break;
                case 3:
                //completing a goal
                int i=1;
                foreach (OGGoal goal in myGoals)
                    {
                        
                        Console.Write($"{i}.");
                        goal.Display();
                        i++;
                    }
                    Console.WriteLine("Select which number goal you want to complete");
                    int  select=int.Parse(Console.ReadLine())-1;
                    OGGoal temp=myGoals[select];
                    int add=temp.CompleteGoal();
                    totalPoints+=add;
                break;
                case 5:
                //save file
                Console.WriteLine("What is the name of the file you are saving to?");
                name=Console.ReadLine();

                using (StreamWriter writer =new StreamWriter(name))
                {
                    writer.WriteLine(totalPoints);
                    foreach(OGGoal goal in myGoals)
                        {
                            string mama=goal.SaveGoal();
                            writer.WriteLine(mama);
                        }
                }
                break;
                case 4:
                //load file
                Console.WriteLine("What is the name of the file you are loading from?");
                name=Console.ReadLine();
                myGoals.Clear();
                using (StreamReader reader = new StreamReader(name))
                    {
                        string line;
                        if ((line=reader.ReadLine())!=null)
                        {
                            totalPoints=int.Parse(line);
                        }

                        while ((line=reader.ReadLine())!=null)
                        {
                            string [] data=line.Split("++");
                            if (data[0]=="Checklist")
                            {
                                myGoals.Add(new ChecklistGoal (data[1], data[2],int.Parse(data[3]),
                                int.Parse(data[4]),int.Parse(data[5]),int.Parse(data[6])));
                            }
                            if (data[0]=="Simple")
                            {
                                myGoals.Add(new SimpleGoal (data[1], data[2],int.Parse(data[3])));
                            }
                            if (data[0]=="Eternal")
                            {
                                myGoals.Add(new EternalGoal (data[1], data[2],int.Parse(data[3])));
                            }
                        }
                    }
                break;
            }
            Console.WriteLine($"You have {totalPoints} points");
    }
    }
}