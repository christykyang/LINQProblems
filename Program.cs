using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> withTH = words.FindAll(w => w.Contains("th"));
            foreach (string word in withTH)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
    }
}
