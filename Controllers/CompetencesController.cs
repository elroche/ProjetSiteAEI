
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAEI.Models;

public class CompetencesController : Controller
{
    private readonly AEIContext _context;


    public CompetencesController(AEIContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

}
