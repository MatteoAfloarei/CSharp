/*Dati 3 numeri stampare il più grande, il più piccolo e la loro media aritmetica*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_3Numeri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Inserisci Numero 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Inserisci Numero 2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Inserisci Numero 3: ");
            num3 = int.Parse(Console.ReadLine());

            int max;
            if (num1 >= num2 && num1 >= num3)
            {
                max = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                max = num2;
            }
            else
            {
                max = num3;
            }

            int min;
            if (num1 <= num2 && num1 <= num3)
            {
                min = num1;
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                min = num2;
            }
            else
            {
                min = num3;
            }

            double media = (num1 + num2 + num3) / 3.0;

            Console.WriteLine($"Il più grande è: {max}");
            Console.WriteLine($"Il più piccolo è: {min}");
            Console.WriteLine($"La media aritmetica è: {media}");
        }
    }
}
