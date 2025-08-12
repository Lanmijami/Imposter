using Reci;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Reci.Reci reciKlasa = new Reci.Reci();
            

            int i = 0;

            try
            {
                while (i < 75)
                {
                    string rec = reciKlasa.VratiRandomRec();
                    Console.WriteLine(rec);


                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            
        }
    }
}
