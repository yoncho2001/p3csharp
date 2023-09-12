using System;
using validate;

public struct Point3D
{
    private static Point3D pointO = new Point3D(0, 0, 0);

    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Point3D(double x, double y, double z)
    {

        X = x;
        Y = y;
        Z = z;
    }

    public Point3D()
    {
        X = 0;
        Y = 0;
        Z = 0;
    }

    public static Point3D O
    {
        get
        {
            return pointO;
        }
    }

    public override string ToString()
    {
        return $"{{{X}, {Y}, {Z}}}";
    }
}

static class Distance
{
    public static double CalculateDistance(Point3D point1, Point3D point2)
    {
        double distance = Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2) + Math.Pow(point1.Z - point2.Z, 2));
        return distance;
    }
}
