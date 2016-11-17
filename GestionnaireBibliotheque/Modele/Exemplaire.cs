using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modele
{
    class Exemplaire
    {
        //variables privées
        private List<Pret> _listeDePrets;
        private Oeuvre _oeuvre;
        private Editeur _editeur;
        private DateTime _dateAjout;
        private String _photo;
        private String _etat;
        private Boolean _disponibilite;

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

        public Exemplaire(DateTime dateAjout, string etat, Boolean disponibilite, Editeur editeur, Oeuvre oeuvre, string photo = "default_path")
        {
            this.DateAjout = dateAjout;
            this.Etat = etat;
            this.Disponibilite = disponibilite;
            this.Editeur = editeur;
            this.Oeuvre = oeuvre;
            this.Photo = photo;

        }

        public Exemplaire(DateTime dateAjout, string etat, Boolean disponibilite, Oeuvre oeuvre, string photo = "default_path")
        {
            this.DateAjout = dateAjout;
            this.Etat = etat;
            this.Disponibilite = disponibilite;
            this.Oeuvre = oeuvre;
        }
        
    }
}
