using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Pret.xaml
    /// </summary>
    public partial class Pret : Page
    {

        private List<int> lstNumbers = new List<int>();

        public Pret()
        {
            InitializeComponent();

            for (int i = 0 ; i < 99; i++)
            {
                lstNumbers.Add(i + 1);
            }
            cb_dureePret.ItemsSource = lstNumbers;

            cb_dureePret.SelectedItem = 1;
        }
    }
}
