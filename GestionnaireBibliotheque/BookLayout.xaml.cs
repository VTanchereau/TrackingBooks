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
       // private Modele.Gestionnaire _gestionnaire;
        Modele.Gestionnaire _gestionnaire = new Modele.Gestionnaire();
        public BookLayout() //Modele.Gestionnaire gestionnaire
        {
            InitializeComponent();
            // en attendant d'avoir un vrai exemplaire à envoyer sinon object null reference exception
           // this._gestionnaire = 
            this._exemplaire = _gestionnaire.GenerateExemplaire();
            
            
        }

        public void retour_Click(object sender, RoutedEventArgs e)
        {
            Window win = new Window();
            Retour r = new Retour(win,this._exemplaire);
            win.Content = r;
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }

        private void pret_Click(object sender, RoutedEventArgs e)
        {
            Window win = new Window();
            Pret pret = new Pret(win, this._exemplaire, _gestionnaire);
            win.Title = "Prêter un livre";
            win.Content = pret;
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }
    }
}
