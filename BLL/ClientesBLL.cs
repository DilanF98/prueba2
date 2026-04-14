using DAO;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class ClientesBLL
    {
        ClientesDAO dao = new ClientesDAO();

        public void Insertar(ClienteDTO cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nombre))
                throw new System.Exception("El nombre del cliente es obligatorio.");

            if(string.IsNullOrEmpty(cliente.Telefono))
                throw new System.Exception("El teléfono del cliente es obligatorio.");

            if(cliente.Telefono.Length < 7 || cliente.Telefono.Length > 12)
                throw new System.Exception("El teléfono del cliente debe tener entre 7 y 12 dígitos.");

            if(!cliente.Telefono.All(char.IsDigit))
                throw new System.Exception("El teléfono del cliente debe contener solo números.");

            if (string.IsNullOrEmpty(cliente.Correo))
                throw new System.Exception("El correo electronico no puede ser vacío.");

            if (!cliente.Correo.Contains("@") || !cliente.Correo.Contains("."))
                throw new System.Exception("El correo electrónico no es válido.");

            List<ClienteDTO> listaClientes = dao.ObtenerTodos();

            foreach (ClienteDTO c in listaClientes)
            {
                if (c.Telefono == cliente.Telefono)
                    throw new Exception("El teléfono ya está registrado para este u otro cliente.");

                if (c.IdCliente != cliente.IdCliente && c.Correo == cliente.Correo)
                    throw new Exception("El correo ya está registrado para este u otro cliente.");
            }

            dao.Insertar(cliente);
        }

        public void Actualizar(ClienteDTO cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nombre))
                throw new System.Exception("El nombre del cliente es obligatorio.");

            if (string.IsNullOrEmpty(cliente.Telefono))
                throw new System.Exception("El teléfono del cliente es obligatorio.");

            if (cliente.Telefono.Length < 7 || cliente.Telefono.Length > 12)
                throw new System.Exception("El teléfono del cliente debe tener entre 7 y 12 dígitos.");

            if (!cliente.Telefono.All(char.IsDigit))
                throw new System.Exception("El teléfono del cliente debe contener solo números.");

            if (string.IsNullOrEmpty(cliente.Correo))
                throw new System.Exception("El correo electronico no puede ser vacío.");

            if (!cliente.Correo.Contains("@") || !cliente.Correo.Contains("."))
                throw new System.Exception("El correo electrónico no es válido.");

            List<ClienteDTO> listaClientes = dao.ObtenerTodos();

            foreach (ClienteDTO c in listaClientes)
            {
                if (c.IdCliente != cliente.IdCliente && c.Telefono == cliente.Telefono)
                    throw new Exception("El teléfono ya está registrado para este u otro cliente.");

                if (c.IdCliente != cliente.IdCliente && c.Correo == cliente.Correo)
                    throw new Exception("El correo ya está registrado para otro cliente.");
            }

            dao.Actualizar(cliente);
        }

        public void Eliminar(int idCliente)
        {
             if(dao.ObtenerPorId(idCliente) == null)
                throw new System.Exception("Cliente no encontrado para eliminar.");
           

            dao.Eliminar(idCliente);
        }

        public List<ClienteDTO> ObtenerTodos()
        {
            return dao.ObtenerTodos();
        }

        public ClienteDTO ObtenerPorId(int idCliente)
        {
            return dao.ObtenerPorId(idCliente);
        }
    }
}

