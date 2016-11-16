using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modèle
{
    class Commentaire
    {
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
        
    }
}
