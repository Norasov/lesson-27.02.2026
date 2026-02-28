using System;

namespace Domain.Models;

public class Library
{
    public string? Name {get; set;}
    public List<Book> Books {get; set;} = new();

    public Library()
    {
        
    }

    public Library(string name)
    {
        Name = name;
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }

    public Book? SearchBook(string title)
    {
        foreach (var item in Books)
        {
            if(item.Title == title)
            {
                return item;
            }
        }
        return null;    
    }
}
