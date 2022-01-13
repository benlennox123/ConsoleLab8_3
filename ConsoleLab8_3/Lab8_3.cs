using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleLab8_3
{
    class Lab8_3
    {
        static void Main(string[] args)
        {
            string path = @"Test\Test1.txt";
            int quantity_symbol = 0;
            //int quantity_line1 = 0;
            int quantity_line2 = 0;
            int quantity_word = 0;
            string text = "";
            using (StreamReader sr = new StreamReader(path))
            {
                text = sr.ReadToEnd();
            }
            /*
            // строки: не считает начало пустой строки без новой строки
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.ReadLine() != null)
                {
                    quantity_line1++;
                }
            }
            */
            // строки выводимые
            string[] Massiv2 = text.Split('\n');
            foreach (string s in Massiv2)
            {
                quantity_line2++;
            }
            // слова
            Console.WriteLine(text);
            Console.WriteLine("--------------------------");
            string[] Massiv1 = text.Split(/*' ', '\n', '\t', '-', '\r'*/);
            foreach (string s in Massiv1)
            {
                //Console.WriteLine(s);
                if (s != "")
                {
                    quantity_word++;
                    //Console.WriteLine(s);
                }
            }
            Console.WriteLine("===========================");
            // символы, включая ESCAPE-последовательности
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.Read() != -1)
                {
                    quantity_symbol++;
                }
            }
            //Console.WriteLine("Количество фактических строк в файле = {0}", quantity_line1);
            Console.WriteLine("Количество выводимых строк в файле = {0}", quantity_line2);
            Console.WriteLine("Количество слов в файле = {0}", quantity_word);
            Console.WriteLine("Количество символов в файле = {0}", quantity_symbol);
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
