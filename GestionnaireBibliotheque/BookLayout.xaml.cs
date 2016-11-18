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
    /// Interaction logic for BookLayout.xaml
    /// </summary>
    public partial class BookLayout : Page
    {
        private Modele.Exemplaire _exemplaire;
        public Modele.Exemplaire Exemplaire { get { return _exemplaire; } set {this._exemplaire = value; } }
        Modele.Gestionnaire gestionnaire = new Modele.Gestionnaire();
        public BookLayout()
        {
            InitializeComponent();
            // en attendant d'avoir un vrai exemplaire à envoyer sinon object null reference exception
            this._exemplaire = gestionnaire.GenerateExemplaire();

        }

        public void retour_Click(object sender, RoutedEventArgs e)
        {
            Window win = new Window();
            Retour r = new Retour(win,this.Exemplaire);
            win.Content = r;
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }

        private void pret_Click(object sender, RoutedEventArgs e)
        {
            Window win = new Window();
            Pret pret = new Pret(win, this._exemplaire);
            win.Title = "Prêter un livre";
            win.Content = pret;
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }

        public void SetNewExemplaire(Modele.Exemplaire ex)
        {
            this.Exemplaire = ex;
            this.SetInfos();
        }

        public void SetInfos()
        {
            tbk_titleBook.Text = this.Exemplaire.Oeuvre.Titre;
            tbk_AuthorTitle.Text = this.Exemplaire.Oeuvre.LstAuteur[0].Nom + " " + this.Exemplaire.Oeuvre.LstAuteur[0].Prenom;
            tbk_addedDay.Text = this.Exemplaire.DateAjout.Day.ToString();
            tbk_addedMonth.Text = this.Exemplaire.DateAjout.Month.ToString();
            tbk_addedyear.Text = this.Exemplaire.DateAjout.Year.ToString();
            tbk_editeur.Text = this.Exemplaire.Editeur.Nom;
            if (this.Exemplaire.Oeuvre.ISBN10 != null && this.Exemplaire.Oeuvre.ISBN13 == null)
            {
                tbk_ISBNnumber.Text = this.Exemplaire.Oeuvre.ISBN10.ToString();
            }
            else if(this.Exemplaire.Oeuvre.ISBN10 == null && this.Exemplaire.Oeuvre.ISBN13 != null)
            {
                tbk_ISBNnumber.Text = this.Exemplaire.Oeuvre.ISBN13.ToString();
            }
            tbk_bookResume.Text = this.Exemplaire.Oeuvre.Resume;
        }
    }
}
