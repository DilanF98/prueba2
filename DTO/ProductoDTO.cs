using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ProductoDTO
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public ProductoDTO() { }

        public ProductoDTO(string codigo, string nombre, decimal precio, int stock)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }
    }
}
