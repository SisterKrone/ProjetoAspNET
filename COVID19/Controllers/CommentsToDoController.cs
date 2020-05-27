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
    public class CommentsToDoController : Controller
    {
        private readonly MvcMovieContext _context;

        public CommentsToDoController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: CommentsToDo
        public async Task<IActionResult> Index()
        {
            var mvcMovieContext = _context.CommentsToDo.Include(c => c.ToDo);
            return View(await mvcMovieContext.ToListAsync());
        }

        // GET: CommentsToDo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commentsToDo = await _context.CommentsToDo
                .Include(c => c.ToDo)
                .FirstOrDefaultAsync(m => m.CommentsToDoId == id);
            if (commentsToDo == null)
            {
                return NotFound();
            }

            return View(commentsToDo);
        }

        // GET: CommentsToDo/Create
        public IActionResult Create()
        {
            ViewData["ToDoId"] = new SelectList(_context.ToDo, "ToDoId", "ToDoId");
            return View();
        }

        // POST: CommentsToDo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CommentsToDoId,Name,Content,ToDoId")] CommentsToDo commentsToDo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(commentsToDo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ToDoId"] = new SelectList(_context.ToDo, "ToDoId", "ToDoId", commentsToDo.ToDoId);
            return View(commentsToDo);
        }

        // GET: CommentsToDo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commentsToDo = await _context.CommentsToDo.FindAsync(id);
            if (commentsToDo == null)
            {
                return NotFound();
            }
            ViewData["ToDoId"] = new SelectList(_context.ToDo, "ToDoId", "ToDoId", commentsToDo.ToDoId);
            return View(commentsToDo);
        }

        // POST: CommentsToDo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CommentsToDoId,Name,Content,ToDoId")] CommentsToDo commentsToDo)
        {
            if (id != commentsToDo.CommentsToDoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(commentsToDo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommentsToDoExists(commentsToDo.CommentsToDoId))
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
            ViewData["ToDoId"] = new SelectList(_context.ToDo, "ToDoId", "ToDoId", commentsToDo.ToDoId);
            return View(commentsToDo);
        }

        // GET: CommentsToDo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commentsToDo = await _context.CommentsToDo
                .Include(c => c.ToDo)
                .FirstOrDefaultAsync(m => m.CommentsToDoId == id);
            if (commentsToDo == null)
            {
                return NotFound();
            }

            return View(commentsToDo);
        }

        // POST: CommentsToDo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var commentsToDo = await _context.CommentsToDo.FindAsync(id);
            _context.CommentsToDo.Remove(commentsToDo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommentsToDoExists(int id)
        {
            return _context.CommentsToDo.Any(e => e.CommentsToDoId == id);
        }
    }
}
