

using Microsoft.AspNetCore.Mvc;

namespace Usuario.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private static List<User> GetUsers()
        {
            return new List<User>{
                new User{Nome = "jaogatao", Id = 1}
             };

        }
        [HttpGet]

        public IActionResult Get()
        {

            return Ok(GetUsers());
        }

    }
}