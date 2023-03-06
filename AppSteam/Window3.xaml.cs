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

namespace JDVAPP
{
    /// <summary>
    /// Lógica de interacción para Window3.xaml
    /// </summary>
    public partial class Ajustes : Window
    {
        public Ajustes()
        {
            InitializeComponent();
        }

        private void VolverAtras(object sender, RoutedEventArgs e)
        {

            Window1 window1 = new Window1();
            this.Visibility = Visibility.Hidden;
            window1.Show();



        }
    }
}
