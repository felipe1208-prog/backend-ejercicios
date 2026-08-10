using System.ComponentModel.DataAnnotations;

namespace Ejercicios_Insystech_C_.DTOs
{
    //Las propiedades del DTO se hacen nulables para que el error 400 no sea el generico de .NET sino el que yo coloqué
    public class UsuarioDTO
    {
        [Required(ErrorMessage = "El campo 'Nombre' es requerido.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El campo 'Correo Electrónico' es requerido.")]
        [EmailAddress(ErrorMessage = "Ingrese un correo válido.")]
        public string? CorreoElectronico { get; set; }

        [Required(ErrorMessage = "La Contraseña es necesaria.")]
        public string? Clave { get; set; }
    }
}
