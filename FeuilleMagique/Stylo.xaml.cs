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
using WpfApplication1;

namespace FeuilleMagique
{
    /// <summary>
    /// Logique d'interaction pour Stylo.xaml
    /// </summary>
    public partial class Stylo : Window
    {
        MainWindow mainWindow;
        public Stylo(MainWindow m)
        {
            InitializeComponent();
            mainWindow = m;
        }

        private void buttonDossier_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.pagesSontAffiche = false;
            mainWindow.dossierGrid.Children.Clear();
            mainWindow.drawFolder();
        }

        private void buttonPageSuivante_Click(object sender, RoutedEventArgs e)
        {
            if (mainWindow.dossierGrid.Visibility == Visibility.Hidden)
            {
                mainWindow.displayPageSuivante();
            }
        }

        private void buttonPagePrecedente_Click(object sender, RoutedEventArgs e)
        {
            if (mainWindow.dossierGrid.Visibility == Visibility.Hidden)
            {
                mainWindow.displayPagePrecedente();
            }
        }

        private void NouvellePage_Click(object sender, RoutedEventArgs e)
        {

            mainWindow.indexPages = 0;
            mainWindow.indexDossier = MainWindow.dossiers.Count;
            MainWindow.dossiers.Add("");
            MainWindow.pages.Add(new List<String>());
            MainWindow.pages[mainWindow.indexDossier].Add("");
            MainWindow.lines.Add(new List<List<Line>>());
            MainWindow.lines[mainWindow.indexDossier].Add(new List<Line>());

            mainWindow.afficher_Page_Selectionne();
        }

    }
}
