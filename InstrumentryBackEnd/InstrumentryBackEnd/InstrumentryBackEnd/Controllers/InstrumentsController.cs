using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InstrumentryBackEnd.Models;
using InstrumentryBackend.Data;

namespace InstrumentryBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstrumentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public InstrumentsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Instruments
        [HttpGet("GetInstrumentryBasicDTO")]
        public async Task<ActionResult<IEnumerable<InstrumentDTO>>> GetInstruments()
        {
          if (_context.Instruments == null)
          {
              return NotFound();
          }
            return await _context.Instruments.Select(x=>new InstrumentDTO
            {
                Brand = x.Brand,
                Model = x.Model,
                Image = x.Image
            }).ToListAsync();
        }

        // GET: api/Instruments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Instrument>> GetInstrument(int id)
        {
          if (_context.Instruments == null)
          {
              return NotFound();
          }
            var instrument = await _context.Instruments.FindAsync(id);

            if (instrument == null)
            {
                return NotFound();
            }

            return instrument;
        }

        // PUT: api/Instruments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstrument(int id, Instrument instrument)
        {
            if (id != instrument.Id)
            {
                return BadRequest();
            }

            _context.Entry(instrument).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstrumentExists(id))
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

        // POST: api/Instruments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Instrument>> PostInstrument(Instrument instrument)
        {
          if (_context.Instruments == null)
          {
              return Problem("Entity set 'AppDbContext.Instruments'  is null.");
          }
            _context.Instruments.Add(instrument);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInstrument", new { id = instrument.Id }, instrument);
        }

        // DELETE: api/Instruments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInstrument(int id)
        {
            if (_context.Instruments == null)
            {
                return NotFound();
            }
            var instrument = await _context.Instruments.FindAsync(id);
            if (instrument == null)
            {
                return NotFound();
            }

            _context.Instruments.Remove(instrument);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InstrumentExists(int id)
        {
            return (_context.Instruments?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
