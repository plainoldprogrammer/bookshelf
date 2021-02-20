using System;

namespace ef
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new DbBookshelfContext();

            var book = new Book
            {
                Title = "The C Programming Language",
                Author = "Dennis Ritchie and Brian Kernighan"
            };

            dbContext.Add<Book>(book);
            dbContext.SaveChanges();
        }
    }
}
