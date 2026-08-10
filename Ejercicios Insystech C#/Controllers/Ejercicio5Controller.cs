using Microsoft.AspNetCore.Http;
using Ejercicios_Insystech_C_.Services;
using Microsoft.AspNetCore.Mvc;
using Ejercicios_Insystech_C_.DTOs;

namespace Ejercicios_Insystech_C_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ejercicio5Controller : ControllerBase
    {
        private readonly LoginService _login;
        public Ejercicio5Controller(LoginService login)
        {
            _login = login;
        }

        [HttpPost]
        public async Task<IActionResult> ValidarUsuario([FromBody] UsuarioDTO request)
        {
            var (status, mensaje) = _login.VerificacionUsuario(request);

            if (status == 404) return NotFound(new { mensaje = mensaje });
            if (status == 400) return NotFound(new { mensaje = mensaje });

            return Ok( new { mensaje = mensaje });
        }

    }
}
