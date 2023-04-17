﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Calculatrice2._0
{
    class Program
    {

        static void Main(string[] args)
        {
            Calculateur calculatrice = new Calculateur();
            try
            {
                int x = 0;
                int y = 0;
                double total;
                Console.WriteLine("ENTREZ UN 1er CHIFFRE (X).");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ENTREZ UN 2eme CHIFFRE (Y).");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Menu d'Action" +
                    "(A) Addition" +
                    "(S) Soustraction" +
                    "(D) Division" +
                    "(M) Multiplication" +
                    "(E) Exposant" +
                    "(L) Logarithme");
                string choix = Console.ReadLine();
                //if(choix == A)
                {
                    Console.WriteLine("FONCTION ADDITION");
                }



                total = calculatrice.exposant(x, y);
                Console.WriteLine($"La Réponse de la divsion ente {x} et {y} est égale a {total}");
                //total = calculatrice.Multiplier(x, y);
                Console.WriteLine($"La Réponse de la Multiplication ente {x} et {y} est égale a {total}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Division Impossible Par 0");
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Dépassement de l'entier!");
                Console.WriteLine(ex.Message);
            }


        }
    }
}