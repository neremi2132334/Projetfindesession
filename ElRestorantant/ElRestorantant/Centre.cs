﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;

namespace ElRestorantant
{
    class Centre
    {
        public void Simulation()
        {
            Console.Clear();
            Console.WriteLine("Choissisez le nom de votre restaurant.");
            string choix = Console.ReadLine();
            Console.WriteLine("Appuyez sur une touche pour commencer");
            Console.ReadKey();
            Restaurant resto = new Restaurant(choix);

            //Début du Menu 
            for (int i = 0; resto.Monnaie != 0 ; i++)
            {
                Console.WriteLine($"--> Jour Numéro {i + 1}");
                Console.WriteLine(">>>> Gestion du Restaurant <<<<\n");
                Console.WriteLine("1 --> Stats Du Restaurant\n"+
                    "2 --> Gestion des Clients\n" +
                    "3 --> Ajuster les plats\n" +
                    "4 --> Achat de Nouveau Plat\n" +
                    "5 --> Engager Employer\n");
                int chx = Convert.ToInt32(Console.ReadLine());
                //CONFIRMATION DU CHOIX
                while ((chx > 5) || (chx < 0))
                {
                    Console.WriteLine("--> Tapez un chiffre pour faire une action (1,2,3,4 OU 5)");
                    chx = Convert.ToInt32(Console.ReadLine());
                }
                if (chx == 1) { resto.RestoStats(); }
                if (chx == 2) { resto.ObtenirClient(); }
                if (chx == 5) { resto.Monnaie = resto.EngagerEmp(); }
            }
        }
    }
}
