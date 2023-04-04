
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAEI.Models;
using MvcAEI.Data;

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
            return RedirectToAction(nameof(Creer));
        }
        return View(contact);
    }
}
