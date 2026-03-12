using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetMenuGroup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnComp_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var Comp2 = new Composition(); // on instancie la deuxième fenêtre
            Comp2.Closed += (s, args) => this.Close(); //On notifie à la première de se fermer au moment où la seconde se ferme
            Comp2.Show(); // on affiche la deuxième
        }

        private void BtnElem_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var Elem2 = new Element(); // on instancie la deuxième fenêtre
            Elem2.Closed += (s, args) => this.Close(); //On notifie à la première de se fermer au moment où la seconde se ferme
            Elem2.Show(); // on affiche la deuxième
        }

        private void BtnMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var Menu2 = new Menu(); // on instancie la deuxième fenêtre
            Menu2.Closed += (s, args) => this.Close(); //On notifie à la première de se fermer au moment où la seconde se ferme
            Menu2.Show(); // on affiche la deuxième
        }
    }
}