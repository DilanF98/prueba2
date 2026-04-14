using System;
using System.Collections.Generic;
using DAO;
using DTO;

namespace BLL
{
    public class VendedoresBLL
    {
        VendedoresDAO dao = new VendedoresDAO();

        public VendedorDTO Login(string usuario, string contrasena)
        {
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
                throw new Exception("Usuario y contraseña son obligatorios.");
            return dao.Login(usuario, contrasena);
        }

        public void Insertar(VendedorDTO vendedor)
        {
            if (string.IsNullOrEmpty(vendedor.Nombre))
                throw new Exception("El nombre es obligatorio.");
            if (string.IsNullOrEmpty(vendedor.Usuario))
                throw new Exception("El usuario es obligatorio.");
            if (string.IsNullOrEmpty(vendedor.Contrasena))
                throw new Exception("La contraseña es obligatoria.");
            dao.Insertar(vendedor);
        }

        public void Actualizar(VendedorDTO vendedor)
        {
            if (string.IsNullOrEmpty(vendedor.Nombre))
                throw new Exception("El nombre es obligatorio.");
            if(string.IsNullOrEmpty(vendedor.Usuario))
                throw new Exception("El usuario es obligatorio.");
            if (string.IsNullOrEmpty(vendedor.Contrasena))
                throw new Exception("La contraseña es obligatoria.");
            dao.Actualizar(vendedor);
        }

        public void Eliminar(int idVendedor)
        {
            if(dao.ObtenerPorId(idVendedor) == null)
                throw new Exception("Vendedor no encontrado para eliminar.");
            dao.Eliminar(idVendedor);
        }

        public List<VendedorListadoDTO> ObtenerTodos()
        {
            return dao.ObtenerTodos();
        }

        public VendedorDTO ObtenerPorId(int idVendedor)
        {
            return dao.ObtenerPorId(idVendedor);
        }
    }
}