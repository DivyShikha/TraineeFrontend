using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeatherForecast.Data;
using WeatherForecast.Model;

namespace WeatherForecast.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrolmentController : ControllerBase
    {
        private readonly TraineeContext _context;

        public EnrolmentController(TraineeContext context)
        {
            _context = context;
        }

        // GET: api/Enrolment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Enrolment>>> GetEnrolments()
        {
            return await _context.Enrolments.ToListAsync();
        }

        // GET: api/Enrolment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Enrolment>> GetEnrolment(int id)
        {
            var enrolment = await _context.Enrolments.FindAsync(id);

            if (enrolment == null)
            {
                return NotFound();
            }

            return enrolment;
        }

        // PUT: api/Enrolment/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEnrolment(int id, Enrolment enrolment)
        {
            if (id != enrolment.EnrollmentID)
            {
                return BadRequest();
            }

            _context.Entry(enrolment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnrolmentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Enrolment
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Enrolment>> PostEnrolment(Enrolment enrolment)
        {
            _context.Enrolments.Add(enrolment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEnrolment", new { id = enrolment.EnrollmentID }, enrolment);
        }

        // DELETE: api/Enrolment/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEnrolment(int id)
        {
            var enrolment = await _context.Enrolments.FindAsync(id);
            if (enrolment == null)
            {
                return NotFound();
            }

            _context.Enrolments.Remove(enrolment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EnrolmentExists(int id)
        {
            return _context.Enrolments.Any(e => e.EnrollmentID == id);
        }
    }
}
