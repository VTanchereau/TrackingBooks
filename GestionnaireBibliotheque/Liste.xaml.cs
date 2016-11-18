﻿using System;
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
        private List<String> lstTitres;
        private List<String> lstAuteur;
        private List<String> lstEditeur;
        private List<String> lstGenre;
        private List<String> lstDateAjout;
        private List<Modele.Exemplaire> _lstEx;

        public Liste(Modele.Gestionnaire gestionnaire)
        {
            InitializeComponent();
            lstTitres = new List<String>();
            lstAuteur = new List<String>();
            lstEditeur = new List<String>();
            lstDateAjout = new List<String>();
            lstGenre = new List<String>();
            _lstEx = new List<Modele.Exemplaire>();

            this.DataContext = gestionnaire;
            _lstEx = (this.DataContext as Modele.Gestionnaire).ListeExemplaires;

            try
            {
                foreach (Modele.Exemplaire exemplaire in _lstEx)
                {
                    String str_auteur = "";
                    String str_genre = "";
                    lstEditeur.Add(exemplaire.Editeur.Nom);
                    lstTitres.Add(exemplaire.Oeuvre.Titre);
                    lstDateAjout.Add(exemplaire.DateAjout.ToString());
                    foreach (Modele.Auteur auteur in exemplaire.Oeuvre.LstAuteur)
                    {
                        str_auteur += auteur.Nom + ", ";
                    }
                    lstAuteur.Add(str_auteur);
                    foreach (Modele.Genre genre in exemplaire.Oeuvre.LstGenre)
                    {
                        str_genre += genre.Nom + ", ";
                    }
                    lstEditeur.Add(str_genre);
                }
            }
            catch (NullReferenceException e) { }
            finally
            {
                lb_auteurName.ItemsSource = lstAuteur;
                lb_dateAjoutBook.ItemsSource = lstDateAjout;
                lb_editorName.ItemsSource = lstEditeur;
                lb_genreBook.ItemsSource = lstGenre;
                lb_titleBook.ItemsSource = lstTitres;
            }
            
        }

    }
}
