﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private MainWindow window;
        private ListSortDirection _sortDirection;
        private GridViewColumnHeader _sortColumn;
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

        private ObservableCollection<Livre> _lstLivre;
        public ObservableCollection<Livre> ListeLivre
        {
            get { return this._lstLivre; }
            set { this._lstLivre = value; }
        }

        private Modele.Gestionnaire _gestionnaire;
        public Modele.Gestionnaire Gestionnaire
        {
            get { return this._gestionnaire; }
            set { this._gestionnaire = value; }
        }

        public Liste(Modele.Gestionnaire gestionnaire, MainWindow w)
        {
            InitializeComponent();
            this.ListeLivre = new ObservableCollection<Livre>();
            this.Gestionnaire = gestionnaire;
            this.ListeExemplaires = gestionnaire.ListeExemplaires;
            WidthColumn = (int)(lv_Livres.Width);
            SetListViewItems();
            DataContext = this;
            this.window = w;
        }

        public void SetListViewItems()
        {
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

                if (this.ListeLivre.Count != 0)
                {
                    Boolean aAjouter = true;
                    foreach (Livre livreTemp in this.ListeLivre)
                    {
                        if (livreTemp.Equals(livre))
                        {
                            aAjouter = false;
                        }
                    }
                    if (aAjouter)
                    {
                        this.ListeLivre.Add(livre);
                    }
                }
                else
                {
                    this.ListeLivre.Add(livre);
                }
                
            }
            if (this.ListeLivre != null && this.ListeLivre.Count > 0)
            {
                  lv_Livres.ItemsSource = this.ListeLivre;
            }
        }

        public void UpdateListView(Modele.Gestionnaire gestionnaire)
        {
            this.Gestionnaire = gestionnaire;
            this.ListeExemplaires = gestionnaire.ListeExemplaires;
            SetListViewItems();
        }

        public void ChangedSelection(object sender, EventArgs e)
        {
            if (lv_Livres.SelectedItem as Livre != null)
            {
                Livre selectedLivre = lv_Livres.SelectedItem as Livre;

                Modele.Exemplaire ex = Gestionnaire.ListeExemplaires.Find(x => x.Oeuvre.Titre.Equals(selectedLivre.Titre));

                this.window.SetBookDetails(ex);
            }
        }

        public class Livre
        {
            public String Titre { get; set; }
            public String Auteurs { get; set; }
            public String Editeur { get; set; }
            public String Genres { get; set; }
            public String DateAjout { get; set; }

            public bool Equals(Livre other)
            {
                return Titre.Equals(other.Titre) && Auteurs.Equals(other.Auteurs) && Editeur.Equals(other.Editeur) && Genres.Equals(other.Genres) && DateAjout.Equals(other.DateAjout);
            }
        }
    }
}
