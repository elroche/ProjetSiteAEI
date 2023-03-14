using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAEI.Models;

public class MembreController : Controller
{
    private readonly AEIContext _context;


    public MembreController(AEIContext context)
    {
        _context = context;
    }


    // Page L'équipe
    public IActionResult Index()
    {
        var mandats = _context.Mandats.OrderByDescending(m => m.Annee).ToList();
        ViewData["mandats"] = mandats;
        var dernierMandatId = _context.Mandats.Max(m => m.Id);
        var membres = _context.Membres.Where(m => m.Mandat.Id == dernierMandatId).Include(m => m.Mandat).ToList();
        return View(membres);
    }

    [HttpPost("{id}")]
    public async Task<IActionResult> Index(int id)
    {

        var mandats = _context.Mandats.OrderByDescending(m => m.Annee).ToList();
        ViewData["mandats"] = mandats;

        var membres = await _context.Membres.Where(m => m.Mandat.Id == id)
           .Include(m => m.Mandat)
           .ToListAsync();

        if (membres == null)
        {
            return NotFound();
        }

        return View(membres);
    }
}
