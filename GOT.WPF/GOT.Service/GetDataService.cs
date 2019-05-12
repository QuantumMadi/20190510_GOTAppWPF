using GOT.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;

namespace GOT.Service
{
    public static class GetDataService
    {
        public static List<Character> GetListOfCharacters()
        {
           return JsonConvert.DeserializeObject<List<Character>>(Downloader.DataJsonFormat(ConfigurationManager.AppSettings["urlString"]));
        }
        
    }
}
