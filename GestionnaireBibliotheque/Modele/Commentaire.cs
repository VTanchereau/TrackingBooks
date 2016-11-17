using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modele
{
    class Commentaire
    {
        private Pret _pret;
        public Pret Pret
        {
            get { return _pret; }
            set { _pret = value; }
        }

        private String _titre;
        public String Titre
        {
            get { return _titre; }
            set { _titre = value; }
        }

        private String _contenu;
        public String Contenu
        {
            get { return _contenu; }
            set { _contenu = value; }
        }

        public Commentaire(string titre, string contenu, Pret pret)
        {
            this._titre = titre;
            this._contenu = contenu;
            this._pret = pret;
        }

        
    }
}
