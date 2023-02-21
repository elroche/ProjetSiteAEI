
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class ContactController : Controller
{
    private readonly AEIContext _context;


    public ContactController(AEIContext context)
    {
        _context = context;
    }

    //Récupère tous les cinémas 
    /*public string Index()
    {

        return "Hello World!"; ;
    }*/



    // GET: Cinema/Create
    // Permet d'ajouter un cinéma
    /*public IActionResult Create()
    {
        return View();
    }

    // POST: Cinema/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Nom,Adresse,CodePostal,Ville,Responsable,PrixPlace")] Cinema cinema)
    {
        if (ModelState.IsValid)
        {
            _context.Add(cinema);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(cinema);
    }*/
}
