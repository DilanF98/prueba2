using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DTO;

namespace DAO
{
    public class VendedoresDAO
    {
        ConexionDAO conec = new ConexionDAO();

        public VendedorDTO Login(string usuario, string contrasena)
        {
            VendedorDTO vendedor = null;
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                // Busca solo por usuario, trae el hash guardado
                string query = "SELECT id_vendedor, nombre, usuario, contrasena, id_rol_fk FROM vendedores WHERE usuario=@usuario";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string hashGuardado = reader.GetString("contrasena");

                    // Verifica que la contraseña ingresada coincida con el hash
                    if (BCrypt.Net.BCrypt.Verify(contrasena, hashGuardado))
                    {
                        vendedor = new VendedorDTO();
                        vendedor.IdVendedor = reader.GetInt32("id_vendedor");
                        vendedor.Nombre = reader.GetString("nombre");
                        vendedor.Usuario = reader.GetString("usuario");
                        vendedor.IdRolFk = Convert.ToInt32(reader["id_rol_fk"]);
                    }
                }
            }
            return vendedor;
        }

        public void Insertar(VendedorDTO vendedor)
        {
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query = "INSERT INTO vendedores (nombre, contrasena, usuario, id_rol_fk) VALUES (@nombre, @contrasena, @usuario, @idRol)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", vendedor.Nombre);
                cmd.Parameters.AddWithValue("@contrasena", BCrypt.Net.BCrypt.HashPassword(vendedor.Contrasena, workFactor: 12));
                cmd.Parameters.AddWithValue("@usuario", vendedor.Usuario);
                cmd.Parameters.AddWithValue("@idRol", vendedor.IdRolFk);
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(VendedorDTO vendedor)
        {
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query;
                if (!string.IsNullOrWhiteSpace(vendedor.Contrasena))
                {
                    query = "UPDATE vendedores SET nombre=@nombre, contrasena=@contrasena, usuario=@usuario, id_rol_fk=@idRol WHERE id_vendedor=@id";
                }
                else
                {
                    query = "UPDATE vendedores SET nombre=@nombre, usuario=@usuario, id_rol_fk=@idRol WHERE id_vendedor=@id";
                }
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", vendedor.Nombre);
                cmd.Parameters.AddWithValue("@usuario", vendedor.Usuario);
                cmd.Parameters.AddWithValue("@idRol", vendedor.IdRolFk);
                cmd.Parameters.AddWithValue("@id", vendedor.IdVendedor);

                if (!string.IsNullOrWhiteSpace(vendedor.Contrasena))
                {
                    string hash = BCrypt.Net.BCrypt.HashPassword(vendedor.Contrasena, workFactor: 12);
                    cmd.Parameters.AddWithValue("@contrasena",hash);
                }
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idVendedor)
        {
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query = "DELETE FROM vendedores WHERE id_vendedor=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idVendedor);
                cmd.ExecuteNonQuery();
            }
        }

        public List<VendedorListadoDTO> ObtenerTodos()
        {
            List<VendedorListadoDTO> lista = new List<VendedorListadoDTO>();
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query = "SELECT id_vendedor, nombre, usuario, id_rol_fk FROM vendedores";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    VendedorListadoDTO v = new VendedorListadoDTO();
                    v.IdVendedor = reader.GetInt32("id_vendedor");
                    v.Nombre = reader.GetString("nombre");
                    v.Usuario = reader.GetString("usuario");
                    v.IdRolFk = Convert.ToInt32(reader["id_rol_fk"]);
                    lista.Add(v);
                }
            }
            return lista;
        }

        public VendedorDTO ObtenerPorId(int idVendedor)
        {
            VendedorDTO vendedor = null;
            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query = "SELECT id_vendedor, nombre, usuario, contrasena, id_rol_fk FROM vendedores WHERE id_vendedor=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idVendedor);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    vendedor = new VendedorDTO();
                    vendedor.IdVendedor = reader.GetInt32("id_vendedor");
                    vendedor.Nombre = reader.GetString("nombre");
                    vendedor.Usuario = reader.GetString("usuario");
                    vendedor.Contrasena = reader.GetString("contrasena");
                    vendedor.IdRolFk = Convert.ToInt32(reader["id_rol_fk"]);
                }
            }
            return vendedor;
        }
    }
}