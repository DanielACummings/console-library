using System;
using consoleLibrary.Models;

namespace consoleLibrary
{
  class Program
  {
    static void Main(string[] args)
    {
      var libr = new library();

      Book theHobbit = new Book("The Hobbit", "JRR Tolkien");

      libr.AddBook(theHobbit);
    }
  }
}
