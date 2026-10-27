/*Creazione di una piramide di asterischi in Console*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_PIRAMIDE
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Variabili
            int n1;

            Console.WriteLine("Inserisci di quanti piani vuoi la piramide: ");
            n1 = int.Parse(Console.ReadLine());

            for (int i = 1; i < n1; i++) //controlla le righe della piramide.
            {

                for (int j = 0; j < n1 - i; j++) // stampa gli spazi prima degli asterischi.
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i - 1; k++)
                { 
                    Console.Write("*"); // stampa gli *
                }
                Console.WriteLine();
            }
        }
    }
}