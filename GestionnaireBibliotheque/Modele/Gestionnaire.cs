using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modele
{
    public class Gestionnaire
    {
        private CustomListes.ListeExemplaires _lstExemplaires;
        private CustomListes.ListeOeuvres _lstOeuvres;
        private CustomListes.ListeGenres _lstGenres;
        private CustomListes.ListeEditeurs _lstEditeurs;
        private CustomListes.ListeAuteurs _lstAuteurs;
        private CustomListes.ListeLecteurs _lstLecteurs;
        private CustomListes.ListePrets _lstPrets;

        public Gestionnaire()
        {
            ListeExemplaires = new CustomListes.ListeExemplaires(new List<Exemplaire>());
            ListeOeuvres = new CustomListes.ListeOeuvres(new List<Oeuvre>());
            ListeGenres = new CustomListes.ListeGenres(new List<Genre>());
            ListeEditeurs = new CustomListes.ListeEditeurs(new List<Editeur>());
            ListeAuteurs = new CustomListes.ListeAuteurs(new List<Auteur>());
            ListeLecteurs = new CustomListes.ListeLecteurs(new List<Lecteur>());
            ListePret = new CustomListes.ListePrets(new List<Pret>());
        }

        public CustomListes.ListeExemplaires ListeExemplaires
        {
            get { return this._lstExemplaires; }
            set { this._lstExemplaires = value; }
        }

        public CustomListes.ListeOeuvres ListeOeuvres
        {
            get { return this._lstOeuvres; }
            set { this._lstOeuvres = value; }
        }

        public CustomListes.ListeGenres ListeGenres
        {
            get { return this._lstGenres; }
            set { this._lstGenres = value; }
        }

        public CustomListes.ListeEditeurs ListeEditeurs
        {
            get { return this._lstEditeurs; }
            set { this._lstEditeurs = value; }
        }

        public CustomListes.ListeAuteurs ListeAuteurs
        {
            get { return this._lstAuteurs; }
            set { this._lstAuteurs = value; }
        }

        public CustomListes.ListeLecteurs ListeLecteurs
        {
            get { return this._lstLecteurs; }
            set { this._lstLecteurs = value; }
        }

        public CustomListes.ListePrets ListePret
        {
            get { return this._lstPrets; }
            set { this._lstPrets = value; }
        }
    }
}
