using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using FirstFloor.ModernUI.Windows.Controls;
using WarehouseManager.BC;
using Properties;
using System;

namespace WarehouseManager.Content
{
    public partial class ListSalidaArticulo : UserControl
    {
        private List<SalidaArticulos> SalidaArticulos = new List<SalidaArticulos>();
        public Salida salida = WarehouseManager.ListFactura.SalidaGlobal;
        private List<Articulo> Articulos = new List<Articulo>();

        public ListSalidaArticulo()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Articulos = obj.ReadArticulo();
            SalidaArticulos = obj.ReadSalidaArticulos(salida.IdSalida);

            listArticulo.DataContext = Articulos;
            listSalidaArticulos.DataContext = SalidaArticulos;


        }

       

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            listSalidaArticulos.DataContext = obj.ReadSalidaArticulos(salida.IdSalida);
            listArticulo.DataContext = obj.ReadArticulo();
        }


        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }

        /*----------------------------------------------------------------*/
        /*-------------------Articulo functions---------------------------*/
        /*----------------------------------------------------------------*/


        private void txtBusqueda_TextChanged2(object sender, TextChangedEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.IdArticulo
                        where (element.Nombre.ToString().Trim().ToLower().Contains(txtNombreBusqueda2.Text.Trim().ToLower()) &&
                        element.Descripcion.ToString().Trim().ToLower().Contains(txtDescripcionBusqueda2.Text.Trim().ToLower()) &&
                        element.Precio.ToString().Trim().ToLower().Contains(txtPrecioBusqueda2.Text.Trim().ToLower()) &&
                        element.Unidad.ToString().Trim().ToLower().Contains(txtUnidadBusqueda2.Text.Trim().ToLower()) &&
                        element.Cantidad.ToString().Trim().ToLower().Contains(txtCantidadBusqueda2.Text.Trim().ToLower())
                         )
                        select element;

            listArticulo.DataContext = query;
        }
        private void headNombre2(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.Nombre
                        select element;

            this.DataContext = query;
        }
        private void headDescripcion2(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.Descripcion
                        select element;

            this.DataContext = query;
        }
        private void headPrecio2(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.Precio
                        select element;

            this.DataContext = query;
        }
        private void headUnidad2(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.Unidad
                        select element;

            this.DataContext = query;
        }
        private void headCantidad2(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Articulos
                        orderby element.Cantidad
                        select element;

            this.DataContext = query;
        }

        private void listArticulo_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Articulo art = listArticulo.SelectedValue as Articulo;
            art.Cantidad = art.Cantidad - Convert.ToInt32(btnCantidad.Text);
            UpdateBC objUpdate = new UpdateBC();

            objUpdate.Update(art, art.IdArticulo);

            CreateBC objCreate = new CreateBC();
            SalidaArticulo salida2 = new SalidaArticulo();
            salida2.IdSalida = salida.IdSalida;
            salida2.IdArticulo = art.IdArticulo;
            salida2.Cantidad = Convert.ToInt32(btnCantidad.Text);

            objCreate.Create(salida2);
            Update();
        }

        private void listSalidaArticulos_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SalidaArticulos art = listSalidaArticulos.SelectedValue as SalidaArticulos;
            SalidaArticulo salidaArt = new SalidaArticulo();

            salidaArt.IdArticulo = art.IdArticulo;
            salidaArt.IdSalida = art.IdSalida;
            salidaArt.IdSalidaArticulo = art.IdSalidaArticulo;
            salidaArt.Cantidad = art.Cantidad;


            UpdateBC objUpdate = new UpdateBC();
            
            ReadOneBC objRead = new ReadOneBC();
            Articulo artUpdate = objRead.ReadOneArticulo(salidaArt.IdArticulo);
            artUpdate.Cantidad += Convert.ToInt16(btnCantidad2.Text);
            salidaArt.Cantidad -= Convert.ToInt16(btnCantidad2.Text);

           

            objUpdate.Update(artUpdate, salidaArt.IdArticulo);
            if (salidaArt.Cantidad == 0)
            {
                DeleteBC objDel = new DeleteBC();
                objDel.DeleteSalidaArticulo(salidaArt.IdSalidaArticulo);
            }
            else
            {
                objUpdate.Update(salidaArt, salidaArt.IdSalidaArticulo);
            }

            Update();

        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            ReadOneBC objRead = new ReadOneBC();
            ReadBC obj = new ReadBC();
            Empleado emp = objRead.ReadOneEmpleado(salida.IdEmpleado);

            List<List<SalidaArticulos>> splitArticulos = new List<List<SalidaArticulos>>();
            List<UserControl> reportes = new List<UserControl>();

            splitArticulos = Split( obj.ReadSalidaArticulos(salida.IdSalida), 45);

            foreach (List<SalidaArticulos> articulos in splitArticulos)
            {
                reportes.Add(new Reports.Salida(articulos, emp.Nombre +" "+ emp.ApellidoPaterno));
            }

            Report objRep = new Report();
            objRep.Generar("", reportes);
        }


        public static List<List<SalidaArticulos>> Split(List<SalidaArticulos> source, int size)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / size)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }

    }
}
