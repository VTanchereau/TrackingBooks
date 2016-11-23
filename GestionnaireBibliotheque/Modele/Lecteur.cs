using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modele
{
    public class Lecteur
    {
        //variables privées
        private List<MoyenContact> _listeMoyenContacts;
        private String _nom;
        private String _prenom;

        //variables publiques
        public List<MoyenContact> ListeMoyenContacts
        {
            get { return _listeMoyenContacts; }
            set { _listeMoyenContacts = value; }
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


        //constructeur de l'objet Lecteur
        public Lecteur(string nom, string prenom)
        {
            this._nom = nom;
            this._prenom = prenom;
        }

        //constructeur surchargé de l'objet Lecteur  
        public Lecteur(string nom, string prenom, List<MoyenContact> liste_moyenDeContact)
        {
            this._nom = nom;
            this._prenom = prenom;
            this.ListeMoyenContacts = liste_moyenDeContact;
        }

        public String lstMoyensContactToCSV()
        {
            String retour = "[";
            for (int i = 0; i < this.ListeMoyenContacts.Count - 1; i++)
            {
                retour += this.ListeMoyenContacts[i].ToCSV();
                retour += ";";
            }
            retour += this.ListeMoyenContacts[this.ListeMoyenContacts.Count - 1].ToCSV();
            retour += "]";
            return retour;
        }

        public String ToCSV()
        {
            String retour = "{";
            retour += this.Prenom;
            retour += ";";
            retour += this.Nom;
            retour += ";";
            retour += this.lstMoyensContactToCSV();
            retour += ";";
            retour += "}";
            return retour;
        }
    }
}
