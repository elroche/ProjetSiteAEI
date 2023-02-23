using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcAEI.Models;

public class Paragraphe
{
    public int Id { get; set; }
    public string? Titre { get; set; }
    public string? Texte { get; set; }
}

