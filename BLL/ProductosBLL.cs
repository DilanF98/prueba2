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

            if (string.IsNullOrEmpty(producto.Codigo))
                throw new Exception("El código del producto es obligatorio.");

            if (dao.ObtenerPorCodigo(producto.Codigo) != null)
                throw new Exception("El código ya existe.");

            dao.Insertar(producto);
        }

        public void Actualizar(ProductoDTO producto)
        {
            if (string.IsNullOrEmpty(producto.Nombre))
                throw new System.Exception("El nombre del producto es obligatorio.");

            ProductoDTO existente = dao.ObtenerPorCodigo(producto.Codigo);
            if (existente != null && existente.IdProducto != producto.IdProducto)
                throw new Exception("El código ya está en uso por otro producto.");

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

