using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201005
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //armstrong
            Console.WriteLine("Az Armstrong-számok:");

            for (int i = 100; i < 1000; i++)
            {
                int tmp = i;
                int sz = tmp / 100;
                tmp -= sz * 100;
                int t = tmp / 10;
                tmp -= t * 10;
                if (Math.Pow(sz, 3) + Math.Pow(t, 3) + Math.Pow(tmp, 3) == i) Console.WriteLine(i);
            }

            //faktor
            Console.Write("\nAdjon meg egy számot: ");
            int input = Convert.ToInt32(Console.ReadLine());
            double faktor = 1;
            for (int i = 2; i <= input; i++)
            {
                faktor *= i;
            }
            Console.WriteLine($"A faktoriálisa {faktor}");

            //6dobas
            int hatos = 0;
            for (int i = 0; i < 100; i++)
            {
                if (rnd.Next(1, 7) == 6) hatos++;
            }
            Console.WriteLine($"\n{hatos} hatost dobtam.");

            //dobasosszeg10
            int tizenketto = 0;
            for (int i = 0; i < 20; i++)
            {
                if (rnd.Next(1, 7) + rnd.Next(1, 7) == 12) tizenketto++;
            }
            Console.WriteLine($"{tizenketto}-szer/szor dobtam tizenkettőt.");

            //sorosszeg
            int sor = 0;
            for (int i = 1; i <= 100; i++)
            {
                sor += i;
            }
            Console.WriteLine($"\nAz első 100 term szám összege {sor}.");

            //dobasosszeg
            int s = 0;
            for (int i = 0; i < 100; i++)
            {
                s += rnd.Next(1, 7);
            }
            Console.WriteLine($"\nA dobások összege {s}.");

            //szoveg_forditva
            Console.Write("\nÍrjon be egy szöveget: ");
            string txt = Console.ReadLine();
            for (int i = txt.Length - 1; i >= 0; i--)
            {
                Console.Write(txt[i]);
            }

            //nev_atlosan
            Console.WriteLine("\n");
            string nev = "Kiss Bence";
            for (int i = 0; i < nev.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(nev[i]);
            }













            Console.ReadKey();
        }
    }
}
