using System;
using System.Collections.Generic;
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
            Console.WriteLine("calculation started");
            calculate();
        }
        public static void calculate()
        {
            Task.Run(() =>
                calculate1()
            );
            
            Task.Run(() =>
                calculate2()
            );
           Task.Run(() =>
                calculate3()
           );

            Console.Read();
        }


        public static int calculate1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("caculation 1 in progress");
            return 500;
        }
        public static int calculate2()
        {
            Thread.Sleep(2000);
            Console.WriteLine("caculation 2 in progress");
            return 2100;
        }
        public static int calculate3()
        {
            Console.WriteLine("caculation 3 in progress");
            return 100;
        }
        
    }
   
}
