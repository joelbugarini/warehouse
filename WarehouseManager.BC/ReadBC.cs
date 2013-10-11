using Properties;
using System.Collections.Generic;
using WarehouseManager.DAC;

namespace WarehouseManager.BC
{
    public class ReadBC
    {
        public List<SalidaArticulo> ReadSalidaArticulo()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readSalidaArticulo();
        }
        public List<SalidaArticulos> ReadSalidaArticulos(int idSalida)
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readSalidaArticulos(idSalida);
        }
        public List<FacturaArticulo> ReadFacturaArticulo()
        {
            ReadDAC objDAC = new ReadDAC();

            return objDAC.readFacturaArticulo();
        }
        public List<Pendiente> ReadPendiente()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readPendiente();
        }
        public List<Entrada> ReadEntrada()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readEntrada();
        }
        public List<Rectificacion> ReadRectificacion()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readRectificacion();
        }
        public List<Provedor> ReadProvedor()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readProvedor();
        }
        public List<Usuario> ReadUsuario()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readUsuario();
        }
        public List<Empleado> ReadEmpleado()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readEmpleado();
        }
        public List<Salida> ReadSalida()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readSalida();
        }
        public List<Articulo> ReadArticulo()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readArticulo();
        }
        public List<Devolucion> ReadDevolucion()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readDevolucion();
        }
        public List<Factura> ReadFactura()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readFactura();
        }

        public List<Entrada> ReadCustomEntrada(string query)
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readCustomEntrada(query);
        }

        public List<FacturaProvedor> ReadFactura(string query)
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readFactura(query);
        }

        public List<EntradaArticulo> ReadEntradaArticulo()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readEntradaArticulo();
        }

        public List<EntradaArticulo> ReadEntradaArticulo(int factura)
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readEntradaArticulo(factura);
        }
        public List<PendienteArticulo> ReadPendienteArticulo(int id)
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readPendienteArticulo(id);
        }
    }
}