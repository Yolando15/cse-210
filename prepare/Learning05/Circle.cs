public class Circle : Shape
{
    private double _radius=5;
    
    public override double GetArea()
    {
        return double.Pi *_radius*_radius;
    }

}