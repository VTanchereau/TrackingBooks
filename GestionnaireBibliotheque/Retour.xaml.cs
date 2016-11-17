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
    /// Logique d'interaction pour Retour.xaml
    /// </summary>
    public partial class Retour : Page
    {
        private Window win;
        public Retour(Window w)
        {
            InitializeComponent();
            this.win = w;
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.win.Close();
        }
    }
}
