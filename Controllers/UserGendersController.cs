using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LonelyForU.Models;

namespace LonelyForU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGendersController : ControllerBase
    {
        private readonly DatingDbContext _context;

        public UserGendersController(DatingDbContext context)
        {
            _context = context;
        }

        // GET: api/UserGenders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserGender>>> GetUserGenders()
        {
          if (_context.UserGenders == null)
          {
              return NotFound();
          }
            return await _context.UserGenders.ToListAsync();
        }

        // GET: api/UserGenders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserGender>> GetUserGender(long id)
        {
          if (_context.UserGenders == null)
          {
              return NotFound();
          }
            var userGender = await _context.UserGenders.FindAsync(id);

            if (userGender == null)
            {
                return NotFound();
            }

            return userGender;
        }

        // PUT: api/UserGenders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserGender(long id, UserGender userGender)
        {
            if (id != userGender.UserGenderId)
            {
                return BadRequest();
            }

            _context.Entry(userGender).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserGenderExists(id))
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

        // POST: api/UserGenders
        [HttpPost]
        public async Task<ActionResult<UserGender>> PostUserGender(UserGender userGender)
        {
          if (_context.UserGenders == null)
          {
              return Problem("Entity set 'DatingDbContext.UserGenders'  is null.");
          }
            _context.UserGenders.Add(userGender);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserGender", new { id = userGender.UserGenderId }, userGender);
        }


        private bool UserGenderExists(long id)
        {
            return (_context.UserGenders?.Any(e => e.UserGenderId == id)).GetValueOrDefault();
        }
    }
}
