
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAEI.Models;

public class MandatController : Controller
{
    private readonly AEIContext _context;


    public MandatController(AEIContext context)
    {
        _context = context;
    }


    // Page L'équipe
    /*public IActionResult Index()
    {
        var mandats = _context.Mandats.OrderBy(m => m.Annee).ToList();
        ViewData["mandats"] = mandats;
        var membres = _context.Mandats.Include(s => s.Membres);
        return View(membres);
    }*/

    public async Task<IActionResult> Index(int id)
    {
        var mandats = _context.Mandats.OrderBy(m => m.Annee).ToList();
        ViewData["mandats"] = mandats;
        var mem = _context.Membres.Where(m => m.Mandat.Id == id).ToList();
        ViewData["mem"] = mem;
        var membres = _context.Membres.OrderBy(m => m.Role).ToList();
        ViewData["membres"] = membres;

        var mandat = await _context.Mandats.Where(m => m.Id == id)
           .Include(m => m.Membres)
           .ToListAsync();

        if (mandat == null)
        {
            return NotFound();
        }

        return View(mandat);
    }
}
