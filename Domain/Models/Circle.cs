using System;

namespace Domain.Models;

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

    public double GetCircumference()
    {
        return 2 * Math.PI * _radius;
    }

    public override string GetInfo()
    {
        return $"Circle | Color: {GetColor()}, Radius: {_radius}, Area: {GetArea():F2}, Circumference: {GetCircumference():F2}";
    }

}
