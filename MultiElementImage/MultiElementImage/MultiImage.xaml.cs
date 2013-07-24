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
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class MultiImage : UserControl
    {
        public MultiImage()
        {
            InitializeComponent();

            //this.mainIcon = new Image();
            //this.mainIcon.Source = new BitmapImage(new Uri("Images/laptop.png", UriKind.Relative));
            //this.statusIcon = new Image();
            //this.statusIcon.Source = new BitmapImage(new Uri("Images/warning.png", UriKind.Relative));
        }
    }
}
