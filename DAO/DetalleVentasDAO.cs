using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DTO;

namespace DAO
{
    public class DetalleVentasDAO
    {
        ConexionDAO conec = new ConexionDAO();

        public void Insertar(DetalleVentaDTO detalle)
        {
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query = @"INSERT INTO detalle_ventas 
                                 (id_venta_fk, codigo_producto, cantidad, precio_unitario, subtotal)
                                 VALUES (@idVenta, @codigoProducto, @cantidad, @precioUnitario, @subtotal)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idVenta", detalle.IdVentaFk);
                cmd.Parameters.AddWithValue("@codigoProducto", detalle.CodigoProducto);
                cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                cmd.Parameters.AddWithValue("@precioUnitario", detalle.PrecioUnitario);
                cmd.Parameters.AddWithValue("@subtotal", detalle.Subtotal);
                cmd.ExecuteNonQuery();
            }
        }

        public List<DetalleVentaDTO> ObtenerPorVenta(int idVenta)
        {
            List<DetalleVentaDTO> lista = new List<DetalleVentaDTO>();
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query = @"SELECT id_detalle, id_venta_fk, codigo_producto, 
                                        cantidad, precio_unitario, subtotal 
                                 FROM detalle_ventas WHERE id_venta_fk=@idVenta";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idVenta", idVenta);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DetalleVentaDTO d = new DetalleVentaDTO();
                    d.IdDetalle = reader.GetInt32("id_detalle");
                    d.IdVentaFk = reader.GetInt32("id_venta_fk");
                    d.CodigoProducto = reader.GetString("codigo_producto");
                    d.Cantidad = reader.GetInt32("cantidad");
                    d.PrecioUnitario = reader.GetDecimal("precio_unitario");
                    d.Subtotal = reader.GetDecimal("subtotal");
                    lista.Add(d);
                }
            }
            return lista;
        }
    }
}