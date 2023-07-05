using CRUDUsers.Models;
using CRUDUsers.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDUsers.Controllers
{
    public class VideogameController : Controller
    {
        private readonly MyDbContext _context;

        public VideogameController(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new VideogameViewModel
            {
                Videogames = await _context.Videogames.ToListAsync(),
                NewVideogame = new Videogame()
            };
            return _context.Videogames != null ?
                View(viewModel) : 
                Problem("There was a problem with the videogames");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VideogameViewModel model)
        {
            if (model != null)
            {
                var newVideogame = new Videogame()
                {
                    name = model.NewVideogame.name,
                    description = model.NewVideogame.description
                };
                _context.Add(newVideogame);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm(int? id)
        {
            Console.WriteLine("Run");
            if (id == null)
            {
                return NotFound();
            }

            var videogame = await _context.Videogames.FindAsync(id);
            Console.WriteLine("Found");
            if (videogame != null)
            {
                _context.Videogames.Remove(videogame);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
