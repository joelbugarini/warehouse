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
    public partial class ListFacturaArticulo : UserControl
    {
        private List<FacturaArticulo> FacturaArticulos = new List<FacturaArticulo>();

        public ListFacturaArticulo()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            FacturaArticulos = obj.ReadFacturaArticulo();

            this.DataContext = FacturaArticulos;

        }

        private void listFacturaArticulo_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            FacturaArticulo register = listFacturaArticulo.SelectedValue as FacturaArticulo;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SingleFacturaArticulo(register)
            }.ShowDialog();
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadFacturaArticulo();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in FacturaArticulos
                        orderby element.IdFacturaArticulo
                        where (element.IdFactura.ToString().Trim().ToLower().Contains(txtIdFacturaBusqueda.Text.Trim().ToLower()) &&
                        element.IdArticulo.ToString().Trim().ToLower().Contains(txtIdArticuloBusqueda.Text.Trim().ToLower()) &&
                        element.Cantidad.ToString().Trim().ToLower().Contains(txtCantidadBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;       
        }
private void headIdFactura(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in FacturaArticulos
		    orderby element.IdFactura
		    select element;

            this.DataContext = query;
        }private void headIdArticulo(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in FacturaArticulos
		    orderby element.IdArticulo
		    select element;

            this.DataContext = query;
        }private void headCantidad(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in FacturaArticulos
		    orderby element.Cantidad
		    select element;

            this.DataContext = query;
        }private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
