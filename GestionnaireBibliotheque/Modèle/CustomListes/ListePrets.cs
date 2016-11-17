using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modèle.CustomListes
{
    class ListePrets
    {
        private List<Pret> lstPrets;

        public ListePrets(List<Pret> _lstPrets)
        {
            this.lstPrets = _lstPrets;
        }

        public void Add(Pret pret)
        {
            this.lstPrets.Add(pret);
        }

        public Pret Get(int i)
        {
            return this.lstPrets[i];
        }
    }
}
