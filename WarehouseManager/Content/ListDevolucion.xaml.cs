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
    public partial class ListDevolucion : UserControl
    {
        private List<Devolucion> Devolucions = new List<Devolucion>();

        public ListDevolucion()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Devolucions = obj.ReadDevolucion();

            this.DataContext = Devolucions;

        }

        private void listDevolucion_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Devolucion register = listDevolucion.SelectedValue as Devolucion;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SingleDevolucion(register)
            }.ShowDialog();
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadDevolucion();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Devolucions
                        orderby element.IdDevolucion
                        where (element.IdEmpleado.ToString().Trim().ToLower().Contains(txtIdEmpleadoBusqueda.Text.Trim().ToLower()) &&
                        element.IdArticulo.ToString().Trim().ToLower().Contains(txtIdArticuloBusqueda.Text.Trim().ToLower()) &&
                        element.Cantidad.ToString().Trim().ToLower().Contains(txtCantidadBusqueda.Text.Trim().ToLower()) &&
                        element.Nota.ToString().Trim().ToLower().Contains(txtNotaBusqueda.Text.Trim().ToLower()) &&
                        element.Fecha.ToString().Trim().ToLower().Contains(txtFechaBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;       
        }
private void headIdEmpleado(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Devolucions
		    orderby element.IdEmpleado
		    select element;

            this.DataContext = query;
        }private void headIdArticulo(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Devolucions
		    orderby element.IdArticulo
		    select element;

            this.DataContext = query;
        }private void headCantidad(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Devolucions
		    orderby element.Cantidad
		    select element;

            this.DataContext = query;
        }private void headNota(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Devolucions
		    orderby element.Nota
		    select element;

            this.DataContext = query;
        }private void headFecha(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Devolucions
		    orderby element.Fecha
		    select element;

            this.DataContext = query;
        }private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
