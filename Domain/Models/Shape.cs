using System;

namespace Domain.Models;

public abstract class Shape
{
    public abstract double CalculateArea();
    public virtual string PrintDescription()
    {
        return "This is abstract class shape";
    }
}
