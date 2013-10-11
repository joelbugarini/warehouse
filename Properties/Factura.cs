using System;

namespace Properties
{
    public class Factura
    {
        private int idFactura;

        public int IdFactura
        {
            get { return idFactura; }
            set { idFactura = value; }
        }
        private int idProvedor;

        public int IdProvedor
        {
            get { return idProvedor; }
            set { idProvedor = value; }
        }
        private string noFactura;

        public string NoFactura
        {
            get { return noFactura; }
            set { noFactura = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

    }
}
