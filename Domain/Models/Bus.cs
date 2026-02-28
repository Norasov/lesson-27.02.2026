using System;

namespace Domain.Models;

public class Bus : IMovable
{
    private string? color_;
    private double speed_;
    private string? model_;

    public Bus(string color, double speed, string model)
    {
        color_ = color;
        speed_ = speed;
        model_ = model;
    }

    public string MoveLeft()
    {
        return "bus is moving left";
    }

    public string MoveRight()
    {
        return "bus is moving right";    
    }
}
