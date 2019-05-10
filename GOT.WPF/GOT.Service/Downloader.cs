using GOT.Service.Abstract;
using System.Net;

namespace GOT.Service
{
    public class Downloader : IDownloader
    {
        public string DataJsonFormat(string url)
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
