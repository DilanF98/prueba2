namespace DTO
{
    public class ClienteDTO
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public ClienteDTO() { }

        public ClienteDTO(string nombre, string telefono, string correo)
        {

            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
        }
    }
}
