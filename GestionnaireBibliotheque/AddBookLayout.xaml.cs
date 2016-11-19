using System;
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
            tbk_resumeLivre.Text = "quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. \n" +
                "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur \n" +
                "magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum \n" +
                "quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut \n" +
                "labore et dolore magnam aliquam quaerat voluptatem.";
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
            if (bookIsbn != "" || bookIsbn != null)
            {
                this.validISBN(bookIsbn);
            }
            else
            {
                bookIsbn = "";
                addBook(bookIsbn);
            }

            this.w.Close();
        }

        private void addBook(String isbn)
        {
            if (tb_titleBook.Text == "" || tb_authorName.Text == "" || tb_editorName.Text == "" || tb_genreName.Text == "" || tbk_resumeLivre.Text == "")
            {
                return;
            }
            String bookTitle = tb_titleBook.Text;
            String bookAuthor = tb_authorName.Text;
            String bookEditor = tb_editorName.Text;
            String bookGenres = tb_genreName.Text;
            String bookResume = tbk_resumeLivre.Text;

            List<Modele.Auteur> lstAuteurs = getAuthors(bookAuthor);
            List<Modele.Genre> lstGenres = getGenres(bookGenres);
            Modele.Oeuvre oeuvre = new Modele.Oeuvre(bookTitle, bookResume, isbn, lstGenres, lstAuteurs);

            Modele.Exemplaire exemplaire;

            if (bookEditor != "" || bookEditor != null)
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

        private void validationIsbn10(int nb_char_isbn, String[] tab_char_isbn)
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
                String isbn = String.Join("", "", tab_char_isbn);
                this.addBook(isbn);
            }
            else if (Int32.Parse(tab_char_isbn[nb_char_isbn - 1]) == validation_key)
            {
                String isbn = String.Join("", "", tab_char_isbn);
                this.addBook(isbn);
            }
            else
            {
                Window w = new Window();
                ValideIsbn page_isbn = new ValideIsbn(w);
                w.Title = "Clé du numéro ISBN 10 non valide";
                w.Content = page_isbn;
                w.ResizeMode = System.Windows.ResizeMode.NoResize;
                w.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                w.ShowDialog();
            }
        }

        private void validationIsbn13(int nb_char_isbn, String[] tab_char_isbn)
        {
            List<int> somme = new List<int>();
            int validation_key = 0;
            int groupe_chiffre = Int32.Parse(tab_char_isbn[0]) + Int32.Parse(tab_char_isbn[1]) + Int32.Parse(tab_char_isbn[2]);
            if (groupe_chiffre == 978 || groupe_chiffre == 979)
            {
                for (float i = 0; i < nb_char_isbn - 1; i++)
                {
                    if (Int32.Parse(tab_char_isbn[(int)i]) % 2 == 0)
                    {
                        somme[(int)i] = Int32.Parse(tab_char_isbn[(int)i]) * 3;
                    }
                    else
                    {
                        somme[(int)i] = Int32.Parse(tab_char_isbn[(int)i]);
                    }
                }
                for (int j = 0; j < somme.Count; j = j + 2)
                {
                    validation_key += somme[j] + somme[j + 1];
                }
                validation_key = 10 % (10 - (10 % validation_key));
                if (Int32.Parse(tab_char_isbn[nb_char_isbn - 1]) == validation_key)
                {
                    String isbn = String.Join("","",tab_char_isbn);
                    this.addBook(isbn);
                }
                else
                {
                    Window w = new Window();
                    ValideIsbn page_isbn = new ValideIsbn(w);
                    w.Title = "Clé du numéro ISBN 13 non valide";
                    w.Content = page_isbn;
                    w.ResizeMode = System.Windows.ResizeMode.NoResize;
                    w.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    w.ShowDialog();
                }
            }
            else
            {
                Window w = new Window();
                ValideIsbn page_isbn = new ValideIsbn(w);
                w.Title = "Groupe de chiffre 979 - 978 non valide";
                w.Content = page_isbn;
                w.ResizeMode = System.Windows.ResizeMode.NoResize;
                w.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                w.ShowDialog();
            }
        }

        private void validISBN(String isbn)
        {
            isbn = isbn.Replace("-", "");
            int nb_char_isbn;
            String[] tab_char_isbn;

            nb_char_isbn = isbn.Length;
            tab_char_isbn = new String[nb_char_isbn];

            for (int i = 0; i < nb_char_isbn; i++)
            {
                tab_char_isbn[i] = isbn.Substring(i, 1);
            }

            if (nb_char_isbn == 10)
            {
                this.validationIsbn10(nb_char_isbn, tab_char_isbn);
            }

            else if (nb_char_isbn == 13)
            {
                this.validationIsbn13(nb_char_isbn, tab_char_isbn);
            }
            else
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
}
