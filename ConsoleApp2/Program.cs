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
            int[] evennumbers = { };
            int[] oddnumbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 20, 18, 2, 12 };
            int[] onenumbers = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            string[] words = { "chalk", "pencil", "marker" };

            //Quantifiers
            //any
            var numbers = oddnumbers.Any(x => x == 9);
            Console.WriteLine(numbers);

            var keyword = words.Any(x => x == "MARKER" || x == "marker");
            Console.WriteLine(keyword);

            //all
            var newnumbers = onenumbers.All(x => x == 1);
            Console.WriteLine(newnumbers);



            //selectmany

            var items = value.SelectMany(x => x.courses,
                                 (studentname, dept) => new
                                 {
                                     newstudentname = studentname.name,
                                     studentplaces = studentname.places,
                                     Course = dept
                                 });

            

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Course} : {item.newstudentname} : {item.studentplaces}");




            }
            Console.WriteLine("--------------------");

            //conversion from list to dictionary
           var product = value.ToDictionary(s => s.name);

            foreach(var pro in product.Keys)
            {
                Console.WriteLine("key:{0} ===> value:{1}", pro, product[pro].name);
            }

        }
    }
    public class student
    {
        public string name { get; set; }
        public string places { get; set; }
        public List<string> courses { get; set; }
        public int Id { get; set; } 


        public static List<student> getstudent()
        {
            return new List<student>
            {
                new student {Id = 1, name = "john", places = "Lagos", courses = new List<string>(){"bio101", "gst103", "mat 105" } },
                new student {Id = 2,  name = "Edward", places = "Ibadan", courses = new List<string>(){"chem104", "bio101", "bam106" } },
                new student {Id = 3, name = "Ali", places = "Jos", courses = new List<string>(){"chem104", "bio101", "bam106" } }
            };
        }
        
    }
}
