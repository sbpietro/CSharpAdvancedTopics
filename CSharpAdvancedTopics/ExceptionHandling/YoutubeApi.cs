using CSharpAdvancedTopics.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvancedTopics.ExceptionHandling
{
	public class YoutubeApi
    {
        public List<Video> GetVideos(string user)
        {
			try
			{
				//fetch logic
				throw new Exception("Some low level error");
			}
			catch (Exception ex)
			{
				//log
				throw new YoutubeException("Could not fetch video from youtube", ex);
			}

			return new List<Video>();
        }
    }
}
