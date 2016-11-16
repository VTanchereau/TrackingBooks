using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modèle
{
    class Genre
    {
        private String _nom;
        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public Genre(string nom)
        {
            this._nom = nom;
        }

    }
}
