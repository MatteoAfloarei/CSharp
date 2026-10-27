/* Un'automobile percorre 20 km con un litro di benzina. 
 * Calcolare la spesa necessaria a
 * percorrere 100 km.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Auto
{
    internal class Program
    {
        static void Main(string[] args)
        {   // L'auto percorre 20 km con 1 litro
            double litri = 100.00 / 20, costoBenzina, spesa;

            // input del prezzo al litro
            Console.WriteLine("inserisci il prezzo della benzina al litro: ");
            costoBenzina = double.Parse(Console.ReadLine());


            spesa = litri * costoBenzina;

            Console.WriteLine($"La spesa necessaria per percorrere 100 km è: " + spesa + "euro");
        }
    }
}
 