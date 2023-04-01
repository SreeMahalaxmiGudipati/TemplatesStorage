using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TemplatesStorage.Data;
using TemplatesStorage.Models;

namespace TemplatesStorage.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
     [EnableCors("AllowOrigin")]
    public class FriendlyController : ControllerBase
    {
        private readonly APIDbContext _context;
        private readonly ILogger<FriendlyController> _logger;

        public FriendlyController(APIDbContext context, ILogger<FriendlyController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/Templates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FriendlyTemplate>>> GetTemplates()
        {
            try {
                return await _context.FriendlyTabel.ToListAsync();
            }
           
             catch (Exception ex)
             {
                _logger.LogError(ex, "An error occurred while getting all samples");
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while getting all samples. Please try again later.");
            }
        }

        // POST: api/Templates
        [HttpPost]
        public async Task<ActionResult<FriendlyTemplate>> PostTemplates(FriendlyTemplate template)
        {
            _context.FriendlyTabel.Add(template);
            await _context.SaveChangesAsync();

         return CreatedAtAction("GetTemplate", new { id = template.Id }, template);

        }

        // DELETE: api/Templates/3
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTemplate(int id)
        {
            var template = await _context.FriendlyTabel.FindAsync(id);
            if (template== null)
            {
                return NotFound();
            }
            _context.FriendlyTabel.Remove(template);
            await _context.SaveChangesAsync();

            return NoContent();
        }

         // GET: api/Templates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FriendlyTemplate>> GetTemplate(int id)
        {
            try {
                var template = await _context.FriendlyTabel.FindAsync(id);

                if (template == null)
                {
                    return NotFound();
                }

                return template;
            }
            
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while getting sample with ID {id}");
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred while getting sample with ID {id}. Please try again later.");
            }
        }
    }
}