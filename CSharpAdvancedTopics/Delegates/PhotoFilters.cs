using System;

namespace CSharpAdvancedTopics
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Contrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resized");
        }

    }
}