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
    public partial class ListProvedor : UserControl
    {
        private List<Provedor> Provedors = new List<Provedor>();

        public ListProvedor()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Provedors = obj.ReadProvedor();

            this.DataContext = Provedors;

        }

        private void listProvedor_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Provedor register = listProvedor.SelectedValue as Provedor;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SingleProvedor(register)
            }.ShowDialog();
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadProvedor();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Provedors
                        orderby element.IdProvedor
                        where (element.Nombre.ToString().Trim().ToLower().Contains(txtNombreBusqueda.Text.Trim().ToLower()) &&
                        element.RFC.ToString().Trim().ToLower().Contains(txtRFCBusqueda.Text.Trim().ToLower()) &&
                        element.Direccion.ToString().Trim().ToLower().Contains(txtDireccionBusqueda.Text.Trim().ToLower()) &&
                        element.Telefono.ToString().Trim().ToLower().Contains(txtTelefonoBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;       
        }
private void headNombre(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Provedors
		    orderby element.Nombre
		    select element;

            this.DataContext = query;
        }private void headRFC(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Provedors
		    orderby element.RFC
		    select element;

            this.DataContext = query;
        }private void headDireccion(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Provedors
		    orderby element.Direccion
		    select element;

            this.DataContext = query;
        }private void headTelefono(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Provedors
		    orderby element.Telefono
		    select element;

            this.DataContext = query;
        }private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
