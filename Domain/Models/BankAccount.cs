using System;

namespace Domain.Models;

public class BankAccount
{
    public string? AccountNumber {get; set;}
    private decimal balance {get; set;}
    public string? Owner {get; set;}
    public void TopUp(decimal amount)
    {
        if(amount > 0)
        {
            balance += amount;
        }
    }

    public void Withdraw(decimal amount)
    {
        if(balance >= amount && amount > 0)
        {
            balance -= amount; 
        }
    }

    public void PrintStatement()
    {
        System.Console.WriteLine($"{Owner}\n{AccountNumber}\n{balance}");
    }
}
