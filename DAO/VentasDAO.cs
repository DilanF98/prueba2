using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DTO;

namespace DAO
{
    public class VentasDAO
    {
        ConexionDAO conec = new ConexionDAO();

        public int Insertar(VentaDTO venta)
        {
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query = @"INSERT INTO ventas (id_cliente_fk, id_vendedor_fk, fecha, total)
                                 VALUES (@idCliente, @idVendedor, @fecha, @total)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idCliente", venta.IdClienteFk);
                cmd.Parameters.AddWithValue("@idVendedor", venta.IdVendedorFk);
                cmd.Parameters.AddWithValue("@fecha", venta.Fecha.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@total", venta.Total);
                cmd.ExecuteNonQuery();

                return (int)cmd.LastInsertedId;
            }
        }

        public List<VentaDTO> ObtenerTodos()
        {
            List<VentaDTO> lista = new List<VentaDTO>();
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query = @"
            SELECT v.id_venta, v.id_cliente_fk, v.id_vendedor_fk,
                   c.nombre AS nombre_cliente,
                   ve.nombre AS nombre_vendedor,
                   v.fecha, v.total
            FROM ventas v
            INNER JOIN clientes c ON c.id_cliente = v.id_cliente_fk
            INNER JOIN vendedores ve ON ve.id_vendedor = v.id_vendedor_fk";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    VentaDTO v = new VentaDTO();
                    v.IdVenta = reader.GetInt32("id_venta");
                    v.IdClienteFk = reader.GetInt32("id_cliente_fk");
                    v.IdVendedorFk = reader.GetInt32("id_vendedor_fk");
                    v.NombreCliente = reader.GetString("nombre_cliente");   // NUEVO
                    v.NombreVendedor = reader.GetString("nombre_vendedor");  // NUEVO
                    v.Fecha = reader.GetDateTime("fecha");
                    v.Total = reader.GetDecimal("total");
                    lista.Add(v);
                }
            }
            return lista;
        }
        public void Eliminar(int idVenta)
        {
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query = "DELETE FROM ventas WHERE id_venta = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idVenta);
                cmd.ExecuteNonQuery();
            }
        }
    }
}