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
            /*char[] rendez = szoveg.ToCharArray();
            Array.Sort(rendez);
            Console.WriteLine(rendez);
            int szamol = 1;
            for (int i = 1;i<rendez.Length;i++)
            {
                if (rendez[i-1] == rendez[i])
                {
                    szamol++;
                    if (i == rendez.Length - 1)
                    {
                        Console.WriteLine("{0}: {1}", rendez[i], szamol);
                    }
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
            }*/
            //1.feladat másképp
            for (int i = 'a'; i <= 'z'; i++)
            {
                int szamol = 0;
                for (int j = 0; j < szoveg.Length; j++)
                {
                    if (i == szoveg[j])
                    {
                        szamol++;
                    }
                }
                if (szamol != 0)
                {
                    Console.WriteLine("{0}: {1}", Convert.ToChar(i), szamol);
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
            StreamWriter ir = new StreamWriter("abc.txt");
            foreach (var sor in adatok)
            {
                if (sor.szo != null)
                {
                    ir.WriteLine(abc(sor.szo));
                }
            }
            /*string szo = "valami";
            Console.WriteLine(abc(szo));*/
            ir.Close();

            //4.feladat
            Console.Write("Kérem adjon meg egy szót: ");
            char[] kar1 = Console.ReadLine().ToCharArray();
            Array.Sort(kar1);
            Console.Write("Kérem adjon meg egy másik szót: ");
            char[] kar2 = Console.ReadLine().ToCharArray();
            Array.Sort(kar2);
            if (kar1.Length == kar2.Length)
            {
                bool igaz = false;
                for (int i = 0; i < kar1.Length; i++)
                {
                    if (kar1[i] != kar2[i])
                    {
                        igaz = true;
                        Console.WriteLine("Nem anagramma");
                        break;
                    }
                }
                if (!igaz)
                {
                    Console.WriteLine("Anagramma");
                }
            }
            else
            {
                Console.WriteLine("Nem anagramma.");
            }

            //5.feladat
            Console.Write("Kérem adjon meg egy szót a szótár.txt állományból: ");
            string szo = Console.ReadLine();
            char[] ujszo = abc(szo).ToCharArray();
            bool ugrik = false;
            bool nincs = false;
            for (int i = 0; i < n; i++)
            {
                string sor = adatok[i].szo;
                char[] ujsor = abc(sor).ToCharArray();
                if (ujszo.Length == sor.Length)
                {
                    ugrik = false;
                    for (int j = 0; j < sor.Length; j++)
                    {
                        if (ujszo[j] != ujsor[j])
                        {
                            ugrik = true;
                            break;
                        }
                    }
                    if (!ugrik)
                    {
                        Console.WriteLine(sor);
                        nincs = true;
                    }
                }
            }
            if (!nincs)
            {
                Console.WriteLine("Nincs a szótárban anagramma");
            }

            //6.feladat
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                if (max < adatok[i].szo.Length)
                {
                    max = adatok[i].szo.Length;
                }
            }

            string[] tomb = { "ser", "der", "res", "sor", "ers", "bor", "sre" };
            /*int k = 0;
            for (int i = 0; i < n; i++)
            {
                
                if (max == adatok[i].szo.Length)
                {
                    tomb[k] = adatok[i].szo;
                    k++;
                }
            }*/

            for (int i = 0; i < 6; i++)
            {
                //bool igaz = false;
                int valami = 0;
                int valami1 = 0;
                for (int j = i + 1; j < 7; j++)
                {
                    if (abc(tomb[i]) == abc(tomb[j]) && valami1 == 0)
                    {
                        Console.WriteLine(tomb[i]);
                        Console.WriteLine(tomb[j]);
                        //igaz = true;
                        valami++;
                        valami1++;
                    }
                    else if (abc(tomb[i]) == abc(tomb[j]) && valami1 < 1)
                    {
                        Console.WriteLine(tomb[j]);
                    }
                    if (valami == 0)
                    {

                        Console.WriteLine(tomb[i]);
                    }
                }
                Console.ReadKey();
            }

            
        }
        //függvény
        static string abc(string szo)
        {
            char[] szoszo = szo.ToCharArray();
            Array.Sort(szoszo);
            string rendezett = null;
            for (int i = 0; i < szoszo.Length; i++)
            {
                rendezett = rendezett + szoszo[i];
            }
            return rendezett;
        }
    }
}
