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

namespace WpfApplication1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> pages = new List<string>();
        List<String> titres = new List<string>();
        int index = 0;
        Cloud cloud ;

        public MainWindow()
        {
            InitializeComponent();
            cloud = new Cloud();
            cloud.Show();
            pages.Add("");
            titres.Add("");
            this.Title = "Page 1";
            numpage.Text = "Page " + (index + 1);
        }
        
        private void pagesuivante_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            pages[index] = feuille.Text;

            if (pages.Count - 1 == index)
            {
                feuille.Text = "";
                titre.Text = "";
                index++;
                pages.Add("");
                titres.Add("");
            }
            else
            {
                index++;
                feuille.Text = pages[index];
                titre.Text = titres[index];
            }

            this.Title = "Page "+ (index+1);
            numpage.Text = "Page " + (index + 1);
            
        }

        private void pageprecedente_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            pages[index] = feuille.Text;
            if (index != 0)
            {
                index--;
            }            
            feuille.Text = pages[index];
            titre.Text = titres[index];
            this.Title = "Page " + (index+1);
            numpage.Text = "Page " + (index + 1);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            cloud.Close();
        }
    }
}
