using System;
using System.Collections.Generic;
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


        public Cloud()
        {
            InitializeComponent();
            InitTimer();
        }

        private DispatcherTimer timer1;
        public void InitTimer()
        {
            timer1 = new DispatcherTimer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = new TimeSpan(0, 0, 2);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            p = MainWindow.pages;
            t = MainWindow.titres;
            updateCloud();
        }

        private void updateCloud()
        {
            int i = 0, j = 0;
            dossiers.Children.Clear();
            foreach (String s in t)
            {
                TextBlock txtBlock = new TextBlock();
                txtBlock.Width = 100;
                txtBlock.Text = s;
                txtBlock.Margin = new Thickness(6);
                txtBlock.Background = Brushes.LightGray;
                txtBlock.FontFamily = new FontFamily("Freestyle Script");
                txtBlock.FontSize = 25;
                txtBlock.TextWrapping = TextWrapping.Wrap;
                txtBlock.TextAlignment = TextAlignment.Center;
                dossiers.Children.Add(txtBlock);
                i++;
            }

            i = 0;
            j = 0;
            pages.Children.Clear();
            foreach (String s in p)
            {
                TextBlock txtBlock = new TextBlock();
                txtBlock.Width = 100;
                txtBlock.Text = s;
                txtBlock.Margin = new Thickness(6);
                txtBlock.Background = Brushes.LightGray;
                txtBlock.FontFamily = new FontFamily("Freestyle Script");
                txtBlock.FontSize = 3;
                txtBlock.TextWrapping = TextWrapping.Wrap;
                txtBlock.TextAlignment = TextAlignment.Center;
                pages.Children.Add(txtBlock);
                i++;
            }
        }


    }
}
