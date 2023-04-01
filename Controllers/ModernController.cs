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
    public class ModernController : ControllerBase
    {
        private readonly APIDbContext _context;
        private readonly ILogger<ModernController> _logger;

        public ModernController(APIDbContext context, ILogger<ModernController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/Templates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModernTemplate>>> GetTemplates()
        {
            try {
                return await _context.ModernTabel.ToListAsync();
            }
           
             catch (Exception ex)
             {
                _logger.LogError(ex, "An error occurred while getting all samples");
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while getting all samples. Please try again later.");
            }
        }

        // POST: api/Templates
        [HttpPost]
        public async Task<ActionResult<ModernTemplate>> PostTemplates(ModernTemplate template)
        {
            _context.ModernTabel.Add(template);
            await _context.SaveChangesAsync();

         return CreatedAtAction("GetTemplate", new { id = template.Id }, template);

        }

        // DELETE: api/Templates/3
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTemplate(int id)
        {
            var template = await _context.ModernTabel.FindAsync(id);
            if (template== null)
            {
                return NotFound();
            }
            _context.ModernTabel.Remove(template);
            await _context.SaveChangesAsync();

            return NoContent();
        }

         // GET: api/Templates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ModernTemplate>> GetTemplate(int id)
        {
            try {
                var template = await _context.ModernTabel.FindAsync(id);

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