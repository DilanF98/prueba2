using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DTO;

namespace DAO
{
    public class ProductosDAO
    {
        ConexionDAO conec = new ConexionDAO();

        public void Insertar(ProductoDTO producto)
        {
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query = "INSERT INTO productos (codigo, nombre, descripcion, precio, stock) VALUES (@codigo, @nombre, @descripcion, @precio, @stock)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@codigo", producto.Codigo);
                cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@precio", producto.Precio);
                cmd.Parameters.AddWithValue("@stock", producto.Stock);
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(ProductoDTO producto)
        {
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query = "UPDATE productos SET codigo=@codigo, nombre=@nombre, descripcion=@descripcion, precio=@precio, stock=@stock WHERE id_producto=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@codigo", producto.Codigo);
                cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@precio", producto.Precio);
                cmd.Parameters.AddWithValue("@stock", producto.Stock);
                cmd.Parameters.AddWithValue("@id", producto.IdProducto);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idProducto)
        {
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query = "DELETE FROM productos WHERE id_producto=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idProducto);
                cmd.ExecuteNonQuery();
            }
        }

        public List<ProductoDTO> ObtenerTodos()
        {
            List<ProductoDTO> lista = new List<ProductoDTO>();
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query = "SELECT id_producto, codigo, nombre, descripcion, precio, stock FROM productos";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ProductoDTO p = new ProductoDTO();
                    p.IdProducto = reader.GetInt32("id_producto");
                    p.Codigo = reader.GetString("codigo");
                    p.Nombre = reader.GetString("nombre");
                    p.Descripcion = reader.IsDBNull(reader.GetOrdinal("descripcion")) ? "" : reader.GetString("descripcion");
                    p.Precio = reader.GetDecimal("precio");
                    p.Stock = reader.GetInt32("stock");
                    lista.Add(p);
                }
            }
            return lista;
        }

        public ProductoDTO ObtenerPorId(int idProducto)
        {
            ProductoDTO producto = null;
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query = "SELECT id_producto, codigo, nombre, descripcion, precio, stock FROM productos WHERE id_producto=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idProducto);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    producto = new ProductoDTO();
                    producto.IdProducto = reader.GetInt32("id_producto");
                    producto.Codigo = reader.GetString("codigo");
                    producto.Nombre = reader.GetString("nombre");
                    producto.Descripcion = reader.IsDBNull(reader.GetOrdinal("descripcion")) ? "" : reader.GetString("descripcion");
                    producto.Precio = reader.GetDecimal("precio");
                    producto.Stock = reader.GetInt32("stock");
                }
            }
            return producto;
        }
        public ProductoDTO ObtenerPorCodigo(string codigo)
        {
            ProductoDTO producto = null;
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query = "SELECT id_producto, codigo, nombre, descripcion, precio, stock FROM productos WHERE codigo = @codigo";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    producto = new ProductoDTO();
                    producto.IdProducto = reader.GetInt32("id_producto");
                    producto.Codigo = reader.GetString("codigo");
                    producto.Nombre = reader.GetString("nombre");
                    producto.Descripcion = reader.IsDBNull(reader.GetOrdinal("descripcion")) ? "" : reader.GetString("descripcion");
                    producto.Precio = reader.GetDecimal("precio");
                    producto.Stock = reader.GetInt32("stock");
                }
            }
            return producto;
        }
    }
}
