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
    /// Logique d'interaction pour confirm_pret.xaml
    /// </summary>
    public partial class confirm_pret : Page
    {
        private Window _win;
        private Modele.Pret _pret;
        public confirm_pret(Window w, Modele.Pret pret)
        {
            InitializeComponent();
            this._win = w;
            this._pret = pret;
        }

        
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
           /* int elapsedSeconds = DateTime.Now.Millisecond /1000 ;
            int endOfTime = elapsedSeconds + 30;

            do
            {
                pgb_confirmPret.Value = elapsedSeconds;
                elapsedSeconds = DateTime.Now.Millisecond/1000 ;

            } while (elapsedSeconds <= endOfTime);

            this._win.Close();*/

        }

        private void btn_annuler_Click(object sender, RoutedEventArgs e)
        {
            this._win.Close();
            Modele.Gestionnaire gestionnaire = new Modele.Gestionnaire();
            gestionnaire.DeletePret(_pret);

        }

        private void btn_faireDisparaitre_Click(object sender, RoutedEventArgs e)
        {
            this._win.Close();
        }

        private void pgb_confirmPret_Initialized(object sender, EventArgs e)
        {
           /* int elapsedSeconds = DateTime.Now.Second;
            int endOfTime = elapsedSeconds + 30;

            do
            {
                pgb_confirmPret.Value = elapsedSeconds;
                elapsedSeconds = DateTime.Now.Second ;

            } while (elapsedSeconds <= endOfTime);

            this._win.Close();*/
        }
    }
}