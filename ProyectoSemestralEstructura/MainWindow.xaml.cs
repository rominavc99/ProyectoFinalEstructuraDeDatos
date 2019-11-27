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
using System.Collections.ObjectModel;

namespace ProyectoSemestralEstructura
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Audiovisual> obras = new ObservableCollection<Audiovisual>();
        public MainWindow()
        {
            InitializeComponent();

            obras.Add(new Audiovisual("Gatos y Perros", 1998, "documental", "5", "alguien", "aqui va una descripcion", "3"));
            obras.Add(new Audiovisual("La era de hielo", 2005, "animada", "5", "alguien", "aqui va una descripcion", "1"));
            obras.Add(new Audiovisual("Penguin", 2007, "documental", "5", "alguien", "aqui va una descripcion", "5"));
            obras.Add(new Audiovisual("Penguin 2", 2009, "documental", "5", "alguien", "aqui va una descripcion", "5"));

            lstViewMain.ItemsSource = obras;

            btnEditar.Visibility = Visibility.Hidden;
            btnGuardar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
            Estrellas1.Visibility = Visibility.Hidden;
            Estrellas2.Visibility = Visibility.Hidden;
            Estrellas3.Visibility = Visibility.Hidden;
            Estrellas4.Visibility = Visibility.Hidden;
            Estrellas5.Visibility = Visibility.Hidden;
            btnGuardar2.Visibility = Visibility.Hidden;
            rdbtnPelicula.Visibility = Visibility.Hidden;
            rdbtnSerie.Visibility = Visibility.Hidden;
            lblTipo.Visibility = Visibility.Hidden;
            btnguardar3.Visibility = Visibility.Hidden;
            lblobligatorio.Visibility = Visibility.Hidden;
            btnEliminar.Visibility = Visibility.Hidden;
            lblserie.Visibility = Visibility.Hidden;
            lblpelicula.Visibility = Visibility.Hidden;
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            
            btnAlfa1.Visibility = Visibility.Hidden;
            btnAlfa2.Visibility = Visibility.Hidden;
            btnNum1.Visibility = Visibility.Hidden;
            btnNum2.Visibility = Visibility.Hidden;
            lblordenar.Visibility = Visibility.Hidden;
            btnEditar.Visibility = Visibility.Hidden;
            Estrellas1.Visibility = Visibility.Hidden;
            Estrellas2.Visibility = Visibility.Hidden;
            Estrellas3.Visibility = Visibility.Hidden;
            Estrellas4.Visibility = Visibility.Hidden;
            Estrellas5.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Visible;
            rdbtnPelicula.Visibility = Visibility.Visible;
            rdbtnSerie.Visibility = Visibility.Visible;
            lblTipo.Visibility = Visibility.Visible;
        }

        private void LstViewMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstViewMain.SelectedIndex != -1)
            {
                btnCancelar.Visibility = Visibility.Visible;
                grdMain.Children.Clear();
                grdMain.Children.Add(new SeleccionadoEditado());
                ((SeleccionadoEditado)(grdMain.Children[0])).txtTituloSD.Text = obras[lstViewMain.SelectedIndex].Titulo;
                ((SeleccionadoEditado)(grdMain.Children[0])).txtGeneroSD.Text = obras[lstViewMain.SelectedIndex].Genero;
                ((SeleccionadoEditado)(grdMain.Children[0])).txtDirectorSD.Text = obras[lstViewMain.SelectedIndex].Productor;
                ((SeleccionadoEditado)(grdMain.Children[0])).txtSinopsisED.Text = obras[lstViewMain.SelectedIndex].Sinopsis;
                ((SeleccionadoEditado)(grdMain.Children[0])).txtYearSD.Text = obras[lstViewMain.SelectedIndex].Year.ToString();
                ((SeleccionadoEditado)(grdMain.Children[0])).txtTemporadasED.Text = obras[lstViewMain.SelectedIndex].Temporadas;
                ((SeleccionadoEditado)(grdMain.Children[0])).txtRantingSD.Text = obras[lstViewMain.SelectedIndex].Ranting;

                btnEditar.Visibility = Visibility.Visible;
                btnAlfa1.Visibility = Visibility.Hidden;
                btnAlfa2.Visibility = Visibility.Hidden;
                btnNum1.Visibility = Visibility.Hidden;
                btnNum2.Visibility = Visibility.Hidden;
                lblordenar.Visibility = Visibility.Hidden;
                btnGuardar2.Visibility = Visibility.Hidden;
                btnEliminar.Visibility = Visibility.Visible;

               

                if (((SeleccionadoEditado)(grdMain.Children[0])).txtRantingSD.Text == "1")
                {
                    Estrellas1.Visibility = Visibility.Visible;
                    Estrellas2.Visibility = Visibility.Hidden;
                    Estrellas3.Visibility = Visibility.Hidden;
                    Estrellas4.Visibility = Visibility.Hidden;
                    Estrellas5.Visibility = Visibility.Hidden;
                }
                if (((SeleccionadoEditado)(grdMain.Children[0])).txtRantingSD.Text == "2")
                {
                    Estrellas2.Visibility = Visibility.Visible;
                    Estrellas1.Visibility = Visibility.Hidden;
                    Estrellas3.Visibility = Visibility.Hidden;
                    Estrellas4.Visibility = Visibility.Hidden;
                    Estrellas5.Visibility = Visibility.Hidden;
                }
                if (((SeleccionadoEditado)(grdMain.Children[0])).txtRantingSD.Text == "3")
                {
                    Estrellas3.Visibility = Visibility.Visible;
                    Estrellas2.Visibility = Visibility.Hidden;
                    Estrellas1.Visibility = Visibility.Hidden;
                    Estrellas4.Visibility = Visibility.Hidden;
                    Estrellas5.Visibility = Visibility.Hidden;
                }
                if (((SeleccionadoEditado)(grdMain.Children[0])).txtRantingSD.Text == "4")
                {
                    Estrellas4.Visibility = Visibility.Visible;
                    Estrellas2.Visibility = Visibility.Hidden;
                    Estrellas3.Visibility = Visibility.Hidden;
                    Estrellas1.Visibility = Visibility.Hidden;
                    Estrellas5.Visibility = Visibility.Hidden;
                }
                if (((SeleccionadoEditado)(grdMain.Children[0])).txtRantingSD.Text == "5")
                {
                    Estrellas5.Visibility = Visibility.Visible;
                    Estrellas2.Visibility = Visibility.Hidden;
                    Estrellas3.Visibility = Visibility.Hidden;
                    Estrellas4.Visibility = Visibility.Hidden;
                    Estrellas1.Visibility = Visibility.Hidden;
                }

                if (((SeleccionadoEditado)(grdMain.Children[0])).txtTemporadasED.Text != "no aplica")
                {
                    lblserie.Visibility = Visibility.Visible;
                    lblpelicula.Visibility = Visibility.Hidden;
                }
                else
                {
                    lblserie.Visibility = Visibility.Hidden;
                    lblpelicula.Visibility = Visibility.Visible;
                }
            }
        }

        private void BtnNum1_Click(object sender, RoutedEventArgs e)
        {
              int gap, i;
              gap = obras.Count / 2;

              while (gap > 0)
              {
                  for (i = 0; i < obras.Count; i++)
                  {
                      if (gap + i < obras.Count && obras[i].Year > obras[gap + i].Year)
                      {
                          var temp = obras[i];
                          obras[i] = obras[gap + i];
                          obras[gap + i] = temp;
                      }
                  }
                  gap--;
              } 
        }

        private void BtnNum2_Click(object sender, RoutedEventArgs e)
        {
             int gap, i;
             gap = obras.Count / 2;

             while (gap > 0)
             {
                 for (i = 0; i < obras.Count; i++)
                 {
                     if (gap + i < obras.Count && obras[i].Year < obras[gap + i].Year)
                     {

                         var temp = obras[i];
                         obras[i] = obras[gap + i];
                         obras[gap + i] = temp;
                     }
                 }
                 gap--;
             } 
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)

        {
            grdMain.Children.Clear();
            grdMain.Children.Add(new SeleccionadoEditado());
            ((SeleccionadoEditado)(grdMain.Children[0])).txtTituloSD.Text = obras[lstViewMain.SelectedIndex].Titulo;
            ((SeleccionadoEditado)(grdMain.Children[0])).txtGeneroSD.Text = obras[lstViewMain.SelectedIndex].Genero;
            ((SeleccionadoEditado)(grdMain.Children[0])).txtDirectorSD.Text = obras[lstViewMain.SelectedIndex].Productor;
            ((SeleccionadoEditado)(grdMain.Children[0])).txtSinopsisED.Text = obras[lstViewMain.SelectedIndex].Sinopsis;
            ((SeleccionadoEditado)(grdMain.Children[0])).txtYearSD.Text = obras[lstViewMain.SelectedIndex].Year.ToString();
            ((SeleccionadoEditado)(grdMain.Children[0])).txtTemporadasED.Text = obras[lstViewMain.SelectedIndex].Temporadas;
            ((SeleccionadoEditado)(grdMain.Children[0])).cbRantingSD.Text = obras[lstViewMain.SelectedIndex].Ranting;

            ((SeleccionadoEditado)(grdMain.Children[0])).txtTituloSD.IsEnabled = true;
            ((SeleccionadoEditado)(grdMain.Children[0])).cbGenero.IsEnabled = true;
            ((SeleccionadoEditado)(grdMain.Children[0])).txtGeneroSD.IsEnabled = true;
            ((SeleccionadoEditado)(grdMain.Children[0])).txtDirectorSD.IsEnabled = true;
            ((SeleccionadoEditado)(grdMain.Children[0])).txtSinopsisED.IsEnabled = true;
            ((SeleccionadoEditado)(grdMain.Children[0])).txtYearSD.IsEnabled = true;
            ((SeleccionadoEditado)(grdMain.Children[0])).txtTemporadasED.IsEnabled = true;
            ((SeleccionadoEditado)(grdMain.Children[0])).cbRantingSD.IsEnabled = true;

            btnGuardar.Visibility = Visibility.Visible;
            btnCancelar.Visibility = Visibility.Visible;
            btnGuardar2.Visibility = Visibility.Hidden;
            lblserie.Visibility = Visibility.Hidden;
            lblpelicula.Visibility = Visibility.Hidden;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grdMain.Children.Clear();
            btnAlfa1.Visibility = Visibility.Visible;
            btnAlfa2.Visibility = Visibility.Visible;
            btnNum1.Visibility = Visibility.Visible;
            btnNum2.Visibility = Visibility.Visible;
            Estrellas1.Visibility = Visibility.Hidden;
            Estrellas2.Visibility = Visibility.Hidden;
            Estrellas3.Visibility = Visibility.Hidden;
            Estrellas4.Visibility = Visibility.Hidden;
            Estrellas5.Visibility = Visibility.Hidden;
            btnGuardar2.Visibility = Visibility.Hidden;
            btnEditar.Visibility = Visibility.Hidden;
            btnguardar3.Visibility = Visibility.Hidden;
            btnEliminar.Visibility = Visibility.Hidden;
            btnGuardar.Visibility = Visibility.Hidden;
            lblserie.Visibility = Visibility.Hidden;
            lblpelicula.Visibility = Visibility.Hidden;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (((SeleccionadoEditado)(grdMain.Children[0])).txtTituloSD.Text == string.Empty || ((SeleccionadoEditado)(grdMain.Children[0])).txtYearSD.Text == string.Empty || ((SeleccionadoEditado)(grdMain.Children[0])).txtSinopsisED.Text == string.Empty || ((SeleccionadoEditado)(grdMain.Children[0])).txtDirectorSD.Text == string.Empty || ((SeleccionadoEditado)(grdMain.Children[0])).cbGenero.Text == string.Empty || ((SeleccionadoEditado)(grdMain.Children[0])).cbRantingSD.Text == string.Empty)
            {
                lblobligatorio.Visibility = Visibility.Visible;
            }
            else
            {
              
                grdMain.Children.Add(new SeleccionadoEditado());
                var cosa = ((SeleccionadoEditado)(grdMain.Children[0]));
                var cosa2 = obras[lstViewMain.SelectedIndex];
                var year2 = cosa2.Year.ToString();
                var year3 = Convert.ToInt32(((SeleccionadoEditado)(grdMain.Children[0])).txtYearSD.Text);

                cosa2.Year = year3;

                cosa2.Titulo = cosa.txtTituloSD.Text;
                cosa2.Sinopsis = cosa.txtSinopsisED.Text;
                cosa2.Temporadas = cosa.txtTemporadasED.Text;
                cosa2.Productor = cosa.txtDirectorSD.Text;
                cosa2.Genero = cosa.cbGenero.Text;
                cosa2.Ranting = cosa.cbRantingSD.Text;

                lblobligatorio.Visibility = Visibility.Hidden;
                lstViewMain.Items.Refresh();
                grdMain.Children.Clear();
            }

            
            btnAlfa1.Visibility = Visibility.Hidden;
            btnAlfa2.Visibility = Visibility.Hidden;
            btnNum1.Visibility = Visibility.Hidden;
            btnNum2.Visibility = Visibility.Hidden;
            lblordenar.Visibility = Visibility.Hidden;
            Estrellas1.Visibility = Visibility.Hidden;
            Estrellas2.Visibility = Visibility.Hidden;
            Estrellas3.Visibility = Visibility.Hidden;
            Estrellas4.Visibility = Visibility.Hidden;
            Estrellas5.Visibility = Visibility.Hidden;
            lblserie.Visibility = Visibility.Hidden;
            lblpelicula.Visibility = Visibility.Hidden;
        }

        private void BtnGuardar2_Click(object sender, RoutedEventArgs e)
        {
            if (((AgregarElemento)(grdMain.Children[0])).txtTitulo.Text == string.Empty || ((AgregarElemento)(grdMain.Children[0])).txtYear.Text == string.Empty || ((AgregarElemento)(grdMain.Children[0])).txtDescripcion.Text == string.Empty || ((AgregarElemento)(grdMain.Children[0])).txtProductor.Text == string.Empty || ((AgregarElemento)(grdMain.Children[0])).cbGenero.Text == string.Empty || ((AgregarElemento)(grdMain.Children[0])).cbRanting.Text == string.Empty)
            {
                lblobligatorio.Visibility = Visibility.Visible;
            }
            else
            {
                var yeartest = ((AgregarElemento)(grdMain.Children[0])).txtYear.Text;
                int yearbien = int.Parse(yeartest);
                string temporadass = "no aplica";

                obras.Add(new Audiovisual(((AgregarElemento)(grdMain.Children[0])).txtTitulo.Text, yearbien, ((AgregarElemento)(grdMain.Children[0])).cbGenero.Text, temporadass, ((AgregarElemento)(grdMain.Children[0])).txtProductor.Text, ((AgregarElemento)(grdMain.Children[0])).txtDescripcion.Text, ((AgregarElemento)(grdMain.Children[0])).cbRanting.Text));

                lstViewMain.Items.Refresh();
                lblobligatorio.Visibility = Visibility.Hidden;
            }
        }

        private void BtnAlfa1_Click(object sender, RoutedEventArgs e)
        {
            bool swap;
            do
            {
                swap = false;
                for (int index = 0; index < (obras.Count - 1); index++)
                {
                    if (string.Compare(obras[index].Titulo, obras[index + 1].Titulo) > 0)
                    {
                        var temp = obras[index];
                        obras[index] = obras[index + 1];
                        obras[index + 1] = temp;
                        swap = true;
                    }
                }
            } while (swap == true);
        }

        private void BtnAlfa2_Click(object sender, RoutedEventArgs e)
        {
            bool swap;
            do
            {
                swap = false;
                for (int index = 0; index < (obras.Count - 1); index++)
                {
                    if (string.Compare(obras[index].Titulo, obras[index + 1].Titulo) < 0)
                    {
                        var temp = obras[index];
                        obras[index] = obras[index + 1];
                        obras[index + 1] = temp;
                        swap = true;
                    }
                }
            } while (swap == true);
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if(lstViewMain.SelectedIndex != -1)
            {
                obras.RemoveAt(lstViewMain.SelectedIndex);
                Estrellas1.Visibility = Visibility.Hidden;
                Estrellas2.Visibility = Visibility.Hidden;
                Estrellas3.Visibility = Visibility.Hidden;
                Estrellas4.Visibility = Visibility.Hidden;
                Estrellas5.Visibility = Visibility.Hidden;
                btnEditar.Visibility = Visibility.Hidden;
                lblserie.Visibility = Visibility.Hidden;
                lblpelicula.Visibility = Visibility.Hidden;
                grdMain.Children.Clear();
            }
        }

        private void RdbtnPelicula_Checked(object sender, RoutedEventArgs e)
        {
            grdMain.Children.Clear();
            grdMain.Children.Add(new AgregarElemento());
            ((AgregarElemento)(grdMain.Children[0])).cbTemporadas.Visibility = Visibility.Hidden;
            ((AgregarElemento)(grdMain.Children[0])).lbltempodaras.Visibility = Visibility.Hidden;
            btnGuardar2.Visibility = Visibility.Visible;
            btnguardar3.Visibility = Visibility.Hidden;
        }

        private void RdbtnSerie_Checked(object sender, RoutedEventArgs e)
        {
            grdMain.Children.Clear();
            grdMain.Children.Add(new AgregarElemento());
            ((AgregarElemento)(grdMain.Children[0])).cbTemporadas.Visibility = Visibility.Visible;
            ((AgregarElemento)(grdMain.Children[0])).lbltempodaras.Visibility = Visibility.Visible;
            btnguardar3.Visibility = Visibility.Visible;
            btnGuardar2.Visibility = Visibility.Hidden;
        }

        private void Btnguardar3_Click(object sender, RoutedEventArgs e)
        {
            if (((AgregarElemento)(grdMain.Children[0])).txtTitulo.Text == string.Empty || ((AgregarElemento)(grdMain.Children[0])).txtYear.Text == string.Empty || ((AgregarElemento)(grdMain.Children[0])).txtDescripcion.Text == string.Empty || ((AgregarElemento)(grdMain.Children[0])).txtProductor.Text == string.Empty || ((AgregarElemento)(grdMain.Children[0])).cbGenero.Text == string.Empty || ((AgregarElemento)(grdMain.Children[0])).cbRanting.Text == string.Empty)
            {
                lblobligatorio.Visibility = Visibility.Visible;
            }

            else
            {
                int year3 = Convert.ToInt32(((AgregarElemento)(grdMain.Children[0])).txtYear.Text);

                obras.Add(new Audiovisual(((AgregarElemento)(grdMain.Children[0])).txtTitulo.Text, year3, ((AgregarElemento)(grdMain.Children[0])).cbGenero.Text, ((AgregarElemento)(grdMain.Children[0])).cbTemporadas.Text, ((AgregarElemento)(grdMain.Children[0])).txtProductor.Text, ((AgregarElemento)(grdMain.Children[0])).txtDescripcion.Text, ((AgregarElemento)(grdMain.Children[0])).cbRanting.Text));
                lblobligatorio.Visibility = Visibility.Visible;
                lstViewMain.Items.Refresh();
            }

        }
    }
}
