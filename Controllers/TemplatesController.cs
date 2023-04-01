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
    public class TemplatesController : ControllerBase
    {
        private readonly APIDbContext _context;
        private readonly ILogger<TemplatesController> _logger;

        public TemplatesController(APIDbContext context, ILogger<TemplatesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/Templates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Template>>> GetTemplates()
        {
            try {
                return await _context.Templatestable.ToListAsync();
            }
           
             catch (Exception ex)
             {
                _logger.LogError(ex, "An error occurred while getting all samples");
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while getting all samples. Please try again later.");
            }
        }

        // POST: api/Templates
        [HttpPost]
        public async Task<ActionResult<Template>> PostTemplates(Template template)
        {
            _context.Templatestable.Add(template);
            await _context.SaveChangesAsync();

         return CreatedAtAction("GetTemplate", new { id = template.Id }, template);

        }

        // DELETE: api/Templates/3
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTemplate(int id)
        {
            var template = await _context.Templatestable.FindAsync(id);
            if (template== null)
            {
                return NotFound();
            }
            _context.Templatestable.Remove(template);
            await _context.SaveChangesAsync();

            return NoContent();
        }

         // GET: api/Templates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Template>> GetTemplate(int id)
        {
            try {
                var template = await _context.Templatestable.FindAsync(id);

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

    //      // PUT: api/Employee/5
    //   [HttpPut("{id}")]
    //     public async Task<IActionResult> PutEmployee(int id, Template template)
    //     {
    //         if (id != template.Id)
    //         {
    //             return BadRequest();
    //         }

    //         _context.Entry(template).State = EntityState.Modified;

    //         try
    //         {
    //             await _context.SaveChangesAsync();
    //         }
    //         catch (DbUpdateConcurrencyException)
    //         {
    //             if (!TemplateExists(id))
    //             {
    //                 return NotFound();
    //             }
    //             else
    //             {
    //                 throw;
    //             }
    //         }

    //         return NoContent();
    //     }

    //     private bool TemplateExists(int id)
    //     {
    //         return _context.Templatestable.Any(e => e.Id == id);
    //     }

    }
}