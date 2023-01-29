using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


public class Article
{
    public int Id { get; set; }

    public string? Titre { get; set; }

    [Display(Name = "Résumé")]
    public string? Resume { get; set; }
    public string? Texte { get; set; }
    public DateTime? Date { get; set; }
}
