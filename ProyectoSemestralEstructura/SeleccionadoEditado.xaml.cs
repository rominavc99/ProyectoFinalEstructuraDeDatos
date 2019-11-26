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
    /// Lógica de interacción para SeleccionadoEditado.xaml
    /// </summary>
    public partial class SeleccionadoEditado : UserControl
    {
        public SeleccionadoEditado()
        {
            InitializeComponent();

            txtTituloSD.IsEnabled = false;
            txtDirectorSD.IsEnabled = false;
            txtTemporadasED.IsEnabled = false;
            txtTituloSD.IsEnabled = false;
            cbGeneroSD.IsEnabled = false;
            txtSinopsisED.IsEnabled = false;
            txtYearSD.IsEnabled = false;
            cbRanting.IsEnabled = false;
            txtRantingSD.IsEnabled = false;
        }
    }
}
