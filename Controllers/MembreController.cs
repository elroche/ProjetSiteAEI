using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAEI.Models;
using MvcAEI.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;



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


    // Page des membres pour les administrateurs
    [Authorize]
    [HttpGet("/Membre/IndexAdmin")]
    public IActionResult IndexAdmin()
    {
        var mandats = _context.Mandats.OrderByDescending(m => m.Annee).ToList();
        ViewData["mandats"] = mandats;
        var membres = _context.Membres.Include(m => m.Mandat).OrderBy(m => m.Id).ToList();
        return View(membres);
    }


    // GET: Membre/Creer
    // Permet de créer un membre
    [Authorize]
    public async Task<IActionResult> Creer()
    {
        var poles = Membre.getNamesPoles();
        ViewData["poles"] = poles;
        var roles = Membre.getNamesRoles();
        ViewData["roles"] = roles;
        var mandats = await _context.Mandats.OrderBy(m => m.Id).ToListAsync();
        ViewData["MandatId"] = new SelectList(mandats, "Id", "Annee");
        return View();
    }

    // POST: Membre/Creer
    // Permet de créer un membre
    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Creer([Bind("Id,Nom,Prenom,Photo,Mot,Pole, Role, MandatId")] MembreDTO membreDTO)
    {
        Membre membre = new Membre(membreDTO);

        var mandat = await _context.Mandats.Where(m => m.Id == membre.MandatId).SingleOrDefaultAsync();
        membre.Mandat = mandat!;

        if (ModelState.IsValid)
        {
            if (membre.Photo==null)
            {
                membre.Photo="/images/membres/anonyme.jpg";
            }
            _context.Add(membre);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexAdmin));
        }
        return View(membre);
    }



    // GET: Membre/Modifier/id
    // Permet de modifier le membre associé à l'identifiant id
    [Authorize]
    public async Task<IActionResult> Modifier(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var membre = await _context.Membres.Include(m => m.Mandat).Where(m => m.Id == id)
               .SingleOrDefaultAsync();
        var poles = Membre.getNamesPoles();
        ViewData["poles"] = poles;
        var roles = Membre.getNamesRoles();
        ViewData["roles"] = roles;
        var mandats = await _context.Mandats.OrderBy(m => m.Id).ToListAsync();
        ViewData["MandatId"] = new SelectList(mandats, "Id", "Annee");

        if (membre == null)
        {
            return NotFound();
        }
        return View(membre);
    }

    // POST: Membre/Modifier/id
    // Permet de modifier le membre associé à l'identifiant id
    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Modifier(int id, [Bind("Id,Nom,Prenom,Photo,Mot,Pole, Role, MandatId")] MembreDTO membreDTO)
    {
        if (id != membreDTO.Id)
        {
            return NotFound();
        }

        Membre membre = new Membre(membreDTO);

        var mandat = _context.Mandats.Find(membre.MandatId);
        membre.Mandat = mandat!;

        if (ModelState.IsValid)
        {
            if (membre.Photo==null)
            {
                membre.Photo="/images/membres/anonyme.jpg";
            }
            try
            {
                _context.Update(membre);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexAdmin));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MembreExist(membre.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }
        return View(membre);
    }

    // Permet de vérifier l'existence du membre associé à l'identifiant id
    private bool MembreExist(int id)
    {
        return _context.Membres.Any(m => m.Id == id);
    }


    // GET: /Membre/Supprimer/id
    // Permet de supprimer le membre associé à l'identifiant id
    [Authorize]
    public async Task<IActionResult> Supprimer(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var membre = await _context.Membres
            .FirstOrDefaultAsync(m => m.Id == id);
        if (membre == null)
        {
            return NotFound();
        }
        return View(membre);
    }

    // POST: /Membre/Supprimer/id
    // Permet de supprimer le membre associé à l'identifiant id
    [Authorize]
    [HttpPost, ActionName("Supprimer")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var membre = await _context.Membres.FindAsync(id);
        if (membre == null)
        {
            return NotFound();
        }
        _context.Membres.Remove(membre);
        await _context.SaveChangesAsync();

        TempData["messageSuccess"] = "La suppression a bien été effectuée.";

        return RedirectToAction(nameof(Index));
    }
}
