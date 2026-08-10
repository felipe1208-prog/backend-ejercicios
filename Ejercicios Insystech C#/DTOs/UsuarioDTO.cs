using System.ComponentModel.DataAnnotations;

namespace Ejercicios_Insystech_C_.DTOs
{
    public class UsuarioDTO
    {
        [Required(ErrorMessage = "El campo 'Nombre' es requerido.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo 'Correo Electrónico' es requerido.")]
        [EmailAddress(ErrorMessage = "Ingrese un correo válido.")]
        public string CorreoElectrónico { get; set; }

        [Required(ErrorMessage = "La Contraseña es necesaria.")]
        public string Clave { get; set; }
    }
}
