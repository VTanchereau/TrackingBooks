using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modele
{
    class Editeur
    {
        //variables privées
        private List<Exemplaire> _listeExemplaires;
        private String _nom;

        //variables publiques
        public List<Exemplaire> ListeExemplaires
        {
            get { return _listeExemplaires; }
            set { _listeExemplaires = value; }
        }

        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        //constructeur de l'objet Editeur
        public Editeur( string nom)
        {
            this.Nom = nom;
        }
        
    }
}
