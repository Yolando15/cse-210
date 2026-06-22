public class Square : Shape
{
    double _side=2;
    public override double GetArea()
    {
        return _side*_side;
    }
}