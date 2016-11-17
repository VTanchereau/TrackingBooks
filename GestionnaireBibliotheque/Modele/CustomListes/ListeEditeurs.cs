using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modele.CustomListes
{
    public class ListeEditeurs
    {
        private List<Editeur> lstEditeurs;

        public ListeEditeurs(List<Editeur> _lstEditeurs)
        {
            this.lstEditeurs = _lstEditeurs;
        }

        public void Add(Editeur editeur)
        {
            this.lstEditeurs.Add(editeur);
        }

        public Editeur Get(String nom)
        {
            for (int i = 0; i < this.lstEditeurs.Count; i++)
            {
                if (nom.Equals(this.lstEditeurs[i].Nom))
                {
                    return this.lstEditeurs[i];
                }
            }
            return null;
        }
    }
}
