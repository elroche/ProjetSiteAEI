﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcAEI.Models;

public class Paragraphe
{
    public int Id { get; set; }
    public string? Titre { get; set; }
    public string? Texte { get; set; }
    public int? ArticleId {get; set;}
    public Article? Article {get; set;}

    public Paragraphe() { }

    public Paragraphe(ParagrapheDTO dto)
    {
        Id = dto.Id;
        Titre = dto.Titre;
        Texte = dto.Texte;
        ArticleId = dto.ArticleId;
    }
}

