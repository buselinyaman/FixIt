using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FixIt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        // Bu endpoint'e sadece Admin rolündeki kullanıcılar erişebilir
        [HttpGet("secret")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetSecret()
        {
            return Ok("Hoş geldin Admin! Bu bilgilere sadece yöneticiler erişebilir 🔐");
        }

        // Bu endpoint herkese açık
        [HttpGet("public")]
        [AllowAnonymous]
        public IActionResult PublicEndpoint()
        {
            return Ok("Bu endpoint herkes tarafından erişilebilir 🌍");
        }
    }
}
