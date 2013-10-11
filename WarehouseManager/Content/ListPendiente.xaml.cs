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
    public partial class ListPendiente : UserControl
    {
        private List<Pendiente> Pendientes = new List<Pendiente>();

        public ListPendiente()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Pendientes = obj.ReadPendiente();

            this.DataContext = Pendientes;

        }

        private void listPendiente_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Pendiente register = listPendiente.SelectedValue as Pendiente;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SinglePendiente(register)
            }.ShowDialog();
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadPendiente();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Pendientes
                        orderby element.IdPendiente
                        where (element.IdFactura.ToString().Trim().ToLower().Contains(txtIdFacturaBusqueda.Text.Trim().ToLower()) &&
                        element.IdArticulo.ToString().Trim().ToLower().Contains(txtIdArticuloBusqueda.Text.Trim().ToLower()) &&
                        element.Cantidad.ToString().Trim().ToLower().Contains(txtCantidadBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;       
        }
private void headIdFactura(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Pendientes
		    orderby element.IdFactura
		    select element;

            this.DataContext = query;
        }private void headIdArticulo(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Pendientes
		    orderby element.IdArticulo
		    select element;

            this.DataContext = query;
        }private void headCantidad(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Pendientes
		    orderby element.Cantidad
		    select element;

            this.DataContext = query;
        }private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
