using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/Даша/Работа";

           string [] catalogues = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            foreach (string d in files)
                Console.WriteLine(d);
            Console.WriteLine();

            foreach (string s in catalogues)
            {

                Console.WriteLine(s);
                Console.WriteLine();
                string[] catalogues2 = Directory.GetFiles(s);
                foreach (string p in catalogues2)
                { 
                    Console.WriteLine(p); 
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
