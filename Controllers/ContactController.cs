
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAEI.Models;
using MvcAEI.Data;
using Microsoft.AspNetCore.Authorization;


public class ContactController : Controller
{
    private readonly ApplicationDbContext _context;

    public ContactController(ApplicationDbContext context)
    {
        _context = context;
    }


    // GET: Contact/Create
    // Permet d'ajouter un contact grâce au formulaire
    public IActionResult Creer()
    {
        return View();
    }

    // POST: Contact/Create
    // Permet d'ajouter un contact grâce au formulaire
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Creer([Bind("Id,Nom,Email,Numero,Objet,Message,Date")] Contact contact)
    {
        if (ModelState.IsValid)
        {
            _context.Add(contact);
            await _context.SaveChangesAsync();
            TempData["messageSuccess"] = "Le formulaire de contact a bien été envoyé.";
            return RedirectToAction(nameof(Creer));
        }
        return View(contact);
    }

    // Page des paragraphes pour les administrateurs
    [Authorize]
    [HttpGet("/Contact/Index")]
    public IActionResult Index()
    {
        var contacts = _context.Contacts.OrderByDescending(p => p.Id).ToList();
        return View(contacts);
    }

    //Page détails d'un paragraphe
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var contact = await _context.Contacts
            .Where(c => c.Id == id)
            .SingleOrDefaultAsync();

        if (contact == null)
        {
            return NotFound();
        }
        
        return View(contact);
    }
}
