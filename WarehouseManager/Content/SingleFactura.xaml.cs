using System;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using WarehouseManager.BC;
using System.Collections.Generic;
using System.Windows.Data;

namespace WarehouseManager.Content
{
    /// <summary>
    /// Interaction logic for SingleFactura.xaml
    /// </summary>                                                
    public partial class SingleFactura : UserControl
    {
        public Factura factura = new Factura();
        public List<Provedor> Proveedores { get; private set; }

        public SingleFactura(Factura reg)
        {
            InitializeComponent();

            txtIdProvedor.ItemsSource = Proveedores;
            factura = reg;

            ReadBC objRead = new ReadBC();
            
            btnActualizar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Collapsed;
        }

        public SingleFactura()
        { 
            ReadBC objRead = new ReadBC();
            Proveedores = objRead.ReadProvedor();

           

            /*txtIdProvedor.ItemsSource = Proveedores;
            txtIdProvedor.SelectedValue = "IdProvedor";
            
            */

            factura.Fecha = DateTime.Now;
            InitializeComponent();

            Binding binding = new Binding();
            binding.Source = Proveedores;

            txtIdProvedor.DisplayMemberPath = "Nombre";
            txtIdProvedor.SelectedValuePath = "IdProvedor";
            txtIdProvedor.SetBinding(ComboBox.ItemsSourceProperty, binding);

            this.DataContext = factura;
           
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateBC obj = new CreateBC();
                obj.Create(factura);
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
                obj.Update(factura, factura.IdFactura);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }
        }

        private void NuevoReg()
        {
            txtIdProvedor.Text = "";
            txtNoFactura.Text = "";
            txtFecha.SelectedDate = null;
            
        }
    }
}
