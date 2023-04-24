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
        public List<Client> lstClient { get; set; }


        public Restaurant(string nom)
        {
            Nom = nom;
            Monnaie = FabriqueNom.rand.Next(2000, 5001);
            NbVente = 0;
            Popularité = 1; 
            lstClient = new List<Client>();
        }


        //Fonction qui donne les statistiques du restaurant
        public void RestoStats()
        {
            Console.WriteLine($"Statistique de Votre Restaurant --> {Nom}\n" +
                   $"Monnaie --> {Monnaie}\n" +
                   $"Nombre de Vente --> {NbVente}\n"+
                   $"Popularité --> {Popularité}\n");
        }

        public void ObtenirClient()
        {
            int moy = (Popularité * 30)/2;
            int rdm = FabriqueNom.rand.Next(2, moy);
            int nbClient = 0;
            for (int i = 0; i < rdm; i++)
            {
                Client client = new Client();
                lstClient.Add(client);
                nbClient = i;
            }
            Console.WriteLine($"Vous Avez {nbClient + 1} client(e)s aujourd'hui ! Voici la liste des clients :\n");
            AfficherClient(lstClient);
        }
        public void AfficherClient(List<Client> lstClient)
        {
            foreach(Client client in lstClient)
            {
                Console.WriteLine($"Voici le nom du Client --> {client.Nom}");
                Console.WriteLine($"Voici l'humeur du Client -> {client.HumeurClient}\n");
                //Console.WriteLine($"Voici sa facture --> {facture}");
            }
        }


    }
}
