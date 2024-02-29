using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Coding.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        // GET: api/<MovieController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok();
        }

        // POST api/<MovieController>/Like/{id}
        [HttpPost("Like/{id}")]
        public async Task<IActionResult> Like(int id, [FromBody] string userId)
        {
            return Ok();
        }

        // POST api/<MovieController>/Dislike/{id}
        [HttpPost("Dislike/{id}")]
        public async Task<IActionResult> Dislike(int id, [FromBody] string userId)
        {
            return Ok();
        }
    }
}
