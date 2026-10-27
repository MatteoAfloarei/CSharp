using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosaFare
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Variabili
            bool domanda = true, errore = true;
            int d, somma, Nnum, num1, num2, media;
            do
            {
                Console.WriteLine("Che Cosa Vuoi Fare? (1)somma (2)media (3)max (4)min (5)esci dal programma");
                d = int.Parse(Console.ReadLine());
                if (d == 1)
                {
                    // Ask how many numbers the user wants to enter, validate and sum them
                    Console.WriteLine("Quanti numeri vuoi inserire per la somma?");
                    while (!int.TryParse(Console.ReadLine(), out Nnum) || Nnum <= 0)
                    {
                        Console.WriteLine("Inserisci un intero positivo per il numero di valori:");
                    }

                    somma = 0;
                    for (int i = 1; i <= Nnum; i++)
                    {
                        do
                        {
                            Console.WriteLine("Inserisci numero: ");
                            errore = int.TryParse(Console.ReadLine(), out num1);
                            if (!errore)// ! trasforma da true in false o viceversa
                            {
                                Console.WriteLine("Errore: riprovare o inserire un intero: ");
                            }
                        } while (!errore);

                        somma += num1;
                    }

                    Console.WriteLine("La somma e: " + somma);
                }
                else if (d == 2)
                {
                    Console.WriteLine("Inserisci 2 per iniziare una media di 2 numeri: ");
                    domanda = int.TryParse(Console.ReadLine(), out Nnum);
                    if (domanda == true)
                    {
                        do
                        {
                            Console.WriteLine("Inserisci numero1: ");
                            errore = int.TryParse(Console.ReadLine(), out num1);
                            if (!errore)
                            {
                                Console.WriteLine("Errore: riprovare o inserire un intero: ");
                            }
                        } while (!errore);

                        do
                        {
                            Console.WriteLine("Inserisci numero2: ");
                            errore = int.TryParse(Console.ReadLine(), out num2);
                            if (!errore)
                            {
                                Console.WriteLine("Errore: riprovare o inserire un intero: ");
                            }
                        } while (!errore);

                        // Calcola e mostra la media
                        media = (num1 + num2) / 2;
                        Console.WriteLine("La media e: " + media);
                    }


                }
                else if (d == 3)
                {
                    Console.WriteLine("Inserisci 2 per vedere il numero minimo di 2 numeri: ");
                    domanda = int.TryParse(Console.ReadLine(), out Nnum);
                    if (domanda == true)
                    {
                        do
                        {
                            Console.WriteLine("Inserisci numero1: ");
                            errore = int.TryParse(Console.ReadLine(), out num1);
                            if (!errore)
                            {
                                Console.WriteLine("Errore: riprovare o inserire un intero: ");
                            }
                        } while (!errore);

                        do
                        {
                            Console.WriteLine("Inserisci numero2: ");
                            errore = int.TryParse(Console.ReadLine(), out num2);
                            if (!errore)
                            {
                                Console.WriteLine("Errore: riprovare o inserire un intero: ");
                            }
                        } while (!errore);

                        // Mostra num piu piccolo

                        if (num1 < num2)
                        {
                            Console.WriteLine(num1 + "e piu piccolo di " + num2);
                        }
                        else
                        {
                            Console.WriteLine(num2 + "e piu piccolo di " + num1);
                        }

                    }
                }
                else if (d == 4)
                {
                    Console.WriteLine("Inserisci 2 per vedere il numero massimo di 2 numeri: ");
                    domanda = int.TryParse(Console.ReadLine(), out Nnum);
                    if (domanda == true)
                    {
                        do
                        {
                            Console.WriteLine("Inserisci numero1: ");
                            errore = int.TryParse(Console.ReadLine(), out num1);
                            if (!errore)
                            {
                                Console.WriteLine("Errore: riprovare o inserire un intero: ");
                            }
                        } while (!errore);

                        do
                        {
                            Console.WriteLine("Inserisci numero2: ");
                            errore = int.TryParse(Console.ReadLine(), out num2);
                            if (!errore)
                            {
                                Console.WriteLine("Errore: riprovare o inserire un intero: ");
                            }
                        } while (!errore);

                        // Mostra num piu piccolo

                        if (num1 > num2)
                        {
                            Console.WriteLine(num1 + "e piu grande di " + num2);
                        }
                        else
                        {
                            Console.WriteLine(num2 + "e piu grande di " + num1);
                        }

                    }
                }

            } while (d != 5);
        }
    }
}