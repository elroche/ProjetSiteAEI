using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAEI.Models;
using MvcAEI.Data;
using Microsoft.AspNetCore.Authorization;


public class MandatController : Controller
{
    private readonly ApplicationDbContext _context;

    public MandatController(ApplicationDbContext context)
    {
        _context = context;
    }

    [Authorize]
    public async Task<IActionResult> Index()
    {
        return View(await _context.Mandats.ToListAsync());
    }

    // GET: /Mandat/Supprimer/id
    [Authorize]
    public async Task<IActionResult> Supprimer(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var mandat = await _context.Mandats
            .FirstOrDefaultAsync(m => m.Id == id);
        if (mandat == null)
        {
            return NotFound();
        }
        return View(mandat);
    }

    // POST: /Mandat/Supprimer/id
    // Permet de supprimer la mandat associée à l'identifiant id
    [Authorize]
    [HttpPost, ActionName("Supprimer")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var mandat = await _context.Mandats.FindAsync(id);
        if (mandat == null)
        {
            return NotFound();
        }
        _context.Mandats.Remove(mandat);
        await _context.SaveChangesAsync();

        TempData["messageSuccess"] = "La suppression a bien été effectuée.";

        return RedirectToAction(nameof(Index));
    }

    // GET: Mandat/Modifier/id
    [Authorize]    
    public async Task<IActionResult> Modifier(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var mandat = await _context.Mandats.FindAsync(id);
        if (mandat == null)
        {
            return NotFound();
        }
        return View(mandat);
    }


    // POST: Mandat/Modifier/id
    // Permet de modifier le mandat associé à l'ientifiant id
    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Modifier(int id, [Bind("Id,Annee")] Mandat mandat)
    {
        if (id != mandat.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(mandat);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmExist(mandat.Id))
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
        return View(mandat);
    }

    // Permet de vérifier l'existaence du mandat associé à l'identifiant id
    private bool FilmExist(int id)
    {
        return _context.Mandats.Any(m => m.Id == id);
    }

    // GET: Mandat/Creer
    [Authorize]
    public IActionResult Creer()
    {
        return View();
    }

    // POST: Mandat/Creer
    // Permet de créer un mandat
    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Creer([Bind("Id,Annee")] Mandat mandat)
    {
        if (ModelState.IsValid)
        {
            _context.Add(mandat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(mandat);
    }


}