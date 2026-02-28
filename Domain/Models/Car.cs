using System;

namespace Domain.Models;

public class Car : IMovable
{
    private string? color_;
    private double speed_;
    private string? model_;

    public Car(string color, double speed, string model)
    {
        color_ = color;
        speed_ = speed;
        model_ = model;
    }

    public string MoveLeft()
    {
        return "car is moving left";
    }

    public string MoveRight()
    {
        return "car is moving right";    
    }
}
