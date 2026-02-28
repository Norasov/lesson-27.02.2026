using System;

namespace Domain.Models;

public class Teacher : Person
{
    public void Explain()
    {
        System.Console.WriteLine("I am explaining");
    }
}
