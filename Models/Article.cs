using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcAEI.Models;

public class Article
{
    public int Id { get; set; }

    public string? Titre { get; set; }

    [Display(Name = "Résumé")]
    public string? Description { get; set; }
    public string? Image { get; set; }
    public List<Paragraphe>? Paragraphes { get; set; }

    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime? Date { get; set; }

    public string? Editeur { get; set; }


    /*public Article(string titre, string description, string image, List<Paragraphe> paragraphes, string editeur, DateTime date)
    {
        Date = date.Date;
    }

    public Article(int id, string titre, string description, string image, List<Paragraphe> paragraphes, string editeur, DateTime date)
    {
        Date = date.Date;
    }*/
}
