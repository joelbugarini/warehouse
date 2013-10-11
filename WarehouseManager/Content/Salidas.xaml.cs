using System;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using WarehouseManager.BC;

namespace WarehouseManager.Content
{
    /// <summary>
    /// Interaction logic for SingleSalida.xaml
    /// </summary>                                                
    public partial class Salidas : UserControl
    {
        public Salida salida = new Salida();

        public Salidas(Salida reg)
        {
            InitializeComponent();
            salida = reg;
            this.DataContext = salida;

            btnActualizar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Collapsed;
        }

        public Salidas()
        {
            InitializeComponent();
            this.DataContext = salida;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NuevoReg()
        {
            txtIdEmpleado.Text = "";
            txtNota.Text = "";
            txtFecha.Text = "";

        }
    }
}
