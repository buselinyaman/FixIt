using FixIt.Data;
using FixIt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FixIt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RequestsController : ControllerBase
    {
        private readonly AppDbContext _db;

        public RequestsController(AppDbContext db)
        {
            _db = db;
        }

        // Yeni request oluşturma
        [HttpPost]
        public async Task<IActionResult> CreateRequest([FromBody] RepairRequest request)
        {
            if (request == null)
                return BadRequest("Request body is empty.");

            _db.RepairRequests.Add(request);
            await _db.SaveChangesAsync();
            return Ok(request);
        }

        // Tüm requestleri listele
        [HttpGet]
        public async Task<IActionResult> GetRequests()
        {
            var requests = await _db.RepairRequests.ToListAsync();
            return Ok(requests);
        }

        // Technician isteği kabul etsin
        [HttpPost("accept/{id}")]
        public async Task<IActionResult> AcceptRequest(int id)
        {
            var req = await _db.RepairRequests.FindAsync(id);
            if (req == null) return NotFound("Request not found.");

            if (req.Status == RequestStatus.Accepted)
                return BadRequest("Request already accepted.");

            req.Status = RequestStatus.Accepted;
            req.StatusNote = "Accepted manually via dashboard";
            await _db.SaveChangesAsync();

            return Ok(req);
        }




        [HttpPost("complete/{id}")]
        public async Task<IActionResult> CompleteRequest(int id)
        {
            var req = await _db.RepairRequests.FindAsync(id);
            if (req == null) return NotFound("Request not found.");

            if (req.Status != RequestStatus.Accepted)
                return BadRequest("Only accepted requests can be completed.");

            req.Status = RequestStatus.Completed;
            req.StatusNote = "Request completed successfully.";
            await _db.SaveChangesAsync();

            return Ok(req);
        }


    }
}


