using System;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using WarehouseManager.BC;

namespace WarehouseManager.Content
{
    /// <summary>
    /// Interaction logic for SingleSalidaArticulo.xaml
    /// </summary>                                                
    public partial class SingleSalidaArticulo : UserControl
    {
        public SalidaArticulo salidaArticulo = new SalidaArticulo();

        public SingleSalidaArticulo(SalidaArticulo reg)
        {
            InitializeComponent();
            salidaArticulo = reg;
            this.DataContext = salidaArticulo;

            btnActualizar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Collapsed;
        }

        public SingleSalidaArticulo()
        {
                InitializeComponent();
                this.DataContext =  salidaArticulo;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateBC obj = new CreateBC();
                obj.Create( salidaArticulo);
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
                obj.Update( salidaArticulo,  salidaArticulo.IdSalidaArticulo);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }
        }

        private void NuevoReg() {
 txtIdSalida.Text = "";
 txtIdArticulo.Text = "";

        }
    }
}
