using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Properties;
using System.Data;
using System.Data.SqlClient;

namespace WarehouseManager.DAC
{
    public class CreateDAC
    {
        DBInfo Info = new DBInfo();
        public bool CreateRecord(SalidaArticulo obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_SalidaArticulo_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdSalida", obj.IdSalida);
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
        public bool CreateRecord(FacturaArticulo obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_FacturaArticulo_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public bool CreateRecord(Pendiente obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Pendiente_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public bool CreateRecord(Entrada obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Entrada_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public bool CreateRecord(Rectificacion obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Rectificacion_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public bool CreateRecord(Provedor obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Provedor_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public bool CreateRecord(Usuario obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Usuario_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public bool CreateRecord(Empleado obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Empleado_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public bool CreateRecord(Salida obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Salida_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public bool CreateRecord(Articulo obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Articulo_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public bool CreateRecord(Devolucion obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Devolucion_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public bool CreateRecord(Factura obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Factura_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
            