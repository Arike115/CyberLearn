using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] evennumbers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 8, 19, 11,2,4,12,16 };
            int[] oddnumbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 18, 2, 12 };
            // string[] words = {"words","all","come","those" };

            //union
            var allnumbers = evennumbers.Union(oddnumbers)
                                        .OrderBy(x => x);

            var numbers = evennumbers.Where(x => x > 10)
                                     .Union(evennumbers.Where(x => x < 10));
            foreach (var i in allnumbers)
            {
                Console.WriteLine(i);

            }

            //intersect
            var queuenumber = evennumbers.Intersect(oddnumbers)
                                         .OrderBy(x => x);
            foreach (var i in queuenumber)
            {
                Console.WriteLine($"intersect::{i}");

            }
            //except
            var exceptnumber = oddnumbers.Except(evennumbers);
            foreach (var i in exceptnumber)
            {
                Console.WriteLine(i);
            }
            //Distict

            var distinctnumber = oddnumbers.Distinct();
            foreach (var i in distinctnumber)
            {
                Console.WriteLine(i);
            }


        }
    }
}
