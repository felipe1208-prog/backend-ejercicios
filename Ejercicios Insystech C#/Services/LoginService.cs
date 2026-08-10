using Ejercicios_Insystech_C_.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Ejercicios_Insystech_C_.Services
{
    public class LoginService
    {
        private readonly List<UsuarioDTO> UsuarioRegistrados = new List<UsuarioDTO>
        {
            new UsuarioDTO { Nombre = "Felipe", CorreoElectronico = "dev@insystech.com.ve", Clave = "Inicial2026*." },
            new UsuarioDTO { Nombre = "Pascia", CorreoElectronico = "dev@insystech.com.ve", Clave = "Inicial2026*." },
            new UsuarioDTO { Nombre = "Freddy", CorreoElectronico = "dev@insystech.com.ve", Clave = "Inicial2026*." },
            new UsuarioDTO { Nombre = "Alejandro", CorreoElectronico = "dev@insystech.com.ve", Clave = "Inicial2026*." },
            new UsuarioDTO { Nombre = "Jose", CorreoElectronico = "dev@insystech.com.ve", Clave = "Inicial2026*." },
            new UsuarioDTO { Nombre = "Diego", CorreoElectronico = "dev@insystech.com.ve", Clave = "Inicial2026*." },
            new UsuarioDTO { Nombre = "Gilman", CorreoElectronico = "gperez@insystech.com.ve", Clave = "Gilmanito007" },
            new UsuarioDTO { Nombre = "Victor", CorreoElectronico = "vpiedra@insystech.com.ve", Clave = "Lucky" },
            new UsuarioDTO { Nombre = "Gregory", CorreoElectronico = "ggomez@insystech.com.ve", Clave = "Strike" },
            new UsuarioDTO { Nombre = "David", CorreoElectronico = "dperez@insystech.com.ve", Clave = "Dart123" },
            new UsuarioDTO { Nombre = "Jesus", CorreoElectronico = "jparedes@insystech.com.ve", Clave = "Inicial2024*" },
            new UsuarioDTO { Nombre = "Javier", CorreoElectronico = "jrojas@insystech.com.ve", Clave = "RojasTrading" },
            new UsuarioDTO { Nombre = "Francisco", CorreoElectronico = "fchacon@insystech.com.ve", Clave = "Coordinator" },
            new UsuarioDTO { Nombre = "Edgar", CorreoElectronico = "eparedes@insystech.com.ve", Clave = "1" }
        };

        public (int, string) VerificacionUsuario(UsuarioDTO request)
        {
            var usuarioEncontrado = UsuarioRegistrados.FirstOrDefault(usuario => usuario.CorreoElectronico == request.CorreoElectronico);

            if (usuarioEncontrado == null) return (404, "Usuario no Encontrado");
            if (usuarioEncontrado.Nombre != request.Nombre) return (400, $"El nombre '{request.Nombre}' es inválido.");
            if (usuarioEncontrado.Clave != request.Clave) return (400, $"La contraseña es incorrecta.");

            return (200, $"Bienvenido {request.Nombre}!. Inciaste sesión correctamente.");
        }
    }

}
