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
    public partial class ListRectificacion : UserControl
    {
        private List<Rectificacion> Rectificacions = new List<Rectificacion>();

        public ListRectificacion()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Rectificacions = obj.ReadRectificacion();

            this.DataContext = Rectificacions;

        }

        private void listRectificacion_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Rectificacion register = listRectificacion.SelectedValue as Rectificacion;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SingleRectificacion(register)
            }.ShowDialog();
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadRectificacion();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Rectificacions
                        orderby element.IdRectificacion
                        where (element.IdArticulo.ToString().Trim().ToLower().Contains(txtIdArticuloBusqueda.Text.Trim().ToLower()) &&
                        element.Cantidad.ToString().Trim().ToLower().Contains(txtCantidadBusqueda.Text.Trim().ToLower()) &&
                        element.Descripcion.ToString().Trim().ToLower().Contains(txtDescripcionBusqueda.Text.Trim().ToLower()) &&
                        element.Fecha.ToString().Trim().ToLower().Contains(txtFechaBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;       
        }
private void headIdArticulo(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Rectificacions
		    orderby element.IdArticulo
		    select element;

            this.DataContext = query;
        }private void headCantidad(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Rectificacions
		    orderby element.Cantidad
		    select element;

            this.DataContext = query;
        }private void headDescripcion(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Rectificacions
		    orderby element.Descripcion
		    select element;

            this.DataContext = query;
        }private void headFecha(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Rectificacions
		    orderby element.Fecha
		    select element;

            this.DataContext = query;
        }private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
