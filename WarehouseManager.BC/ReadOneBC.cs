using Properties;
using System.Collections.Generic;
using WarehouseManager.DAC;

namespace WarehouseManager.BC
{
    public class ReadOneBC
    {
 public SalidaArticulo ReadOneSalidaArticulo(int idSalidaArticulo)
        {

             ReadOneDAC objDAC = new ReadOneDAC();
           
                return objDAC.readOneSalidaArticulo(idSalidaArticulo);
        }
 public FacturaArticulo ReadOneFacturaArticulo(int idFacturaArticulo)
        {

             ReadOneDAC objDAC = new ReadOneDAC();
           
                return objDAC.readOneFacturaArticulo(idFacturaArticulo);
        }
 public Pendiente ReadOnePendiente(int idPendiente)
        {

             ReadOneDAC objDAC = new ReadOneDAC();
           
                return objDAC.readOnePendiente(idPendiente);
        }
 public Entrada ReadOneEntrada(int idEntrada)
        {

             ReadOneDAC objDAC = new ReadOneDAC();
           
                return objDAC.readOneEntrada(idEntrada);
        }
 public Rectificacion ReadOneRectificacion(int idRectificacion)
        {

             ReadOneDAC objDAC = new ReadOneDAC();
           
                return objDAC.readOneRectificacion(idRectificacion);
        }
 public Provedor ReadOneProvedor(int idProvedor)
        {

             ReadOneDAC objDAC = new ReadOneDAC();
           
                return objDAC.readOneProvedor(idProvedor);
        }
 public Usuario ReadOneUsuario(int idUsuario)
        {

             ReadOneDAC objDAC = new ReadOneDAC();
           
                return objDAC.readOneUsuario(idUsuario);
        }
 public Empleado ReadOneEmpleado(int idEmpleado)
        {

             ReadOneDAC objDAC = new ReadOneDAC();
           
                return objDAC.readOneEmpleado(idEmpleado);
        }
 public Salida ReadOneSalida(int idSalida)
        {

             ReadOneDAC objDAC = new ReadOneDAC();
           
                return objDAC.readOneSalida(idSalida);
        }
 public Articulo ReadOneArticulo(int idArticulo)
        {

             ReadOneDAC objDAC = new ReadOneDAC();
           
                return objDAC.readOneArticulo(idArticulo);
        }
 public Devolucion ReadOneDevolucion(int idDevolucion)
        {

             ReadOneDAC objDAC = new ReadOneDAC();
           
                return objDAC.readOneDevolucion(idDevolucion);
        }
 public Factura ReadOneFactura(int idFactura)
        {

             ReadOneDAC objDAC = new ReadOneDAC();
           
                return objDAC.readOneFactura(idFactura);
        }
 

    }
}