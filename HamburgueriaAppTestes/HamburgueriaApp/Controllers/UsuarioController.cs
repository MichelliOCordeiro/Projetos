using Dominio.Hamburgueria.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servico.Hamburgueria;

namespace HamburgueriaApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private UsuarioService _userService;
        public UsuarioController(UsuarioService userService)
        {
            _userService = userService;
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginDto login)
        {            
            var resposta = _userService.Login(login.Email, login.Senha);

            return Ok(resposta);
        }
    }
}
