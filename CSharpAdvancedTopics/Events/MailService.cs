using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvancedTopics.Events
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Sending email..." + e.Video.Title);
        }
    }
}
