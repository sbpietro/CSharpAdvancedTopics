using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvancedTopics.Events
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Sending text message..." + e.Video.Title);
        }
    }
}
