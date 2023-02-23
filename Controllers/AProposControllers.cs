
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAEI.Models;

public class AProposController : Controller
{
    private readonly AEIContext _context;


    public AProposController(AEIContext context)
    {
        _context = context;
    }

    public IActionResult PresentationJE()
    {
        return View();
    }

}
