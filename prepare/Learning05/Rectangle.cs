public class Rectangle : Shape
{
    private double length=5;
    private double width=7;

    public override double GetArea()
    {
        return length*width;
    }
}