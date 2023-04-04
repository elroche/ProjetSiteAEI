using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MvcAEI.Models;

public class MembreDTO
{
    public int Id { get; set; }
    public string? Nom { get; set; }
    public string? Prenom { get; set; }
    public string? Photo { get; set; }
    public string? Mot { get; set; }

    public Pole? Pole { get; set; }

    public Role? Role { get; set; }
    public int? MandatId { get; set; }
    
    public static string[] getNamesPoles()
    {
        return (Enum.GetNames(typeof(Pole)));
    }

    public static string[] getNamesRoles()
    {
        return (Enum.GetNames(typeof(Role)));
    }

}
