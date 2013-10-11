using Properties;
using WarehouseManager.DAC;

namespace WarehouseManager.BC
{
    public class CreateBC
    {
        public string Create(SalidaArticulo obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(FacturaArticulo obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(Pendiente obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(Entrada obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(Rectificacion obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(Provedor obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(Usuario obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(Empleado obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(Salida obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(Articulo obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(Devolucion obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(Factura obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
    }
}