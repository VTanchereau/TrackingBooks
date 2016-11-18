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
    /// Logique d'interaction pour ValideIsbn.xaml
    /// </summary>
    public partial class ValideIsbn : Page
    {
        private Window w;

        public ValideIsbn(Window w)
        {
            InitializeComponent();
            this.w = w;
            tbk_isbn_valide.Text = "Le numéro ISBN saisie N'est pas valide";
        }

        private void btn_fermer_valide_isbn_Click(object sender, RoutedEventArgs e)
        {
            this.w.Close();
        }
    }
}
