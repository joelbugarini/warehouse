using FirstFloor.ModernUI.Windows.Controls;
using Properties;

namespace WarehouseManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainFactura : ModernWindow
    {
        public FacturaProvedor factura = ListFactura.facturaGlobal;
        private Provedor provedor = new Provedor();
        public MainFactura()
        {
            InitializeComponent();

            Title = factura.Provedor + " " + factura.NoFactura;
            nameTitle.DisplayName = factura.Provedor + " - " + factura.Fecha.ToString("dddd, dd MMMM yyyy") + " - " + factura.NoFactura;
        }
    }
}
