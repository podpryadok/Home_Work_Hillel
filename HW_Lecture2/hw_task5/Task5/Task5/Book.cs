using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    class Book
    {
        public string Title;
        public string Author;
        public string Content;

        public Book(string t, string a, string c)
        {
            Title = t;
            Author = a;
            Content = c;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Title);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Author);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ResetColor();
        }
    }
}
