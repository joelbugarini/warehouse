using Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WarehouseManager.Reports
{
    /// <summary>
    /// Interaction logic for Salida.xaml
    /// </summary>
    public partial class Salida : UserControl
    {
        public Salida()
        {
            InitializeComponent();
        }

        public Salida(List<SalidaArticulos> articulos, string name)
        {
            InitializeComponent();
            txtNombre.Text = name;
            DataContext = articulos;
        }
    }
}
