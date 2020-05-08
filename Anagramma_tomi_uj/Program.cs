using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagramma_tomi_uj
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.feladat
            Console.Write("Kérem adjon meg egy szöveget: ");
            string szoveg = Console.ReadLine();
            char[] rendez = szoveg.ToCharArray();
            Array.Sort(rendez);
            Console.WriteLine(rendez);
            int szamol = 1;
            for (int i = 1;i<rendez.Length;i++)
            {
                if (rendez[i-1] == rendez[i])
                {
                    szamol++;
                }
                else
                {                  
                    Console.WriteLine("{0}: {1}", rendez[i - 1], szamol);
                    szamol = 1;
                    if (i == rendez.Length -1)
                    {
                        Console.WriteLine("{0}: {1}", rendez[i], szamol);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
