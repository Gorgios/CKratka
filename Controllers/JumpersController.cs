using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SkijumpingTeams.Data;
using SkijumpingTeams.Models;

namespace SkijumpingTeams.Controllers
{
    [Authorize]
    public class JumpersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JumpersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Jumpers
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Jumpers.Include(j => j.Team);
            return View(await applicationDbContext.ToListAsync());
        }
        // GET: Jumpers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jumper = await _context.Jumpers
                .Include(j => j.Team)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jumper == null)
            {
                return NotFound();
            }

            return View(jumper);
        }

        // GET: Jumpers/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewData["TeamID"] = new SelectList(_context.Teams, "ID", "Nation");
            return View();
        }

        // POST: Jumpers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,PersonalBest,CarrerWins,DateOfBirth,PhotoLink,TeamID")] Jumper jumper)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jumper);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TeamID"] = new SelectList(_context.Teams, "ID", "Nation", jumper.TeamID);
            return View(jumper);
        }

        // GET: Jumpers/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jumper = await _context.Jumpers.FindAsync(id);
            if (jumper == null)
            {
                return NotFound();
            }
            ViewData["TeamID"] = new SelectList(_context.Teams, "ID", "Nation", jumper.TeamID);
            return View(jumper);
        }

        // POST: Jumpers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,PersonalBest,CarrerWins,DateOfBirth,PhotoLink,TeamID")] Jumper jumper)
        {
            if (id != jumper.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jumper);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JumperExists(jumper.ID))
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
            ViewData["TeamID"] = new SelectList(_context.Teams, "ID", "Nation", jumper.TeamID);
            return View(jumper);
        }

        // GET: Jumpers/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jumper = await _context.Jumpers
                .Include(j => j.Team)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jumper == null)
            {
                return NotFound();
            }

            return View(jumper);
        }

        // POST: Jumpers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jumper = await _context.Jumpers.FindAsync(id);
            _context.Jumpers.Remove(jumper);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JumperExists(int id)
        {
            return _context.Jumpers.Any(e => e.ID == id);
        }
    }
}
