
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcAEI.Models;

public class ContactController : Controller
{
    private readonly AEIContext _context;


    public ContactController(AEIContext context)
    {
        _context = context;
    }



    // GET: Contact/Create
    // Permet d'ajouter un contact grâce au formulaire
    public IActionResult Create()
    {
        return View();
    }

    // POST: Contact/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Nom,Email,Numero,Objet,Message,Date")] Contact contact)
    {
        if (ModelState.IsValid)
        {
            _context.Add(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Create));
        }
        return View(contact);
    }
}
