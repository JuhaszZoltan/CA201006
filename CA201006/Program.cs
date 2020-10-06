using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CA201006
{
    class Program
    {
        static void Main(string[] args)
        {
            //eljárás
            Console.WriteLine();
            //függvény
            //string hw = Console.ReadLine();
            Ugat();
            Ugat();
            Ugat();
            var nap = MilyenNapVanMa();
            Console.WriteLine(nap);
            Ugat();
            Ugat();
            Ugat();
            Console.WriteLine("hello world!");
            var kerek = Math.Pow(2, 10);
            Console.WriteLine(kerek);
            Koszon("Zoli");
            var sum = Osszead(10, 20);
            Console.WriteLine(sum);
            Sokszor(10, "krumpli");
            int n = 10;
            string szoTag = "tu";
            string tu = SokSzotag(n, szoTag);
            Console.WriteLine(tu);
            sum = Osszead(20, 30, 4);
            sum = Osszead(new int[] { 30, 40, 40, 40, 4, 40, 40, 40});
            sum = Osszead(40, 40, 40, 40, 40, 5);
            sum = Osszead(40);

            int x = 10;
            Valtoztat(ref x);
            Console.WriteLine(x);

            int y = 400000;
            Kimeno(out y);
            Console.WriteLine(y);


            //pl.:

            int[] tomb = { 30, 10, 40, 0, 12 };
            Array.Resize(ref tomb, 10);
            Console.WriteLine(tomb.Length);

            Console.Write("irj be egy szamot: ");
            string szoveg = Console.ReadLine();
            //int z;
            bool sikerult = int.TryParse(szoveg, out int z);
            Console.WriteLine(z * 2);
            Console.ReadKey();
        }
        static void Valtoztat(ref int x)
        {
            x = 200;
        }

        static void Kimeno(out int y)
        {
            y = 200;
            y *= 2;
        }

        static string SokSzotag(int n, string szoTag)
        {
            string ret = "";
            for (int i = 0; i < n; i++)
            {
                ret += szoTag + "-";
            }
            ret = ret.TrimEnd('-');
            return ret;
        }
        static void Sokszor(int szam, string szoveg)
        {
            for (int i = 0; i < szam; i++)
            {
                Console.WriteLine(szoveg);
            }
        }
        static int Osszead(int x, int y)
        {
            return x + y;
        }
        static int Osszead(int x, int y, int z)
        {
            return x + y + z;
        }
        static int Osszead(params int[] t)
        {
            int sum = 0;
            foreach (var e in t)
            {
                sum += e;
            }
            return sum;
        }

        static void Ugat()
        {
            Console.WriteLine("vau-vau");
        }
        static string MilyenNapVanMa()
        {
            return DateTime.Now.DayOfWeek.ToString();
        }
        static void Koszon(string nev)
        {
            Console.WriteLine($"Szia {nev}!");
        }   
    }
}
