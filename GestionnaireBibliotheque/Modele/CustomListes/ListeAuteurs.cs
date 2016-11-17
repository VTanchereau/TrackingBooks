using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modele.CustomListes
{
    public class ListeAuteurs
    {
        private List<Auteur> lstAuteurs;

        public ListeAuteurs(List<Auteur> _lstAuteurs)
        {
            this.lstAuteurs = _lstAuteurs;
        }

        public void Add(Auteur auteur)
        {
            this.lstAuteurs.Add(auteur);
        }

        public void AddAll(List<Auteur> lstAuteur)
        {
            foreach (Auteur auteur in lstAuteur){
                this.lstAuteurs.Add(auteur);
            }
        }

        public Auteur Get(String nom)
        {
            for (int i = 0; i < this.lstAuteurs.Count; i++)
            {
                if (nom.Equals(this.lstAuteurs[i].Nom))
                {
                    return this.lstAuteurs[i];
                }
            }
            return null;
        }
    }
}
