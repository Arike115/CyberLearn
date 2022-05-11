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
            //Task[] t = new Task[2];
            // string[] files = null;
            // string[] dir = null;

            // string docdirectory = Environment.GetFolderPath(Environment.SpecialFolder.System);
            // t[0] = Task.Factory.StartNew(() => files = Directory.GetFiles(docdirectory));
            // t[1] = Task.Factory.StartNew(() => dir = Directory.GetDirectories(docdirectory));

            // Task.Factory.ContinueWhenAny(t, completedfile =>
            // {
            //     Console.WriteLine("{0}::Contains", docdirectory);
            //     Console.WriteLine("{0}::files", files.Length);
            //     Console.WriteLine("{0}::subdirectories", dir.Length);
            // });
            //Console.ReadKey();
            Console.Write("Enter path: ");
            
            string path = Console.ReadLine();
            if (path == null)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                if (Directory.Exists(path))
                {
                    Directory.Delete(path);
                    Console.WriteLine("Folder deleted");
                }
                else
                {
                    Console.WriteLine("Folder not found");
                }
            }

            
        }
        //public static void calculate()
        //{
        //    Task.Run(() =>
        //        calculate1()
        //    );
            
        //    Task.Run(() =>
        //        calculate2()
        //    );
        //   Task.Run(() =>
        //        calculate3()
        //   );

        //    Console.Read();
        //}


        //public static int calculate1()
        //{
        //    Thread.Sleep(3000);
        //    Console.WriteLine("caculation 1 in progress");
        //    return 500;
        //}
        //public static int calculate2()
        //{
        //    Thread.Sleep(2000);
        //    Console.WriteLine("caculation 2 in progress");
        //    return 2100;
        //}
        //public static int calculate3()
        //{
        //    Console.WriteLine("caculation 3 in progress");
        //    return 100;
        //}
        
    }
   
}
