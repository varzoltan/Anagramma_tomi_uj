using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Anagramma_tomi_uj
{
    /*public class szotar
    {
        public string szo { get; private set; }

        public szotar(string sor)//konstruktor
        {
            szo = sor;
        }
    }*/
    class Program
    {
        struct Adat
        {
            public string szo;
        }

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

            //2.feladat
            Adat[] adatok = new Adat[300];
            StreamReader olvas = new StreamReader(@"C:\Users\Rendszergazda\Desktop\2010-okt-Anagramma\szotar.txt");
            int n = 0;
            while (!olvas.EndOfStream)
            {
                adatok[n].szo = olvas.ReadLine();
                n++;
            }
            olvas.Close();
            /*List<szotar> adatok = new List<szotar>();//példányosítom a listát
            //Beolvasás
            foreach (string i in File.ReadAllLines(@"C:\Users\Rendszergazda\Desktop\2010-okt-Anagramma\szotar.txt"))
            {
                adatok.Add(new szotar(i));
            }*/

            //3.feladat
            string szo = "valami";
            Console.WriteLine(abc(szo));
            Console.ReadKey();
        }

        //függvény
        static string abc(string szo)
        {
            char[] szoszo = szo.ToCharArray();
            Array.Sort(szoszo);
            string rendezett = null;
            for (int i = 0;i<szoszo.Length;i++)
            {
                rendezett = rendezett + szoszo[i];
            }
            return rendezett;
        }
    }
}
