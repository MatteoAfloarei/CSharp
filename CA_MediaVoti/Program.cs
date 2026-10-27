/*Dati N voti inseriti dall’utente, calcolarne la media.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_MediaVoti
{
    internal class Program
    {
        static void Main(string[] args)
        {   //variabili
            double voti, media = 0, risultato;
            int nvoti;

            //input
            Console.WriteLine("Inserisci quanti voti hai: ");
            nvoti = int.Parse(Console.ReadLine());

            //ciclo e calcolo
            for (int i = 0; i < nvoti; i++)
            {
                do
                {
                    Console.WriteLine("Inserisci i voti: ");
                    voti = double.Parse(Console.ReadLine());

                } while (voti <= 0 || voti > 10);

                media = media + voti;
            }

            //output
            risultato = media / nvoti;

            Console.WriteLine("La media e': " + risultato);

        }
    }
    
}
