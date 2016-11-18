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
    /// Logique d'interaction pour Liste.xaml
    /// </summary>
    public partial class Liste : Page
    {
        private List<String> lstTitres;
        private List<String> lstAuteur;
        private List<String> lstEditeur;
        private List<String> lstGenre;
        private List<String> lstDateAjout;
        private List<Modele.Exemplaire> _lstEx;

        public Liste()
        {
            InitializeComponent();
            _lstEx = (this.DataContext as Modele.Gestionnaire).ListeExemplaires;
            foreach (Modele.Exemplaire exemplaire in _lstEx)
            {
                lb_auteurName.ItemsSource = exemplaire.Oeuvre.LstAuteur;
                lb_editorName.ItemsSource = exemplaire.Editeur.Nom;
                lb_titleBook.ItemsSource = exemplaire.Oeuvre.Titre;
                lb_dateAjoutBook.ItemsSource = exemplaire.DateAjout.ToString();
                lb_genreBook.ItemsSource = exemplaire.Oeuvre.LstGenre;
            }
        }

    }
}
