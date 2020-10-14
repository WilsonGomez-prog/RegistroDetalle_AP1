using System;
using System.Windows;
using RegistroDetalle_AP1.Entidades;
using RegistroDetalle_AP1.DAL;

namespace RegistroDetalle_AP1.UI.Registros
{
    public partial class rOrdenes : Window
    {
        Ordenes orden;
        public rOrdenes()
        {
            InitializeComponent();
            orden = new Ordenes();
            this.DataContext = orden;
        }

        private void Limpiar()
        {
            this.orden = new Ordenes();
            this.DataContext = orden;
        }

        private bool Validar()
        {
            bool valido = true;

            if(CantidadTextBox.Text.Length == 0)
            {
                valido = false;
                MessageBox.Show("Error, cantidad no válida, esta vacía.", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if (ProductoIdComboBox.SelectedIndex != null)
            {
                valido = false;
                MessageBox.Show("Error, producto no válido, \nno ha seleccionado ningún producto.", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (CantidadTextBox.Text.Length == 0)
            {
                valido = false;
                MessageBox.Show("Error, cantidad no válida, esta vacía.", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }


            return valido;
        }

        public void GuardarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        public void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        public void EliminarButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}