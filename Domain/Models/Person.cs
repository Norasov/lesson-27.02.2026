using System;

namespace Domain.Models;

public class Person
{
    public int Age;
    public void Greeet()
    {
        System.Console.WriteLine("Hello!");
    }

    public void SetAge(int age)
    {
        Age = age;
    }
}
