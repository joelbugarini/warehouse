using System;

namespace Properties
{
    public class SalidaArticulos
    {
        private int idSalidaArticulo;

        public int IdSalidaArticulo
        {
            get { return idSalidaArticulo; }
            set { idSalidaArticulo = value; }
        }
        private int idSalida;

        public int IdSalida
        {
            get { return idSalida; }
            set { idSalida = value; }
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
        private string unidad;

        public string Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

    }
}
