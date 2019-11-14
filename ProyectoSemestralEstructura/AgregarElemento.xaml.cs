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

namespace ProyectoSemestralEstructura
{
    /// <summary>
    /// Lógica de interacción para AgregarElemento.xaml
    /// </summary>
    public partial class AgregarElemento : UserControl
    {
        public AgregarElemento()
        {
            InitializeComponent();
            
            
        }

        private void RdbtnPelicula_Checked(object sender, RoutedEventArgs e)
        {
                grdPeliculaSerie.Children.Clear();
                grdPeliculaSerie.Children.Add(new usrpelicula());
        }

        private void RdbtnSerie_Checked(object sender, RoutedEventArgs e)
        {
            grdPeliculaSerie.Children.Clear();
            grdPeliculaSerie.Children.Add(new usrSerie());
        }
    }
  

}
