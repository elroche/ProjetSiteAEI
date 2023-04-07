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
    // Permet de creer un article
    [Authorize]
    public IActionResult Creer()
    {
        return View();
    }

    // POST: Article/Creer
    // Permet de créer un article
    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Creer([Bind("Id,Titre,Description, Image,Date, Editeur ")] Article article)
    {
        if(article.Image==null)
        {
            article.Image="/images/Articles/motjb.png";
        }
        if (ModelState.IsValid)
        {
            _context.Add(article);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexAdmin));
        }
        return View(article);
    }


    // GET: Article/Modifier/id
    // Permet de modifier l'article associé à l'identifiant id
    [Authorize]    
    public async Task<IActionResult> Modifier(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var article = await _context.Articles.FindAsync(id);
        if (article == null)
        {
            return NotFound();
        }
        return View(article);
    }


    // POST: Article/Modifier/id
    // Permet de modifier l'article associé à l'ientifiant id
    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Modifier(int id, [Bind("Id,Titre, Description, Image, Date, Editeur")] Article article)
    {
        if (id != article.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            if (article.Image==null)
            {
                article.Image="/images/Articles/motjb.png";
            }
            try
            {
                _context.Update(article);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticleExist(article.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(IndexAdmin));
        }
        return View(article);
    }

    // Permet de vérifier l'existence de l'article associé à l'identifiant id
    private bool ArticleExist(int id)
    {
        return _context.Articles.Any(m => m.Id == id);
    }

    // GET: /Article/Supprimer/id
    // Permet de supprimer l'article associé à l'identifiant id
    [Authorize]
    public async Task<IActionResult> Supprimer(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var article = await _context.Articles
            .FirstOrDefaultAsync(m => m.Id == id);
        if (article == null)
        {
            return NotFound();
        }
        return View(article);
    }

    // POST: /Article/Supprimer/id
    // Permet de supprimer l'article associée à l'identifiant id
    [Authorize]
    [HttpPost, ActionName("Supprimer")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var article = await _context.Articles.Include(a => a.Paragraphes).FirstOrDefaultAsync(a => a.Id == id);
        if (article == null)
        {
            return NotFound();
        }
            // Supprimer tous les paragraphes associés à l'article
        _context.Paragraphes.RemoveRange(article.Paragraphes);
    
        // Ensuite, supprimer l'article lui-même
        _context.Articles.Remove(article);
    
        await _context.SaveChangesAsync();

        TempData["messageSuccess"] = "La suppression a bien été effectuée.";

        return RedirectToAction(nameof(IndexAdmin));
    }
}
