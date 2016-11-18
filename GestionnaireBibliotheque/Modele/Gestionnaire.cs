using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireBibliotheque.Modele
{
    public class Gestionnaire
    {
        private List<Exemplaire> _lstExemplaires;
        private List<Oeuvre> _lstOeuvres;
        private List<Genre> _lstGenres;
        private List<Editeur> _lstEditeurs;
        private List<Auteur> _lstAuteurs;
        private List<Lecteur> _lstLecteurs;
        private List<Pret> _lstPrets;

        public Gestionnaire()
        {
            ListeExemplaires = new List<Exemplaire>();
            ListeOeuvres = new List<Oeuvre>();
            ListeGenres = new List<Genre>();
            ListeEditeurs = new List<Editeur>();
            ListeAuteurs = new List<Auteur>();
            ListeLecteurs = new List<Lecteur>();
            ListePret = new List<Pret>();
        }

        public List<Exemplaire> ListeExemplaires
        {
            get { return this._lstExemplaires; }
            set { this._lstExemplaires = value; }
        }

        public List<Oeuvre> ListeOeuvres
        {
            get { return this._lstOeuvres; }
            set { this._lstOeuvres = value; }
        }

        public List<Genre> ListeGenres
        {
            get { return this._lstGenres; }
            set { this._lstGenres = value; }
        }

       

        public List<Editeur> ListeEditeurs
        {
            get { return this._lstEditeurs; }
            set { this._lstEditeurs = value; }
        }

        public List<Auteur> ListeAuteurs
        {
            get { return this._lstAuteurs; }
            set { this._lstAuteurs = value; }
        }

        public List<Lecteur> ListeLecteurs
        {
            get { return this._lstLecteurs; }
            set { this._lstLecteurs = value; }
        }

        public List<Pret> ListePret
        {
            get { return this._lstPrets; }
            set { this._lstPrets = value; }
        }

        public void AddExemplaire(Exemplaire ex)
        {
            this.ListeAuteurs.AddRange(ex.Oeuvre.LstAuteur);
            this.ListeGenres.AddRange(ex.Oeuvre.LstGenre);
            this.ListeOeuvres.Add(ex.Oeuvre);
            this.ListeEditeurs.Add(ex.Editeur);
            this.ListeExemplaires.Add(ex);
        }

        public void AddPret(Pret pret)
        {
            this.ListeLecteurs.Add(pret.Lecteur);
            this.ListePret.Add(pret);
        }

        public void AddLecteur(Lecteur lecteur)
        {
            this.ListeLecteurs.Add(lecteur);
        }

        public void DeletePret(Pret pret)
        {
            if (ListePret.Contains(pret))
            {
                ListePret.Remove(pret);
            }
        }

        //methode pour generer un faux exemplaire
        public Modele.Exemplaire GenerateExemplaire()
        {
            List<Modele.Auteur> lstAuteurs = new List<Modele.Auteur>();
            Modele.Editeur Editeur = new Modele.Editeur("nom");
            List<Modele.Genre> lstGenres = new List<Modele.Genre>();
            Modele.Oeuvre Oeuvre = new Modele.Oeuvre("titre", "Resume", lstGenres, lstAuteurs);
            Modele.Exemplaire exemplaire;

            return exemplaire = new Modele.Exemplaire(Oeuvre, Editeur);
        }
    }
}
