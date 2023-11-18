using api.Models;
using api.Repositories;
using api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace api.Controllers
{
    [ApiController]
    public class AuthController : Controller
    {
        [HttpPost]
        [Route("/login")]
        public async Task<IActionResult> login(User model)
        {
            var user = UserRepository.Get(model.Email, model.Password);

            if (user == null)
                return NotFound(new { message = "Usuário inválido" });

            var token = TokenServices.GenerateToken(user);

            user.Password = "";

            return Ok(new
            {
                user = user,
                token = token
            });
        }
    }
}
