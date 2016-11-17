using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modele
{
    public class Oeuvre
    {
        private List<Exemplaire> _listeExemplaires;
        private List<Genre> _lstGenre;
        private List<Auteur> _lstauteur;
        private String _titre;
        private String _resume;
        private int _ISBN10;
        private int _ISBN13;

        public List<Exemplaire> ListeExemplaires
        {
            get { return _listeExemplaires; }
            set { _listeExemplaires = value; }
        }
        
        public List<Genre> LstGenre
        {
            get { return _lstGenre; }
            set { _lstGenre = value; }
        }
        
        public List<Auteur> LstAuteur
        {
            get { return _lstauteur; }
            set { _lstauteur = value; }
        }
        
        public String Titre
        {
            get { return _titre; }
            set { _titre = value; }
        }
        
        public String Resume
        {
            get { return _resume; }
            set { _resume = value; }
        }

        public int ISBN10
        {
            get { return _ISBN10; }
            set { _ISBN10 = value; }
        }
       
        public int ISBN13
        {
            get { return _ISBN13; }
            set { _ISBN13 = value; }
        }

        public Oeuvre(string titre, string resume, int typeISBN, int numero_ISBN, List<Genre> lstGenre, List<Auteur> lstauteur)
        {
            this.Titre = titre;
            this.Resume = resume;
            if (typeISBN == 13)
            {
                this.ISBN13 = numero_ISBN;
            }
            else
            {
                this.ISBN10 = numero_ISBN;

            }
            this.LstGenre = lstGenre;
            this.LstAuteur = lstauteur;
        }

        public Oeuvre(string titre, string resume, List<Genre> lstGenre, List<Auteur> lstauteur)
        {
            this.Titre = titre;
            this.Resume = resume;
            this.LstGenre = lstGenre;
            this.LstAuteur = lstauteur;
        }

    }
}
