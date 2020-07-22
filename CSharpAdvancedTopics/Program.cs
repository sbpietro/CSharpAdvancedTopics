using CSharpAdvancedTopics.Delegates;
using CSharpAdvancedTopics.Generics;
using CSharpAdvancedTopics.LambdaExpressions;
using System;
using System.Net.Http.Headers;

namespace CSharpAdvancedTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region GENERICS

            //var book = new Book { Isbn = "1111", Title = "C# Advanced Topics" };

            //var numbers = new GenericList<int>();
            //numbers.Add(10);

            //var books = new GenericList<Book>();
            //books.Add(book);

            //var dictionary = new GenericDictionary<string, Book>();
            //dictionary.Add("1234", book);


            //var number = new Generics.Nullable<int>(5);
            //Console.WriteLine("Has Value ?" + number.HasValue);
            //Console.WriteLine("Value: " + number.GetValueOrDefault());

            #endregion

            #region DELEGATES

            //var processor = new PhotoProcessor();
            //var filters = new PhotoFilters();
            //Action<Photo> filterHandler = filters.ApplyBrightness;
            //filterHandler += filters.ApplyContrast;
            //filterHandler += CustomFilter.ApplyRemoveRedEye;

            //processor.Process("path", filterHandler);

            #endregion

            #region LAMBDA EXPRESSIONS

            Func<int, int> Square = number => number * number;
            Console.WriteLine(Square(5));

            const int factor = 5;
            Func<int, int> Multiplier = n => n * factor;
            Console.WriteLine(Multiplier(10));

            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(b => b.Price < 10);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

            #endregion
        }
    }
}
