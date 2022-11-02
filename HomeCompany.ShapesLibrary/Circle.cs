namespace HomeCompany.ShapesLibrary;

public class Circle : IShape
{
    private readonly double _radius;
    
    public double Radius
    {
        get => _radius;
        private init
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("Radius");
            _radius = value;
        }
    } 

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}