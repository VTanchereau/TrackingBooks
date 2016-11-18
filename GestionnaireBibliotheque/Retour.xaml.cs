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
        private Modele.Exemplaire _exemplaire;
        public Retour(Window w, Modele.Exemplaire exemplaire)
        {
            InitializeComponent();
            this.win = w;
            this._exemplaire = exemplaire;
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.win.Close();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            String etat = "";
            if (rb_etatBon.IsChecked == true)
            {
                etat = rb_etatBon.Content.ToString();
            }
            if(rb_etatMauvais.IsChecked == true)
            {
                etat = rb_etatMauvais.Content.ToString();
            }
            
            Modele.Commentaire commentaire = new Modele.Commentaire(tb_commBook.Text);
            this._exemplaire.Set_retourExemplaire(commentaire, etat);

        }
    }
}
