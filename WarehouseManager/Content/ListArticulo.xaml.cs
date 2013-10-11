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
    public partial class ListArticulo : UserControl
    {
        private List<Articulo> Articulos = new List<Articulo>();

        public ListArticulo()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Articulos = obj.ReadArticulo();

            this.DataContext = Articulos;

        }

        private void listArticulo_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Articulo register = listArticulo.SelectedValue as Articulo;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SingleArticulo(register)
            }.ShowDialog();
        }

        public void Update()
        {
            ReadBC obj = new ReadBC();
            Articulos = obj.ReadArticulo();
            this.DataContext = Articulos;
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.IdArticulo
                        where (element.Nombre.ToString().Trim().ToLower().Contains(txtNombreBusqueda.Text.Trim().ToLower()) &&
                        element.Descripcion.ToString().Trim().ToLower().Contains(txtDescripcionBusqueda.Text.Trim().ToLower()) &&
                        element.Precio.ToString().Trim().ToLower().Contains(txtPrecioBusqueda.Text.Trim().ToLower()) &&
                        element.Unidad.ToString().Trim().ToLower().Contains(txtUnidadBusqueda.Text.Trim().ToLower()) &&
                        element.Cantidad.ToString().Trim().ToLower().Contains(txtCantidadBusqueda.Text.Trim().ToLower())
                         )
                        select element;

            this.DataContext = query;
        }
        private void headNombre(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.Nombre
                        select element;

            this.DataContext = query;
        }
        private void headDescripcion(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.Descripcion
                        select element;

            this.DataContext = query;
        }
        private void headPrecio(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.Precio
                        select element;

            this.DataContext = query;
        }
        private void headUnidad(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.Unidad
                        select element;

            this.DataContext = query;
        }
        private void headCantidad(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.Cantidad
                        select element;

            this.DataContext = query;
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            /*List<Articulo>[] tmpArticulos = new List<Articulo>[20];
            tmpArticulos[0] = new List<Articulo>();
            List<UserControl> reportes = new List<UserControl>();

            List<List<Articulo>> splitArticulos = new List<List<Articulo>>();
           
            int paginador = 0, ar = 0;

            foreach(Articulo art in Articulos)
            {
                if (paginador < 45)
                {
                    tmpArticulos[ar].Add(art);
                }
                else
                {
                   // reportes.Add(new Reports.Inventario(tmpArticulos));
                    splitArticulos.Add(tmpArticulos[ar]);
                    ar++;
                    tmpArticulos[ar] = new List<Articulo>(); ;
                    paginador = 0;

                }
                paginador++;
            }*/

            List<List<Articulo>> splitArticulos = new List<List<Articulo>>();
            List<UserControl> reportes = new List<UserControl>();

            splitArticulos = Split(Articulos, 45);

            foreach (List<Articulo> articulos in splitArticulos) 
            {
                reportes.Add(new Reports.Inventario(articulos));
            }

            Report objRep = new Report();
            objRep.Generar("", reportes);
        }

        public static List<List<Articulo>> Split(List<Articulo> source, int size)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / size)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }

        private void listArticulo_KeyUp(object sender, KeyEventArgs e)
        {
            Articulo art = listArticulo.SelectedValue as Articulo;
            if (art != null)
            {
                if (e.Key == Key.Delete)
                {
                    if (true == ModernDialog.ShowMessage("¿Desea eliminar el registro?", "Eliminar", System.Windows.MessageBoxButton.YesNo))
                    {
                        DeleteBC del = new DeleteBC();
                        del.DeleteArticulo(art.IdArticulo);
                        Update();
                    }
                }
            }
            else
            {
                ModernDialog.ShowMessage("No ha seleccionado ningun registro para eliminar", "Eliminar", System.Windows.MessageBoxButton.OK);
            }

        }

        private void Grid_MouseWheel_1(object sender, MouseWheelEventArgs e)
        {
            MessageBox.Show("Funcha");
        }

        private void listArticulo_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            MessageBox.Show("FunchaList");
        }
    }
}
