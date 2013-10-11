using System;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using WarehouseManager.BC;

namespace WarehouseManager.Content
{
    /// <summary>
    /// Interaction logic for SingleDevolucion.xaml
    /// </summary>                                                
    public partial class SingleDevolucion : UserControl
    {
        public Devolucion devolucion = new Devolucion();

        public SingleDevolucion(Devolucion reg)
        {
            InitializeComponent();
            devolucion = reg;
            this.DataContext = devolucion;

            btnActualizar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Collapsed;
        }

        public SingleDevolucion()
        {
                InitializeComponent();
                this.DataContext =  devolucion;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateBC obj = new CreateBC();
                obj.Create( devolucion);
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
                obj.Update( devolucion,  devolucion.IdDevolucion);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }
        }

        private void NuevoReg() {
 txtIdEmpleado.Text = "";
 txtIdArticulo.Text = "";
 txtCantidad.Text = "";
 txtNota.Text = "";
 txtFecha.Text = "";

        }
    }
}
