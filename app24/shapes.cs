using validate;

public abstract class Shape
{
    protected double width;
    protected double height;

    public Shape()
    {
        this.width = 0;
        this.height = 0;
    }

    public Shape(double width, double height)
    {
        Validate.isPositive(width);
        Validate.isPositive(height);

        this.width = width;
        this.height = height;
    }

    public double Width
    {
        get
        {
            return this.width;
        }
    }

    public double Height
    {
        get
        {
            return this.height;
        }
    }

    public abstract double CalculateSurface();

    public abstract string ToString();
}

public class Triangle : Shape
{
    public Triangle() : base()
    { }

    public Triangle(double width, double height) : base(width, height)
    { }

    public override double CalculateSurface()
    {
        return (height * width) / 2;
    }

    public override string ToString()
    {
        return "Triangle:\nWidth: " + Width.ToString() + " Height: " + Height.ToString();
    }
}

public class Rectangle : Shape
{
    public Rectangle() : base()
    { }

    public Rectangle(double width, double height) : base(width, height)
    { }

    public override double CalculateSurface()
    {
        return height * width;
    }

    public override string ToString()
    {
        return "Rectangle:\nWidth: " + Width.ToString() + " Height: " + Height.ToString();
    }
}

public class Square : Shape
{
    public Square() : base()
    { }

    public Square(double width) : base(width, width)
    { }

    public override double CalculateSurface()
    {
        return height * width;
    }

    public override string ToString()
    {
        return "Square:\nWidth: " + Width.ToString() + " Height: " + Height.ToString();
    }
}