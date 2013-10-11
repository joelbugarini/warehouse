using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Properties;
using System.Data;
using System.Data.SqlClient;

namespace WarehouseManager.DAC
{
    public class UpdateDAC
    {
        DBInfo Info = new DBInfo();
        public bool UpdateRecord(SalidaArticulo obj, int idSalidaArticulo)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_SalidaArticulo_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdSalidaArticulo", idSalidaArticulo);
            cmd.Parameters.AddWithValue("@IdSalida", obj.IdSalida);
            cmd.Parameters.AddWithValue("@IdArticulo", obj.IdArticulo);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool UpdateRecord(FacturaArticulo obj, int idFacturaArticulo)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_FacturaArticulo_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdFacturaArticulo", idFacturaArticulo);
            cmd.Parameters.AddWithValue("@IdFactura", obj.IdFactura);
            cmd.Parameters.AddWithValue("@IdArticulo", obj.IdArticulo);
            cmd.Parameters.AddWithValue("@Cantidad", obj.Cantidad);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool UpdateRecord(Pendiente obj, int idPendiente)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Pendiente_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdPendiente", idPendiente);
            cmd.Parameters.AddWithValue("@IdFactura", obj.IdFactura);
            cmd.Parameters.AddWithValue("@IdArticulo", obj.IdArticulo);
            cmd.Parameters.AddWithValue("@Cantidad", obj.Cantidad);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool UpdateRecord(Entrada obj, int idEntrada)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Entrada_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEntrada", idEntrada);
            cmd.Parameters.AddWithValue("@IdFactura", obj.IdFactura);
            cmd.Parameters.AddWithValue("@IdArticulo", obj.IdArticulo);
            cmd.Parameters.AddWithValue("@Cantidad", obj.Cantidad);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool UpdateRecord(Rectificacion obj, int idRectificacion)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Rectificacion_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdRectificacion", idRectificacion);
            cmd.Parameters.AddWithValue("@IdArticulo", obj.IdArticulo);
            cmd.Parameters.AddWithValue("@Cantidad", obj.Cantidad);
            cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
            cmd.Parameters.AddWithValue("@Fecha", obj.Fecha);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool UpdateRecord(Provedor obj, int idProvedor)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Provedor_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProvedor", idProvedor);
            cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
            cmd.Parameters.AddWithValue("@RFC", obj.RFC);
            cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
            cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool UpdateRecord(Usuario obj, int idUsuario)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Usuario_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
            cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
            cmd.Parameters.AddWithValue("@Contraseña", obj.Contraseña);
            cmd.Parameters.AddWithValue("@Tipo", obj.Tipo);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool UpdateRecord(Empleado obj, int idEmpleado)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Empleado_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
            cmd.Parameters.AddWithValue("@NoEmpleado", obj.NoEmpleado);
            cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
            cmd.Parameters.AddWithValue("@ApellidoPaterno", obj.ApellidoPaterno);
            cmd.Parameters.AddWithValue("@ApellidoMaterno", obj.ApellidoMaterno);
            cmd.Parameters.AddWithValue("@Departamento", obj.Departamento);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool UpdateRecord(Salida obj, int idSalida)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Salida_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdSalida", idSalida);
            cmd.Parameters.AddWithValue("@IdEmpleado", obj.IdEmpleado);
            cmd.Parameters.AddWithValue("@Nota", obj.Nota);
            cmd.Parameters.AddWithValue("@Fecha", obj.Fecha);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool UpdateRecord(Articulo obj, int idArticulo)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Articulo_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdArticulo", idArticulo);
            cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
            cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
            cmd.Parameters.AddWithValue("@Precio", obj.Precio);
            cmd.Parameters.AddWithValue("@Unidad", obj.Unidad);
            cmd.Parameters.AddWithValue("@Cantidad", obj.Cantidad);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool UpdateRecord(Devolucion obj, int idDevolucion)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Devolucion_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdDevolucion", idDevolucion);
            cmd.Parameters.AddWithValue("@IdEmpleado", obj.IdEmpleado);
            cmd.Parameters.AddWithValue("@IdArticulo", obj.IdArticulo);
            cmd.Parameters.AddWithValue("@Cantidad", obj.Cantidad);
            cmd.Parameters.AddWithValue("@Nota", obj.Nota);
            cmd.Parameters.AddWithValue("@Fecha", obj.Fecha);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool UpdateRecord(Factura obj, int idFactura)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Factura_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdFactura", idFactura);
            cmd.Parameters.AddWithValue("@IdProvedor", obj.IdProvedor);
            cmd.Parameters.AddWithValue("@NoFactura", obj.NoFactura);
            cmd.Parameters.AddWithValue("@Fecha", obj.Fecha);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }

    }
}
            