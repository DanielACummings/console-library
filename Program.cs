using System;
using consoleLibrary.Models;

namespace consoleLibrary
{
  class Program
  {
    static void Main(string[] args)
    {
      //library setup
      var libr = new Library();

      var theHobbit = new Book("The Hobbit", "J.R.R. Tolkien");
      var princeCaspian = new Book("Prince Caspian", "C.S. Lewis");
      var theHungerGames = new Book("The Hunger Games", "Suzanne Collins");

      libr.AddBook(theHobbit);
      libr.AddBook(princeCaspian);
      libr.AddBook(theHungerGames);

      //main app
      bool inLibrary = true;
      while (inLibrary)
      {
        libr.PrintBooks();
        string selection = Console.ReadLine();
        libr.Quit(selection);
        libr.Checkout(selection);
      }
    }
  }
}
