public abstract class OGGoal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public OGGoal(string name, string description, int points)
    {
        _name=name;
        _description=description;
        _points=points;
    }

//Lets use some of those abstract methods
    public abstract void Display();
    public abstract string SaveGoal();
    public abstract void LoadGoal();
    public abstract int CompleteGoal();
}