/* Un rappresentante di commercio guadagna un fisso mensile di lire 2000 euro più 100 euro per ogni enciclopedia venduta. 
 * Quanto guadagna al mese, sapendo che gli viene trattenuto il 18%?*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Commerciale
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Variabili
            double mesetot = 2000, enc, risultato1, risultato2, perc = 0.18, enctot;

            // Input
            Console.WriteLine("Inserisci il numero di enciclopedie che hai venduto: ");
            enc = double.Parse(Console.ReadLine());

            // Calcoli
            enctot = enc * 100;
            risultato1 = enctot + mesetot;
            risultato2 = risultato1 - (risultato1 * perc);

            // Output
            Console.WriteLine("Guadagni senza interessi: " + risultato1);
            Console.WriteLine("Guadagni con interessi dell'18%: " + risultato2);
        }
    }
}
