using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElRestorantant
{
    public enum Humeur
    {
        Joyeux,
        Rageux, 
        Neutre,     
    }
    class Client
    {
        public string Nom { get; set; }
        public Humeur HumeurClient { get; set; }

        public Client()
        {
            Nom = FabriqueNom.FabriquerNom();

            //Setting de l'humeur du client 
            int nb = FabriqueNom.rand.Next(0, 3);
            HumeurClient = (Humeur)nb;
        }

    }
}
