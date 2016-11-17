using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modèle
{
    class Genre
    {
        private List<Oeuvre> _listeOeuvres;
        public List<Oeuvre> ListeOeuvres
        {
            get { return _listeOeuvres; }
            set { _listeOeuvres = value; }
        }

        private String _nom;
        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public Genre(string nom)
        {
            this.Nom = nom;
        }

       
    }
}
