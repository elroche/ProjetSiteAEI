using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAEI.Models;
using MvcAEI.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

public class ParagrapheController : Controller
{
    private readonly ApplicationDbContext _context;

    public ParagrapheController(ApplicationDbContext context)
    {
        _context = context;
    }

    
    // Page des paragraphes pour les administrateurs
    [Authorize]
    [HttpGet("/Paragraphe/Index")]
    public IActionResult Index()
    {
        var paragraphes = _context.Paragraphes.Include(a => a.Article).OrderByDescending(p => p.Id).ToList();
        return View(paragraphes);
    }

    //Page détails d'un paragraphe
    [Authorize]
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var paragraphes = _context.Paragraphes.Where(p => p.Article.Id==id).ToList();
        ViewData["paragraphes"] = paragraphes;

        var article = await _context.Articles
            .Include(a => a.Paragraphes)
            .Where(a => a.Id == id)
            .SingleOrDefaultAsync();

        if (article == null)
        {
            return NotFound();
        }

        return View(article);
    }

    // GET: Paragraphe/Creer
    // Permet de créer un paragraphe
    [Authorize]
    public async Task<IActionResult> Creer()
    {
        var articles = await _context.Articles.OrderBy(a => a.Id).ToListAsync();
        ViewData["ArticlesId"] = new SelectList(articles, "Id", "Titre");
        return View();
    }

    // POST: Paragraphe/Creer
    // Permet de créer un paragraphe
    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Creer([Bind("Id,Titre,Texte,ArticleId")] ParagrapheDTO paragrapheDTO)
    {
        Paragraphe paragraphe = new Paragraphe(paragrapheDTO);

        var article = _context.Articles.Find(paragraphe.ArticleId);
        paragraphe.Article = article!;

        if (ModelState.IsValid)
        {
            _context.Add(paragraphe);
            await _context.SaveChangesAsync();
            TempData["messageSuccess"] = "La création du paragraphe a bien été effectuée.";
            return RedirectToAction(nameof(Index));
        }
        return View(paragraphe);
    }

    // GET: Paragraphe/Modifier/id
    // Permet de modifier le paragraphe associé à l'identifiant id
    [Authorize]
    public async Task<IActionResult> Modifier(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var paragraphe = await _context.Paragraphes.Include(p => p.Article).Where(a => a.Id == id)
               .SingleOrDefaultAsync();
        var articles = await _context.Articles.OrderBy(a => a.Id).ToListAsync();
        ViewData["ArticlesId"] = new SelectList(articles, "Id", "Titre");

        if (paragraphe == null)
        {
            return NotFound();
        }
        return View(paragraphe);
    }

    // POST: Paragraphe/Modifier/id
    // Permet de modifier le paragraphe associé à l'identifiant id
    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Modifier(int id, [Bind("Id,Titre,Texte,ArticleId")] ParagrapheDTO paragrapheDTO)
    {
        if (id != paragrapheDTO.Id)
        {
            return NotFound();
        }

        Paragraphe paragraphe = new Paragraphe(paragrapheDTO);

        var article = _context.Articles.Find(paragraphe.ArticleId);
        paragraphe.Article = article!;

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(paragraphe);
                await _context.SaveChangesAsync();
                TempData["messageSuccess"] = "La modification du paragraphe a bien été effectuée.";
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParagrapheExist(paragraphe.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }
        return View(paragraphe);
    }

    // Permet de vérifier l'existence du paragraphe associé à l'identifiant id
    private bool ParagrapheExist(int id)
    {
        return _context.Paragraphes.Any(p => p.Id == id);
    }


    // GET: /Paragraphe/Supprimer/id
    // Permet de supprimer le paragraphe associé à l'identifiant id
    [Authorize]
    public async Task<IActionResult> Supprimer(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var paragraphe = await _context.Paragraphes.Include(a => a.Article).Where(p => p.Id == id)
            .SingleOrDefaultAsync();
        if (paragraphe == null)
        {
            return NotFound();
        }
        return View(paragraphe);
    }

    // POST: /Paragraphe/Supprimer/id
    // Permet de supprimer le paragraphe associé à l'identifiant id
    [Authorize]
    [HttpPost, ActionName("Supprimer")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var paragraphe = await _context.Paragraphes.Include(a => a.Article).Where(p => p.Id == id)
            .SingleOrDefaultAsync();
        if (paragraphe == null)
        {
            return NotFound();
        }
        _context.Paragraphes.Remove(paragraphe);
        await _context.SaveChangesAsync();

        TempData["messageSuccess"] = "La suppression du paragraphe a bien été effectuée.";

        return RedirectToAction(nameof(Index));
    }


}
