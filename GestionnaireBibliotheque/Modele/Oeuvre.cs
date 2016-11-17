using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modele
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

        private List<Auteur> _lstauteur;
        public List<Auteur> LstAuteur
        {
            get { return _lstauteur; }
            set { _lstauteur = value; }
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
        
        public Oeuvre(string titre, string resume, int numero_ISBN10, int numero_ISBN13, Genre genre, List<Auteur> lstauteur )
        {
            this.Titre = titre;
            this.Resume = resume;
            this.ISBN10 = numero_ISBN10;
            this.ISBN13 = numero_ISBN13;
            this.Genre = genre;
            this.LstAuteur = lstauteur;
        }

    }
}
