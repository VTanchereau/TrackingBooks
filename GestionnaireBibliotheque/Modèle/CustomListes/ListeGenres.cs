using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modèle.CustomListes
{
    class ListeGenres
    {
        private List<Genre> lstGenres;

        public ListeGenres(List<Genre> _lstGenres)
        {
            this.lstGenres = _lstGenres;
        }

        public void Add(Genre genre)
        {
            this.lstGenres.Add(genre);
        }

        public Genre Get(String nom)
        {
            for (int i = 0; i < this.lstGenres.Count; i++)
            {
                if (nom.Equals(this.lstGenres[i].Nom))
                {
                    return this.lstGenres[i];
                }
            }
            return null;
        }
    }
}
