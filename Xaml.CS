/// Ian Markham
/// February 22nd
/// U1_03IanComputer
/// Click buttons to show computer part details
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

namespace U1_03IanComputer
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

        private void btnprcr_Click(object sender, RoutedEventArgs e)
        {
            imgprcr.Visibility = System.Windows.Visibility.Visible;
            lblprcr.Visibility = System.Windows.Visibility.Visible;
            imgmom.Visibility = System.Windows.Visibility.Hidden;
            lblmom.Visibility = System.Windows.Visibility.Hidden;
            imgram.Visibility = System.Windows.Visibility.Hidden;
            lblram.Visibility = System.Windows.Visibility.Hidden;
            imgssd.Visibility = System.Windows.Visibility.Hidden;
            lblssd.Visibility = System.Windows.Visibility.Hidden;
            imgcase.Visibility = System.Windows.Visibility.Hidden;
            lblcase.Visibility = System.Windows.Visibility.Hidden;
            imgpwr.Visibility = System.Windows.Visibility.Hidden;
            lblpwr.Visibility = System.Windows.Visibility.Hidden;
            imggrph.Visibility = System.Windows.Visibility.Hidden;
            lblgrph.Visibility = System.Windows.Visibility.Hidden;
            imgmonitor.Visibility = System.Windows.Visibility.Hidden;
            lblmonitor.Visibility = System.Windows.Visibility.Hidden;
            imghdd.Visibility = System.Windows.Visibility.Hidden;
            lblhdd.Visibility = System.Windows.Visibility.Hidden;
        }

        private void btnmom_Click(object sender, RoutedEventArgs e)
        {
            imgmom.Visibility = System.Windows.Visibility.Visible;
            lblmom.Visibility = System.Windows.Visibility.Visible;
            imgprcr.Visibility = System.Windows.Visibility.Hidden;
            lblprcr.Visibility = System.Windows.Visibility.Hidden;
            imgram.Visibility = System.Windows.Visibility.Hidden;
            lblram.Visibility = System.Windows.Visibility.Hidden;
            imgssd.Visibility = System.Windows.Visibility.Hidden;
            lblssd.Visibility = System.Windows.Visibility.Hidden;
            imgcase.Visibility = System.Windows.Visibility.Hidden;
            lblcase.Visibility = System.Windows.Visibility.Hidden;
            imgpwr.Visibility = System.Windows.Visibility.Hidden;
            lblpwr.Visibility = System.Windows.Visibility.Hidden;
            imggrph.Visibility = System.Windows.Visibility.Hidden;
            lblgrph.Visibility = System.Windows.Visibility.Hidden;
            imgmonitor.Visibility = System.Windows.Visibility.Hidden;
            lblmonitor.Visibility = System.Windows.Visibility.Hidden;
            imghdd.Visibility = System.Windows.Visibility.Hidden;
            lblhdd.Visibility = System.Windows.Visibility.Hidden;
        }

        private void btnram_Click(object sender, RoutedEventArgs e)
        {
            imgram.Visibility = System.Windows.Visibility.Visible;
            lblram.Visibility = System.Windows.Visibility.Visible;
            imgmom.Visibility = System.Windows.Visibility.Hidden;
            lblmom.Visibility = System.Windows.Visibility.Hidden;
            imgprcr.Visibility = System.Windows.Visibility.Hidden;
            lblprcr.Visibility = System.Windows.Visibility.Hidden;
            imgssd.Visibility = System.Windows.Visibility.Hidden;
            lblssd.Visibility = System.Windows.Visibility.Hidden;
            imgcase.Visibility = System.Windows.Visibility.Hidden;
            lblcase.Visibility = System.Windows.Visibility.Hidden;
            imgpwr.Visibility = System.Windows.Visibility.Hidden;
            lblpwr.Visibility = System.Windows.Visibility.Hidden;
            imggrph.Visibility = System.Windows.Visibility.Hidden;
            lblgrph.Visibility = System.Windows.Visibility.Hidden;
            imgmonitor.Visibility = System.Windows.Visibility.Hidden;
            lblmonitor.Visibility = System.Windows.Visibility.Hidden;
            imghdd.Visibility = System.Windows.Visibility.Hidden;
            lblhdd.Visibility = System.Windows.Visibility.Hidden;
        }

        private void btnssd_Click(object sender, RoutedEventArgs e)
        {
            imgssd.Visibility = System.Windows.Visibility.Visible;
            lblssd.Visibility = System.Windows.Visibility.Visible;
            imgmom.Visibility = System.Windows.Visibility.Hidden;
            lblmom.Visibility = System.Windows.Visibility.Hidden;
            imgprcr.Visibility = System.Windows.Visibility.Hidden;
            lblprcr.Visibility = System.Windows.Visibility.Hidden;
            imgram.Visibility = System.Windows.Visibility.Hidden;
            lblram.Visibility = System.Windows.Visibility.Hidden;
            imgcase.Visibility = System.Windows.Visibility.Hidden;
            lblcase.Visibility = System.Windows.Visibility.Hidden;
            imgpwr.Visibility = System.Windows.Visibility.Hidden;
            lblpwr.Visibility = System.Windows.Visibility.Hidden;
            imggrph.Visibility = System.Windows.Visibility.Hidden;
            lblgrph.Visibility = System.Windows.Visibility.Hidden;
            imgmonitor.Visibility = System.Windows.Visibility.Hidden;
            lblmonitor.Visibility = System.Windows.Visibility.Hidden;
            imghdd.Visibility = System.Windows.Visibility.Hidden;
            lblhdd.Visibility = System.Windows.Visibility.Hidden;
        }

        private void btncase_Click(object sender, RoutedEventArgs e)
        {
            imgcase.Visibility = System.Windows.Visibility.Visible;
            lblcase.Visibility = System.Windows.Visibility.Visible;
            imgmom.Visibility = System.Windows.Visibility.Hidden;
            lblmom.Visibility = System.Windows.Visibility.Hidden;
            imgprcr.Visibility = System.Windows.Visibility.Hidden;
            lblprcr.Visibility = System.Windows.Visibility.Hidden;
            imgram.Visibility = System.Windows.Visibility.Hidden;
            lblram.Visibility = System.Windows.Visibility.Hidden;
            imgssd.Visibility = System.Windows.Visibility.Hidden;
            lblssd.Visibility = System.Windows.Visibility.Hidden;
            imgpwr.Visibility = System.Windows.Visibility.Hidden;
            lblpwr.Visibility = System.Windows.Visibility.Hidden;
            imggrph.Visibility = System.Windows.Visibility.Hidden;
            lblgrph.Visibility = System.Windows.Visibility.Hidden;
            imgmonitor.Visibility = System.Windows.Visibility.Hidden;
            lblmonitor.Visibility = System.Windows.Visibility.Hidden;
            imghdd.Visibility = System.Windows.Visibility.Hidden;
            lblhdd.Visibility = System.Windows.Visibility.Hidden;
        }

        private void btnpwr_Click(object sender, RoutedEventArgs e)
        {
            imgpwr.Visibility = System.Windows.Visibility.Visible;
            lblpwr.Visibility = System.Windows.Visibility.Visible;
            imgmom.Visibility = System.Windows.Visibility.Hidden;
            lblmom.Visibility = System.Windows.Visibility.Hidden;
            imgprcr.Visibility = System.Windows.Visibility.Hidden;
            lblprcr.Visibility = System.Windows.Visibility.Hidden;
            imgram.Visibility = System.Windows.Visibility.Hidden;
            lblram.Visibility = System.Windows.Visibility.Hidden;
            imgssd.Visibility = System.Windows.Visibility.Hidden;
            lblssd.Visibility = System.Windows.Visibility.Hidden;
            imgcase.Visibility = System.Windows.Visibility.Hidden;
            lblcase.Visibility = System.Windows.Visibility.Hidden;
            imggrph.Visibility = System.Windows.Visibility.Hidden;
            lblgrph.Visibility = System.Windows.Visibility.Hidden;
            imgmonitor.Visibility = System.Windows.Visibility.Hidden;
            lblmonitor.Visibility = System.Windows.Visibility.Hidden;
            imghdd.Visibility = System.Windows.Visibility.Hidden;
            lblhdd.Visibility = System.Windows.Visibility.Hidden;
        }

        private void btngrph_Click(object sender, RoutedEventArgs e)
        {
            imggrph.Visibility = System.Windows.Visibility.Visible;
            lblgrph.Visibility = System.Windows.Visibility.Visible;
            imgmom.Visibility = System.Windows.Visibility.Hidden;
            lblmom.Visibility = System.Windows.Visibility.Hidden;
            imgprcr.Visibility = System.Windows.Visibility.Hidden;
            lblprcr.Visibility = System.Windows.Visibility.Hidden;
            imgram.Visibility = System.Windows.Visibility.Hidden;
            lblram.Visibility = System.Windows.Visibility.Hidden;
            imgssd.Visibility = System.Windows.Visibility.Hidden;
            lblssd.Visibility = System.Windows.Visibility.Hidden;
            imgcase.Visibility = System.Windows.Visibility.Hidden;
            lblcase.Visibility = System.Windows.Visibility.Hidden;
            imgpwr.Visibility = System.Windows.Visibility.Hidden;
            lblpwr.Visibility = System.Windows.Visibility.Hidden;
            imgmonitor.Visibility = System.Windows.Visibility.Hidden;
            lblmonitor.Visibility = System.Windows.Visibility.Hidden;
            imghdd.Visibility = System.Windows.Visibility.Hidden;
            lblhdd.Visibility = System.Windows.Visibility.Hidden;
        }

        private void btnmonitor_Click(object sender, RoutedEventArgs e)
        {
            imgmonitor.Visibility = System.Windows.Visibility.Visible;
            lblmonitor.Visibility = System.Windows.Visibility.Visible;
            imgmom.Visibility = System.Windows.Visibility.Hidden;
            lblmom.Visibility = System.Windows.Visibility.Hidden;
            imgprcr.Visibility = System.Windows.Visibility.Hidden;
            lblprcr.Visibility = System.Windows.Visibility.Hidden;
            imgram.Visibility = System.Windows.Visibility.Hidden;
            lblram.Visibility = System.Windows.Visibility.Hidden;
            imgssd.Visibility = System.Windows.Visibility.Hidden;
            lblssd.Visibility = System.Windows.Visibility.Hidden;
            imgcase.Visibility = System.Windows.Visibility.Hidden;
            lblcase.Visibility = System.Windows.Visibility.Hidden;
            imgpwr.Visibility = System.Windows.Visibility.Hidden;
            lblpwr.Visibility = System.Windows.Visibility.Hidden;
            imggrph.Visibility = System.Windows.Visibility.Hidden;
            lblgrph.Visibility = System.Windows.Visibility.Hidden;
            imghdd.Visibility = System.Windows.Visibility.Hidden;
            lblhdd.Visibility = System.Windows.Visibility.Hidden;
        }

        private void btnhdd_Click(object sender, RoutedEventArgs e)
        {
            imghdd.Visibility = System.Windows.Visibility.Visible;
            lblhdd.Visibility = System.Windows.Visibility.Visible;
            imgmom.Visibility = System.Windows.Visibility.Hidden;
            lblmom.Visibility = System.Windows.Visibility.Hidden;
            imgprcr.Visibility = System.Windows.Visibility.Hidden;
            lblprcr.Visibility = System.Windows.Visibility.Hidden;
            imgram.Visibility = System.Windows.Visibility.Hidden;
            lblram.Visibility = System.Windows.Visibility.Hidden;
            imgssd.Visibility = System.Windows.Visibility.Hidden;
            lblssd.Visibility = System.Windows.Visibility.Hidden;
            imgcase.Visibility = System.Windows.Visibility.Hidden;
            lblcase.Visibility = System.Windows.Visibility.Hidden;
            imgpwr.Visibility = System.Windows.Visibility.Hidden;
            lblpwr.Visibility = System.Windows.Visibility.Hidden;
            imggrph.Visibility = System.Windows.Visibility.Hidden;
            lblgrph.Visibility = System.Windows.Visibility.Hidden;
            imgmonitor.Visibility = System.Windows.Visibility.Hidden;
            lblmonitor.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
