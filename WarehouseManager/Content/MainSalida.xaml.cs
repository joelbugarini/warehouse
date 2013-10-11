using FirstFloor.ModernUI.Windows.Controls;
using Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WarehouseManager.BC;

namespace WarehouseManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainSalida : ModernWindow
    {
        public Salida salida = ListFactura.SalidaGlobal;
        public MainSalida()
        {
            ReadOneBC obj = new ReadOneBC();
            InitializeComponent();
            nameTitle.DisplayName = obj.ReadOneEmpleado(salida.IdEmpleado).Nombre + " - " + salida.Fecha;
            this.Title = nameTitle.DisplayName;
        }
    }
}
