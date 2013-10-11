using System;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using WarehouseManager.BC;

namespace WarehouseManager.Content
{
    /// <summary>
    /// Interaction logic for SingleEmpleado.xaml
    /// </summary>                                                
    public partial class SingleEmpleado : UserControl
    {
        public Empleado empleado = new Empleado();

        public SingleEmpleado(Empleado reg)
        {
            InitializeComponent();
            empleado = reg;
            this.DataContext = empleado;

            btnActualizar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Collapsed;
        }

        public SingleEmpleado()
        {
                InitializeComponent();
                this.DataContext =  empleado;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateBC obj = new CreateBC();
                obj.Create( empleado);
            }
            catch(Exception ex)
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
                obj.Update( empleado,  empleado.IdEmpleado);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }
        }

        private void NuevoReg() {
 txtNoEmpleado.Text = "";
 txtNombre.Text = "";
 txtApellidoPaterno.Text = "";
 txtApellidoMaterno.Text = "";
 txtDepartamento.Text = "";

        }
    }
}
