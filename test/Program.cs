using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {


            /*StreamWriter writer = new StreamWriter("C:/кладовка/testzone/текст.txt",true);
            writer.WriteLine("");
            writer.WriteLine("send nudes 13");
            writer.Close();
            StreamReader reader = new StreamReader("C:/кладовка/testzone/текст.txt");
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
            
            Directory.CreateDirectory("C:/кладовка/testzone/fuku");
            Console.ReadLine();
            Directory.CreateDirectory("C:/кладовка/testzone/fuku/bic");
            Console.ReadLine();
            Directory.Delete("C:/кладовка/testzone/fuku",true);
            Console.ReadLine();
            */

            /*
            StreamWriter sw = new StreamWriter("C:/кладовка/testzone/1.txt", true);
            for (int i = 1; i<=500; i++)
            {
                if (i % 10 == 0)
                    sw.WriteLine(i+",");
                else
                    sw.Write(i + ","); ;
            }
            sw.Close();

            StreamReader sr = new StreamReader("C:/кладовка/testzone/1.txt");
            Console.Write(sr.ReadToEnd());
            sr.Close();*/

            // задиние 2 

            //File.Create("C:/кладовка/testzone/2.txt");
            string[] colors = {"red", "green", "black", "white", "blue"};

            StreamWriter swcol = new StreamWriter("C:/кладовка/testzone/2.txt");
            foreach (string color in colors)
            {
                swcol.WriteLine(color);
            }
            swcol.Close();

            StreamReader srcol = new StreamReader("C:/кладовка/testzone/2.txt");
            string col = "";
            int maxcol = 0;
            while (!srcol.EndOfStream)
            {
                col = srcol.ReadLine();
                if (col.Length > maxcol)
                    maxcol = col.Length;
                Console.WriteLine("строка: " + col + " Длина: " + col.Length);


            }

            Console.WriteLine("максимальная длина строки = "+maxcol);
            Console.ReadKey();

            

        }
    }
}
