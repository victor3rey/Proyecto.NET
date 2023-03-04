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

namespace AppSteam
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
       
        public Window2()
        {
            InitializeComponent();
        }

        List<string> rutasImagenes = new List<string> { "UD Almeria.png", "Athletic.png", "Atm.png", "FCB.png", "betis.png", "cadiz.png", "celta.png", "elche.png", "espanyol.png", "getafe.png", "girona.png", "mallorca.png", "osasuna.png", "rayoo.png", "real madrid.png", "real sociedad.png", "sevilla.png", "valencia.png", "valladolid.png", "villareal.png" };
        int indice = 0;

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
            if (indice == rutasImagenes.Count)
            {
                indice = 0;
            }


            imagen2.Source = new BitmapImage(new Uri(rutasImagenes[indice], UriKind.Relative));
            indice++;
        }
        private void MostrarImagenAnterior3(object sender, RoutedEventArgs e)
        {
            indice--;

            if (indice < 0)
            {
                indice = rutasImagenes.Count - 1;
            }


            imagen2.Source = new BitmapImage(new Uri(rutasImagenes[indice], UriKind.Relative));
        }

        private void VolverAtras(object sender, RoutedEventArgs e)
        {

            Window1 window1 = new Window1();
            this.Visibility = Visibility.Hidden;
            window1.Show();



        }

    }
}

