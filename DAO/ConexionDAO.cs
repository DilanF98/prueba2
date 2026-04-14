using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class ConexionDAO
    {
        //AQUÍ VAN LAS CREDENCIALES DE LA BASE DE DATOS
        //TRABAJEN CON LOCALHOST CON EL DUMP SQL QUE LES PROPORCIONÉ
        //SI USAN OTRA BASE DE DATOS, MODIFIQUEN ESTA CADENACONEXION
        private string cadenaConexion;


        public ConexionDAO()
        {
            cadenaConexion = $"server=localhost;Database=prograv;Uid=root;Password= ;";
        }

        public MySqlConnection CrearConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}
