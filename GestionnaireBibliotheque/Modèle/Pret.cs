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

        private string _lecteur;
        public string Lecteur
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

        public Pret(DateTime dateDebut, DateTime dateRappel, string lecteur)
        {
            List<string> listeLecteurs = new List<string>();

            for(int i =0; i< listeLecteurs.Count(); i++)
            {
                if(listeLecteurs.ind)
            }
            this.DateDebut = dateDebut;
            this.DateRappel = dateRappel;


        }


    }
}
