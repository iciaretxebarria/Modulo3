using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VideoclubWebApp.Data;
using VideoclubWebApp.Models;

namespace VideoclubWebApp.Controllers
{
    public class UserFilmsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserFilmsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UserFilms
        public async Task<IActionResult> Index(bool vigente)
        {

            if (vigente!=null)
            {
                if (vigente)
                {
                    return View(await _context.UserFilm.Include(u => u.Film).Include(u => u.User).Where(u => u.ReturnDate > DateTime.Now).ToListAsync());

                }
                else
                {

                    return View(await _context.UserFilm.Include(u => u.Film).Include(u => u.User).Where(u => u.ReturnDate < DateTime.Now).ToListAsync());
                }
            }

            return View(await _context.UserFilm.Include(u => u.Film).Include(u => u.User).ToListAsync());

        }

        // GET: UserFilms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userFilm = await _context.UserFilm
                .Include(u => u.Film)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userFilm == null)
            {
                return NotFound();
            }

            return View(userFilm);
        }

        // GET: UserFilms/Create
        public IActionResult Create()
        {
            ViewData["FilmId"] = new SelectList(_context.Film, "Id", "Id");
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id");
            return View();
        }

        // POST: UserFilms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateRental,ReturnDate,UserId,FilmId")] UserFilm userFilm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userFilm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FilmId"] = new SelectList(_context.Film, "Id", "Id", userFilm.FilmId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", userFilm.UserId);
            return View(userFilm);
        }

        // GET: UserFilms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userFilm = await _context.UserFilm.FindAsync(id);
            if (userFilm == null)
            {
                return NotFound();
            }
            ViewData["FilmId"] = new SelectList(_context.Film, "Id", "Id", userFilm.FilmId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", userFilm.UserId);
            return View(userFilm);
        }

        // POST: UserFilms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateRental,ReturnDate,UserId,FilmId")] UserFilm userFilm)
        {
            if (id != userFilm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userFilm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserFilmExists(userFilm.Id))
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
            ViewData["FilmId"] = new SelectList(_context.Film, "Id", "Id", userFilm.FilmId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", userFilm.UserId);
            return View(userFilm);
        }

        // GET: UserFilms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userFilm = await _context.UserFilm
                .Include(u => u.Film)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userFilm == null)
            {
                return NotFound();
            }

            return View(userFilm);
        }

        // POST: UserFilms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userFilm = await _context.UserFilm.FindAsync(id);
            _context.UserFilm.Remove(userFilm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserFilmExists(int id)
        {
            return _context.UserFilm.Any(e => e.Id == id);
        }
    }
}
