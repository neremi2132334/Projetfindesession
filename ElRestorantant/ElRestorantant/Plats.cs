using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElRestorantant
{
    public class Plats
    {
<<<<<<< HEAD
        public void Acheterplat()
=======
        public string Nom { get; set; }
        public List<ingredients> LstIngredient { get; set; }
        public string Rarete { get; set; }
        public double PrixAchat { get; set; }
        public double PrixVente { get; set; }

        public Plats(string nom, List<ingredients> lstIngredient, string rarete, double prixAchat, double prixVente)
>>>>>>> b47fc7345dca85a412665c9a83b47eadda49a1ee
        {
            Nom = nom;
            LstIngredient = lstIngredient;
            Rarete = rarete;
            PrixAchat = prixAchat;
            PrixVente = prixVente;
        }

        public void Changerplat()
        {


        }

        public void Acheterplat()
        {


        }

        public static List<Plats> CreerPlats(List<ingredients> ingredientsDisponibles)
        {
            List<Plats> plats = new List<Plats>();

            // Quiche au poulet et poivron
            plats.Add(new Plats("Quiche au poulet et poivron", new List<ingredients>
            {
                ingredientsDisponibles.Find(i => i.Nom == "Farine"),
                ingredientsDisponibles.Find(i => i.Nom == "Beurre"),
                ingredientsDisponibles.Find(i => i.Nom == "Oeuf"),
                ingredientsDisponibles.Find(i => i.Nom == "Lait"),
                ingredientsDisponibles.Find(i => i.Nom == "Poivron"),
                ingredientsDisponibles.Find(i => i.Nom == "Poivre"),
                ingredientsDisponibles.Find(i => i.Nom == "Poulet")
                
            }, "Rare", 10.00, 15.00));

            // Spaghetti bolognaise
            plats.Add(new Plats("Spaghetti bolognaise", new List<ingredients>
            {
                // ... (ajoutez les ingrédients ici)
            }, "Moyenne", 12.0f, 18.0f));

            // ... (ajoutez les autres plats ici)

            return plats;
        }
    }

   
}
