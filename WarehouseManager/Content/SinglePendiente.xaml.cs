using System;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using WarehouseManager.BC;

namespace WarehouseManager.Content
{
    /// <summary>
    /// Interaction logic for SinglePendiente.xaml
    /// </summary>                                                
    public partial class SinglePendiente : UserControl
    {
        public Pendiente pendiente = new Pendiente();

        public SinglePendiente(Pendiente reg)
        {
            InitializeComponent();
            pendiente = reg;
            this.DataContext = pendiente;

            btnActualizar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Collapsed;
        }

        public SinglePendiente()
        {
                InitializeComponent();
                this.DataContext =  pendiente;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateBC obj = new CreateBC();
                obj.Create( pendiente);
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
                obj.Update( pendiente,  pendiente.IdPendiente);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }
        }

        private void NuevoReg() {
 txtIdFactura.Text = "";
 txtIdArticulo.Text = "";
 txtCantidad.Text = "";

        }
    }
}
