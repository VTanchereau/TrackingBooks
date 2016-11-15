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
    /// Logique d'interaction pour AddBookLayout.xaml
    /// </summary>
    public partial class AddBookLayout : Page
    {
        public AddBookLayout()
        {
            InitializeComponent();
            subTitle.Text = "quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. \n" +
                "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur \n" +
                "magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum \n" +
                "quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut \n" +
                "labore et dolore magnam aliquam quaerat voluptatem.";

        }


    }
}
