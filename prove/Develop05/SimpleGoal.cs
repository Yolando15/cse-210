

using System.Runtime.CompilerServices;

public class SimpleGoal : OGGoal
{

    private bool _completed=false;
    public SimpleGoal(string name, string description, int points, bool completed=false): base(name, description, points)
    {
        _completed=completed;
    }
    public override void Display()
    {
        string condition;
        if (_completed==true)
        {
            condition="(#)";
        }
        else
        {
            condition="( )";
        }
        Console.WriteLine($"{condition} {_name}--({_description})");
    }
    public override void LoadGoal()
    {
        
    }
    public override string SaveGoal()
    {
        return $"Simple++{_name}++{_description}++{_points}++{_completed}";
    }


    public override int CompleteGoal()
    {
        if (_completed==false)
        {
            _completed=true;
            return _points;
        }
        else
        {
            Console.WriteLine("You have already completed this goal");
            return (0);
        }
        
    }
}