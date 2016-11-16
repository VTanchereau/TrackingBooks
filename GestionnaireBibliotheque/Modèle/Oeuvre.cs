using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modèle
{
    class Oeuvre
    {
        private List<Exemplaire> _listeExemplaires;
        public List<Exemplaire> ListeExemplaires
        {
            get { return _listeExemplaires; }
            set { _listeExemplaires = value; }
        }

        private Genre _genre;
        public Genre Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        private Auteur _auteur;
        public Auteur Auteur
        {
            get { return _auteur; }
            set { _auteur = value; }
        }


        private String _titre;
        public String Titre
        {
            get { return _titre; }
            set { _titre = value; }
        }

        private String _resume;
        public String Resume
        {
            get { return _resume; }
            set { _resume = value; }
        }

        private int _ISBN10;
        public int ISBN10
        {
            get { return _ISBN10; }
            set { _ISBN10 = value; }
        }

        private int _ISBN13;
        public int ISBN13
        {
            get { return _ISBN13; }
            set { _ISBN13 = value; }
        }
        
        public Oeuvre(string titre, string resume, int numero_ISBN10, int numero_ISBN13, Genre genre, Auteur auteur )
        {
            this._titre = titre;
            this._resume = resume;
            this.ISBN10 = numero_ISBN10;
            this.ISBN13 = numero_ISBN13;
            this._genre = genre;
            this._auteur = auteur;
        }

    }
}
