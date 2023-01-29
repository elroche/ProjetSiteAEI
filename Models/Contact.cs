using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


public class Contact
{
    public int Id { get; set; }

    public string? Nom { get; set; }

    [Display(Name = "Adresse mail")]
    //[Required(ErrorMessage = "Veuillez entrer une adresse mail valide.")]
    public EmailAddressAttribute? Email { get; set; }

    [Display(Name = "Numéro de téléphone")]
    //[Required(ErrorMessage = "Veuillez entrer un numéro de téléphone valide.")]
    public PhoneAttribute? Numero { get; set; }
    public string? Objet { get; set; }
    public string? Message { get; set; }
    public DateTime? Date { get; set; }
}

