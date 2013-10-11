using System;

namespace Properties
{
    public class Salida
    {
        private int idSalida;

        public int IdSalida
        {
            get { return idSalida; }
            set { idSalida = value; }
        }
        private int idEmpleado;

        public int IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string nota;

        public string Nota
        {
            get { return nota; }
            set { nota = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

    }
}
