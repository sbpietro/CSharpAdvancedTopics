using CSharpAdvancedTopics.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvancedTopics.LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book(){Title = "Title 1", Price = 5},
                new Book(){Title = "Title 2", Price = 8},
                new Book(){Title = "Title 3", Price = 15},
                new Book(){Title = "Title 4", Price = 16.99f},
                new Book(){Title = "Title 5", Price = 5.99f},
                new Book(){Title = "Title 6", Price = 6.99f},
                new Book(){Title = "Title 7", Price = 12.99f}
            };
        }
    }
}
