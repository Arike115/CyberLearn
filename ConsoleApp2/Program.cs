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
            int[] evennumbers = { 2, 4,8};
            int[] oddnumbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 18, 2, 12 };
            // string[] words = {"words","all","come","those" };

            //Agregate Operators

            //sum

            var numbers = evennumbers.Where(x => x > 20)
                                      .Sum(x => x);
            Console.WriteLine(numbers);

            ////min
            var number = oddnumbers.Min(x => x);
            Console.WriteLine(number);

            ////max
            var num = evennumbers.Max(x => x);
            Console.WriteLine(num);

            ////average
            var avaragenum = oddnumbers.Average(x => x);
            Console.WriteLine(avaragenum);

            //Agregate
            var allsum = evennumbers.Aggregate((a,b) => a*b);
            Console.WriteLine(allsum);
        }
    }
}
