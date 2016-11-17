using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modele
{
    class Exemplaire
    {
        private List<Pret> _listeDePrets;
        public List<Pret> ListeDePrets
        {
            get { return _listeDePrets; }
            set { _listeDePrets = value; }
        }

        private Oeuvre _oeuvre;
        public Oeuvre Oeuvre
        {
            get { return _oeuvre; }
            set { _oeuvre = value; }
        }

        private Editeur _editeur;
        public  Editeur Editeur
        {
            get { return _editeur; }
            set { _editeur = value; }
        }

        private String _photo;
        public String Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }

        private DateTime _dateAjout;
        public DateTime DateAjout
        {
            get { return _dateAjout; }
            set { _dateAjout = value; }
        }

        private String _etat;
        public String Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }

        private Boolean _disponibilite;
        public Boolean Disponibilite
        {
            get { return _disponibilite; }
            set { _disponibilite = value; }
        }

        public Exemplaire(DateTime dateAjout, string etat, Boolean disponibilite, Editeur editeur, Oeuvre oeuvre)
        {
            this._dateAjout = dateAjout;
            this._etat = etat;
            this._disponibilite = disponibilite;
            this._editeur = editeur;
            this._oeuvre = oeuvre;
        }

        public Exemplaire(DateTime dateAjout, string etat, string photo, Boolean disponibilite, Editeur editeur, Oeuvre oeuvre)
        {
            this._dateAjout = dateAjout;
            this._etat = etat;
            this._disponibilite = disponibilite;
            this._photo = photo;
            this._editeur = editeur;
            this._oeuvre = oeuvre;
        }

        public Exemplaire(DateTime dateAjout, string etat, Boolean disponibilite, Oeuvre oeuvre)
        {
            this._dateAjout = dateAjout;
            this._etat = etat;
            this._disponibilite = disponibilite;
            this._oeuvre = oeuvre;
        }

        public Exemplaire(DateTime dateAjout, string etat, string photo, Boolean disponibilite, Oeuvre oeuvre)
        {
            this._dateAjout = dateAjout;
            this._etat = etat;
            this._disponibilite = disponibilite;
            this._photo = photo;
            this._oeuvre = oeuvre;
        }




    }
}
