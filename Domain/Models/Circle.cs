using System;

namespace Domain.Models;

public class Circle : Shape
{
    double _radius;
    double pi = 3.14;
    public Circle(double radius)
    {
        _radius = radius;
    }
    public override double CalculateArea()
    {
        return pi * _radius * _radius;
    }

    public override string PrintDescription()
    {
        return "This is a Circle";
    }
}
