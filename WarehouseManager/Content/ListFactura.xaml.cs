using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using FirstFloor.ModernUI.Windows.Controls;
using WarehouseManager.BC;
using Properties;
using System.Windows.Data;
using System;
using System.Globalization;

namespace WarehouseManager.Content
{
    public partial class ListFactura : UserControl
    {
        private List<FacturaProvedor> Facturas = new List<FacturaProvedor>();

        public ListFactura()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Facturas = obj.ReadFactura(@"
            select IdFactura,(select Nombre 
				  from Provedor 
				  where Provedor.IdProvedor = Factura.IdProvedor ) as Provedor, NoFactura, Fecha 
from Factura");

            this.DataContext = Facturas;

        }

        private void listFactura_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            FacturaProvedor register = listFactura.SelectedValue as FacturaProvedor;
            
            if (register != null)
            {
                WarehouseManager.ListFactura.facturaGlobal = register;
                new WarehouseManager.MainFactura().Show();
            }
        }

        public void Update()
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadFactura(@"
            select IdFactura,(select Nombre 
				  from Provedor 
				  where Provedor.IdProvedor = Factura.IdProvedor ) as Provedor, NoFactura, Fecha 
from Factura");
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Facturas
                        orderby element.IdFactura
                        where (element.Provedor.ToString().Trim().ToLower().Contains(txtIdProvedorBusqueda.Text.Trim().ToLower()) &&
                        element.NoFactura.ToString().Trim().ToLower().Contains(txtNoFacturaBusqueda.Text.Trim().ToLower()) &&
                        element.Fecha.ToString("dddd, dd MMMM yyyy").Trim().ToLower().Contains(txtFechaBusqueda.Text.Trim().ToLower())
                         )
                        select element;

            this.DataContext = query;
        }



        private void headIdProvedor(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Facturas
                        orderby element.Provedor
                        select element;

            this.DataContext = query;
        }
        private void headNoFactura(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Facturas
                        orderby element.NoFactura
                        select element;

            this.DataContext = query;
        }
        private void headFecha(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Facturas
                        orderby element.Fecha.ToString("dddd, dd MMMM yyyy")
                        select element;

            this.DataContext = query;
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void listFactura_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                FacturaProvedor factura = listFactura.SelectedValue as FacturaProvedor;
                if (factura != null)
                {

                    if (true == ModernDialog.ShowMessage("¿Desea eliminar el registro?", "Eliminar", System.Windows.MessageBoxButton.YesNo))
                    {
                        DeleteBC del = new DeleteBC();
                        del.DeleteFactura(factura.IdFactura);
                        Update();
                    }
                }
                else
                {
                    ModernDialog.ShowMessage("No ha seleccionado ningun registro para eliminar", "Eliminar", System.Windows.MessageBoxButton.OK);
                }
            }
        }

    
    }

    [ValueConversion(typeof(System.DateTime), typeof(string))]
    public class ConvertDateToFullDate : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime? res = value as DateTime?;
            if (res.HasValue)
                return res.Value.ToString("dddd, dd MMMM yyyy");

            return value;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime res;
            if (DateTime.TryParse(value.ToString(), out res))
                return res;

            return value;
        }
    }
}
