using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


public class Article
{
    public int Id { get; set; }

    public string? Titre { get; set; }

    [Display(Name = "Résumé")]
    public string? Description { get; set; }
    public string? Image { get; set; }
    public List<Paragraphe>? Paragraphes { get; set; }
    public DateTime? Date { get; set; }
    public string? Editeur { get; set; }
}
