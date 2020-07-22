using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpAdvancedTopics.Extension_Methods
{
    public static class StringExtensions
    {
        public static string Shorten(this string post, int wordCount)
        {
            if (wordCount < 0)
                throw new ArgumentOutOfRangeException("Wrong word count");

            if (wordCount == 0)
                return "";

            var words = post.Split(' ');
            if (words.Length <= wordCount)
                return post;

            return string.Join(" ", words.Take(wordCount));
        }
    }
}
