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
    public partial class ListUsuario : UserControl
    {
        private List<Usuario> Usuarios = new List<Usuario>();

        public ListUsuario()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Usuarios = obj.ReadUsuario();

            this.DataContext = Usuarios;

        }

        private void listUsuario_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Usuario register = listUsuario.SelectedValue as Usuario;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SingleUsuario(register)
            }.ShowDialog();
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadUsuario();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Usuarios
                        orderby element.IdUsuario
                        where (element.Nombre.ToString().Trim().ToLower().Contains(txtNombreBusqueda.Text.Trim().ToLower()) &&
                        element.Contraseña.ToString().Trim().ToLower().Contains(txtContraseñaBusqueda.Text.Trim().ToLower()) &&
                        element.Tipo.ToString().Trim().ToLower().Contains(txtTipoBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;       
        }
private void headNombre(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Usuarios
		    orderby element.Nombre
		    select element;

            this.DataContext = query;
        }private void headContraseña(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Usuarios
		    orderby element.Contraseña
		    select element;

            this.DataContext = query;
        }private void headTipo(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Usuarios
		    orderby element.Tipo
		    select element;

            this.DataContext = query;
        }private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
