using System;

namespace Properties
{
    public class EntradaArticulo
    {
        private int idEntrada;
        public int IdEntrada
        {
            get { return idEntrada; }
            set { idEntrada = value; }
        }

        private int idFactura;
        public int IdFactura
        {
            get { return idFactura; }
            set { idFactura = value; }
        }

        private int idArticulo;
        public int IdArticulo
        {
            get { return idArticulo; }
            set { idArticulo = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private float precio;
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private int cantidad;
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

    }
}
