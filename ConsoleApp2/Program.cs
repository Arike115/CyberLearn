using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public  class Program
    {
        //Task.Run
        public static void Main(string[] args)
        {
           var total = calculator.Add(50, 50);
            Console.WriteLine(total);
            var subtotal = calculator.Add(new List<int>{ 5,6,7,8,4,6,78,3,5,2,300});
            Console.WriteLine(subtotal);

        }

    }

    
    public class calculator
    {
        [Obsolete("use :Add(List<int> numbers) method ")]
        public static int Add(int firstnumber, int secondnumber)
        {
            Console.WriteLine("method outdated"); 
            return firstnumber + secondnumber;
           
        }

        public static int Add(List<int> numbers)
        {
            Console.WriteLine("new method");
            int result = 0;
            foreach(var number in numbers)
            {
                result = result + number;
            }
            return result;
        }
    }


}
