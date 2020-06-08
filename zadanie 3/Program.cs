using System;
using System.Text;
using System.Collections.Generic;
namespace zadanie3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1.");
            int[] ki = new int[] { -20, 1, -5, 9, 4, -18, 6, 74 };
            int min = 100;
            int ho = 0;
            for (int won = 0; won < 8; won++)
            {
                if (Math.Abs(ki[won]) < min) min = Math.Abs(ki[won]); ho = won;

            }
            Console.WriteLine("Номер элемента: " + ho);

            Console.WriteLine("\n" + "Задание №2." + "\n");


            int[] meow = new int[] { 1, -4, 8, 1, 6, 8, 3, -4, 2, 5 };
            int oww = 0;
            for (int wo = 0; wo < 10; wo++) Console.Write(meow[wo] + " ");

            Console.WriteLine();
            for (int wo = 0; wo < 10; wo++)
            {
                oww = 1;
                for (int wow = 0; wow < 10; wow++) if (meow[wo] == meow[wow] && wo != wow) oww = 2; if (oww == 1) Console.Write(meow[wo] + " ");

            }
            Console.WriteLine("\n" + "Задание №3.");
            Random rnd = new Random();
            int[] mr = { -3, 6, 4, 2, 8, 50, -1, 5, 9 };
            int[] plpl = new int[mr.Length];
            int hehe = 0, kkkk = 0;
            for (int bla = 0; bla < plpl.Length; bla++)
            {
                plpl[bla] = rnd.Next(-100, 100);
                Console.Write(plpl[bla] + "\t");
                if (plpl[bla] > 0) hehe++;
            }
            Console.WriteLine();
            int[] meoww = new int[hehe];
            for (int bla = 0; bla < plpl.Length; bla++)
            {
                if (plpl[bla] > 0) meoww[kkkk] = plpl[bla]; kkkk++;
            }

            for (int bla = 0; bla < meoww.Length; bla++) { Console.Write(meoww[bla] + "\t"); }
        }
    }
}            

    