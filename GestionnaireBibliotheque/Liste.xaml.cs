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
        private Modele.CustomListes.ListeExemplaires _lstEx;

        public Liste()
        {
            InitializeComponent();

        }

        public List<Modele.Exemplaire> LstEx{
            get{ return _lstEx;}
            set{ _lstEx = value; }
        }
    }
}
