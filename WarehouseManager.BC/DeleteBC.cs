using Properties;
using WarehouseManager.DAC;

namespace WarehouseManager.BC
{
    public class DeleteBC
    {
        public string DeleteSalidaArticulo(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteSalidaArticulo(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteFacturaArticulo(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteFacturaArticulo(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeletePendiente(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deletePendiente(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteRectificacion(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteRectificacion(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteProvedor(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteProvedor(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteUsuario(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteUsuario(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteEmpleado(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteEmpleado(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteSalida(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteSalida(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteArticulo(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteArticulo(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteDevolucion(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteDevolucion(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteFactura(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteFactura(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteEntrada(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteEntrada(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }

    }
}