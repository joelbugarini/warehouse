using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Properties;
using System.Data;
using System.Data.SqlClient;

namespace WarehouseManager.DAC
{
    public class ReadDAC
    {
        DBInfo Info = new DBInfo();
        public List<SalidaArticulo> readSalidaArticulo()
        {
            List<SalidaArticulo> salidaArticuloList = new List<SalidaArticulo>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_SalidaArticulo_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        SalidaArticulo tmp = new SalidaArticulo();

                        tmp.IdSalidaArticulo = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdSalidaArticulo;
                        tmp.IdSalida = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdSalida;
                        tmp.IdArticulo = (reader.GetValue(2) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(2)) : tmp.IdArticulo;

                        salidaArticuloList.Add(tmp);
                    }
                }

                con.Close();
            }

            return salidaArticuloList;
        }

        public List<SalidaArticulos> readSalidaArticulos(int idSalida)
        {
            List<SalidaArticulos> salidaArticulosList = new List<SalidaArticulos>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_SalidaArticulos_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdSalida", idSalida);

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        SalidaArticulos tmp = new SalidaArticulos();

                        tmp.IdSalidaArticulo = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdSalidaArticulo;
                        tmp.IdSalida = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdSalida;
                        tmp.IdArticulo = (reader.GetValue(2) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(2)) : tmp.IdArticulo;
                        tmp.Nombre = (reader.GetValue(3) != DBNull.Value) ? Convert.ToString(reader.GetValue(3)) : tmp.Nombre;
                        tmp.Descripcion = (reader.GetValue(4) != DBNull.Value) ? Convert.ToString(reader.GetValue(4)) : tmp.Descripcion;
                        tmp.Precio = (reader.GetValue(5) != DBNull.Value) ? Convert.ToSingle(reader.GetValue(5)) : tmp.Precio;
                        tmp.Unidad = (reader.GetValue(6) != DBNull.Value) ? Convert.ToString(reader.GetValue(6)) : tmp.Unidad;
                        tmp.Cantidad = (reader.GetValue(7) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(7)) : tmp.Cantidad;

                        salidaArticulosList.Add(tmp);
                    }
                }

                con.Close();
            }

            return salidaArticulosList;
        }

        public List<FacturaArticulo> readFacturaArticulo()
        {
            List<FacturaArticulo> facturaArticuloList = new List<FacturaArticulo>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_FacturaArticulo_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        FacturaArticulo tmp = new FacturaArticulo();

                        tmp.IdFacturaArticulo = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdFacturaArticulo;
                        tmp.IdFactura = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdFactura;
                        tmp.IdArticulo = (reader.GetValue(2) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(2)) : tmp.IdArticulo;
                        tmp.Cantidad = (reader.GetValue(3) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(3)) : tmp.Cantidad;

                        facturaArticuloList.Add(tmp);
                    }
                }

                con.Close();
            }

            return facturaArticuloList;
        }
        public List<Pendiente> readPendiente()
        {
            List<Pendiente> pendienteList = new List<Pendiente>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Pendiente_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Pendiente tmp = new Pendiente();

                        tmp.IdPendiente = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdPendiente;
                        tmp.IdFactura = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdFactura;
                        tmp.IdArticulo = (reader.GetValue(2) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(2)) : tmp.IdArticulo;
                        tmp.Cantidad = (reader.GetValue(3) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(3)) : tmp.Cantidad;

                        pendienteList.Add(tmp);
                    }
                }

                con.Close();
            }

            return pendienteList;
        }
        public List<Entrada> readEntrada()
        {
            List<Entrada> entradaList = new List<Entrada>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Entrada_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Entrada tmp = new Entrada();

                        tmp.IdEntrada = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdEntrada;
                        tmp.IdFactura = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdFactura;
                        tmp.IdArticulo = (reader.GetValue(2) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(2)) : tmp.IdArticulo;
                        tmp.Cantidad = (reader.GetValue(3) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(3)) : tmp.Cantidad;

                        entradaList.Add(tmp);
                    }
                }

                con.Close();
            }

            return entradaList;
        }

        public List<Entrada> readCustomEntrada(string query)
        {
            List<Entrada> entradaList = new List<Entrada>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                   
                SqlCommand com = new SqlCommand(query, con);

                con.Open();

                using (SqlDataReader reader = com.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Entrada tmp = new Entrada();

                        tmp.IdEntrada = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdEntrada;
                        tmp.IdFactura = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdFactura;
                        tmp.IdArticulo = (reader.GetValue(2) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(2)) : tmp.IdArticulo;
                        tmp.Cantidad = (reader.GetValue(3) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(3)) : tmp.Cantidad;

                        entradaList.Add(tmp);
                    }
                }

                con.Close();
            }

            return entradaList;
        }
        public List<Rectificacion> readRectificacion()
        {
            List<Rectificacion> rectificacionList = new List<Rectificacion>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Rectificacion_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Rectificacion tmp = new Rectificacion();

                        tmp.IdRectificacion = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdRectificacion;
                        tmp.IdArticulo = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdArticulo;
                        tmp.Cantidad = (reader.GetValue(2) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(2)) : tmp.Cantidad;
                        tmp.Descripcion = (reader.GetValue(3) != DBNull.Value) ? Convert.ToString(reader.GetValue(3)) : tmp.Descripcion;
                        tmp.Fecha = (reader.GetValue(4) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(4)) : tmp.Fecha;

                        rectificacionList.Add(tmp);
                    }
                }

                con.Close();
            }

            return rectificacionList;
        }
        public List<Provedor> readProvedor()
        {
            List<Provedor> provedorList = new List<Provedor>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Provedor_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Provedor tmp = new Provedor();

                        tmp.IdProvedor = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdProvedor;
                        tmp.Nombre = (reader.GetValue(1) != DBNull.Value) ? Convert.ToString(reader.GetValue(1)) : tmp.Nombre;
                        tmp.RFC = (reader.GetValue(2) != DBNull.Value) ? Convert.ToString(reader.GetValue(2)) : tmp.RFC;
                        tmp.Direccion = (reader.GetValue(3) != DBNull.Value) ? Convert.ToString(reader.GetValue(3)) : tmp.Direccion;
                        tmp.Telefono = (reader.GetValue(4) != DBNull.Value) ? Convert.ToString(reader.GetValue(4)) : tmp.Telefono;

                        provedorList.Add(tmp);
                    }
                }

                con.Close();
            }

            return provedorList;
        }
        public List<Usuario> readUsuario()
        {
            List<Usuario> usuarioList = new List<Usuario>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Usuario_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Usuario tmp = new Usuario();

                        tmp.IdUsuario = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdUsuario;
                        tmp.Nombre = (reader.GetValue(1) != DBNull.Value) ? Convert.ToString(reader.GetValue(1)) : tmp.Nombre;
                        tmp.Contraseña = (reader.GetValue(2) != DBNull.Value) ? Convert.ToString(reader.GetValue(2)) : tmp.Contraseña;
                        tmp.Tipo = (reader.GetValue(3) != DBNull.Value) ? Convert.ToString(reader.GetValue(3)) : tmp.Tipo;

                        usuarioList.Add(tmp);
                    }
                }

                con.Close();
            }

            return usuarioList;
        }
        public List<Empleado> readEmpleado()
        {
            List<Empleado> empleadoList = new List<Empleado>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Empleado_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Empleado tmp = new Empleado();

                        tmp.IdEmpleado = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdEmpleado;
                        tmp.NoEmpleado = (reader.GetValue(1) != DBNull.Value) ? Convert.ToString(reader.GetValue(1)) : tmp.NoEmpleado;
                        tmp.Nombre = (reader.GetValue(2) != DBNull.Value) ? Convert.ToString(reader.GetValue(2)) : tmp.Nombre;
                        tmp.ApellidoPaterno = (reader.GetValue(3) != DBNull.Value) ? Convert.ToString(reader.GetValue(3)) : tmp.ApellidoPaterno;
                        tmp.ApellidoMaterno = (reader.GetValue(4) != DBNull.Value) ? Convert.ToString(reader.GetValue(4)) : tmp.ApellidoMaterno;
                        tmp.Departamento = (reader.GetValue(5) != DBNull.Value) ? Convert.ToString(reader.GetValue(5)) : tmp.Departamento;

                        empleadoList.Add(tmp);
                    }
                }

                con.Close();
            }

            return empleadoList;
        }
        public List<Salida> readSalida()
        {
            List<Salida> salidaList = new List<Salida>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SELECT IdSalida, IdEmpleado, Nota, Fecha, (SELECT Nombre+ ' ' + ApellidoPaterno + ' ' + ApellidoMaterno FROM Empleado Where IdEmpleado  = Salida.IdEmpleado) AS Nombre FROM Salida  ", con);
                //cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Salida tmp = new Salida();

                        tmp.IdSalida = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdSalida;
                        tmp.IdEmpleado = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdEmpleado;
                        tmp.Nota = (reader.GetValue(2) != DBNull.Value) ? Convert.ToString(reader.GetValue(2)) : tmp.Nota;
                        tmp.Fecha = (reader.GetValue(3) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(3)) : tmp.Fecha;
                        tmp.Nombre = (reader.GetValue(4) != DBNull.Value) ? Convert.ToString(reader.GetValue(4)) : tmp.Nombre;
                       

                        salidaList.Add(tmp);
                    }
                }

                con.Close();
            }

            return salidaList;
        }
        public List<Articulo> readArticulo()
        {
            List<Articulo> articuloList = new List<Articulo>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Articulo_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Articulo tmp = new Articulo();

                        tmp.IdArticulo = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdArticulo;
                        tmp.Nombre = (reader.GetValue(1) != DBNull.Value) ? Convert.ToString(reader.GetValue(1)) : tmp.Nombre;
                        tmp.Descripcion = (reader.GetValue(2) != DBNull.Value) ? Convert.ToString(reader.GetValue(2)) : tmp.Descripcion;
                        tmp.Precio = (reader.GetValue(3) != DBNull.Value) ? Convert.ToSingle(reader.GetValue(3)) : tmp.Precio;
                        tmp.Unidad = (reader.GetValue(4) != DBNull.Value) ? Convert.ToString(reader.GetValue(4)) : tmp.Unidad;
                        tmp.Cantidad = (reader.GetValue(5) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(5)) : tmp.Cantidad;

                        articuloList.Add(tmp);
                    }
                }

                con.Close();
            }

            return articuloList;
        }
        public List<Devolucion> readDevolucion()
        {
            List<Devolucion> devolucionList = new List<Devolucion>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Devolucion_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Devolucion tmp = new Devolucion();

                        tmp.IdDevolucion = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdDevolucion;
                        tmp.IdEmpleado = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdEmpleado;
                        tmp.IdArticulo = (reader.GetValue(2) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(2)) : tmp.IdArticulo;
                        tmp.Cantidad = (reader.GetValue(3) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(3)) : tmp.Cantidad;
                        tmp.Nota = (reader.GetValue(4) != DBNull.Value) ? Convert.ToString(reader.GetValue(4)) : tmp.Nota;
                        tmp.Fecha = (reader.GetValue(5) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(5)) : tmp.Fecha;

                        devolucionList.Add(tmp);
                    }
                }

                con.Close();
            }

            return devolucionList;
        }
        public List<Factura> readFactura()
        {
            List<Factura> facturaList = new List<Factura>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Factura_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Factura tmp = new Factura();

                        tmp.IdFactura = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdFactura;
                        tmp.IdProvedor = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdProvedor;
                        tmp.NoFactura = (reader.GetValue(2) != DBNull.Value) ? Convert.ToString(reader.GetValue(2)) : tmp.NoFactura;
                        tmp.Fecha = (reader.GetValue(3) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(3)) : tmp.Fecha;

                        facturaList.Add(tmp);
                    }
                }

                con.Close();
            }

            return facturaList;
        }

        public List<FacturaProvedor> readFactura(string query)
        {
            List<FacturaProvedor> facturaList = new List<FacturaProvedor>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        FacturaProvedor tmp = new FacturaProvedor();

                        tmp.IdFactura = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdFactura;
                        tmp.Provedor = (reader.GetValue(1) != DBNull.Value) ? Convert.ToString(reader.GetValue(1)) : tmp.Provedor;
                        tmp.NoFactura = (reader.GetValue(2) != DBNull.Value) ? Convert.ToString(reader.GetValue(2)) : tmp.NoFactura;
                        tmp.Fecha = (reader.GetValue(3) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(3)) : tmp.Fecha;

                        facturaList.Add(tmp);
                    }
                }

                con.Close();
            }

            return facturaList;
        }
        public List<EntradaArticulo> readEntradaArticulo()
        {
            List<EntradaArticulo> entradaArticuloList = new List<EntradaArticulo>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_EntradaArticulo_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        EntradaArticulo tmp = new EntradaArticulo();

                        tmp.IdEntrada = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdEntrada;
                        tmp.IdFactura = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdFactura;
                        tmp.IdArticulo = (reader.GetValue(2) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(2)) : tmp.IdArticulo;
                        tmp.Nombre = (reader.GetValue(3) != DBNull.Value) ? Convert.ToString(reader.GetValue(3)) : tmp.Nombre;
                        tmp.Descripcion = (reader.GetValue(4) != DBNull.Value) ? Convert.ToString(reader.GetValue(4)) : tmp.Descripcion;
                        tmp.Precio = (reader.GetValue(5) != DBNull.Value) ? Convert.ToSingle(reader.GetValue(5)) : tmp.Precio;
                        tmp.Cantidad = (reader.GetValue(6) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(6)) : tmp.Cantidad;

                        entradaArticuloList.Add(tmp);
                    }
                }

                con.Close();
            }

            return entradaArticuloList;
        }

        public List<EntradaArticulo> readEntradaArticulo(int idfactura)
        {
            List<EntradaArticulo> entradaArticuloList = new List<EntradaArticulo>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_EntradaArticulo_SelectCustom", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdFactura", idfactura);

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        EntradaArticulo tmp = new EntradaArticulo();

                        tmp.IdEntrada = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdEntrada;
                        tmp.IdFactura = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdFactura;
                        tmp.IdArticulo = (reader.GetValue(2) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(2)) : tmp.IdArticulo;
                        tmp.Nombre = (reader.GetValue(3) != DBNull.Value) ? Convert.ToString(reader.GetValue(3)) : tmp.Nombre;
                        tmp.Descripcion = (reader.GetValue(4) != DBNull.Value) ? Convert.ToString(reader.GetValue(4)) : tmp.Descripcion;
                        tmp.Precio = (reader.GetValue(5) != DBNull.Value) ? Convert.ToSingle(reader.GetValue(5)) : tmp.Precio;
                        tmp.Cantidad = (reader.GetValue(6) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(6)) : tmp.Cantidad;

                        entradaArticuloList.Add(tmp);
                    }
                }

                con.Close();
            }

            return entradaArticuloList;
        }

        public List<PendienteArticulo> readPendienteArticulo(int id)
        {
            List<PendienteArticulo> pendienteArticuloList = new List<PendienteArticulo>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_PendienteArticulo_SelectCustom", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdFactura", id);

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        PendienteArticulo tmp = new PendienteArticulo();

                        tmp.IdPendiente = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdPendiente;
                        tmp.IdFactura = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdFactura;
                        tmp.IdArticulo = (reader.GetValue(2) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(2)) : tmp.IdArticulo;
                        tmp.Cantidad = (reader.GetValue(4) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(4)) : tmp.Cantidad;
                        tmp.Nombre = (reader.GetValue(3) != DBNull.Value) ? Convert.ToString(reader.GetValue(3)) : tmp.Nombre;

                        pendienteArticuloList.Add(tmp);
                    }
                }

                con.Close();
            }

            return pendienteArticuloList;
        }

    }
}
            