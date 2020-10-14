using RegistroDetalle_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RegistroDetalle_AP1.UI.Registros
{
    /// <summary>
    /// Lógica de interacción para rArticulos.xaml
    /// </summary>
    public partial class rArticulos : Window
    {
        Articulos articulo = new Articulos();
        public rArticulos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            this.articulo = new Articulos();
            this.DataContext = articulo;
        }

        private bool Validar()
        {
            bool valido = true;

            if (string.IsNullOrEmpty(DescripcionTextBox.Text))
            {
                valido = false;
                MessageBox.Show("Error, descripción no válida, esta vacía.", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if (Convert.ToInt32(PrecioTextBox.Text) <= 0)
            {
                valido = false;
                MessageBox.Show("Error, precio del artículo no válido. \nEl número ingresado es 0 o negativo.", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return valido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
