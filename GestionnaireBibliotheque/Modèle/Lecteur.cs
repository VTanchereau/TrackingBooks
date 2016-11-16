using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modèle
{
    class Lecteur
    {
        private List<MoyenContact> _listeMoyenContacts;
        public List<MoyenContact> ListeMoyenContacts
        {
            get { return _listeMoyenContacts; }
            set { _listeMoyenContacts = value; }
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

        public Lecteur(string nom, string prenom)
        {
            this._nom = nom;
            this._prenom = prenom;
        }

    }
}
