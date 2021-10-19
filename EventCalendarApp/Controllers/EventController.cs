using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EventCalendarApp.Models;
using Newtonsoft.Json;

namespace EventCalendarApp.Controllers
{
    public class EventController : Controller
    {
        private readonly EventContext _context;

        public EventController(EventContext context)
        {
            _context = context;
        }

        // GET: Event
        public IActionResult Index()
        {
            var Events = _context.Events.ToList();
            return new JsonResult(Events);
        }

        // GET: Event/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = _context.Events
                .FirstOrDefault(m => m.EventId == id);
            if (@event == null)
            {
                return NotFound();
            }

            return new JsonResult(@event);
        }

        // POST: Event/Create
        [HttpPost]

        public IActionResult Create([FromBody] System.Text.Json.JsonElement @event)
        {
            Event _event = JsonConvert.DeserializeObject<Event>(@event.ToString());
            _context.Events.Add(_event);
            _context.SaveChanges();


            return new JsonResult(@event);
        }

        // POST: Event/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [FromBody] System.Text.Json.JsonElement @event)
        {
            Event _event = JsonConvert.DeserializeObject<Event>(@event.ToString());

            if (id != _event.EventId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(_event);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(_event.EventId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return new JsonResult(id);
        }

        // POST: Event/Delete/5
        //[HttpPost, ActionName("Delete")]
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var @event = await _context.Events.FindAsync(id);
            _context.Events.Remove(@event);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.EventId == id);
        }
    }
}
