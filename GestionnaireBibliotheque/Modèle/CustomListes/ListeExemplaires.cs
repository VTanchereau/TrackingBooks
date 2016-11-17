using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modèle.CustomListes
{
    class ListeExemplaires
    {
        private List<Exemplaire> lstExemplaire;

        public ListeExemplaires(List<Exemplaire> _lstExemplaire)
        {
            this.lstExemplaire = _lstExemplaire;
        }

        public void Add(Exemplaire ex)
        {
            this.lstExemplaire.Add(ex);
        }

        public Exemplaire Get(int i)
        {
            return this.lstExemplaire[i];
        }
    }
}
