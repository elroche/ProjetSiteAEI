using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcAEI.Models;


namespace MvcAEI.Data;

//Création de la base de donnée
public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Article> Articles { get; set; } = null!;
    public DbSet<Contact> Contacts { get; set; } = null!;
    public DbSet<Mandat> Mandats { get; set; } = null!;
    public DbSet<Membre> Membres { get; set; } = null!;
    public DbSet<Paragraphe> Paragraphes {get; set;} = null!;
    public string DbPath { get; private set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }
}
