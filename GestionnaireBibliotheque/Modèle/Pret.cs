using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modèle
{
    class Pret
    {
        private Exemplaire _exemplaire;
        public Exemplaire Exemplaire
        {
            get { return _exemplaire; }
            set { _exemplaire = value; }
        }       

        private Commentaire _commentaire;
        public Commentaire Commentaire
        {
            get { return _commentaire; }
            set { _commentaire = value; }
        }

        private Lecteur _lecteur;
        public Lecteur Lecteur
        {
            get { return _lecteur; }
            set { _lecteur = value; }
        }

        private DateTime _dateDebut;
        public DateTime DateDebut
        {
            get { return _dateDebut; }
            set { _dateDebut = value; }
        }

        private DateTime _dateRetour;
        public DateTime DateRetour
        {
            get { return _dateRetour; }
            set { _dateRetour = value; }
        }

        private DateTime _dateRappel;
        public DateTime DateRappel
        {
            get { return _dateRappel; }
            set { _dateRappel = value; }
        }

        public Pret(DateTime dateDebut, DateTime dateRetour, DateTime dateRappel)
        {
            this._dateDebut = dateDebut;
            this._dateRetour = dateRetour;
            this._dateRappel = dateRappel;
        }


    }
}
