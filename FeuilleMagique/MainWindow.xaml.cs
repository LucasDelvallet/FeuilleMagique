using FeuilleMagique;
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
        public static List<String> pages = new List<string>();
        public static List<String> titres = new List<string>();
        int index = 0;
        Cloud cloud ;
        Stylo stylo;
        Boolean pagesSontAffiche = false;

        public static List<String> getPages()
        {
            return pages;
        }

        public static List<String> getTitres()
        {
            return titres;
        }

        public MainWindow()
        {
            InitializeComponent();

            cloud = new Cloud();
            cloud.Show();
            stylo = new Stylo(this);
            stylo.Show();

            this.Title = "Page 1";
            numpage.Text = "Page " + (index + 1);

            titres.Add("AEL");
            titres.Add("AEO");
            titres.Add("IHM");
            titres.Add("GL");
            titres.Add("COO");
            titres.Add("BL");
            titres.Add("CAR");

            pages.Add("Lorem ipsum dolor sit amet, consectetur adipiscing elit. \n Fusce sit amet venenatis augue.  \n Sed commodo sem eu nibh laoreet faucibus. In congue diam ligula, nec pellentesque ante mollis at.");
            pages.Add("Morbi placerat nibh eros, eget fermentum nulla cursus non. Cras sit amet justo eleifend nibh feugiat dapibus eget quis metus.");
            pages.Add("Duis aliquet vel ligula sagittis mollis. Nam sollicitudin venenatis felis, eu fringilla nisl bibendum ullamcorper. Praesent aliquet varius nunc, a pharetra orci bibendum ac. \n  Praesent et elementum est. Ut vitae malesuada nisi, sed tincidunt diam.  \n Suspendisse fringilla blandit mauris nec porttitor.  \n Cras sed est vel metus gravida malesuada.  \n Cras sed est vel metus gravida malesuada.  \n Cras sed est vel metus gravida malesuada.  \n  Cras sed est vel metus gravida malesuada. \n  Cras sed est vel metus gravida malesuada.  \n Cras sed est vel metus gravida malesuada.  \n Cras sed est vel metus gravida malesuada.");
            pages.Add("Aliquam iaculis quam ipsum, ut underlined eros vulputate eget. Proin vitae vestibulum lorem");
            pages.Add("");

            feuille.Visibility = Visibility.Hidden;
            drawFolder();
        }
        
        private void pagesuivante_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            pages[index] = feuille.Text;

            if (pages.Count - 1 == index)
            {
                feuille.Text = "";
                //titre.Text = "";
                index++;
                pages.Add("");
                //titres.Add("");
            }
            else
            {
                index++;
                feuille.Text = pages[index];
                //titre.Text = titres[index];
            }

            this.Title = "Page "+ (index+1);
            numpage.Text = "Page " + (index + 1);

            gifImageDroite.StartAnimation();
            gifImageGauche.Visibility = Visibility.Hidden;
            gifImageDroite.Visibility = Visibility.Visible;
        }

        private void pageprecedente_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            pages[index] = feuille.Text;
            if (index != 0)
            {
                index--;
            }            
            feuille.Text = pages[index];
            //titre.Text = titres[index];
            this.Title = "Page " + (index+1);
            numpage.Text = "Page " + (index + 1);

            gifImageGauche.StartAnimation();
            gifImageGauche.Visibility = Visibility.Visible;
            gifImageDroite.Visibility = Visibility.Hidden;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            cloud.Close();
            stylo.Close();
        }

        public void drawFolder()
        {
            int i = 0;
            int j = 0;
            foreach(String s in titres){
                TextBlock txtBlock = new TextBlock();
                txtBlock.Text = s;
                txtBlock.Margin = new Thickness(6) ;
                txtBlock.Background = Brushes.LightGray;
                txtBlock.FontFamily = titre.FontFamily;
                txtBlock.FontSize = titre.FontSize;
                txtBlock.TextWrapping = TextWrapping.Wrap;
                txtBlock.TextAlignment = TextAlignment.Center;
                dossierGrid.Children.Add(txtBlock);
                Grid.SetColumn(txtBlock, i);
                Grid.SetRow(txtBlock, j);
                i++;
                if(i == 4)
                {
                    i = 0;
                    j++;
                }
            }
            feuille.Visibility = Visibility.Hidden;
            titre.Visibility = Visibility.Hidden;
            numpage.Visibility = Visibility.Hidden;
            pageprecedente.Visibility = Visibility.Hidden;
            pagesuivante.Visibility = Visibility.Hidden;
        }

        public void drawPages()
        {
            int i = 0;
            int j = 0;
            foreach (String s in pages)
            {
                TextBlock txtBlock = new TextBlock();
                txtBlock.Text = s;
                txtBlock.Margin = new Thickness(6);
                txtBlock.Background = Brushes.LightGray;
                txtBlock.FontFamily = titre.FontFamily;
                txtBlock.FontSize = 3;             
                dossierGrid.Children.Add(txtBlock);
                Grid.SetColumn(txtBlock, i);
                Grid.SetRow(txtBlock, j);
                i++;
                if (i == 4)
                {
                    i = 0;
                    j++;
                }
            }
        }

        private void dossierGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //TextBlock tb = sender as TextBlock;
            //index = dossierGrid.Children.IndexOf(tb);

            if (pagesSontAffiche)
            {
                feuille.Visibility = Visibility.Visible;
                titre.Visibility = Visibility.Visible;
                numpage.Visibility = Visibility.Visible;
                pageprecedente.Visibility = Visibility.Visible;
                pagesuivante.Visibility = Visibility.Visible;

                pagesSontAffiche = false;
                dossierGrid.Children.Clear();

                index = 2;
                feuille.Text = pages[index];
                titre.Text = titres[index];
                numpage.Text = "Page " + (index + 1);
            }
            else
            {
                dossierGrid.Children.Clear();
                drawPages();
                pagesSontAffiche = true;
            }
        }
    }
}
