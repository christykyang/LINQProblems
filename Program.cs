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
            //problem 1
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> withTH = words.FindAll(w => w.Contains("th"));
            foreach (string word in withTH)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

            //problem 2
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            IEnumerable<string> distinctNames = names.Distinct();
            foreach(string name in distinctNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            //problem 3
            int intIndex;
            List<int> gradesInNumbers = new List<int>();
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };
            //gradesInNumbers = 
            //int[] grades = intIndex.Split()
            


        }

    }
}
