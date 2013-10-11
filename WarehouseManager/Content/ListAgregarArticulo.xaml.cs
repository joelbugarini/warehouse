using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using FirstFloor.ModernUI.Windows.Controls;
using WarehouseManager.BC;
using Properties;
using System;
using System.Text.RegularExpressions;

namespace WarehouseManager.Content
{
    public partial class ListAgregarArticulo : UserControl
    {
        private List<Articulo> Articulos = new List<Articulo>();

        public ListAgregarArticulo()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Articulos = obj.ReadArticulo();

            this.DataContext = Articulos;

        }

        private void listArticulo_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Articulo register = listArticulo.SelectedValue as Articulo;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SingleArticulo(register)
            }.ShowDialog();
        }

        public void Update()
        {
            ReadBC obj = new ReadBC();
            Articulos = obj.ReadArticulo();
            this.DataContext = Articulos;
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.IdArticulo
                        where (element.Nombre.ToString().Trim().ToLower().Contains(txtNombreBusqueda.Text.Trim().ToLower()) &&
                        element.Descripcion.ToString().Trim().ToLower().Contains(txtDescripcionBusqueda.Text.Trim().ToLower()) &&
                        element.Precio.ToString().Trim().ToLower().Contains(txtPrecioBusqueda.Text.Trim().ToLower()) &&
                        element.Unidad.ToString().Trim().ToLower().Contains(txtUnidadBusqueda.Text.Trim().ToLower()) &&
                        element.Cantidad.ToString().Trim().ToLower().Contains(txtCantidadBusqueda.Text.Trim().ToLower())
                         )
                        select element;

            this.DataContext = query;
        }
        private void headNombre(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.Nombre
                        select element;

            this.DataContext = query;
        }
        private void headDescripcion(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.Descripcion
                        select element;

            this.DataContext = query;
        }
        private void headPrecio(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.Precio
                        select element;

            this.DataContext = query;
        }
        private void headUnidad(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.Unidad
                        select element;

            this.DataContext = query;
        }
        private void headCantidad(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.Cantidad
                        select element;

            this.DataContext = query;
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Articulo art = listArticulo.SelectedValue as Articulo;
            Entradas.ArticuloNuevo.IdArticulo = art.IdArticulo;
            Entradas.ArticuloNuevo.Cantidad = Convert.ToInt32(txtCantidad.Text);
            Entradas.agregar = true;

        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
