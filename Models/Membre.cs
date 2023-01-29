using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


public class Membre
{
    public int Id { get; set; }

    public string? Nom { get; set; }
    public string? Prenom { get; set; }

    [Display(Name = "Année")]
    public DateTime Year { get; set; }
    public Pole? Pole { get; set; }

    public Role? Role { get; set; }

    //[Display(Name = "Code postal")]
    //[Required(ErrorMessage = "Veuillez entrer un code postal valide.")]
    //public int CodePostal { get; set; }

}

public enum Pole
{
    Presidence, PoleA, PoleB, Communication
}

public enum Role
{
    [Display(Name = "Président(e)")]
    President,

    [Display(Name = "Vice-Président(e)")]
    VicePresident,

    [Display(Name = "Trésorier(e)")]
    Tresorier,

    [Display(Name = "Vice-Trésorier(e)")]
    ViceTresorier,

    [Display(Name = "Responsable du pole Communication")]
    RespoCommunication
}
