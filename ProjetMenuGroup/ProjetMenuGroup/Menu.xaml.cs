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
using System.Windows.Shapes;

namespace ProjetMenuGroup
{
    /// <summary>
    /// Logique d'interaction pour Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void BtnRetour_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var Edit2 = new MainWindow(); // on instancie la deuxième fenêtre
            Edit2.Closed += (s, args) => this.Close(); //On notifie à la première de se fermer au moment où la seconde se ferme
            Edit2.Show(); // on affiche la deuxième
        }
    }
}
