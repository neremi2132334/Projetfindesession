using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElRestorantant
{
    class Restaurant
    {
        public string Nom { get; set; }
        public int Monnaie { get; set; }
        public int NbVente { get; set; }
        public int Popularité { get; set;}


        public Restaurant(string nom)
        {
            Nom = nom;
            Monnaie = random.Next(2000, 5001);
            NbVente = 0;
            Popularité = 0; 
        }


        //Fonction qui donne les statistiques du restaurant
        public void RestoStats()
        {
            Console.WriteLine($"Statistique de Votre Restaurant --> {Nom}");

        }


        //Fonction qui sert a Random 
        static readonly Random random = new Random();
    }
}
