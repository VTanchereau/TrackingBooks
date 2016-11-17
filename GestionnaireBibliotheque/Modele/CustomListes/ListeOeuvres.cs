using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modele.CustomListes
{
    public class ListeOeuvres
    {
        private List<Oeuvre> lstOeuvre;

        public ListeOeuvres(List<Oeuvre> _lstOeuvre)
        {
            this.lstOeuvre = _lstOeuvre;
        }

        public void Add(Oeuvre oeuvre)
        {
            this.lstOeuvre.Add(oeuvre);
        }

        public Oeuvre Get(String titre)
        {
            for (int i = 0; i < this.lstOeuvre.Count; i++)
            {
                if (titre.Equals(this.lstOeuvre[i].Titre))
                {
                    return this.lstOeuvre[i];
                }
            }
            return null;
        }
    }
}
