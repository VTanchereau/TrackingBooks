using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modele
{
    public class Genre
    {
        //variables privées
        private List<Oeuvre> _listeOeuvres;
        private String _nom;

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

        //constructeur de l'objet Genre
        public Genre(string nom)
        {
            this.Nom = nom;
        }

        public String ToCSV()
        {
            String retour = "{";
            retour += this.Nom;
            retour += "}";
            return retour;
        }
    }
}
