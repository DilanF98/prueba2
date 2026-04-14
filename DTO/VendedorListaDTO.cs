using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class VendedorListadoDTO
    {
        public int IdVendedor { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public int IdRolFk { get; set; }
    }
}
