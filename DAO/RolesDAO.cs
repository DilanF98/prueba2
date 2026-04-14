using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class RolesDAO
    {
        ConexionDAO conec = new ConexionDAO();

        public List<RolDTO> ObtenerTodos()
        {
            List<RolDTO> lista = new List<RolDTO>();

            using (MySqlConnection conn = conec.CrearConexion())
            {
                conn.Open();
                string query = "SELECT id_rol, descripcion FROM roles";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    RolDTO rol = new RolDTO();
                    rol.IdRol = reader.GetInt32("id_rol");
                    rol.Descripcion = reader.GetString("descripcion");

                    lista.Add(rol);
                }
            }

            return lista;
        }
    }
}
