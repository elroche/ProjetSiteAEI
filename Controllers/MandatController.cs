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
    
    // Page de tous les mandats des administrateurs
    [Authorize]
    public async Task<IActionResult> Index()
    {
        return View(await _context.Mandats.ToListAsync());
    }

    // GET: /Mandat/Supprimer/id
    // Permet de supprimer le mandat associé à l'identifiant id
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
    // Permet de supprimer le mandat associée à l'identifiant id
    [Authorize]
    [HttpPost, ActionName("Supprimer")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var mandat = await _context.Mandats.Include(m => m.Membres).FirstOrDefaultAsync(m => m.Id == id);
        if (mandat == null)
        {
            return NotFound();
        }
        // Supprimer tous les membres associés au mandat
        _context.Membres.RemoveRange(mandat.Membres);
    
        // Ensuite, supprimer le mandat lui-même
        _context.Mandats.Remove(mandat);

        await _context.SaveChangesAsync();

        TempData["messageSuccess"] = "La suppression du mandat a bien été effectuée.";

        return RedirectToAction(nameof( Index));
    }

    // GET: Mandat/Modifier/id
    // Permet de modifier le mandat associé à l'identifiant id
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
                TempData["messageSuccess"] = "La modification du mandat a bien été effectuée.";

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MandatExist(mandat.Id))
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

    // Permet de vérifier l'existence du mandat associé à l'identifiant id
    private bool MandatExist(int id)
    {
        return _context.Mandats.Any(m => m.Id == id);
    }

    // GET: Mandat/Creer
    // Permet de creer un mandat
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
            TempData["messageSuccess"] = "La création du mandat a bien été effectuée.";
            return RedirectToAction(nameof(Index));
        }
        return View(mandat);
    }
}