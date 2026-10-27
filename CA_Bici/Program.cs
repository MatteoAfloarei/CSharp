/*Una bicicletta elettrica consuma 1 kWh ogni 25 km.*/
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Bici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prezzokwh, percorrere, spesa,energia;

            Console.WriteLine("Inserisci il prezzo dell'energia al kwh: ");
             prezzokwh = double.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci quanti km vuoi percorrere: ");
            percorrere = double.Parse(Console.ReadLine());

            energia = percorrere / 25;
            spesa = prezzokwh * energia;

            Console.WriteLine("Energia necessaria: " + energia);
            Console.WriteLine("Spesa necessaria: " + spesa);
        }
    }
}
