using CSharpAdvancedTopics.Delegates;
using CSharpAdvancedTopics.Events;
using CSharpAdvancedTopics.ExceptionHandling;
using CSharpAdvancedTopics.Extension_Methods;
using CSharpAdvancedTopics.Generics;
using CSharpAdvancedTopics.LambdaExpressions;
using System;
using System.IO;
using System.Linq;
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

            //Func<int, int> Square = number => number * number;
            //Console.WriteLine(Square(5));

            //const int factor = 5;
            //Func<int, int> Multiplier = n => n * factor;
            //Console.WriteLine(Multiplier(10));

            //var books = new BookRepository().GetBooks();
            //var cheapBooks = books.FindAll(b => b.Price < 10);
            //foreach (var book in cheapBooks)
            //{
            //    Console.WriteLine(book.Title);
            //}

            #endregion

            #region EVENTS

            //var video = new Video() { Title = "Video 1" };
            //var videoEncoder = new VideoEncoder(); //publisher
            //var mailService = new MailService(); //subscriber
            //var messageService = new MessageService(); //subscriber

            //videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            //videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            //videoEncoder.Encode(video);

            #endregion

            #region EXTENSION METHODS

            //var post = "This is supposed to be a very long blog post bla bla bla bla bla bla...";
            //var shortenedPost = post.Shorten(5);

            //Console.WriteLine(shortenedPost);

            #endregion

            #region LINQ

            //var books = new BookRepository().GetBooks();

            ////linq query operators
            //var cheaperBooks = from b in books
            //                   where b.Price < 10
            //                   orderby b.Title
            //                   select b.Title;

            ////linq Extension methods
            //var cheapBooks = books
            //                    .Where(b => b.Price < 10)
            //                    .OrderBy(b => b.Title)
            //                    .Select(b => b.Title);

            //var singleBook = books.SingleOrDefault(b => b.Title.Equals("Title 1"));
            //Console.WriteLine(singleBook.Title);

            //var skippedBooks = books.Skip(2).Take(3);

            //foreach (var book in skippedBooks)
            //{
            //    Console.WriteLine(book.Title);
            //}

            //var count = books.Count;
            //Console.WriteLine(count);

            //var max = books.Max(b => b.Price);
            //var min = books.Min(b => b.Price);

            //Console.WriteLine(max);
            //Console.WriteLine(min);

            #endregion

            #region NULLABLE TYPES

            //DateTime? date = null;

            //Console.WriteLine("Value or default " + date.GetValueOrDefault());
            //Console.WriteLine("date has value " + date.HasValue);
            //Console.WriteLine("date " + date.Value);

            //DateTime? date = new DateTime(2014, 1, 1);
            //DateTime date2 = date.GetValueOrDefault();

            //Console.WriteLine(date2);

            //DateTime? date = null;
            //DateTime date2 = date ?? DateTime.Today;

            //DateTime date3 = date != null ? date.GetValueOrDefault() : DateTime.Today;

            //Console.WriteLine(date2);

            #endregion

            #region DYNAMICS

            //object obj = "Stefano";
            //var methodInfo = obj.GetType().GetMethod("GetHashCode");
            //methodInfo.Invoke(null, null);

            //dynamic excel = "stefano";
            //excel.Optimize();

            //dynamic name = "stefano";
            ////name = 10;
            //name++;

            //int i = 5;
            //dynamic d = i;

            #endregion

            #region EXCEPTION HANDLING

            //try
            //{
            //    var calculator = new Calculator();
            //    var result = calculator.Divide(5, 0);
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine("You cannot divide by zero");
            //}
            //catch(ArithmeticException ex)
            //{

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Unexpected error occurred");
            //}

            //try
            //{
            //    using (var streamReader = new StreamReader(@"c://file.zip"))
            //    {
            //        var content = streamReader.ReadToEnd();
            //    }


            //    throw new Exception("Oops");
            //}
            //catch(FileNotFoundException ex)
            //{
            //    Console.WriteLine("File not found");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Unexpected error occurred");
            //}

            //try
            //{
            //    var api = new YoutubeApi();
            //    var videos = api.GetVideos("stefano");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            #region ASYNC PROGRAMMING

            //synchronous


            #endregion
        }
    }
}
