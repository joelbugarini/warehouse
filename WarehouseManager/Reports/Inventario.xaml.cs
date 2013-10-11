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
using Properties;

namespace WarehouseManager.Reports
{
    /// <summary>
    /// Interaction logic for Inventario.xaml
    /// </summary>
    public partial class Inventario : UserControl
    {
        public Inventario()
        {
            InitializeComponent();
        }
        public Inventario(List<Articulo> articulos)
        {
            InitializeComponent();

            DataContext = articulos;
        }
    }
}
