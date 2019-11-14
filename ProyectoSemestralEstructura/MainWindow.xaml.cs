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

            obras.Add(new Audiovisual("Jose", 1998, "terror", 5, "yo mismo", "aqui va una descripcion", 3));
            obras.Add(new Audiovisual("Jose", 1999, "aqui va una sinopsis", "terror", "yo mismo", 3));
            obras.Add(new Audiovisual("Jose", 1993, "aqui va una sinopsis", "terror", "yo mismo", 3));




            lstViewMain.ItemsSource = obras;
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            grdMain.Children.Add(new AgregarElemento());
            btnAlfa1.Visibility = Visibility.Hidden;
            btnAlfa2.Visibility = Visibility.Hidden;
            btnNum1.Visibility = Visibility.Hidden;
            btnNum2.Visibility = Visibility.Hidden;
            lblordenar.Visibility = Visibility.Hidden;

        }

        private void LstViewMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
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
    }
    
}
