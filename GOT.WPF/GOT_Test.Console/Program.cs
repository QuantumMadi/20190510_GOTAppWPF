using GOT.Models;
using GOT.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOT_Test.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> characters = GetDataService.GetListOfCharacters();
            System.Console.WriteLine(characters[0].Name);
        }
    }
}
