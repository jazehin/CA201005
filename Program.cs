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

            //EGYMÁSBA ÁGYAZOTT CIKLUSOK

            //faktorialis
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                faktor = 1;
                for (int j = 2; j <= i; j++)
                {
                    faktor *= i;
                }
                Console.WriteLine($"{i} faktoriálisa {faktor}");
            }

            Console.ReadKey();
            Console.Clear();

            //primek
            Console.WriteLine("Prímek 500 alatt:");
            for (int i = 2; i < 500; i++)
            {
                int osztok = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0) osztok++;
                }
                if (osztok == 2) Console.WriteLine(i);
            }

            Console.ReadKey();
            Console.Clear();

            //szamok
            //a
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }

            //b
            Console.WriteLine("\n");
            for (int i = 9; i > 0; i--)
            {
                for (int j = 9 - i; j > 0; j--)
                {
                    Console.Write("  ");
                }
                for (int j = i; j >= 1; j--)
                {
                    
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.Clear();

            //vakáció
            string output = "VAKÁCIÓ";
            //a
            for (int i = 0; i < output.Length; i++)
            {
                for (int j = i; j < output.Length; j++)
                {
                    Console.Write($"{output[j]} ");
                }
                Console.WriteLine();
            }

            //b
            Console.WriteLine("\n");
            for (int i = output.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = output.Length - i - 1; j >= 0; j--)
                {
                    Console.Write($"{output[Math.Abs(j - output.Length + 1)]} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.Clear();

            //szorzotabla
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.SetCursorPosition((j - 1) * 4, i - 1);
                    Console.Write(i * j);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.Clear();

            /*
            Változó i, j:Egész
            Ciklus i:= 2 - től 0 - ig 1 lépésközzel
                Ciklus j:= 0 - tól 2 - ig 1 lépésközzel
                    Ha i = j akkor
                        Ki(1)
                    különben
                        Ki(0)
                    Elágazás vége
                Ciklus vége
                Ki(soremelés)
            Ciklus vége
            */

            for (int i = 2; i >= 0; i--)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (i == j) Console.Write("1");
                    else Console.Write("0");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.Clear();

            //35: c)

            //összesített feladat

            Console.WriteLine("Alapműveletek gyakorlása\n\n1. Összeadás\n2. Kivonás\n3. Szorzás\n4. Osztás\n");
            Console.Write("Válasszon menüpontot (1-4): ");
            input = Convert.ToInt32(Console.ReadLine());
            int helyes = 0;
            switch(input)
            {
                case 1:
                    for (int i = 0; i < 10; i++)
                    {
                        int a = rnd.Next(1, 51);
                        int b = rnd.Next(1, 51);
                        Console.Write($"{i + 1}. {a} + {b} = ");
                        int eredm = Convert.ToInt32(Console.ReadLine());
                        if (eredm == a + b)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Helyes :)");
                            helyes++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Helytelen :(");
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
                case 2:
                    for (int i = 0; i < 10; i++)
                    {
                        int a = rnd.Next(1, 51);
                        while (a == 50)
                        {
                            a = rnd.Next(1, 51);
                        }
                        int b = rnd.Next(1, 51);
                        while (b > a)
                        {
                            b = rnd.Next(1, 51);
                        }
                        Console.Write($"{i + 1}. {a} - {b} = ");
                        int eredm = Convert.ToInt32(Console.ReadLine());
                        if (eredm == a - b)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Helyes :)");
                            helyes++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Helytelen :(");
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
                case 3:
                    for (int i = 0; i < 10; i++)
                    {
                        int a = rnd.Next(2, 11);
                        int b = rnd.Next(2, 11);
                        Console.Write($"{i + 1}. {a} * {b} = ");
                        int eredm = Convert.ToInt32(Console.ReadLine());
                        if (eredm == a * b)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Helyes :)");
                            helyes++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Helytelen :(");
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
                case 4:
                    for (int i = 0; i < 10; i++)
                    {
                        int a = rnd.Next(2, 101);
                        int b = rnd.Next(2, 101);
                        while (a % b != 0) {
                            a = rnd.Next(2, 101);
                            b = rnd.Next(2, 101);
                        }
                        Console.Write($"{i + 1}. {a} / {b} = ");
                        int eredm = Convert.ToInt32(Console.ReadLine());
                        if (eredm == a / b)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Helyes :)");
                            helyes++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Helytelen :(");
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
            Console.Write($"\nAz eredmény: 10/{helyes} - ");
            switch (helyes)
            {
                case 10:
                    Console.WriteLine("Kitűnő");
                    break;
                case 9:
                    Console.WriteLine("Nagyon jó");
                    break;
                case 8:
                    Console.WriteLine("Jó");
                    break;
                case 7:
                    Console.WriteLine("Közepes");
                    break;
                case 6:
                    Console.WriteLine("Fejlődőképes");
                    break;
                default:
                    Console.WriteLine("Neked készült ez a program!");
                    break;
            }







            Console.ReadKey();
        }
    }
}
