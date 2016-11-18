using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modele
{
    public class Pret
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
        public Pret(Exemplaire exemplaire, DateTime dateDebut, DateTime dateRappel, Lecteur lecteur)
        {
           // List<Lecteur> listeLecteurs = new List<Lecteur>();
            this.DateDebut = dateDebut;
            this.Exemplaire = exemplaire;
            this.Lecteur = lecteur;
            this.DateRappel = dateRappel;
            
        }

        //Methode deplacée dans l'objet exemplaire car le retour se fait à partir d'un exemplaire via son pretActif.
       /* private void Set_RetourPret(Commentaire commentaire)
        {
            this.DateRetour = DateTime.Today;
            this.Commentaire = commentaire;
        }*/
       


    }
}
