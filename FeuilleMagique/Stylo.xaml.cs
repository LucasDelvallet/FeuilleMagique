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
            mainWindow.drawFolder();
        }
    }
}
