using System;
using System.Collections.Generic;
using System.Drawing;
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



namespace AppSteam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Seleccion: Window
    {
        public Seleccion()
        {
            InitializeComponent();
           
        }
        List<string> rutasImagenes = new List<string> { "UD Almeria.png","Athletic.png","Atm.png","FCB.png","betis.png","cadiz.png","celta.png","elche.png","espanyol.png","getafe.png","girona.png","mallorca.png","osasuna.png","rayoo.png","real madrid.png","real sociedad.png","sevilla.png","valencia.png","valladolid.png","villareal.png" };
        int indice = 0;

        private void MostrarSiguienteImagen(object sender, RoutedEventArgs e)
        {
            if (indice == rutasImagenes.Count)
            {
                indice = 0;
            }

            imagen.Source = new BitmapImage(new Uri(rutasImagenes[indice], UriKind.Relative));
            indice++;
        }
        private void MostrarImagenAnterior(object sender, RoutedEventArgs e)
        {
            indice--;

            if (indice < 0)
            {
                indice = rutasImagenes.Count - 1;
            }

            imagen.Source = new BitmapImage(new Uri(rutasImagenes[indice], UriKind.Relative));
        }
        private void VolverAtras(object sender, RoutedEventArgs e)
        {

            Window1 window1 = new Window1();
            this.Visibility = Visibility.Hidden;
            window1.Show();



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            this.Visibility = Visibility.Hidden;
            window4.Show();
        }
    }

}
