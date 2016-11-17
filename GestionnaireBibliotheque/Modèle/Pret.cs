using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modèle
{
    class Pret
    {
        //variables privées
        private Exemplaire _exemplaire;
        private Commentaire _commentaire;
        private Lecteur _lecteur;
        private DateTime _dateDebut;
        private DateTime _dateRetour;
        private DateTime _dateRappel;

        //variables publiques
        public Exemplaire Exemplaire
        {
            get { return _exemplaire; }
            set { _exemplaire = value; }
        }       
        public Commentaire Commentaire
        {
            get { return _commentaire; }
            set { _commentaire = value; }
        }
        public Lecteur Lecteur
        {
            get { return _lecteur; }
            set { _lecteur = value; }
        }
        public DateTime DateDebut
        {
            get { return _dateDebut; }
            set { _dateDebut = value; }
        }
        public DateTime DateRetour
        {
            get { return _dateRetour; }
            set { _dateRetour = value; }
        }
        public DateTime DateRappel
        {
            get { return _dateRappel; }
            set { _dateRappel = value; }
        }

        //constructeur de l'objet Pret
        public Pret(Exemplaire exemplaire, DateTime dateDebut, DateTime dateRappel, Lecteur lecteur, int valeur_dateRappel, string typeValeur_dateRappel)
        {
            List<Lecteur> listeLecteurs = new List<Lecteur>();
            this.DateDebut = dateDebut;
            this.Exemplaire = exemplaire;

            for (int i =0; i< listeLecteurs.Count(); i++)
            {
                if(listeLecteurs[i] == lecteur)
                {
                    this.Lecteur = lecteur;
                }
            }
            if(typeValeur_dateRappel == "jour")
            {
                this.DateRappel.AddDays(valeur_dateRappel);
            }
            if(typeValeur_dateRappel == "semaine")
            {
                this.DateRappel.AddDays(valeur_dateRappel * 7);
            }
            if(typeValeur_dateRappel == "mois")
            {
                this.DateRappel.AddMonths(valeur_dateRappel);
            }
        }

        private void Set_dateRetour()
        {
            this.DateRetour = DateTime.Today;
        }
       /* private void format_dateRappel()
        {
        
        }*/


    }
}
