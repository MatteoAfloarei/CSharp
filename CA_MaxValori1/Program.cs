/* Data una serie di N numeri determinare il valore più grande*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_MaxValore
{
    internal class Program
    {
        static void Main(string[] args)
        {  //variabili
            int N, num;
            bool success = true;
            do
            {    //input
                Console.WriteLine("Inserisci il numero di valori da confrontare: ");
                success = int.TryParse(Console.ReadLine(), out N);

                if (!success)
                {
                    Console.WriteLine("Riprovare: ");
                }
                int maxValue = 0;
                for (int i = 0; i < N; i++)
                {
                    do
                    {
                        Console.WriteLine("Inserisci numero: ");
                        success = int.TryParse(Console.ReadLine(), out num);
                        if (!success)
                        {
                            Console.WriteLine("Errore: riprovare o inserire un intero: ");
                        }
                    } while (!success);
                    if (i == 1)
                    {
                        maxValue = num;
                    }
                    else if (num > maxValue)
                    {
                        maxValue = num;
                    }
                }
                Console.WriteLine("Il numero max e: " + maxValue);
            } while (!success || success);


        }
    }
}
