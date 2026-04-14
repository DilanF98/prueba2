// DTO/VentaDTO.cs
public class VentaDTO
{
    public int IdVenta { get; set; }
    public int IdClienteFk { get; set; }
    public int IdVendedorFk { get; set; }
    public string NombreCliente { get; set; }   
    public string NombreVendedor { get; set; }  
    public DateTime Fecha { get; set; }
    public decimal Total { get; set; }
}