using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modèle
{
    class Auteur
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

        private String _prenom;
        public String Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public Auteur(string nom, string prenom)
        {
            this._nom = nom;
            this._prenom = Prenom;
        }

    }
}
