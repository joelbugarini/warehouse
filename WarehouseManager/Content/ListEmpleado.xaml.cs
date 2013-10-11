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
    public partial class ListEmpleado : UserControl
    {
        private List<Empleado> Empleados = new List<Empleado>();

        public ListEmpleado()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Empleados = obj.ReadEmpleado();

            this.DataContext = Empleados;

        }

        private void listEmpleado_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Empleado register = listEmpleado.SelectedValue as Empleado;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SingleEmpleado(register)
            }.ShowDialog();
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadEmpleado();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Empleados
                        orderby element.IdEmpleado
                        where (element.NoEmpleado.ToString().Trim().ToLower().Contains(txtNoEmpleadoBusqueda.Text.Trim().ToLower()) &&
                        element.Nombre.ToString().Trim().ToLower().Contains(txtNombreBusqueda.Text.Trim().ToLower()) &&
                        element.ApellidoPaterno.ToString().Trim().ToLower().Contains(txtApellidoPaternoBusqueda.Text.Trim().ToLower()) &&
                        element.ApellidoMaterno.ToString().Trim().ToLower().Contains(txtApellidoMaternoBusqueda.Text.Trim().ToLower()) &&
                        element.Departamento.ToString().Trim().ToLower().Contains(txtDepartamentoBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;       
        }
private void headNoEmpleado(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Empleados
		    orderby element.NoEmpleado
		    select element;

            this.DataContext = query;
        }private void headNombre(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Empleados
		    orderby element.Nombre
		    select element;

            this.DataContext = query;
        }private void headApellidoPaterno(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Empleados
		    orderby element.ApellidoPaterno
		    select element;

            this.DataContext = query;
        }private void headApellidoMaterno(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Empleados
		    orderby element.ApellidoMaterno
		    select element;

            this.DataContext = query;
        }private void headDepartamento(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Empleados
		    orderby element.Departamento
		    select element;

            this.DataContext = query;
        }private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
