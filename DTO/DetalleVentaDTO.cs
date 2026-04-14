namespace DTO
{
    public class DetalleVentaDTO
    {
        public int IdDetalle { get; set; }
        public int IdVentaFk { get; set; }
        public string CodigoProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }

        public DetalleVentaDTO() { }

        public DetalleVentaDTO(string codigoProducto, int cantidad, decimal precioUnitario)
        {
            CodigoProducto = codigoProducto;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Subtotal = precioUnitario * cantidad;
        }
    }
}