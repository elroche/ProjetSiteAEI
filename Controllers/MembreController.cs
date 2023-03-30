using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAEI.Models;
using MvcAEI.Data;
using Microsoft.AspNetCore.Authorization;


public class MembreController : Controller
{
    private readonly ApplicationDbContext _context;

    public MembreController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Page L'équipe
    [HttpGet("/Membre")]
    public IActionResult Index()
    {
        var mandats = _context.Mandats.OrderByDescending(m => m.Annee).ToList();
        ViewData["mandats"] = mandats;
        var dernierMandatId = _context.Mandats.Max(m => m.Id);
        var membres = _context.Membres.Where(m => m.Mandat.Id == dernierMandatId).Include(m => m.Mandat).ToList();
        return View(membres);
    }

    [HttpPost("/{id}")]
    public async Task<IActionResult> Details(int id)
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


    // Page L'équipe
    [Authorize]
    [HttpGet("/Membre/IndexAdmin")]
    public IActionResult IndexAdmin()
    {
        var mandats = _context.Mandats.OrderByDescending(m => m.Annee).ToList();
        ViewData["mandats"] = mandats;
        var membres = _context.Membres.Include(m => m.Mandat).OrderBy(m => m.Id).ToList();
        return View(membres);
    }


    // // GET: Membre/Create
    // public IActionResult Create()
    // {
    //     var genres = Film.getNamesGenres();
    //     ViewData["genres"] = genres;
    //     return View();
    // }

    // // POST: Membre/Create
    // // Permet de créer un membre
    // [HttpPost]
    // [ValidateAntiForgeryToken]
    // public async Task<IActionResult> Create([Bind("Id,Nom,Realisateur,Resume,Genre,Date,Duree")] Film film)
    // {
    //     if (ModelState.IsValid)
    //     {
    //         _context.Add(film);
    //         await _context.SaveChangesAsync();
    //         return RedirectToAction(nameof(Index));
    //     }
    //     return View(film);
    // }
}
