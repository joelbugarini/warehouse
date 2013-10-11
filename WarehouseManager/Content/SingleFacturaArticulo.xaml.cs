using System;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using WarehouseManager.BC;

namespace WarehouseManager.Content
{
    /// <summary>
    /// Interaction logic for SingleFacturaArticulo.xaml
    /// </summary>                                                
    public partial class SingleFacturaArticulo : UserControl
    {
        public FacturaArticulo facturaArticulo = new FacturaArticulo();

        public SingleFacturaArticulo(FacturaArticulo reg)
        {
            InitializeComponent();
            facturaArticulo = reg;
            this.DataContext = facturaArticulo;

            btnActualizar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Collapsed;
        }

        public SingleFacturaArticulo()
        {
                InitializeComponent();
                this.DataContext =  facturaArticulo;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateBC obj = new CreateBC();
                obj.Create( facturaArticulo);
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
                obj.Update( facturaArticulo,  facturaArticulo.IdFacturaArticulo);
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
