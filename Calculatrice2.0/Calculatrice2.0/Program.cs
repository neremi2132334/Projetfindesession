using System;
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
                double total=0;
                Console.WriteLine("ENTREZ UN 1er CHIFFRE (X).");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ENTREZ UN 2eme CHIFFRE (Y).");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Menu d'Action" +
                    "(1) Addition" +
                    "(2) Soustraction" +
                    "(3) Division" +
                    "(4) Multiplication" +
                    "(5) Exposant" +
                    "(6) Logarithme");
                int choix = Convert.ToInt32(Console.ReadLine());
                    switch (choix)
                    {
                        case 1:
                            total =calculatrice.Addition(x,y);
                            break;
                        case 2:
                            total = calculatrice.Soustraction(x, y);
                            break;
                        case 3:
                            total = calculatrice.Diviser(x, y);
                            break;
                        case 4:
                            total = calculatrice.Multiplier(x, y);
                            break;
                        case 5:
                            total= calculatrice.Exposant(x,y);
                            break;
                        case 6:
                            total = calculatrice.Log(x,y);
                            break;
                    }
                Console.WriteLine($"{total}");
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