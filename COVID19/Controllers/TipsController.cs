using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using COVID19.Data;
using COVID19.Models;

namespace COVID19.Controllers
{
    public class TipsController : Controller
    {
        private readonly MvcMovieContext _context;

        public TipsController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: Tips
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tips.ToListAsync());
        }

        // GET: Tips/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tips = await _context.Tips
                .FirstOrDefaultAsync(m => m.TipsId == id);
            if (tips == null)
            {
                return NotFound();
            }

            return View(tips);
        }

        // GET: Tips/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tips/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipsId,Title,Content,LinkImage")] Tips tips)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tips);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tips);
        }

        // GET: Tips/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tips = await _context.Tips.FindAsync(id);
            if (tips == null)
            {
                return NotFound();
            }
            return View(tips);
        }

        // POST: Tips/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TipsId,Title,Content,LinkImage")] Tips tips)
        {
            if (id != tips.TipsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tips);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipsExists(tips.TipsId))
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
            return View(tips);
        }

        // GET: Tips/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tips = await _context.Tips
                .FirstOrDefaultAsync(m => m.TipsId == id);
            if (tips == null)
            {
                return NotFound();
            }

            return View(tips);
        }

        // POST: Tips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tips = await _context.Tips.FindAsync(id);
            _context.Tips.Remove(tips);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipsExists(int id)
        {
            return _context.Tips.Any(e => e.TipsId == id);
        }
    }
}
