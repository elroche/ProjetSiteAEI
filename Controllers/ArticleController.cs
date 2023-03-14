using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAEI.Models;

public class ArticleController : Controller
{
    private readonly AEIContext _context;


    public ArticleController(AEIContext context)
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
