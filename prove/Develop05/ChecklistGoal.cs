public class ChecklistGoal : OGGoal
{
    public int _end;
    public int _current;
    public int _bonus;
    public ChecklistGoal(string name, string description, int points, int end, int current, int bonus) : base(name, description, points)
    {
        _end=end;
        _current=current;
        _bonus=bonus;

    }
    public override void LoadGoal()
    {
        
    }
    public override string SaveGoal()
    {
        return $"Checklist++{_name}++{_description}++{_points}++{_end}++{_current}++{_bonus}";
    }
    public override void Display()
    {
        string completed;
        if (_current==_end)
        {
            completed="(#)";
        }
        else
        {
            completed="( )";
        }
        Console.WriteLine($"{completed}-{_current}/{_end}--{_name} ({_description})");
    }
    public override int CompleteGoal()
    {
        _current+=1;
        if (_current<_end)
        {
            return _points;
        }
        else
        {
            return _points+_bonus;
        }

    }
}