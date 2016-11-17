using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modèle.CustomListes
{
    class ListeLecteurs
    {
        private List<Lecteur> lstLecteurs;

        public ListeLecteurs(List<Lecteur> _lstLecteurs)
        {
            this.lstLecteurs = _lstLecteurs;
        }

        public void Add(Lecteur lecteur)
        {
            this.lstLecteurs.Add(lecteur);
        }

        public Lecteur Get(String nom)
        {
            for (int i = 0; i < this.lstLecteurs.Count; i++)
            {
                if (nom.Equals(this.lstLecteurs[i].Nom))
                {
                    return this.lstLecteurs[i];
                }
            }
            return null;
        }
    }
}
