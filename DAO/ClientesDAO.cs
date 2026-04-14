using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DTO;

namespace DAO
{
    public class ClientesDAO
    {
        ConexionDAO conec = new ConexionDAO();

        public void Insertar(ClienteDTO cliente)
        {
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query = "INSERT INTO clientes (nombre, telefono, correo) VALUES (@nombre, @telefono, @correo)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@correo", cliente.Correo);
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(ClienteDTO cliente)
        {
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query = "UPDATE clientes SET nombre=@nombre, telefono=@telefono, correo=@correo WHERE id_cliente=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@correo", cliente.Correo);
                cmd.Parameters.AddWithValue("@id", cliente.IdCliente);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idCliente)
        {
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query = "DELETE FROM clientes WHERE id_cliente=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idCliente);
                cmd.ExecuteNonQuery();
            }
        }

        public List<ClienteDTO> ObtenerTodos()
        {
            List<ClienteDTO> lista = new List<ClienteDTO>();
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query = "SELECT id_cliente, nombre, telefono, correo FROM clientes";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ClienteDTO c = new ClienteDTO();
                    c.IdCliente = reader.GetInt32("id_cliente");
                    c.Nombre = reader.GetString("nombre");
                    c.Telefono = reader.IsDBNull(reader.GetOrdinal("telefono")) ? "" : reader.GetString("telefono");
                    c.Correo = reader.IsDBNull(reader.GetOrdinal("correo")) ? "" : reader.GetString("correo");
                    lista.Add(c);
                }
            }
            return lista;
        }

        public ClienteDTO ObtenerPorId(int idCliente)
        {
            ClienteDTO cliente = null;
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query = "SELECT id_cliente, nombre, telefono, correo FROM clientes WHERE id_cliente=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idCliente);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cliente = new ClienteDTO();
                    cliente.IdCliente = reader.GetInt32("id_cliente");
                    cliente.Nombre = reader.GetString("nombre");
                    cliente.Telefono = reader.IsDBNull(reader.GetOrdinal("telefono")) ? "" : reader.GetString("telefono");
                    cliente.Correo = reader.IsDBNull(reader.GetOrdinal("correo")) ? "" : reader.GetString("correo");
                }
            }
            return cliente;
        }
    }
}
