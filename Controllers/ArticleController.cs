using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAEI.Models;
using MvcAEI.Data;

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

}
