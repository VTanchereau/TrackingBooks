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
        List<Modele.MoyenContact> Liste_MoyenDeContact = new List<Modele.MoyenContact>();

        public Pret()
        {
            InitializeComponent();


            for (int i = 1 ; i < 99; i++)
            {
                lstNumbers.Add(i);
            }
            cb_dureePret.ItemsSource = lstNumbers;
            cb_dureePret.SelectedItem = 1;
        }
        
        // methode pour ajouter un pret 
        private void btn_valider_Click(object sender, RoutedEventArgs e)
        {
            if( string.IsNullOrEmpty(tb_typeMoyenContact.Text) && string.IsNullOrEmpty(tb_valueMoyenContact.Text))
            {
                for (int i = 0; i < lv_moyenContact.Items.Count; i++)
                {
                    Liste_MoyenDeContact.Add((Modele.MoyenContact)lv_moyenContact.Items.GetItemAt(i));
                }
            }

            if (string.IsNullOrEmpty(tb_nomLecteur.Text) && string.IsNullOrEmpty(tb_prenomLecteur.Text) && Liste_MoyenDeContact !=null)
            {
                Modele.Lecteur lecteur = new Modele.Lecteur(tb_nomLecteur.Text, tb_prenomLecteur.Text, Liste_MoyenDeContact);

                if (GenerateExemplaire() != null && string.IsNullOrEmpty(cb_dureePret.Text))
                {
                    Modele.Pret Pret = new Modele.Pret(GenerateExemplaire(), DateTime.Today, Set_dateRappel(int.Parse(cb_dureePret.Text)), lecteur);
                }
            }
          
        }
        //methode pour ajouter un moyen de contact dans la liste, 
        private void btn_addMoyenContact_Click(object sender, RoutedEventArgs e)
        {
            Modele.MoyenContact MoyenDeContact = new Modele.MoyenContact(tb_typeMoyenContact.Text, tb_valueMoyenContact.Text);
            Liste_MoyenDeContact.Add(MoyenDeContact);
            lv_moyenContact.ItemsSource = Liste_MoyenDeContact;
        }
        //methode pour generer un faux exemplaire
        private Modele.Exemplaire GenerateExemplaire()
        {
            List<Modele.Auteur> lstAuteurs = new List<Modele.Auteur>();
            Modele.Editeur Editeur = new Modele.Editeur("nom");
            Modele.Genre Genre = new Modele.Genre("genre");
            Modele.Oeuvre Oeuvre = new Modele.Oeuvre("titre", "Resume", Genre, lstAuteurs);
            Modele.Exemplaire exemplaire;

            return exemplaire = new Modele.Exemplaire(DateTime.Today,"neuf",true, Editeur,Oeuvre);
        }

        //methode pour transformer la date de rappel
        private DateTime Set_dateRappel(int valeurAjouter)
        {
            DateTime dateRappel = DateTime.Today;
            if ( cb_dureePret.Text == "jour")
            {
                dateRappel.AddDays(valeurAjouter);
            }
            if (cb_dureePret.Text == "semaine")
            {
                dateRappel.AddDays(valeurAjouter * 7);
            }
            if (cb_dureePret.Text == "mois")
            {
                dateRappel.AddMonths(valeurAjouter);
            }
            return dateRappel;
        }
    }
}
