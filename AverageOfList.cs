﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class AverageOfList
    {
        List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };
        public static void SplitFunction(List<string> classGrades)
        {
            var grades = classGrades[0].Split();
            for (int i = 0; i < classGrades.Count; i++)
            {
                //gradesInNumbers.Add(i);
                Console.WriteLine(classGrades[i]);
            }
            Console.ReadLine();

        }
        //public static void ConvertStringToInt()
        //{
        //    List<int> gradesAsInts;
        //    gradesAsInts = Convert.ToInt32(classGrades[i])
        //}
    }
}
