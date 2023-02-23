using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcAEI.Models;

public class Mandat
{
    public int Id { get; set; }

    [Display(Name = "Année")]
    public int Annee { get; set; }
    public List<Membre>? Membres { get; set; }
}
