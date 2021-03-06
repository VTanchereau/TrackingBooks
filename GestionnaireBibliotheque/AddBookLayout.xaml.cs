﻿using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour AddBookLayout.xaml
    /// </summary>
    public partial class AddBookLayout : Page
    {
        private Modele.Gestionnaire _gestionnaire;
        private Window w;
        private MainWindow mainWindow;
        public Modele.Gestionnaire Gestionnaire
        {
            get { return this._gestionnaire; }
            set { this._gestionnaire = value; }
        }

        public AddBookLayout(Modele.Gestionnaire _gestionnaire, Window win, MainWindow mainWindow)
        {
            InitializeComponent();
            tbk_authorName.Text = "Nom de l'auteur";
            tbk_editorName.Text = "Nom de l'éditeur";
            tbk_genreName.Text = "Genre du livre";
            tbk_titleBook.Text = "Titre du livre";
            this.Gestionnaire = _gestionnaire;
            tbk_ISBNBook.Text = "Numéro ISBN du livre";
            this.w = win;
            this.mainWindow = mainWindow;
        }

        private void isbnButton_Click(object sender, RoutedEventArgs e)
        {
            help aide = new help();
            Window win = new Window();
            aide.tbk_helpTitle.Text = "Numéro ISBN";
            win.Content = aide;
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }

        private void titleButton_Click(object sender, RoutedEventArgs e)
        {
            help aide = new help();
            Window win = new Window();
            aide.tbk_helpTitle.Text = "Titre du livre";
            win.Content = aide;
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }

        private void authorButton_Click(object sender, RoutedEventArgs e)
        {
            help aide = new help();
            Window win = new Window();
            aide.tbk_helpTitle.Text = "Auteur du livre";
            win.Content = aide;
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }

        private void genreButton_Click(object sender, RoutedEventArgs e)
        {
            help aide = new help();
            Window win = new Window();
            aide.tbk_helpTitle.Text = "Genre";
            win.Content = aide;
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }

        private void commButton_Click(object sender, RoutedEventArgs e)
        {
            help aide = new help();
            Window win = new Window();
            aide.tbk_helpTitle.Text = "Commentaire";
            win.Content = aide;
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }

        private void editorButton_Click(object sender, RoutedEventArgs e)
        {
            help aide = new help();
            Window win = new Window();
            aide.tbk_helpTitle.Text = "Editeur";
            win.Content = aide;
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }

        private void btn_aideAuthor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Annuler_Click(object sender, RoutedEventArgs e)
        {

            this.w.Close();

        }

        private void btn_Valider_Click_1(object sender, RoutedEventArgs e)
        {
            String bookIsbn = tb_ISBNBook.Text;
            if (bookIsbn != "" && bookIsbn != null)
            {
                if (!validISBN(bookIsbn))
                {
                    PopUpInvalidIsbn();
                    return;
                }
                String[] tab_char_isbn = stringToCharTab(bookIsbn); ;
                bookIsbn = String.Join("", "", tab_char_isbn);
            }
            else
            {
                bookIsbn = "";
            }
            addBook(bookIsbn);
            this.w.Close();
        }

        private void addBook(String isbn)
        {
            if (tb_titleBook.Text == "" || tb_authorName.Text == "" || tb_editorName.Text == "" || tb_genreName.Text == "" || tb_resumeLivre.Text == "")
            {
                return;
            }
            String bookTitle = tb_titleBook.Text;
            String bookAuthor = tb_authorName.Text;
            String bookEditor = tb_editorName.Text;
            String bookGenres = tb_genreName.Text;
            String bookResume = tb_resumeLivre.Text;

            List<Modele.Auteur> lstAuteurs = getAuthors(bookAuthor);
            List<Modele.Genre> lstGenres = getGenres(bookGenres);
            Modele.Oeuvre oeuvre = new Modele.Oeuvre(bookTitle, bookResume, isbn, lstGenres, lstAuteurs);

            Modele.Exemplaire exemplaire;

            if (bookEditor != "" && bookEditor != null)
            {
                Modele.Editeur editeur = new Modele.Editeur(bookEditor);
                exemplaire = new Modele.Exemplaire(oeuvre, editeur);
            }
            else
            {
                exemplaire = new Modele.Exemplaire(oeuvre);
            }
            this.Gestionnaire.AddExemplaire(exemplaire);
            this.mainWindow.Gestionnaire = this.Gestionnaire;
            this.mainWindow.UpdateListe();
        }

        private List<Modele.Auteur> getAuthors(String bookAuthor)
        {
            List<String> authors = new List<String>(bookAuthor.Split(','));
            List<Modele.Auteur> lstAuthors = new List<Modele.Auteur>();

            for (int i = 0; i < authors.Count; i++)
            {
                List<String> authorNames = new List<String>(authors[i].Split(','));
                String prenomAuteur = authorNames[0];
                String nomAuteur = "";
                if (authorNames.Count > 1)
                {
                    nomAuteur = authorNames[1];
                    if (authorNames.Count > 2)
                    {
                        for (int j = 2; j < authorNames.Count; j++)
                        {
                            nomAuteur += " " + authorNames[j];
                        }
                    }
                }

                Modele.Auteur author = new Modele.Auteur(nomAuteur, prenomAuteur);

                lstAuthors.Add(author);
            }
            return lstAuthors;
        }

        private List<Modele.Genre> getGenres(String bookGenres)
        {
            List<String> genres = new List<String>(bookGenres.Split(','));
            List<Modele.Genre> lstGenres = new List<Modele.Genre>();

            for (int i = 0; i < genres.Count; i++)
            {
                Modele.Genre genre = new Modele.Genre(genres[i]);

                lstGenres.Add(genre);
            }
            return lstGenres;
        }

        private Boolean validationIsbn10(int nb_char_isbn, String[] tab_char_isbn)
        {
            int[] somme = new int[nb_char_isbn-1];
            int validation_key=0;
            for (int i = 1; i < nb_char_isbn; i++)
            {
                int nbr = int.Parse(tab_char_isbn[i - 1]);
                somme[i - 1] = nbr * i;
            }
            for (int j = 0; j<somme.Count(); j = j + 1)
            {
                validation_key += somme[j];
            }
            validation_key = validation_key % 11;
            if (validation_key == 10)
            {
                return true;
            }
            else if (Int32.Parse(tab_char_isbn[nb_char_isbn - 1]) == validation_key)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Boolean validationIsbn13(int nb_char_isbn, String[] tab_char_isbn)
        {
            int[] somme = new int[nb_char_isbn];
            int validation_key = 0;
            String groupe_chiffre = tab_char_isbn[0] + tab_char_isbn[1] + tab_char_isbn[2];
            if (groupe_chiffre == "978" || groupe_chiffre == "979")
            {
                for (int i = 0; i < nb_char_isbn - 1; i++)
                {
                    if (i % 2 != 0)
                    {
                        somme[i] = Int32.Parse(tab_char_isbn[i]) * 3;
                    }
                    else
                    {
                        somme[i] = Int32.Parse(tab_char_isbn[i]);
                    }
                }
                for (int j = 0; j < somme.Count(); j++)
                {
                    validation_key += somme[j];
                }
                validation_key = (10 - (validation_key % 10) % 10);
                if (Int32.Parse(tab_char_isbn[nb_char_isbn - 1]) == validation_key)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private Boolean validISBN(String isbn)
        {
            isbn = isbn.Replace("-", "");
            int nb_char_isbn;
            nb_char_isbn = isbn.Length;
            String[] tab_char_isbn = stringToCharTab(isbn);

            if (nb_char_isbn == 10)
            {
                return validationIsbn10(nb_char_isbn, tab_char_isbn);
            }
            else if (nb_char_isbn == 13)
            {
                return validationIsbn13(nb_char_isbn, tab_char_isbn);
            }
            else
            {
                return false;
            }
        }

        private String[] stringToCharTab(String value)
        {
            value = value.Replace("-", "");
            int nb_char_isbn;
            String[] tab_char_isbn;

            nb_char_isbn = value.Length;
            tab_char_isbn = new String[nb_char_isbn];

            for (int i = 0; i < nb_char_isbn; i++)
            {
                tab_char_isbn[i] = value.Substring(i, 1);
            }
            return tab_char_isbn;
        }

        private void PopUpInvalidIsbn()
        {
            Window w = new Window();
            ValideIsbn page_isbn = new ValideIsbn(w);
            w.Title = "Numéro ISBN non valide";
            w.Content = page_isbn;
            w.ResizeMode = System.Windows.ResizeMode.NoResize;
            w.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            w.ShowDialog();
        }
    }
}
