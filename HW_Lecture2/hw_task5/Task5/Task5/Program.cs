using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Title title1 = new Title("titel 111");
            Author author1 = new Author("author 111");
            Content content1 = new Content("content 111");

            Book book1 = new Book(title1.title, author1.author, content1.content);

            book1.Show();

            Console.ReadLine();
        }
    }
}
