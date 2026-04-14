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

        public int RegistrarVenta(VentaDTO venta, List<DetalleVentaDTO> detalles)
        {
            if (detalles == null || detalles.Count == 0)
                throw new Exception("La venta debe tener al menos un producto.");

            // Calcular total sumando subtotales
            decimal total = 0;
            foreach (DetalleVentaDTO d in detalles)
            {
                d.Subtotal = d.PrecioUnitario * d.Cantidad;
                total += d.Subtotal;
            }
            venta.Total = total;

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
            return ventasDao.ObtenerTodos().Find(v => v.IdVenta == idVenta);
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
                throw new Exception($"No existe ninguna venta con Id {idVenta}.");

            ventasDao.Eliminar(idVenta);
        }
    }
}