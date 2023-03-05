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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AppSteam
{
    /// <summary>
    /// Lógica de interacción para Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }


        List<string> rutasImagenes = new List<string> {" almeria2.png", "athletic2.png", "atm2.png", "FCB2.png", "betis2.png", "cadiz2.png", "celta2.png", "elche2.png", "espanyol2.png", "getafe2.png", "girona2.png", "mallorca2.png", "osasuna2.png", "rayoo2.png", "real madrid2.png", "real sociedad2.png", "sevilla2.png", "valencia2.png", "valladolid2.png", "villareal2.png" };
        int indice = 0;
        List<string> rutasImagenes2 = new List<string> { "1min-removebg-preview (1).png", "2min-removebg-preview.png", "3min-removebg-preview.png", "3min-removebg-preview.png", "4min-removebg-preview.png", "4min-removebg-preview.png", "5min-removebg-preview.png", "6min-removebg-preview.png" };
        int indice2 = 0;

        private void MostrarSiguienteImagen2(object sender, RoutedEventArgs e)
        {
            if (indice == rutasImagenes.Count)
            {
                indice = 0;
            }

            imagen.Source = new BitmapImage(new Uri(rutasImagenes[indice], UriKind.Relative));
            indice++;

        }
        private void MostrarImagenAnterior2(object sender, RoutedEventArgs e)
        {
            indice--;

            if (indice < 0)
            {
                indice = rutasImagenes.Count - 1;
            }

            imagen.Source = new BitmapImage(new Uri(rutasImagenes[indice], UriKind.Relative));

        }
        private void MostrarSiguienteImagen3(object sender, RoutedEventArgs e)
        {
            if (indice2 == rutasImagenes2.Count)
            {
                indice2 = 0;
            }

            imagen2.Source = new BitmapImage(new Uri(rutasImagenes2[indice2], UriKind.Relative));
            indice2++;

        }
        private void MostrarImagenAnterior3(object sender, RoutedEventArgs e)
        {
            indice2--;

            if (indice2 < 0)
            {
                indice2 = rutasImagenes2.Count - 1;
            }

            imagen2.Source = new BitmapImage(new Uri(rutasImagenes2[indice2], UriKind.Relative));

        }
        private void VolverAtras(object sender, RoutedEventArgs e)
        {

            Window1 window1 = new Window1();
            this.Visibility = Visibility.Hidden;
            window1.Show();



        }
    }
}
