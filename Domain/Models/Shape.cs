using System;

namespace Domain.Models;

public class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual string GetInfo()
    {
        return $"Shape | Color: {_color}";
    }

}
