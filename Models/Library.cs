using System;
using System.Collections.Generic;

namespace consoleLibrary.Models
{
  class Library
  {
    //fields & properties
    private List<Book> Books { get; set; }
    private List<Book> CheckedOut { get; set; }

    //methods
    public void AddBook(Book book)
    {
      Books.Add(book);
    }

    public void PrintBooks()
    {
      Console.WriteLine("Welcome to the Library!\n\nAvailable Books:");
      for (int i = 0; i < Books.Count; i++)
      {
        Console.WriteLine($"{i + 1} {Books[i].Title} - {Books[i].Author}");
      }
      Console.WriteLine("\nSelect a book number to checkout. \"q\" = quit & \"r\" = return.");
    }

    public void Quit(string selection)
    {
      if (selection == "q")
      {
        Environment.Exit(0);
      }
    }
    public void Checkout(string selection)
    {
      Book selectedBook = ValidateBook(selection, Books);

      if (selectedBook == null)
      {
        Console.Clear();
        System.Console.WriteLine("Invalid Selection");
        return;
      }
      else
      {
        Console.Clear();
        selectedBook.Available = false;
        CheckedOut.Add(selectedBook);
        Books.Remove(selectedBook);
        Console.WriteLine($"You've checked out {selectedBook.Title}");
      }
    }

    //constructor
    private Book ValidateBook(string selection, List<Book> bookList)
    {
      int bookIndex = 0;
      bool valid = Int32.TryParse(selection, out bookIndex);
      if (!valid || bookIndex < 1 || bookIndex > bookList.Count)
      {
        return null;
      }
      return bookList[bookIndex - 1];
    }

    public Library()
    {
      Books = new List<Book>();
      CheckedOut = new List<Book>();
    }
  }
}