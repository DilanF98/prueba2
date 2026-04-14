using System.Windows.Forms;
using DTO;

namespace Presentacion.Utilidades
{
    public static class InterfazHelper
    {
        public static void CargarDatosPerfil(Label lblNombre, Label lblRol)
        {
            if (Sesion.VendedorActivo != null)
            {
                lblNombre.Text = Sesion.VendedorActivo.Nombre;

                lblRol.Text = Sesion.VendedorActivo.IdRolFk == 1 ? "Administrador" : "Vendedor";
                lblRol.AutoSize = true;
            }
        }
    }
}