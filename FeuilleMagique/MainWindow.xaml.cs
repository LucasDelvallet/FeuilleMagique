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
using System.Windows.Resources;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<List<String>> pages = new List<List<string>>();
        public static List<String> dossiers = new List<string>();
        public int indexPages = 0;
        public int indexDossier = 0;

        Cloud cloud ;
        Stylo stylo;
       public bool pagesSontAffiche = false;

        public static List<List<String>> getPages()
        {
            return pages;
        }

        public static List<String> getDossiers()
        {
            return dossiers;
        }

        public MainWindow()
        {
            InitializeComponent();
            Application.Current.MainWindow.WindowState = WindowState.Maximized;

            cloud = new Cloud(this);
            cloud.Topmost = true;
            cloud.Show();
            stylo = new Stylo(this);
            stylo.Topmost = true;
            stylo.Show();

            double W = System.Windows.SystemParameters.FullPrimaryScreenWidth;
            double H = System.Windows.SystemParameters.FullPrimaryScreenHeight;

            cloud.Left = W - cloud.Width ;
            cloud.Top = 50;

            stylo.Left = W - stylo.Width;
            stylo.Top = 50 + cloud.Height + cloud.Top;


            numpage.Text = "Page " + (indexPages + 1);

            dossiers.Add("AEL"); pages.Add(new List<String>());
            dossiers.Add("AEO"); pages.Add(new List<String>());
            dossiers.Add("IHM"); pages.Add(new List<String>());
            dossiers.Add("GL"); pages.Add(new List<String>());
            dossiers.Add("COO"); pages.Add(new List<String>());
            dossiers.Add("BL"); pages.Add(new List<String>());
            dossiers.Add("CAR"); pages.Add(new List<String>());

            pages[0].Add("Lorem ipsum dolor sit amet, consectetur adipiscing elit. \n Fusce sit amet venenatis augue.  \n Sed commodo sem eu nibh laoreet faucibus. In congue diam ligula, nec pellentesque ante mollis at.");
            pages[0].Add("Morbi placerat nibh eros, eget fermentum nulla cursus non. Cras sit amet justo eleifend nibh feugiat dapibus eget quis metus.");
            pages[0].Add("Duis aliquet vel ligula sagittis mollis. Nam sollicitudin venenatis felis, eu fringilla nisl bibendum ullamcorper. Praesent aliquet varius nunc, a pharetra orci bibendum ac. \n  Praesent et elementum est. Ut vitae malesuada nisi, sed tincidunt diam.  \n Suspendisse fringilla blandit mauris nec porttitor.  \n Cras sed est vel metus gravida malesuada.  \n Cras sed est vel metus gravida malesuada.  \n Cras sed est vel metus gravida malesuada.  \n  Cras sed est vel metus gravida malesuada. \n  Cras sed est vel metus gravida malesuada.  \n Cras sed est vel metus gravida malesuada.  \n Cras sed est vel metus gravida malesuada.");
            pages[0].Add("Aliquam iaculis quam ipsum, ut underlined eros vulputate eget. Proin vitae vestibulum lorem");
            pages[0].Add("");

            pages[1].Add("ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN \n ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN \n ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN \n ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN \n ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN \n ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN \n ");
            pages[1].Add("ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN \n ");
            pages[1].Add("ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN \n ");
            pages[1].Add("ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN \n ");
            pages[1].Add("ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN \n ");
            pages[1].Add("ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN \n ");
            pages[1].Add("ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN \n ");
            pages[1].Add("ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN \n ");
            pages[1].Add("ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN ANPAN \n ");
            pages[1].Add("");

            pages[2].Add("nte mollis at.");
            pages[2].Add("Morbi placerat nibh eus eget quis metus.");
            pages[2].Add("Duis aliquetndum ac. \n  Praesent encidunt diam.  \n Suspendisse fring \n Cras sed est vel metus gravida malesuada.  \n Cras sed est vel metus gravida malesuada.  \n Cras sed est vel metus gravida malesuada.  \n  Cras sed est vel metus gravida malesuada. \n  Cras sed est vel metus gravida malesuada.  \n Cras sed est vel metus gravida malesuada.  \n Cras sed est vel metus gravida malesuada.");
            pages[2].Add("Aliquam os vulputate eget. Proin vitae vestibulum lorem");
            pages[2].Add("");

            pages[3].Add("Lorem ipsum dolor sit ametras sit amet justo eleifend nibh feugiat dapibus eget quis metus.");
            pages[3].Add("Denenatis felis, eu fringilla nisl bibendum ullamcorper. Praesent aliquet varius nunc, a pharetra orci bibendum ac. \n  Praesent et elementum est. Ut vitae malesuada nisi, sed tincidunt diam.  \n Suspendisse fringilla blandit mauris nec porttitor.  \n Cras sed est vel metus gravida malesuada.  \n Cras sed est vel metus gravida malesuada.  \n Cras sed est vel metus gravida malesuada.  \n  Cras sed est vel metus gravida malesuada. \n  Cras sed est vel metus gravida malesuada.  \n Cras sed est vel metus gravida malesuada.  \n Cras sed est vel metus gravida malesuada.");
            pages[3].Add("Al");
            pages[3].Add("");

            pages[4].Add("Bouh.");
            pages[4].Add("");

            pages[5].Add("Lorem ipsum dolor sit amet, consectetur adipiscing elit. \n Fusce sit amet venenatis augue.  \n Sed commodo sem eu nibh laoreet faucibus. In congue diam ligula, nec pellentesque ante mollis at.");
            pages[5].Add("Aliquam iaculis quam ipsum, ut underlined eros vulputate eget. Proin vitae vestibulum lorem");
            pages[5].Add("");

            pages[6].Add("Lorem ipsum dolor sit amet, consectetur adipiscing elit. ");
            pages[6].Add("");


            feuille.Visibility = Visibility.Hidden;
            drawFolder();

            gifImageDroite.mainWindow = this;
            gifImageDroite.isPageSuivante = true;
            gifImageGauche.mainWindow = this;
            gifImageGauche.isPageSuivante = false;
        }
        
        private void pagesuivante_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            titre.Visibility = Visibility.Hidden;
            numpage.Visibility = Visibility.Hidden;
            feuille.Visibility = Visibility.Hidden;
            pagesNaviguer.Visibility = Visibility.Hidden;
            ScrollPagesNaviguer.Visibility = Visibility.Hidden;

            gifImageDroite.StartAnimation();
            gifImageGauche.Visibility = Visibility.Hidden;
            gifImageDroite.Visibility = Visibility.Visible;
        }

        public void displayPageSuivante()
        {
            titre.Visibility = Visibility.Visible;
            numpage.Visibility = Visibility.Visible;
            feuille.Visibility = Visibility.Visible;
            pagesNaviguer.Visibility = Visibility.Visible;
            ScrollPagesNaviguer.Visibility = Visibility.Visible;

            pages[indexDossier][indexPages] = feuille.Text;

            if (pages[indexDossier].Count - 1 == indexPages)
            {
                feuille.Text = "";
                //titre.Text = "";
                indexPages++;
                pages[indexDossier].Add("");
                //titres.Add("");
            }
            else
            {
                indexPages++;
                feuille.Text = pages[indexDossier][indexPages];
                //titre.Text = titres[index];
            }
            
            numpage.Text = "Page " + (indexPages + 1);
            updatePagesNaviguer();
        }

        private void pageprecedente_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            titre.Visibility = Visibility.Hidden;
            numpage.Visibility = Visibility.Hidden;
            feuille.Visibility = Visibility.Hidden;
            pagesNaviguer.Visibility = Visibility.Hidden;
            ScrollPagesNaviguer.Visibility = Visibility.Hidden;

            gifImageGauche.StartAnimation();
            gifImageGauche.Visibility = Visibility.Visible;
            gifImageDroite.Visibility = Visibility.Hidden;
        }

        public void displayPagePrecedente()
        {
            titre.Visibility = Visibility.Visible;
            numpage.Visibility = Visibility.Visible;
            feuille.Visibility = Visibility.Visible;
            pagesNaviguer.Visibility = Visibility.Visible;
            ScrollPagesNaviguer.Visibility = Visibility.Visible;

            pages[indexDossier][indexPages] = feuille.Text;
            if (indexPages != 0)
            {
                indexPages--;
            }
            feuille.Text = pages[indexDossier][indexPages];
            //titre.Text = titres[index];
            numpage.Text = "Page " + (indexPages + 1);
            updatePagesNaviguer();
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
            foreach (String s in dossiers){
                int locali = i;
                int localj = j;
                Panel pnl = new WrapPanel();
                pnl.Width = 100;
                pnl.Height = 100;

                Image img = new Image();
                var uriSource = new Uri(@"/FeuilleMagique;component/Images/folder.png", UriKind.Relative);
                img.Source = new BitmapImage(uriSource);
                img.Width = 100;
                img.Height = 60;

                TextBlock txtBlock = new TextBlock();
                txtBlock.Text = s;
                txtBlock.Margin = new Thickness(6) ;
                txtBlock.FontFamily = titre.FontFamily;
                txtBlock.FontSize = titre.FontSize;
                txtBlock.TextWrapping = TextWrapping.Wrap;
                txtBlock.TextAlignment = TextAlignment.Center;

                pnl.MouseDown += new MouseButtonEventHandler(delegate (object sender, MouseButtonEventArgs e)
                {
                    indexDossier = locali + (localj*4);
                });

                pnl.Children.Add(img);
                pnl.Children.Add(txtBlock);

                dossierGrid.Children.Add(pnl);
                Grid.SetColumn(pnl, i);
                Grid.SetRow(pnl, j);
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
            pagesNaviguer.Visibility = Visibility.Hidden;
            ScrollPagesNaviguer.Visibility = Visibility.Hidden;
            dossierGrid.Visibility = Visibility.Visible;
        }

        public void drawPages()
        {
            int i = 0;
            int j = 0;
            foreach (String s in pages[indexDossier])
            {
                Uri resourceUri = new Uri("Images/feuilleCarreau.gif", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;

                TextBlock txtBlock = new TextBlock();
                txtBlock.Text = s;
                txtBlock.Margin = new Thickness(6);
                txtBlock.Background = brush;
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

            titre.Text = dossiers[indexDossier];
            titre.Visibility = Visibility.Visible;
            titre.IsEnabled = false;
        }

        public void afficher_Page_Selectionne()
        {
            titre.IsEnabled = true;
            feuille.Visibility = Visibility.Visible;
            titre.Visibility = Visibility.Visible;
            numpage.Visibility = Visibility.Visible;
            pageprecedente.Visibility = Visibility.Visible;
            pagesuivante.Visibility = Visibility.Visible;
            pagesNaviguer.Visibility = Visibility.Visible;
            ScrollPagesNaviguer.Visibility = Visibility.Visible;
            dossierGrid.Visibility = Visibility.Hidden;

            pagesSontAffiche = false;
            dossierGrid.Children.Clear();

            feuille.Text = pages[indexDossier][indexPages];
            titre.Text = dossiers[indexDossier];
            numpage.Text = "Page " + (indexPages + 1);
            updatePagesNaviguer();
        }

        private void dossierGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //TextBlock tb = sender as TextBlock;
            //index = dossierGrid.Children.IndexOf(tb);

            if (pagesSontAffiche)
            {
                afficher_Page_Selectionne();
            }
            else
            {
                dossierGrid.Children.Clear();
                drawPages();
                pagesSontAffiche = true;
            }
        }

        private void updatePagesNaviguer()
        {
            int i = 0;
            pagesNaviguer.Children.Clear();
            foreach (String s in pages[indexDossier])
            {
                int locali = i;
                Uri resourceUri = new Uri("Images/feuilleCarreau.gif", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;

                TextBlock txtBlock = new TextBlock();
                txtBlock.Width = 50;
                txtBlock.Height = 80;
                txtBlock.Text = s;
                txtBlock.Margin = new Thickness(6,1,6,0);
                txtBlock.Background = brush;
                txtBlock.FontFamily = new FontFamily("Freestyle Script");
                txtBlock.FontSize = 3;
                txtBlock.TextWrapping = TextWrapping.Wrap;
                if (i == indexPages)
                {
                    txtBlock.Background = Brushes.Yellow;
                }
                
                txtBlock.MouseDown += new MouseButtonEventHandler(delegate (object sender, MouseButtonEventArgs e)
                {
                    indexPages = locali;
                });

                pagesNaviguer.Children.Add(txtBlock);
                i++;
            }
        }


        private void GridElementClick(object sender, RoutedEventArgs e)
        {
            Control _btn = sender as Control;

            int _row = (int)_btn.GetValue(Grid.RowProperty);
            int _column = (int)_btn.GetValue(Grid.ColumnProperty);
        }

        private void pagesNaviguer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            feuille.Visibility = Visibility.Visible;
            titre.Visibility = Visibility.Visible;
            numpage.Visibility = Visibility.Visible;
            pageprecedente.Visibility = Visibility.Visible;
            pagesuivante.Visibility = Visibility.Visible;
            pagesNaviguer.Visibility = Visibility.Visible;
            ScrollPagesNaviguer.Visibility = Visibility.Visible;

            pagesSontAffiche = false;
            dossierGrid.Children.Clear();

            feuille.Text = pages[indexDossier][indexPages];
            titre.Text = dossiers[indexDossier];
            numpage.Text = "Page " + (indexPages + 1);
            updatePagesNaviguer();
        }

        private void titre_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (feuille.Visibility == Visibility.Visible)
            {
                String t = ((TextBox)sender).Text;
                if (dossiers.Contains(t))
                {
                    pages[indexDossier].RemoveAt(indexPages);
                    if (pages[indexDossier].Count == 0) { 
                        dossiers.RemoveAt(indexDossier);
                        pages.RemoveAt(indexDossier);
                    }

                    indexDossier = dossiers.IndexOf(t);
                    indexPages = pages[indexDossier].Count;

                    /*if (pages[indexDossier].Last().Equals(""))
                    {
                        pages[indexDossier].RemoveAt(pages[indexDossier].Count - 1);
                        indexPages--;
                    }*/
                    pages[indexDossier].Add(feuille.Text);
                    afficher_Page_Selectionne();
                }
                else
                {
                    dossiers.Add(t);
                    pages.Add(new List<String>());
                    pages[dossiers.Count - 1].Add(feuille.Text);

                    pages[indexDossier].RemoveAt(indexPages);
                    if (pages[indexDossier].Count == 0)
                    {
                        dossiers.RemoveAt(indexDossier);
                        pages.RemoveAt(indexDossier);
                    }

                    indexDossier = dossiers.Count - 1;
                    indexPages = 0;
                    afficher_Page_Selectionne();
                }
            }

        }
    }
}
