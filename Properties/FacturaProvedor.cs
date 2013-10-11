using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Properties
{
    public class FacturaProvedor
    {
        private int idFactura;

        public int IdFactura
        {
            get { return idFactura; }
            set { idFactura = value; }
        }
        private string provedor;

        public string Provedor
        {
            get { return provedor; }
            set { provedor = value; }
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
