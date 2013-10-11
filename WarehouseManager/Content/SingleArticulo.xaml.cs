using System;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using WarehouseManager.BC;

namespace WarehouseManager.Content
{
    /// <summary>
    /// Interaction logic for SingleArticulo.xaml
    /// </summary>                                                
    public partial class SingleArticulo : UserControl
    {
        public Articulo articulo = new Articulo();

        public SingleArticulo(Articulo reg)
        {
            InitializeComponent();
            articulo = reg;
            this.DataContext = articulo;

            btnActualizar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Collapsed;

            /* txtCantidad.IsReadOnly = true;
             txtPrecio.IsReadOnly = true;
             txtUnidad.IsReadOnly = true;*/
        }

        public SingleArticulo()
        {
            InitializeComponent();
            this.DataContext = articulo;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {                                                                   
            try
            {
                CreateBC obj = new CreateBC();
                obj.Create(articulo);
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
                obj.Update(articulo, articulo.IdArticulo);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }
        }

        private void NuevoReg()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtUnidad.Text = "";
            txtCantidad.Text = "";
           
        }
    }
}
