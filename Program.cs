using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MvcAEI.Data;
using MvcAEI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

//builder.Services.AddDbContext<AEIContext>();

var app = builder.Build();

// Configuration de la base de données
var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
optionsBuilder.UseSqlite("Data Source=app.db");

// Création du service provider pour la gestion des services
var serviceProvider = new ServiceCollection()
    .AddDbContext<ApplicationDbContext>(options => options.UseSqlite("Data Source=app.db"))
    .BuildServiceProvider();

// Récupération du contexte de la base de données
var context = serviceProvider.GetService<ApplicationDbContext>();

// Ajout des données initiales
SeedData.Init(context, serviceProvider).Wait();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
