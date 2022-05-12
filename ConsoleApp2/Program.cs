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
        
        public static void Main(string[] args)
        {
            //Directoryinfo
            DirectoryInfo dir = new DirectoryInfo(".");
            DirectoryInfo direc = new DirectoryInfo(@"C:\Program Files");
            Console.WriteLine(direc.Name);
            Console.WriteLine(direc.FullName);
            Console.WriteLine(direc.Parent);
            Console.WriteLine(direc.CreationTime);
            Console.WriteLine(dir.Name);

            //File

            string[] words = { "this is a ball", "this is a house", "set to chalk", "mice" };
            string path = @"C:\testingFile.txt";

            File.WriteAllLines(path, words);

            foreach(var word in File.ReadLines(path))
            {
                Console.WriteLine(word);
            }

            //fileinfo

            //DirectoryInfo dit = new DirectoryInfo(@"Documents");

            //FileInfo[] textfile = dit.GetFiles("*.txt", SearchOption.AllDirectories);
            //Console.WriteLine("matches:{0}", textfile.Length);

            //foreach (FileInfo file in textfile)
            //{
            //    Console.WriteLine(file.FullName);
            //    Console.WriteLine(file.CreationTime);

            //}
            Writeforall();
            Readforall();

            //filestream write
            string path3 = @"C:\testingFile.txt";
            FileStream fs = File.Open(path3, FileMode.OpenOrCreate);
          //or  var fx = new FileStream(path3, FileMode.Open);
            string neword = "this is a brand new car";

             byte[] bytlist = Encoding.Default.GetBytes(neword);
            fs.Write(bytlist, 0, bytlist.Length);
            fs.Position = 0;

            byte[] filelist = new byte[bytlist.Length];
            for(int i = 0; i < bytlist.Length; i++)
            {
                filelist[i] = (byte)fs.ReadByte();
            }
            Console.WriteLine(Encoding.Default.GetString(filelist));
            fs.Close();

        }

        //streamwriter
        public static void Writeforall()
        {
            StreamWriter sw = new StreamWriter(@"C:\testingFile.txt");
            sw.WriteLine("welcome to cyberspace");
            sw.WriteLine("pleasure to meet you");
            sw.Close();
        }

        public static void Readforall()
        {
            StreamReader sr = new StreamReader(@"C:\testingFile.txt");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
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
