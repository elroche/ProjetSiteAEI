using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAEI.Models;
using MvcAEI.Data;

public class AProposController : Controller
{
    private readonly ApplicationDbContext _context;

    // Le contrôleur a besoin d'une instance de ApplicationDbContext pour accéder à la base de données
    public AProposController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Action pour afficher la vue de présentation de l'entreprise
    public IActionResult PresentationJE()
    {
        return View();
    }

    // Action pour afficher la vue des mentions légales
    public IActionResult MentionsLegales()
    {
        return View();
    }
}
