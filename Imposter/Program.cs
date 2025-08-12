using Reci;
using System;
using System.Threading;

namespace Imposter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            #region ConsoleColour
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            #endregion

            //Console.WriteLine(">>> Koliko igraca igra igru?");
            //string unosIgraca = Console.ReadLine();
            Reci.Reci reciDepo = new Reci.Reci();

            Console.WriteLine(">>> Koliko igraca igra?");
            string unosIgraci = Console.ReadLine();
            int brojIgraca = Int32.Parse(unosIgraci);

            Console.WriteLine(">>> Igra pocinje");
            Thread.Sleep(2000);
            Console.WriteLine(">>> ===============");

            bool igramo = false;
            while (!igramo)
            {
                
                string rec = reciDepo.VratiRandomRec();
                Random random = new Random();
                int imposter = random.Next(0, brojIgraca);

                for (int i = 0; i < brojIgraca; i++)
                {
                    string zadataRec;
                    if (i == imposter)
                    {
                        zadataRec = "imposter";
                    }
                    else
                    {
                        zadataRec = rec;
                    }

                    Console.WriteLine(">>> Rec za igraca " + (i+1) + " : ");

                    Cekanje();

                    Console.WriteLine(">>> Tvoja rec je: " + zadataRec);
                    Console.WriteLine("");
                    Console.WriteLine(">>> Pritisni Enter i reci sledecem da pogleda rec!");

                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                    }


                }

                Console.WriteLine(">>> Da li idalje zelite da igrate? Y | N");
                string unosIgranje = Console.ReadLine();
                if(unosIgranje == "N")
                {
                    igramo = true;
                }
                else
                {
                    igramo = false;
                }
            }
        }

        public static void Cekanje()
        {
            Thread.Sleep(1000);
            Console.WriteLine(5);
            Thread.Sleep(1000);
            Console.WriteLine(4);
            Thread.Sleep(1000);
            Console.WriteLine(3);
            Thread.Sleep(1000);
            Console.WriteLine(2);
            Thread.Sleep(1000);
            Console.WriteLine(1);
            Thread.Sleep(1000);
        }
    }
}
