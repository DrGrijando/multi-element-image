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

namespace MultiElementImage
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {        
            InitializeComponent();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            image1.mainIcon.Source = new BitmapImage(new Uri("Images/laptop.png", UriKind.Relative));
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {           
            image1.mainIcon.Source = new BitmapImage(new Uri("Images/trashcan.png", UriKind.Relative));
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            image1.statusIcon.Source = new BitmapImage(new Uri("Images/warning.png", UriKind.Relative));
        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            image1.statusIcon.Source = new BitmapImage(new Uri("Images/battery.png", UriKind.Relative));
        }

        private void RadioButton_Checked_5(object sender, RoutedEventArgs e)
        {
            image1.statusIcon.Source = new BitmapImage(new Uri("Images/null.png", UriKind.Relative));
        }
    }
}
