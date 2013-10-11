using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Properties;
using System.Data;
using System.Data.SqlClient;

namespace WarehouseManager.DAC
{
    public class DeleteDAC
    {
        DBInfo Info = new DBInfo();
        public bool deleteSalidaArticulo(int idSalidaArticulo)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_SalidaArticulo_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdSalidaArticulo", idSalidaArticulo);
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
        public bool deleteFacturaArticulo(int idFacturaArticulo)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_FacturaArticulo_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdFacturaArticulo", idFacturaArticulo);
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
        public bool deletePendiente(int idPendiente)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Pendiente_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdPendiente", idPendiente);
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
        public bool deleteRectificacion(int idRectificacion)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Rectificacion_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdRectificacion", idRectificacion);
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
        public bool deleteProvedor(int idProvedor)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Provedor_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProvedor", idProvedor);
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
        public bool deleteUsuario(int idUsuario)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Usuario_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
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
        public bool deleteEmpleado(int idEmpleado)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Empleado_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
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
        public bool deleteSalida(int idSalida)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Salida_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdSalida", idSalida);
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
        public bool deleteArticulo(int idArticulo)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Articulo_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdArticulo", idArticulo);
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
        public bool deleteDevolucion(int idDevolucion)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Devolucion_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdDevolucion", idDevolucion);
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
        public bool deleteFactura(int idFactura)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Factura_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdFactura", idFactura);
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
        public bool deleteEntrada(int idEntrada)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Entrada_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEntrada", idEntrada);
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
            