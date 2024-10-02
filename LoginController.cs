using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace Login_API
{
    [Route("login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] LoginRequest loginRequest)
        {
            // Validação básica das credenciais
            if (loginRequest.Username == "admin" && loginRequest.Password == "1234")
            {
                return Ok(new { success = true, message = "Login bem sucedido!" });
            }
            else
            {
                return Unauthorized(new { success = false, message = "Credenciais inválidas" });
            }
        }
    }
}
