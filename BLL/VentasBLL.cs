using System;
using System.Collections.Generic;
using DAO;
using DTO;

namespace BLL
{
    public class VentasBLL
    {
        VentasDAO ventasDao = new VentasDAO();
        DetalleVentasDAO detalleDao = new DetalleVentasDAO();
        ProductosDAO productosDao = new ProductosDAO();

        private const decimal iva = 0.13m;

        public int RegistrarVenta(VentaDTO venta, List<DetalleVentaDTO> detalles)
        {
            if (detalles == null || detalles.Count == 0)
            {
                throw new Exception("La venta debe tener al menos un producto.");
            }

            // Calcular subtotal sumando líneas de detalle
            decimal subtotal = 0;
            foreach (DetalleVentaDTO d in detalles)
            {
                d.Subtotal = d.PrecioUnitario * d.Cantidad;
                subtotal += d.Subtotal;
            }

            // Guardar total CON IVA en la BD
            venta.Total = subtotal + (subtotal * iva);

            // Paso 1: insertar cabecera de venta y obtener id
            int idVenta = ventasDao.Insertar(venta);

            // Paso 2: insertar cada detalle
            foreach (DetalleVentaDTO d in detalles)
            {
                d.IdVentaFk = idVenta;
                detalleDao.Insertar(d);

                // Paso 3: descontar stock usando el código del producto
                ProductoDTO prod = productosDao.ObtenerPorCodigo(d.CodigoProducto);
                if (prod != null)
                {
                    prod.Stock = prod.Stock - d.Cantidad;
                    productosDao.Actualizar(prod);
                }
            }

            return idVenta;
        }

        public List<VentaDTO> ObtenerTodas()
        {
            return ventasDao.ObtenerTodos();
        }

        public List<DetalleVentaDTO> ObtenerDetalles(int idVenta)
        {
            return detalleDao.ObtenerPorVenta(idVenta);
        }

        public VentaDTO ObtenerPorId(int idVenta)
        {
            return ventasDao.ObtenerPorId(idVenta);
        }

        public string ObtenerNombreProducto(string codigo)
        {
            ProductoDTO prod = productosDao.ObtenerPorCodigo(codigo);
            return prod != null ? prod.Nombre : codigo;
        }

        public void Eliminar(int idVenta)
        {
            VentaDTO venta = ObtenerPorId(idVenta);
            if (venta == null)
            {
                throw new Exception($"No existe ninguna venta con Id {idVenta}.");
            }

            // Recuperar los detalles para saber qué stock devolver
            List<DetalleVentaDTO> detalles = detalleDao.ObtenerPorVenta(idVenta);
            foreach (DetalleVentaDTO d in detalles)
            {
                ProductoDTO prod = productosDao.ObtenerPorCodigo(d.CodigoProducto);
                if (prod != null)
                {
                    prod.Stock += d.Cantidad;   // devolver unidades al inventario
                    productosDao.Actualizar(prod);
                }
            }

            ventasDao.Eliminar(idVenta);
        }
    }
}
