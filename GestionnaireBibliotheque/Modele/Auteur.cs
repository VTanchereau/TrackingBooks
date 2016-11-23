using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modele
{
    public class Auteur
    {
        //variables privées
        private List<Oeuvre> _listeOeuvres;
        private String _nom;
        private String _prenom;

        //variables publiques
        public List<Oeuvre> ListeOeuvres
        {
            get { return _listeOeuvres; }
            set { _listeOeuvres = value; }
        }

        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public String Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        //constructeur de l'objet Auteur
        public Auteur(string nom, string prenom)
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }

        override
        public String ToString()
        {
            return this.Prenom + " " + this.Nom;
        }

    }
}
