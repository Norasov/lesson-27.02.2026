using System;

namespace Domain.Models;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    public double GetLength()
    {
        return _length;
    }

    public double GetWidth()
    {
        return _width;
    }

    public double GetArea()
    {
        return _length * _width;
    }

    public double GetPerimeter()
    {
        return 2 * (_length + _width);
    }

    public override string GetInfo()
    {
        return $"Rectangle | Color: {GetColor()}, Length: {_length}, Width: {_width}, Area: {GetArea()}, Perimeter: {GetPerimeter()}";
    }

}
