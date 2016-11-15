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
            tb_authorName.Text = "Nom de l'auteur";
            tb_editorBook.Text = "Nom de l'éditeur";
            tb_sagaName.Text = "Nom de la saga";
            tb_titleBook.Text = "Titre du livre";

        }

        private void isbnButton_Click(object sender, RoutedEventArgs e)
        {
            help aide = new help();
            Window win = new Window();
            aide.titleHelp.Text = "Numéro ISBN";
            win.Content = aide;
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }

        private void titleButton_Click(object sender, RoutedEventArgs e)
        {
            help aide = new help();
            Window win = new Window();
            aide.titleHelp.Text = "Titre du livre";
            win.Content = aide;
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }

        private void authorButton_Click(object sender, RoutedEventArgs e)
        {
            help aide = new help();
            Window win = new Window();
            aide.titleHelp.Text = "Auteur du livre";
            win.Content = aide;
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }

        private void sagaButton_Click(object sender, RoutedEventArgs e)
        {
            help aide = new help();
            Window win = new Window();
            aide.titleHelp.Text = "Saga";
            win.Content = aide;
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }

        private void commButton_Click(object sender, RoutedEventArgs e)
        {
            help aide = new help();
            Window win = new Window();
            aide.titleHelp.Text = "Commentaire";
            win.Content = aide;
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }

        private void editorButton_Click(object sender, RoutedEventArgs e)
        {
            help aide = new help();
            Window win = new Window();
            aide.titleHelp.Text = "Editeur";
            win.Content = aide;
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }
    }
}
