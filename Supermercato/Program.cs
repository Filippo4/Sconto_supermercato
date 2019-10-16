using System;

namespace Supermercato
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("inserisci l'importo della spesa");
            double importo = double.Parse(Console.ReadLine());
            if (importo > 100)
            {
                double sconto = importo / 100 * 20;
                double importo_finale = importo - sconto;
                Console.WriteLine($"hai diritto ad uno sconto,l'importo scontato è {importo_finale}");
            }
            else
                Console.WriteLine($"non è applicabile lo sconto,l'importo da pagare è {importo}");
                Console.ReadLine();
            
        }
    }
}
