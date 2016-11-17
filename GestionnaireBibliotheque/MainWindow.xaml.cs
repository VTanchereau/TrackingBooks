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
        private Modele.Gestionnaire _Gestionnaire;
        public Modele.Gestionnaire Gestionnaire
        {
            get { return this._Gestionnaire; }
            set { this._Gestionnaire = value; }
        }

        public MainWindow()
        {
            this.WindowState = WindowState.Maximized;
            this.Gestionnaire = new Modele.Gestionnaire();
            InitializeComponent();
            ListeRetourAttente lra = new ListeRetourAttente();
            Window win = new Window();
            win.Title = "Liste des livres en attentes de retour";
            win.Content = lra;
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            Window win = new Window();
            AddBookLayout addBookWindow = new AddBookLayout(this.Gestionnaire, win);
            win.Content = addBookWindow;
            win.Title = "Ajouter un livre";
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }

        private void lendBook_Click(object sender, RoutedEventArgs e)
        {
            PretGeneral p = new PretGeneral();
            Window w = new Window();

            w.Content = p;
            w.Title = "Prêter un livre";
            w.SizeToContent = SizeToContent.WidthAndHeight;
            w.ResizeMode = System.Windows.ResizeMode.NoResize;

            w.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            w.ShowDialog();
        }

        private void getBackBook_Click(object sender, RoutedEventArgs e)
        {
            PretGeneral p = new PretGeneral();
            Window w = new Window();

            w.Content = p;
            w.Title = "Retour d'un livre";
            w.SizeToContent = SizeToContent.WidthAndHeight;
            w.ResizeMode = System.Windows.ResizeMode.NoResize;

            w.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            w.ShowDialog();
        }
    }
}
