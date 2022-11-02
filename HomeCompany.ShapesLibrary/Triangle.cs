namespace HomeCompany.ShapesLibrary;

public class Triangle : IShape
{
    private readonly double _side1;
    private readonly double _side2;
    private readonly double _side3;

    public double Side1
    {
        get => _side1;
        private init
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("Side1");
            _side1 = value;
        }
    } 
    
    public double Side2
    {
        get => _side2;
        private init
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("Side2");
            _side2 = value;
        }
    }
        
    public double Side3
    {
        get => _side3;
        private init
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("Side3");
            _side3 = value;
        }
    }

    public Triangle(double side1, double side2, double side3)
    {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
        
        DefineTriangleSides(out double hypotenuse, out double leg1, out double leg2);
        if (leg1 + leg2 <= hypotenuse)
            throw new ArgumentOutOfRangeException("Еriangle sides length mismatch");
    }
    
    public double GetArea()
    {
        var halfPerimeter = GetPerimeter() / 2;
        return Math.Sqrt(halfPerimeter *
                         (halfPerimeter - Side1) *
                         (halfPerimeter - Side2) *
                         (halfPerimeter - Side3));
    }

    public double GetPerimeter()
    {
        return Side1 + Side2 + Side3;
    }

    public bool IsRightAngled()
    {
        const double calculationError = 0.1;
        DefineTriangleSides(out double hypotenuse, out double leg1, out double leg2);
        return Math.Abs(hypotenuse * hypotenuse - leg1 * leg1 - leg2 * leg2) < calculationError;
    }

    private void DefineTriangleSides(out double hypotenuse, out double leg1, out double leg2)
    {
        if (Side1 >= Side2 && Side1 >= Side3)
        {
            hypotenuse = Side1;
            leg1 = Side2;
            leg2 = Side3;
        }
        else if (Side2 >= Side1 && Side2 >= Side3)
        {
            hypotenuse = Side2;
            leg1 = Side1;
            leg2 = Side3;
        }
        else
        {
            hypotenuse = Side3;
            leg1 = Side1;
            leg2 = Side2;
        }
    }
}