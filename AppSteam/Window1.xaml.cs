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
using System.Windows.Navigation;

namespace JDVAPP
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
       
        public Window1()
        {
            InitializeComponent();
           
        }

        private void siguienteventana(object sender, RoutedEventArgs e)
        {
            Seleccion sele = new Seleccion();
            this.Visibility = Visibility.Hidden;
            sele.Show();

        }
        private void siguienteDOS(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            this.Visibility = Visibility.Hidden;
            window2.Show();


        }

        private void siguienteAjustes(object sender, RoutedEventArgs e)
        {
            Ajustes ajus = new Ajustes();
            this.Visibility = Visibility.Hidden;
            ajus.Show();
        }

    } 
}

