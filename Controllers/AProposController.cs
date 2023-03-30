
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAEI.Models;
using MvcAEI.Data;

public class AProposController : Controller
{
    private readonly ApplicationDbContext _context;

    public AProposController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult PresentationJE()
    {
        return View();
    }

    public IActionResult MentionsLegales()
    {
        return View();
    }

}
