using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/Даша/Автоматизация BIM/Task 8/text.txt";
            int N = 0;
            int sum = 0;
            string stroka = "";
            int count=0;
            StreamReader sr = new StreamReader(path);
            do
            {
                
                N++;
                sum += stroka.Length;
                string[] stringArray = stroka.Split();
                stroka = sr.ReadLine();
                foreach (string word in stringArray)
                        count++;

            }
            while (stroka != null);
            
            Console.WriteLine("Количество строк = {0}", N-1);
            Console.WriteLine("Количество символов = {0}", sum);
            Console.WriteLine("Количество слов = {0}", count);
            Console.ReadKey();

        }
    }
}
