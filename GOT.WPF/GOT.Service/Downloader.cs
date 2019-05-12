using System.Net;

namespace GOT.Service
{
    public static class Downloader 
    {
        public static string DataJsonFormat(string url)
        {
            using (var client = new WebClient())
            {
                try
                {
                    return client.DownloadString(url);
                }
                catch (WebException exception)
                {                  
                    return exception.Message;
                }
            }
        }
    }
}
