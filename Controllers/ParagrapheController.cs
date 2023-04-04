using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAEI.Models;
using MvcAEI.Data;
using Microsoft.AspNetCore.Authorization;

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
    public IActionResult IndexAdmin()
    {
        var paragraphes = _context.Paragraphes.OrderByDescending(p => p.Id).ToList();
        return View(paragraphes);
    }

    //Page détails d'un paragraphe
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
