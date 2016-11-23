using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modele
{
    public class Exemplaire
    {
        //variables privées
        private List<Pret> _listeDePrets;
        private Oeuvre _oeuvre;
        private Editeur _editeur;
        private DateTime _dateAjout;
        private String _photo;
        private String _etat;
        private Boolean _disponibilite;
        private Pret _pretActif;

        //variables publiques
        public List<Pret> ListeDePrets
        {
            get { return _listeDePrets; }
            set { _listeDePrets = value; }
        }

        public Oeuvre Oeuvre
        {
            get { return _oeuvre; }
            set { _oeuvre = value; }
        }

        public  Editeur Editeur
        {
            get { return _editeur; }
            set { _editeur = value; }
        }

        public String Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }

        public DateTime DateAjout
        {
            get { return _dateAjout; }
            set { _dateAjout = value; }
        }

        public String Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }

        public Boolean Disponibilite
        {
            get { return _disponibilite; }
            set { _disponibilite = value; }
        }

        public Pret PretActif
        {
            get { return _pretActif; }
            set { _pretActif = value; }
        }

        public Exemplaire(Oeuvre oeuvre, Editeur editeur, string photo = "default_path")
        {
            this.DateAjout = DateTime.Today;
            this.Etat = "Bon";
            this.Disponibilite = true; ;
            this.Editeur = editeur;
            this.Oeuvre = oeuvre;
            this.Photo = photo;

        }

        public Exemplaire(Oeuvre oeuvre, string photo = "default_path")
        {
            this.DateAjout = DateTime.Today;
            this.Etat = "Bon";
            this.Disponibilite = true;
            this.Oeuvre = oeuvre;
            this.Photo = photo;
        }

        public void Set_retourExemplaire(Commentaire commentaire, string etat)
        {
            this._pretActif.DateRetour = DateTime.Today;
            this._pretActif.Commentaire = commentaire;
            this._etat = etat;
        }

        public String lstPretsToCSV()
        {
            String retour = "[";
            for (int i = 0; i < this.ListeDePrets.Count - 1; i++)
            {
                retour += this.ListeDePrets[i].ToCSV();
                retour += ";";
            }
            retour += this.ListeDePrets[this.ListeDePrets.Count - 1].ToCSV();
            retour += "]";
            return retour;
        }

        public String ToCSV()
        {
            String retour = "{";
            retour += this.Oeuvre.ToCSV();
            retour += ";";
            retour += this.Editeur.ToCSV();
            retour += ";";
            retour += this.Photo;
            retour += ";";
            retour += this.DateAjout.ToString();
            retour += ";";
            retour += this.lstPretsToCSV();
            retour += ";";
            retour += "}";
            return retour;
        }
    }
}
