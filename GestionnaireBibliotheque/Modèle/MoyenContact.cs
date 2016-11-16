using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modèle
{
    class MoyenContact
    {
        private String _type;

        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private String _valeur;

        public String Valeur
        {
            get { return _valeur; }
            set { _valeur = value; }
        }

        private int _ordre;

        public int Ordre
        {
            get { return _ordre; }
            set { _ordre = value; }
        }

        public MoyenContact(string type, string valeur, int ordre)
        {
            this._type = type;
            this._valeur = valeur;
            this._ordre = ordre;
        }
    }
}
