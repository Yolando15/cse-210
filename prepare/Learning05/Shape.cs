public abstract class Shape
{
    protected string _color;
    // methods
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color=color;
    }

    public abstract double GetArea();
}