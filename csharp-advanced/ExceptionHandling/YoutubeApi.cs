using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class YoutubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access youtube web service
                // read the data
                // create a list of Video objects\
                throw new Exception("Oops some low level youtube error");
            }
            catch (Exception ex)
            {
                throw new YoutubeException("Cannot fetch the videos from youtube", ex);
            }

            return new List<Video>();
        }
    }
}
