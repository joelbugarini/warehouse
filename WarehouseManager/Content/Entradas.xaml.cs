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
using FirstFloor.ModernUI.Windows.Controls;
using Properties;
using WarehouseManager.BC;

namespace WarehouseManager.Content
{
    /// <summary>
    /// Interaction logic for Entradas.xaml
    /// </summary>
    public partial class Entradas : UserControl
    {
        public static Entrada ArticuloNuevo { get; set; }
        public static bool agregar { get; set; }
        public FacturaProvedor factura { get; set; }
        private List<EntradaArticulo> EntradaArticulos = new List<EntradaArticulo>();
        private List<PendienteArticulo> PendienteArticulos = new List<PendienteArticulo>();
        public Entradas()
        {
            factura = WarehouseManager.ListFactura.facturaGlobal;
            InitializeComponent();
            ArticuloNuevo = new Entrada();
            ArticuloNuevo.IdFactura = factura.IdFactura;
            agregar = false;

            Update();
        }

        private void Update()
        {
            ReadBC objReader = new ReadBC();
            EntradaArticulos = objReader.ReadEntradaArticulo(factura.IdFactura);
            this.DataContext = EntradaArticulos;

            ReadBC objReaderPendiente = new ReadBC();
            PendienteArticulos = objReaderPendiente.ReadPendienteArticulo(factura.IdFactura);
            listPendienteArticulo.DataContext = PendienteArticulos;
            
            double total = 0;

            foreach (EntradaArticulo art in EntradaArticulos) 
            {
                total += art.Precio * art.Cantidad;
            }
            txtTotal.Text = total.ToString("$ 0.00");

        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in EntradaArticulos
                        orderby element.IdEntrada
                        where (element.Nombre.ToString().Trim().ToLower().Contains(txtNombreBusqueda.Text.Trim().ToLower()) &&
                        element.Descripcion.ToString().Trim().ToLower().Contains(txtDescripcionBusqueda.Text.Trim().ToLower()) &&
                        element.Precio.ToString().Trim().ToLower().Contains(txtPrecioBusqueda.Text.Trim().ToLower()) &&
                        element.Cantidad.ToString().Trim().ToLower().Contains(txtCantidadBusqueda.Text.Trim().ToLower())
                         )
                        select element;

            this.DataContext = query;
        }

        private void headNombre(object sender, MouseButtonEventArgs e)
        {
            var query = from element in EntradaArticulos
                        orderby element.Nombre
                        select element;

            this.DataContext = query;
        }
        private void headDescripcion(object sender, MouseButtonEventArgs e)
        {
            var query = from element in EntradaArticulos
                        orderby element.Descripcion
                        select element;

            this.DataContext = query;
        }
        private void headPrecio(object sender, MouseButtonEventArgs e)
        {
            var query = from element in EntradaArticulos
                        orderby element.Precio
                        select element;

            this.DataContext = query;
        }
        private void headCantidad(object sender, MouseButtonEventArgs e)
        {
            var query = from element in EntradaArticulos
                        orderby element.Cantidad
                        select element;

            this.DataContext = query;
        }

        private void listEntrada_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender != null)
            {
                EntradaArticulo register = listEntradaArticulo.SelectedValue as EntradaArticulo;

                ReadOneBC objReadOne = new ReadOneBC();
                DeleteBC objDelete = new DeleteBC();
                CreateBC objCreate = new CreateBC();
                UpdateBC objUpdate = new UpdateBC();

                Articulo art = objReadOne.ReadOneArticulo(register.IdArticulo);
                art.Cantidad = art.Cantidad - register.Cantidad;
                objUpdate.Update(art, art.IdArticulo);

                Pendiente pend = new Pendiente();
                pend.IdArticulo = register.IdArticulo;
                pend.IdFactura = register.IdFactura;
                pend.Cantidad = register.Cantidad;
                objCreate.Create(pend);

                objDelete.DeleteEntrada(register.IdEntrada);

                Update();
            }
        }

        private void listPendiente_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender != null)
            {
                PendienteArticulo register = listPendienteArticulo.SelectedValue as PendienteArticulo;

                ReadOneBC objReadOne = new ReadOneBC();
                DeleteBC objDelete = new DeleteBC();
                CreateBC objCreate = new CreateBC();
                UpdateBC objUpdate = new UpdateBC();

                Articulo art = objReadOne.ReadOneArticulo(register.IdArticulo);
                art.Cantidad = art.Cantidad + register.Cantidad;
                objUpdate.Update(art, art.IdArticulo);

                objDelete.DeletePendiente(register.IdPendiente);

                Entrada entr = new Entrada();
                entr.IdArticulo = register.IdArticulo;
                entr.IdFactura = register.IdFactura;
                entr.Cantidad = register.Cantidad;
                objCreate.Create(entr);

                Update();
            }
        }

        private void btnAgregarEntrada_Click(object sender, RoutedEventArgs e)
        {
            Pages.AgregarEntrada dialog = new Pages.AgregarEntrada();

            dialog.Title = "Agregar";
            dialog.Content = new Pages.AgregarArticulo();
            dialog.ResizeMode = ResizeMode.CanResize;
            dialog.UpdateLayout();
            dialog.ShowDialog();

            

            if (agregar) 
            {
                Entrada nuevaEntrada = new Entrada();
                nuevaEntrada = ArticuloNuevo;
                CreateBC objCreate = new CreateBC();
                objCreate.Create(nuevaEntrada);

                ReadBC objReader = new ReadBC();
                EntradaArticulos = objReader.ReadEntradaArticulo();
                this.DataContext = EntradaArticulos;
                agregar = false;
            }
            else 
            {
            
            }
            
        }

        private Entrada EntradaArticuloToEntrada(EntradaArticulo nuevo)
        {
            Entrada entrada = new Entrada();
            nuevo.IdEntrada = entrada.IdEntrada;
            nuevo.IdArticulo = entrada.IdArticulo;
            nuevo.Cantidad = entrada.Cantidad;
            nuevo.IdFactura = entrada.IdFactura;
            return entrada;
        }

        private EntradaArticulo EntradaToEntradaArticulo(Entrada nuevo)
        {
            EntradaArticulo entrada = new EntradaArticulo();
            nuevo.IdEntrada = entrada.IdEntrada;
            nuevo.IdArticulo = entrada.IdArticulo;
            nuevo.Cantidad = entrada.Cantidad;
            nuevo.IdFactura = entrada.IdFactura;
            return entrada;
        }

        private void btnEliminarEntrada_Click(object sender, RoutedEventArgs e)
        {
            EntradaArticulo reg = listEntradaArticulo.SelectedValue as EntradaArticulo;
            DeleteBC objDelete = new DeleteBC();
            objDelete.DeleteEntrada(reg.IdEntrada);

            ReadBC objReader = new ReadBC();
            EntradaArticulos = objReader.ReadEntradaArticulo(factura.IdFactura);
            this.DataContext = EntradaArticulos;
        }
    }
}
