using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestionnaireBibliotheque
{
    /// <summary>
    /// Logique d'interaction pour Liste.xaml
    /// </summary>
    public partial class Liste : Page
    {
        private int _widthColumn;
        public int WidthColumn
        {
            get { return this._widthColumn; }
            set { this._widthColumn = value; }
        }
        private List<Modele.Exemplaire> _lstExemplaires;
        public List<Modele.Exemplaire> ListeExemplaires
        {
            get { return this._lstExemplaires; }
            set { this._lstExemplaires = value; }
        }

        private List<Livre> _lstLivre;
        public List<Livre> ListeLivre
        {
            get { return this._lstLivre; }
            set { this._lstLivre = value; }
        }

        public Liste(Modele.Gestionnaire gestionnaire)
        {
            InitializeComponent();
            this.ListeExemplaires = gestionnaire.ListeExemplaires;
            WidthColumn = (int)(lv_Livres.Width);
            SetListViewItems();
        }

        public void SetListViewItems()
        {
            this.ListeLivre = new List<Livre>();
            foreach (Modele.Exemplaire exemplaire in ListeExemplaires)
            {
                Livre livre = new Livre();

                livre.Titre = exemplaire.Oeuvre.Titre;
                livre.Editeur = exemplaire.Editeur.Nom;
                livre.DateAjout = exemplaire.DateAjout.ToString();

                String auteurs = "";
                for (int i = 0; i < exemplaire.Oeuvre.LstAuteur.Count - 1; i++)
                {
                    auteurs += exemplaire.Oeuvre.LstAuteur[i].Prenom + " " + exemplaire.Oeuvre.LstAuteur[i].Nom + ", ";
                }
                auteurs += exemplaire.Oeuvre.LstAuteur[exemplaire.Oeuvre.LstAuteur.Count - 1].Prenom + " " + exemplaire.Oeuvre.LstAuteur[exemplaire.Oeuvre.LstAuteur.Count - 1].Nom;
                livre.Auteurs = auteurs;

                String genres = "";
                for (int i = 0; i < exemplaire.Oeuvre.LstGenre.Count - 1; i++)
                {
                    genres += exemplaire.Oeuvre.LstGenre[i].Nom + ", ";
                }
                genres += exemplaire.Oeuvre.LstGenre[exemplaire.Oeuvre.LstGenre.Count - 1].Nom;
                livre.Genres = genres;
                this.ListeLivre.Add(livre);
            }
            if (this.ListeLivre != null && this.ListeLivre.Count > 0)
            {
                lv_Livres.ItemsSource = this.ListeLivre;
            }
        }

        public void UpdateListView(Modele.Gestionnaire gestionnaire)
        {
            this.ListeExemplaires = gestionnaire.ListeExemplaires;
            SetListViewItems();
        }

        public class Livre
        {
            public String Titre { get; set; }
            public String Auteurs { get; set; }
            public String Editeur { get; set; }
            public String Genres { get; set; }
            public String DateAjout { get; set; }
        }

    }
}
