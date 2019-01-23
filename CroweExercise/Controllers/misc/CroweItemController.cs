using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CroweExercise.Models;

namespace CroweExercise.Controllers
{
    [Route("api/croweitem")]
    [ApiController]
    public class CroweItemController : ControllerBase
    {
        private readonly CroweExerciseContext _context;

        public CroweItemController(CroweExerciseContext context)
        {
            _context = context;

            if (_context.CroweItems.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.CroweItems.Add(new CroweItem { Name = "Item1" });
                _context.SaveChanges();
            }
        }

        // GET: api/croweitem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CroweItem>>> GetCroweItems()
        {
            return await _context.CroweItems.ToListAsync();
        }

        // GET: api/croweitem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CroweItem>> GetCroweItem(long id)
        {
            var todoItem = await _context.CroweItems.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

        // POST: api/croweitem
        [HttpPost]
        public async Task<ActionResult<CroweItem>> PostCroweItem(CroweItem croweItem)
        {
            _context.CroweItems.Add(croweItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCroweItem", new { id = croweItem.Id }, croweItem);
        }

        // PUT: api/croweitem/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCroweItem(long id, CroweItem croweItem)
        {
            if (id != croweItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(croweItem).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/croweitem/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CroweItem>> DeleteTodoItem(long id)
        {
            var todoItem = await _context.CroweItems.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _context.CroweItems.Remove(todoItem);
            await _context.SaveChangesAsync();

            return todoItem;
        }
    }
}