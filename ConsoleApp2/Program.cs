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
            var value = student.getstudent();
            int[] evennumbers = {};
            int[] oddnumbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 18, 2, 12 };
            string[] words = { };
            
            //element operators

            //First or FirstOrDefault
            var numbers = words.FirstOrDefault();
            Console.WriteLine(numbers);
            //Last or lastordefault
            var allodds = evennumbers.LastOrDefault();
            Console.WriteLine(allodds);
            //single or single or default
            var all = oddnumbers.SingleOrDefault(x => x == 3);
             Console.WriteLine(all);
            //Console.WriteLine(all);

            
           
            

            

        }
       

    }
    public class student
    {
        public string name { get; set; }
        public string places { get; set; }

        public static List<student> getstudent()
        {
            return new List<student>();
            {
                new student { name = "john", places = "Lagos" };
                new student { name = "Edward", places = "Ibadan" };
            }
        }
    }
}
