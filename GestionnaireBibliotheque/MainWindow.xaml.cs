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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Liste listeAffichage;

        private Modele.Gestionnaire _Gestionnaire;
        public Modele.Gestionnaire Gestionnaire
        {
            get { return this._Gestionnaire; }
            set { this._Gestionnaire = value; }
        }

        public MainWindow()
        {
            this.WindowState = WindowState.Maximized;
            InitializeComponent();
            this.Gestionnaire = new Modele.Gestionnaire();
            this.listeAffichage = new Liste(this.Gestionnaire);
            liste.Navigate(this.listeAffichage);
            ListeRetourAttente lra = new ListeRetourAttente();
            Window win = new Window();
            win.Title = "Liste des livres en attentes de retour";
            win.Content = lra;
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }

        public void UpdateListe()
        {
            this.listeAffichage.UpdateListView(this.Gestionnaire);
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            Window win = new Window();
            AddBookLayout addBookWindow = new AddBookLayout(this.Gestionnaire, win, this);
            win.Content = addBookWindow;
            win.Title = "Ajouter un livre";
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }

        private void lendBook_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window();
            PretGeneral p = new PretGeneral(w);
            
            w.Content = p;
            w.Title = "Prêter un livre";
            w.SizeToContent = SizeToContent.WidthAndHeight;
            w.ResizeMode = System.Windows.ResizeMode.NoResize;

            w.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            w.ShowDialog();
        }

        private void getBackBook_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window();
            PretGeneral p = new PretGeneral(w);
            
            w.Content = p;
            w.Title = "Retour d'un livre";
            w.SizeToContent = SizeToContent.WidthAndHeight;
            w.ResizeMode = System.Windows.ResizeMode.NoResize;

            w.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            w.ShowDialog();
        }

        public void UpdateListBooks()
        {

        }
    }
}
