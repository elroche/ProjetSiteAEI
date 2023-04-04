using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAEI.Models;
using MvcAEI.Data;
using Microsoft.AspNetCore.Authorization;

public class ArticleController : Controller
{
    private readonly ApplicationDbContext _context;

    public ArticleController(ApplicationDbContext context)
    {
        _context = context;
    }

    //Page Articles
    public async Task<IActionResult> Index()
    {
        var articles = _context.Articles.OrderByDescending(m => m.Id).ToList();
        return View(articles);
    }

    //Page détails d'un article
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

    // Page des Article pour les administrateurs
    [Authorize]
    [HttpGet("/Article/IndexAdmin")]
    public IActionResult IndexAdmin()
    {
        var articles = _context.Articles.OrderByDescending(a => a.Id).ToList();
        return View(articles);
    }


    // GET: Article/Creer
    // [Authorize]
    // public async Task<IActionResult> Creer()
    // {
    //     var mandats = await _context.Mandats.OrderBy(m => m.Id).ToListAsync();
    //     ViewData["MandatId"] = new SelectList(mandats, "Id", "Annee");
    //     return View();
    // }

    // POST: Article/Creer
    // Permet de créer un membre
    // [Authorize]
    // [HttpPost]
    // [ValidateAntiForgeryToken]
    // public async Task<IActionResult> Creer([Bind("Id,Nom,Prenom,Photo,Mot,Pole, Role, MandatId")] MembreDTO membreDTO)
    // {
    //     Membre membre = new Membre(membreDTO);

    //     var mandat = await _context.Mandats.Where(m => m.Id == membre.MandatId).SingleOrDefaultAsync();
    //     membre.Mandat = mandat!;

    //     if (ModelState.IsValid)
    //     {
    //         if (membre.Photo==null)
    //         {
    //             membre.Photo="/images/membres/anonyme.jpg";
    //         }
    //         _context.Add(membre);
    //         await _context.SaveChangesAsync();
    //         return RedirectToAction(nameof(IndexAdmin));
    //     }
    //     return View(membre);
    // }

}
