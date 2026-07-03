public class EternalGoal : OGGoal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }
    public override void Display()
    {
        Console.WriteLine($"( ) {_name}--({_description})");
    }
    public override void LoadGoal()
    {
        
    }
    public override string SaveGoal()
    {
        return $"Eternal++{_name}++{_description}++{_points}";
    }
    
    public override int CompleteGoal()
    {
        return _points;
    }
    
}