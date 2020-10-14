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

            if(MontoTextBox.Text.Length == 0)
            {
                valido = false;
                MessageBox.Show("Error, monto no valido, esta vacio.", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return valido;
        }

        public void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            Contexto contexto = new Contexto();
            var orden = new Ordenes();

            orden.Fecha = DateTime.Now;
            orden.Monto = 250;

            orden.Detalle.Add(new OrdenesDetalle() {ArticuloId = 3, Cantidad = 2, Precio = 50});
            orden.Detalle.Add(new OrdenesDetalle() {ArticuloId = 1, Cantidad = 1, Precio = 150});
            
            contexto.Ordenes.Add(orden);

            contexto.SaveChanges();

            contexto.Dispose();
        }

        public void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        public void EliminarButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        } 
    }
}