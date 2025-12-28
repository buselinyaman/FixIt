using FixIt.Data;
using FixIt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FixIt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _db;

        public UsersController(AppDbContext db)
        {
            _db = db;
        }

        // Kullanıcı oluştur
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] User user)
        {
            _db.Users.Add(user);
            await _db.SaveChangesAsync();
            return Ok(user);
        }

        // Tüm kullanıcıları listele
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _db.Users.ToListAsync();
            return Ok(users);
        }
    }
}
