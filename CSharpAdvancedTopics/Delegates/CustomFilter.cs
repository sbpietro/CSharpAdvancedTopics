using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvancedTopics.Delegates
{
    public class CustomFilter
    {
        public static void ApplyRemoveRedEye(Photo photo)
        {
            Console.WriteLine("Removed red eye");
        }
    }
}
