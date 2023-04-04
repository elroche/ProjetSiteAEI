
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAEI.Models;
using MvcAEI.Data;

public class CompetencesController : Controller
{
    private readonly ApplicationDbContext _context;

    public CompetencesController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Page competences
    public IActionResult Index()
    {
        return View();
    }

}
