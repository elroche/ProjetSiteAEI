using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcAEI.Models;

public class Contact
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Veuillez entrer votre nom et prénom.")]
    public string? Nom { get; set; }

    [Display(Name = "Adresse mail")]
    [Required(ErrorMessage = "Veuillez entrer une adresse mail valide.")]
    [EmailAddress]
    public string? Email { get; set; }

    [Display(Name = "Numéro de téléphone")]
    [Required(ErrorMessage = "Veuillez entrer un numéro de téléphone valide.")]
    [Phone]
    public string? Numero { get; set; }

    [Required(ErrorMessage = "Veuillez entrer l'objet de votre message")]
    public string? Objet { get; set; }

    [Required(ErrorMessage = "Veuillez saisir votre message")]
    public string? Message { get; set; }
    public DateTime date = DateTime.Today;

    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }
}

