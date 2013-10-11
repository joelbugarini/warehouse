using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using FirstFloor.ModernUI.Windows.Controls;
using WarehouseManager.BC;
using Properties;

namespace WarehouseManager.Content
{
    public partial class ListSalida : UserControl
    {
        private List<Salida> Salidas = new List<Salida>();

        public ListSalida()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Salidas = obj.ReadSalida();

            this.DataContext = Salidas;

        }

        private void listSalida_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Salida register = listSalida.SelectedValue as Salida;

            if (register != null)
            {
                WarehouseManager.ListFactura.SalidaGlobal = register;
                new WarehouseManager.MainSalida().Show();
            }
        }

        public void Update()
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadSalida();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Salidas
                        orderby element.IdSalida
                        where (element.Nota.ToString().Trim().ToLower().Contains(txtNotaBusqueda.Text.Trim().ToLower()) &&
                        element.Fecha.ToString().Trim().ToLower().Contains(txtFechaBusqueda.Text.Trim().ToLower())
                         )
                        select element;

            this.DataContext = query;
        }
        private void headIdEmpleado(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Salidas
                        orderby element.IdEmpleado
                        select element;

            this.DataContext = query;
        }
        private void headNota(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Salidas
                        orderby element.Nota
                        select element;

            this.DataContext = query;
        }
        private void headFecha(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Salidas
                        orderby element.Fecha
                        select element;

            this.DataContext = query;
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
