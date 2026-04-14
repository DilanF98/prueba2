using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class RolesBLL
    {
        RolesDAO dao = new RolesDAO();

        public List<RolDTO> ObtenerTodos()
        {
            return dao.ObtenerTodos();
        }
    }
}
