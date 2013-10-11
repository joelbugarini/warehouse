using Properties;
using WarehouseManager.DAC;

namespace WarehouseManager.BC
{
    public class UpdateBC
    {
 public string Update(SalidaArticulo obj, int idSalidaArticulo)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idSalidaArticulo) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
 public string Update(FacturaArticulo obj, int idFacturaArticulo)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idFacturaArticulo) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
 public string Update(Pendiente obj, int idPendiente)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idPendiente) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
 public string Update(Entrada obj, int idEntrada)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idEntrada) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
 public string Update(Rectificacion obj, int idRectificacion)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idRectificacion) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
 public string Update(Provedor obj, int idProvedor)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idProvedor) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
 public string Update(Usuario obj, int idUsuario)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idUsuario) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
 public string Update(Empleado obj, int idEmpleado)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idEmpleado) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
 public string Update(Salida obj, int idSalida)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idSalida) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
 public string Update(Articulo obj, int idArticulo)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idArticulo) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
 public string Update(Devolucion obj, int idDevolucion)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idDevolucion) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
 public string Update(Factura obj, int idFactura)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idFactura) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }

    }
}