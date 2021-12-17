using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenVanCuong560.Models;

namespace NguyenVanCuong560.Controllers
{
    public class UniversityNVC560Controller : Controller
    {
        private readonly ApplicationDBContext _context;

        public UniversityNVC560Controller(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: UniversityNVC560
        public async Task<IActionResult> Index()
        {
            return View(await _context.UniversityNVC560.ToListAsync());
        }

        // GET: UniversityNVC560/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityNVC560 = await _context.UniversityNVC560
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityNVC560 == null)
            {
                return NotFound();
            }

            return View(universityNVC560);
        }

        // GET: UniversityNVC560/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UniversityNVC560/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UniversityId,UniversityName")] UniversityNVC560 universityNVC560)
        {
            if (ModelState.IsValid)
            {
                _context.Add(universityNVC560);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(universityNVC560);
        }

        // GET: UniversityNVC560/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityNVC560 = await _context.UniversityNVC560.FindAsync(id);
            if (universityNVC560 == null)
            {
                return NotFound();
            }
            return View(universityNVC560);
        }

        // POST: UniversityNVC560/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UniversityId,UniversityName")] UniversityNVC560 universityNVC560)
        {
            if (id != universityNVC560.UniversityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(universityNVC560);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UniversityNVC560Exists(universityNVC560.UniversityId))
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
            return View(universityNVC560);
        }

        // GET: UniversityNVC560/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityNVC560 = await _context.UniversityNVC560
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityNVC560 == null)
            {
                return NotFound();
            }

            return View(universityNVC560);
        }

        // POST: UniversityNVC560/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var universityNVC560 = await _context.UniversityNVC560.FindAsync(id);
            _context.UniversityNVC560.Remove(universityNVC560);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UniversityNVC560Exists(string id)
        {
            return _context.UniversityNVC560.Any(e => e.UniversityId == id);
        }
    }
}
