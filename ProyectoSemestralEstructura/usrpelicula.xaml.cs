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
    /// Lógica de interacción para usrpelicula.xaml
    /// </summary>
    public partial class usrpelicula : UserControl
    {
        public usrpelicula()
        {
            InitializeComponent();

           

        }
        string Titulopeli { get; set; }
        int Yearpeli { get; set; }
        string Descripcionpeli { get; set; }
        string Generopeli { get; set; }
        string DirectorPeli { get; set; }
        string Rantingpeli { get; set; }

        public void probar (string titulopeli, int yearpeli, string descripcionpeli, string generopeli, string directorpeli, string rantingpeli)
        {
            this.Titulopeli = titulopeli;
            this.Yearpeli = yearpeli;
            this.Descripcionpeli = descripcionpeli;
            this.Generopeli = generopeli;
            this.DirectorPeli = directorpeli;
            this.Rantingpeli = rantingpeli;

            titulopeli = txtTitulo.Text;
            yearpeli = int.Parse(txtYear.Text);
            descripcionpeli = txtDescripcion.Text;
            generopeli = cbGenero.Text;
            directorpeli = txtProductor.Text;
            rantingpeli = cbRanting.Text;
           
        }
    }
}
