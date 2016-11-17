using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modele
{
    class MoyenContact
    {
        //variables privées
        private Lecteur _lecteur;
        private String _type;
        private String _valeur;
        private int _ordre;

        //variables publiques
        public Lecteur Lecteur
        {
            get { return _lecteur; }
            set { _lecteur = value; }
        }
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public String Valeur
        {
            get { return _valeur; }
            set { _valeur = value; }
        }
        public int Ordre
        {
            get { return _ordre; }
            set { _ordre = value; }
        }

        //constructeur de l'objet MoyenContact
        public MoyenContact(string type, string valeur, int ordre, Lecteur lecteur)
        {
            this.Type = type;
            this.Valeur = valeur;
            this.Lecteur = Lecteur;
            //this._ordre = ordre;
        }
    }
}
