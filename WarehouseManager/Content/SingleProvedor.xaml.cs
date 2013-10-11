using System;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using WarehouseManager.BC;

namespace WarehouseManager.Content
{
    /// <summary>
    /// Interaction logic for SingleProvedor.xaml
    /// </summary>                                                
    public partial class SingleProvedor : UserControl
    {
        public Provedor provedor = new Provedor();

        public SingleProvedor(Provedor reg)
        {
            InitializeComponent();
            provedor = reg;
            this.DataContext = provedor;

            btnActualizar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Collapsed;
        }

        public SingleProvedor()
        {
                InitializeComponent();
                this.DataContext =  provedor;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateBC obj = new CreateBC();
                obj.Create( provedor);
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
                obj.Update( provedor,  provedor.IdProvedor);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }
        }

        private void NuevoReg() {
 txtNombre.Text = "";
 txtRFC.Text = "";
 txtDireccion.Text = "";
 txtTelefono.Text = "";

        }
    }
}
