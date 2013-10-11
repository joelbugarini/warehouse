using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Properties;
using System.Data;
using System.Data.SqlClient;

namespace WarehouseManager.DAC
{
    public class ReadOneDAC
    {
        DBInfo Info = new DBInfo();
        public SalidaArticulo readOneSalidaArticulo(int idSalidaArticulo)
        {
            SalidaArticulo salidaArticulo = new SalidaArticulo();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_SalidaArticulo_SelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdSalidaArticulo", idSalidaArticulo);

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

                        salidaArticulo = tmp;
                    }
                }

                con.Close();
            }

            return salidaArticulo;
        }
        public FacturaArticulo readOneFacturaArticulo(int idFacturaArticulo)
        {
            FacturaArticulo facturaArticulo = new FacturaArticulo();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_FacturaArticulo_SelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdFacturaArticulo", idFacturaArticulo);

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

                        facturaArticulo = tmp;
                    }
                }

                con.Close();
            }

            return facturaArticulo;
        }
        public Pendiente readOnePendiente(int idPendiente)
        {
            Pendiente pendiente = new Pendiente();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Pendiente_SelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPendiente", idPendiente);

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

                        pendiente = tmp;
                    }
                }

                con.Close();
            }

            return pendiente;
        }
        public Entrada readOneEntrada(int idEntrada)
        {
            Entrada entrada = new Entrada();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Entrada_SelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEntrada", idEntrada);

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

                        entrada = tmp;
                    }
                }

                con.Close();
            }

            return entrada;
        }
        public Rectificacion readOneRectificacion(int idRectificacion)
        {
            Rectificacion rectificacion = new Rectificacion();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Rectificacion_SelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdRectificacion", idRectificacion);

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

                        rectificacion = tmp;
                    }
                }

                con.Close();
            }

            return rectificacion;
        }
        public Provedor readOneProvedor(int idProvedor)
        {
            Provedor provedor = new Provedor();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Provedor_SelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProvedor", idProvedor);

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

                        provedor = tmp;
                    }
                }

                con.Close();
            }

            return provedor;
        }
        public Usuario readOneUsuario(int idUsuario)
        {
            Usuario usuario = new Usuario();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Usuario_SelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

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

                        usuario = tmp;
                    }
                }

                con.Close();
            }

            return usuario;
        }
        public Empleado readOneEmpleado(int idEmpleado)
        {
            Empleado empleado = new Empleado();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Empleado_SelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

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

                        empleado = tmp;
                    }
                }

                con.Close();
            }

            return empleado;
        }
        public Salida readOneSalida(int idSalida)
        {
            Salida salida = new Salida();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Salida_SelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdSalida", idSalida);

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

                        salida = tmp;
                    }
                }

                con.Close();
            }

            return salida;
        }
        public Articulo readOneArticulo(int idArticulo)
        {
            Articulo articulo = new Articulo();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Articulo_SelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdArticulo", idArticulo);

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

                        articulo = tmp;
                    }
                }

                con.Close();
            }

            return articulo;
        }
        public Devolucion readOneDevolucion(int idDevolucion)
        {
            Devolucion devolucion = new Devolucion();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Devolucion_SelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdDevolucion", idDevolucion);

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

                        devolucion = tmp;
                    }
                }

                con.Close();
            }

            return devolucion;
        }
        public Factura readOneFactura(int idFactura)
        {
            Factura factura = new Factura();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Factura_SelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdFactura", idFactura);

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

                        factura = tmp;
                    }
                }

                con.Close();
            }

            return factura;
        }

    }
}
            