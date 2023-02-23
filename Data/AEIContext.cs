using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MvcAEI.Models;

public class AEIContext : DbContext
{
    public DbSet<Article> Articles { get; set; } = null!;
    public DbSet<Contact> Contacts { get; set; } = null!;
    public DbSet<Mandat> Mandats { get; set; } = null!;
    public DbSet<Membre> Membres { get; set; } = null!;
    public DbSet<Paragraphe> Paragraphes {get; set;} = null!;
    public string DbPath { get; private set; }

    public AEIContext()
    {
        // Path to SQLite database file
        DbPath = "AEI.db";
    }
    // The following configures EF to create a SQLite database file locally
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // Use SQLite as database
        options.UseSqlite($"Data Source={DbPath}");
        // Optional: log SQL queries to console
        options.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information);
    }
}