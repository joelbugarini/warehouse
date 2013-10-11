using System;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using WarehouseManager.BC;

namespace WarehouseManager.Content
{
    /// <summary>
    /// Interaction logic for SingleRectificacion.xaml
    /// </summary>                                                
    public partial class SingleRectificacion : UserControl
    {
        public Rectificacion rectificacion = new Rectificacion();

        public SingleRectificacion(Rectificacion reg)
        {
            InitializeComponent();
            rectificacion = reg;
            this.DataContext = rectificacion;

            btnActualizar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Collapsed;
        }

        public SingleRectificacion()
        {
                InitializeComponent();
                this.DataContext =  rectificacion;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateBC obj = new CreateBC();
                obj.Create( rectificacion);
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
                obj.Update( rectificacion,  rectificacion.IdRectificacion);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }
        }

        private void NuevoReg() {
 txtIdArticulo.Text = "";
 txtCantidad.Text = "";
 txtDescripcion.Text = "";
 txtFecha.Text = "";

        }
    }
}
