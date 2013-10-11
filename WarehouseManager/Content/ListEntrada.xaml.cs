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
    public partial class ListEntrada : UserControl
    {
        private List<Entrada> Entradas = new List<Entrada>();

        public ListEntrada()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Entradas = obj.ReadEntrada();

            this.DataContext = Entradas;

        }

        private void listEntrada_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Entrada register = listEntrada.SelectedValue as Entrada;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SingleEntrada(register)
            }.ShowDialog();
        }

        public void Update()
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadEntrada();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Entradas
                        orderby element.IdEntrada
                        where (element.IdFactura.ToString().Trim().ToLower().Contains(txtIdFacturaBusqueda.Text.Trim().ToLower()) &&
                        element.IdArticulo.ToString().Trim().ToLower().Contains(txtIdArticuloBusqueda.Text.Trim().ToLower()) &&
                        element.Cantidad.ToString().Trim().ToLower().Contains(txtCantidadBusqueda.Text.Trim().ToLower())
                         )
                        select element;

            this.DataContext = query;
        }
        private void headIdFactura(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Entradas
                        orderby element.IdFactura
                        select element;

            this.DataContext = query;
        }
        private void headIdArticulo(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Entradas
                        orderby element.IdArticulo
                        select element;

            this.DataContext = query;
        }
        private void headCantidad(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Entradas
                        orderby element.Cantidad
                        select element;

            this.DataContext = query;
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
   
    }
}
