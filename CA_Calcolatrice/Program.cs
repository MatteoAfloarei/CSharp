using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variabili
            string operatore;
            bool success = true;
            double Num, Risultato = 0;
            int tent;
            do
            {
                Console.WriteLine("Che operatore devi Fare?");
                Console.WriteLine("(+)");
                Console.WriteLine("(-)");
                Console.WriteLine("(*)");
                Console.WriteLine("(/)");
                Console.WriteLine("(%)");
                Console.WriteLine("Esc (5)");
                operatore = Console.ReadLine();
                Console.WriteLine("Quanti Num vuoi inserire: ");
                success = int.TryParse(Console.ReadLine(), out tent);
                if (!success)
                {
                    Console.WriteLine("Riprovare: ");
                }
                if (operatore == "+")
                {
                    for (int i = 0; i < tent; i++)
                    {
                        Console.WriteLine("Inserisci un numero:");

                        success = double.TryParse(Console.ReadLine(), out Num);

                        if (success)
                        {
                            Risultato += Num;
                        }
                        else
                        {
                            Console.WriteLine("Numero non valido!");

                        }
                    }

                    Console.WriteLine("La somma è: " + Risultato);
                }
                else if (operatore == "-")
                {
                    for (int i = 0; i < tent; i++)
                    {
                        Console.WriteLine("Inserisci un numero:");

                        success = double.TryParse(Console.ReadLine(), out Num);

                        if (success)
                        {
                            Risultato -= Num;
                        }
                        else
                        {
                            Console.WriteLine("Numero non valido!");

                        }
                    }

                    Console.WriteLine("La sottrazione è: " + Risultato);
                }
                else if (operatore == "*")
                {
                    for (int i = 0; i < tent; i++)
                    {
                        Console.WriteLine("Inserisci un numero:");

                        success = double.TryParse(Console.ReadLine(), out Num);

                        if (success)
                        {
                            Risultato *= Num;
                        }
                        else
                        {
                            Console.WriteLine("Numero non valido!");

                        }
                    }

                    Console.WriteLine("La Moltiplicazione è: " + Risultato);
                }
                else if (operatore == "/")
                {
                    for (int i = 0; i < tent; i++)
                    {
                        Console.WriteLine("Inserisci un numero:");

                        success = double.TryParse(Console.ReadLine(), out Num);

                        if (success)
                        {
                            Risultato /= Num;
                        }
                        else
                        {
                            Console.WriteLine("Numero non valido!");

                        }
                    }

                    Console.WriteLine("La divisione è: " + Risultato);
                }
            } while (!success || operatore == "5");
        }
    }
}
