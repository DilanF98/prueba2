using System.Collections.Generic;
using DAO;
using DTO;

namespace BLL
{
    public class ProductosBLL
    {
        ProductosDAO dao = new ProductosDAO();

        public void Insertar(ProductoDTO producto)
        {
            if (string.IsNullOrEmpty(producto.Nombre))
                throw new System.Exception("El nombre del producto es obligatorio.");

            if (producto.Precio <= 0)
                throw new System.Exception("El precio debe ser mayor a 0.");

            if (producto.Stock < 0)
                throw new System.Exception("El stock no puede ser negativo.");

            if(dao.ObtenerPorCodigo(producto.Codigo) != null)
               throw new SystemException("El codigo ya existe");

            if (string.IsNullOrEmpty(producto.Codigo))
                throw new System.Exception("El codigo del producto es obligatorio");

            dao.Insertar(producto);
        }

        public void Actualizar(ProductoDTO producto)
        {
            if (string.IsNullOrEmpty(producto.Nombre))
                throw new System.Exception("El nombre del producto es obligatorio.");

            if (dao.ObtenerPorCodigo(producto.Codigo) != null && producto.Codigo != dao.ObtenerPorCodigo(producto.Codigo).Codigo)
                throw new SystemException("El codigo ya existe");

            if (producto.Precio <= 0)
                throw new System.Exception("El precio debe ser mayor a 0.");

            if (string.IsNullOrEmpty(producto.Codigo))
                throw new System.Exception("El codigo del producto es obligatorio");

            if (producto.Stock < 0)
                throw new System.Exception("El stock no puede ser negativo.");

            dao.Actualizar(producto);
        }

        public void Eliminar(int idProducto)
        {
            if(dao.ObtenerPorId(idProducto) == null)
                throw new System.Exception("Producto no encontrado para eliminar.");

            dao.Eliminar(idProducto);
        }

        public List<ProductoDTO> ObtenerTodos()
        {
            return dao.ObtenerTodos();
        }

        public ProductoDTO ObtenerPorId(int idProducto)
        {
            return dao.ObtenerPorId(idProducto);
        }

       
    }
}

