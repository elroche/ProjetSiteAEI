using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


public class Mandat
{
    public int Id { get; set; }

    [Display(Name = "Année")]
    public DateTime Annee { get; set; }
    public List<Membre>? Membres { get; set; }
}
