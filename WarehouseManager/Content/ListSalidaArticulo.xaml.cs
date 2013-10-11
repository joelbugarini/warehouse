using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using FirstFloor.ModernUI.Windows.Controls;
using WarehouseManager.BC;
using Properties;

namespace WarehouseManager.Content
{
    public partial class ListSalidaArticulo : UserControl
    {
        private List<SalidaArticulos> SalidaArticulos = new List<SalidaArticulos>();
        public Salida salida = WarehouseManager.ListFactura.SalidaGlobal;
        private List<Articulo> Articulos = new List<Articulo>();

        public ListSalidaArticulo()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Articulos = obj.ReadArticulo();
            SalidaArticulos = obj.ReadSalidaArticulos(salida.IdSalida);

            DataContext = Articulos;

        }

        private void listSalidaArticulos_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadSalidaArticulos(salida.IdSalida);
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in SalidaArticulos
                        orderby element.IdSalidaArticulo
                        where (element.Nombre.ToString().Trim().ToLower().Contains(txtNombreBusqueda.Text.Trim().ToLower()) &&
                        element.Descripcion.ToString().Trim().ToLower().Contains(txtDescripcionBusqueda.Text.Trim().ToLower()) &&
                        element.Precio.ToString().Trim().ToLower().Contains(txtPrecioBusqueda.Text.Trim().ToLower()) &&
                        element.Unidad.ToString().Trim().ToLower().Contains(txtUnidadBusqueda.Text.Trim().ToLower()) &&
                        element.Cantidad.ToString().Trim().ToLower().Contains(txtCantidadBusqueda.Text.Trim().ToLower())
                         )
                        select element;

            this.DataContext = query;
        }
        private void headIdSalida(object sender, MouseButtonEventArgs e)
        {
            var query = from element in SalidaArticulos
                        orderby element.IdSalida
                        select element;

            this.DataContext = query;
        }
        private void headIdArticulo(object sender, MouseButtonEventArgs e)
        {
            var query = from element in SalidaArticulos
                        orderby element.IdArticulo
                        select element;

            this.DataContext = query;
        }
        private void headNombre(object sender, MouseButtonEventArgs e)
        {
            var query = from element in SalidaArticulos
                        orderby element.Nombre
                        select element;

            this.DataContext = query;
        }
        private void headDescripcion(object sender, MouseButtonEventArgs e)
        {
            var query = from element in SalidaArticulos
                        orderby element.Descripcion
                        select element;

            this.DataContext = query;
        }
        private void headPrecio(object sender, MouseButtonEventArgs e)
        {
            var query = from element in SalidaArticulos
                        orderby element.Precio
                        select element;

            this.DataContext = query;
        }
        private void headUnidad(object sender, MouseButtonEventArgs e)
        {
            var query = from element in SalidaArticulos
                        orderby element.Unidad
                        select element;

            this.DataContext = query;
        }
        private void headCantidad(object sender, MouseButtonEventArgs e)
        {
            var query = from element in SalidaArticulos
                        orderby element.Cantidad
                        select element;

            this.DataContext = query;
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }

        /*----------------------------------------------------------------*/
        /*-------------------Articulo functions---------------------------*/
        /*----------------------------------------------------------------*/


        private void txtBusqueda_TextChanged2(object sender, TextChangedEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.IdArticulo
                        where (element.Nombre.ToString().Trim().ToLower().Contains(txtNombreBusqueda2.Text.Trim().ToLower()) &&
                        element.Descripcion.ToString().Trim().ToLower().Contains(txtDescripcionBusqueda2.Text.Trim().ToLower()) &&
                        element.Precio.ToString().Trim().ToLower().Contains(txtPrecioBusqueda2.Text.Trim().ToLower()) &&
                        element.Unidad.ToString().Trim().ToLower().Contains(txtUnidadBusqueda2.Text.Trim().ToLower()) &&
                        element.Cantidad.ToString().Trim().ToLower().Contains(txtCantidadBusqueda2.Text.Trim().ToLower())
                         )
                        select element;

            this.DataContext = query;
        }
        private void headNombre2(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.Nombre
                        select element;

            this.DataContext = query;
        }
        private void headDescripcion2(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.Descripcion
                        select element;

            this.DataContext = query;
        }
        private void headPrecio2(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.Precio
                        select element;

            this.DataContext = query;
        }
        private void headUnidad2(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.Unidad
                        select element;

            this.DataContext = query;
        }
        private void headCantidad2(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.Cantidad
                        select element;

            this.DataContext = query;
        }

        private void listArticulo_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Aqui van los cambios");
        }

    }
}
