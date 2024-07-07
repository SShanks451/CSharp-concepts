namespace ExceptionHandling
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
            try
            {
                using (var streamReader = new StreamReader(@"c:\file.zip"))
                {
                    var content = streamReader.ReadToEnd();
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Soory, an exception occured");
            }
            */

            // ----------------------------------------------------------------------------------------------

            try
            {
                var api = new YoutubeApi();
                var videos = api.GetVideos("mosh");    
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}