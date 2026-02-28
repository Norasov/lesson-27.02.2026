using System;

namespace Domain.Models;

public class Student : Person
{
    public void Study()
    {
        System.Console.WriteLine("I'm Studying");
    }

    public void ShowAge()
    {
        System.Console.WriteLine($"My age is {Age} years old");
    }
}
