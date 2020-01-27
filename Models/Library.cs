using System;
using System.Collections.Generic;

namespace consoleLibrary.Models
{
  class library
  {
    private List<Book> Books { get; set; }

    public void PrintBooks()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        Console.WriteLine($"{i + 1} {Books[i].Title} - {Books[i].Author}");
      }
    }
    public void AddBook(Book book)
    {
      Books.Add(book);
    }
  }
}