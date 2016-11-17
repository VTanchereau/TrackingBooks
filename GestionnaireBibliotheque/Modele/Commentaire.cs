using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modele
{
    public class Commentaire
    {
        //variables privées 
        private Pret _pret;
        private String _titre;
        private String _contenu;

        //variables publiques
        public Pret Pret
        {
            get { return _pret; }
            set { _pret = value; }
        }

        public String Titre
        {
            get { return _titre; }
            set { _titre = value; }
        }

        public String Contenu
        {
            get { return _contenu; }
            set { _contenu = value; }
        }

        //constructeur de l'objet Commentaire
        public Commentaire(string titre, string contenu, Pret pret)
        {
            this._titre = titre;
            this._contenu = contenu;
            this._pret = pret;
        }

        
    }
}
