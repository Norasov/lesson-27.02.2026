using System;

namespace Domain.Models;

public class Book
{
    public string? Title {get; set;}
    public string? Author {get; set;}
    public int PublicationYear {get; set;}
    public Book(){ }
    public Book(string title, string author, int publicationyear)
    {
        Title  = title;
        Author = author;
        PublicationYear = publicationyear;
    }
}
