/*Scrivere un programma che, lette le misure dei lati di un triangolo,
 * visualizzi se il triangolo è equilatero, isoscele o scaleno*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Tipotriangolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lat1, lat2, lat3;

            Console.WriteLine("Inserisci la misura del lato 1: ");
            lat1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci la misura del lato 2: ");
            lat2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci la misura del lato 3: ");
            lat3 = int.Parse(Console.ReadLine());

            if (lat1 == lat2 && lat2 == lat3)
            {
                Console.WriteLine("Il triangolo e': Equilatero  ");
            }
            else if (lat1 == lat2 || lat2 == lat3 || lat1 == lat3)
            {
                Console.WriteLine("Il triangolo e': Isocele");
            }
            else {
                Console.WriteLine("Il triangolo e': Scaleno");
            }

            
        }
    }
}
