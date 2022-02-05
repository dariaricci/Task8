using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/Даша/Автоматизация BIM/Task 8/Числа.txt";
            StreamWriter sw = new StreamWriter(path);
            Random random = new Random();
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine(random.Next(0,20));
            }
            sw.Close();
            StreamReader sr = new StreamReader(path);

            for (int i = 0; i < 10; i++)
            {
                sum += Convert.ToInt32(sr.ReadLine());
            }  
            
            Console.WriteLine(sum);
            Console.ReadKey();


            
            
        }
    }
}
