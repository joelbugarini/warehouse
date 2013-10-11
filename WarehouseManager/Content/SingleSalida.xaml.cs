using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using WarehouseManager.BC;
using System.Windows.Input;
using System.Collections.Generic;

namespace WarehouseManager.Content
{
    /// <summary>
    /// Interaction logic for SingleSalida.xaml
    /// </summary>                                                
    public partial class SingleSalida : UserControl
    {
        public Salida salida = new Salida();
        public List<Empleado> Empleados = new List<Empleado>();

        public SingleSalida()
        {
            InitializeComponent();
            ReadBC read = new ReadBC();
            Empleados = read.ReadEmpleado();

            this.DataContext = Empleados;

            salida.Fecha = DateTime.Now.Date;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateBC obj = new CreateBC();
                Empleado emp = listEmpleado.SelectedValue as Empleado;
                salida.IdEmpleado = emp.IdEmpleado;
                salida.Nota = txtNota.Text;
                salida.Fecha = txtFecha.SelectedDate.Value;
                obj.Create(salida);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }

            NuevoReg();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UpdateBC obj = new UpdateBC();
                obj.Update(salida, salida.IdSalida);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }
        }

        private void NuevoReg()
        {
       
            txtNota.Text = "";
            txtFecha.Text = "";

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
            var query = from element in Empleados
                        orderby element.NoEmpleado
                        select element;

            this.DataContext = query;
        }
        private void headNombre(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Empleados
                        orderby element.Nombre
                        select element;

            this.DataContext = query;
        }
        private void headApellidoPaterno(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Empleados
                        orderby element.ApellidoPaterno
                        select element;

            this.DataContext = query;
        }
        private void headApellidoMaterno(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Empleados
                        orderby element.ApellidoMaterno
                        select element;

            this.DataContext = query;
        }
        private void headDepartamento(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Empleados
                        orderby element.Departamento
                        select element;

            this.DataContext = query;
        }
      
    }
}
