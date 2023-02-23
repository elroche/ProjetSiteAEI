using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcAEI.Models;

public class Contact
{
    public int Id { get; set; }

    public string? Nom { get; set; }

    [Display(Name = "Adresse mail")]
    [Required(ErrorMessage = "Veuillez entrer une adresse mail valide.")]
    [EmailAddress]
    public string? Email { get; set; }

    [Display(Name = "Numéro de téléphone")]
    [Required(ErrorMessage = "Veuillez entrer un numéro de téléphone valide.")]
    [Phone]
    public string? Numero { get; set; }
    public string? Objet { get; set; }
    public string? Message { get; set; }
    public DateTime date = DateTime.Today;

    public DateTime Date
    {
        get { return date; }
        set { date = value;}
    }
}

