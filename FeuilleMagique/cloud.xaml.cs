using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApplication1
{
    /// <summary>
    /// Logique d'interaction pour cloud.xaml
    /// </summary>
    public partial class Cloud : Window
    {
        List<String> p;
        List<String> t;
        MainWindow mainWindow;
        int indexDossier = 0;

        public Cloud(MainWindow m)
        {
            InitializeComponent();
            InitTimer();
            mainWindow = m;
        }

        private DispatcherTimer timer1;
        public void InitTimer()
        {
            timer1 = new DispatcherTimer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = new TimeSpan(0, 0, 1);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            p = MainWindow.pages[indexDossier];
            t = MainWindow.dossiers;
            updateCloud();
        }

        private void updateCloud()
        {
            int i = 0, j = 0;
            dossiers.Children.Clear();
            foreach (String s in t)
            {
                int locali = i;
                Panel pnl = new WrapPanel(); 
                pnl.Width = 100;
                pnl.Height = 100;

                Image img = new Image();
                var uriSource = new Uri(@"/FeuilleMagique;component/Images/folder.png", UriKind.Relative);
                img.Source = new BitmapImage(uriSource);
                img.Width = 100;
                img.Height = 60;

                TextBlock txtBlock = new TextBlock();
                txtBlock.Width = 100;
                txtBlock.Text = s;
                txtBlock.Margin = new Thickness(6);
                txtBlock.Background = Brushes.LightGray;
                txtBlock.FontFamily = new FontFamily("Freestyle Script");
                if (i == indexDossier)
                {
                    txtBlock.Background = Brushes.Yellow;
                }

                pnl.MouseDown += new MouseButtonEventHandler(delegate (object sender, MouseButtonEventArgs e)
                {
                    indexDossier = locali;
                    updateCloud();
                });

                txtBlock.FontSize = 25;
                txtBlock.TextWrapping = TextWrapping.Wrap;
                txtBlock.TextAlignment = TextAlignment.Center;

               
                pnl.Children.Add(img);
                pnl.Children.Add(txtBlock);
                dossiers.Children.Add(pnl);
                i++;
            }

            p = MainWindow.pages[indexDossier];
            i = 0;
            j = 0;
            pages.Children.Clear();
            foreach (String s in p)
            {
                int locali = i;
                Uri resourceUri = new Uri("Images/feuilleCarreau.gif", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;


                TextBlock txtBlock = new TextBlock();
                txtBlock.Width = 80;
                txtBlock.Height = 100;
                txtBlock.Text = s;
                txtBlock.Margin = new Thickness(6);
                txtBlock.Background = brush;
                txtBlock.FontFamily = new FontFamily("Freestyle Script");
                txtBlock.FontSize = 3;
                txtBlock.TextWrapping = TextWrapping.Wrap;

                txtBlock.MouseDown += new MouseButtonEventHandler(delegate (object sender, MouseButtonEventArgs e)
                {
                    System.IO.File.WriteAllText(@"test.txt", p[locali]);
                    System.Diagnostics.Process.Start(@"test.txt");
                });
                pages.Children.Add(txtBlock);
                i++;
            }
        }

    }
}
