using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MvcAEI.Models;


public enum Pole
{
    [Display(Name = "Le bureau")]
    Bureau,

    [Display(Name = "Pôle Trésorerie")]
    Tresorerie,

    [Display(Name = "Pôle Développement Commercial")]
    DevCommercial,

    [Display(Name = "Pôle Communication")]
    Communication,

    [Display(Name = "Pôle Qualité")]
    Qualite,

    [Display(Name = "Pôle Systèmes d'information")]
    SystemeInformation,

    [Display(Name = "Pôle Etude")]
    Etude
}

public enum Role
{
    [Display(Name = "Président(e)")]
    President,

    [Display(Name = "Vice-Président(e)")]
    VicePresident,

    [Display(Name = "Secretaire Génréral")]
    Secretaire,

    [Display(Name = "Trésorier(e)")]
    Tresorier,

    [Display(Name = "Vice-Trésorier(e)")]
    ViceTresorier,
    Comptable,

    [Display(Name = "Responsable Développement Commercial")]
    RespoDevCommercial,

    [Display(Name = "Co-Responsable Développement Commercial")]
    CoRespoDevCommercial,

    [Display(Name = "Chargé d'affaires")]
    ChargeAffaire,

    [Display(Name = "Responsable Qualité")]
    RespoQualite,

    [Display(Name = "Chargé Qualité")]
    ChargeQualite,

    [Display(Name = "Responsable des Systèmes d'information")]
    RespoSystInformation,

    [Display(Name = "Responsable Technique")]
    RespoTechnique,

    [Display(Name = "Responsable du pole Communication")]
    RespoCom,

    [Display(Name = "Chargé de Communication")]
    ChargeComm,

    [Display(Name = "Responsable Suivi d'Etudes")]
    RespoSuiviEtudes,

    [Display(Name = "Co-Responsable Suivi d'Etudes")]
    CoRespoSuiviEtudes,

    [Display(Name = "Chef de Projet")]
    ChefProjet,

    [Display(Name = "Chargé Commercial-Etude")]
    ChargeCommmercialEtude,
}

public class Membre
{
    public int Id { get; set; }
    public string? Nom { get; set; }
    public string? Prenom { get; set; }
    public string? Photo { get; set; }
    public string? Mot { get; set; }
    public int? MandatId { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Mandat? Mandat { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Pole? Pole { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Role? Role { get; set; }



    public static string[] getNamesPoles()
    {
        return (Enum.GetNames(typeof(Pole)));
    }

    public static string[] getNamesRoles()
    {
        return (Enum.GetNames(typeof(Role)));
    }

    public Membre() { }

    public Membre(MembreDTO dto)
    {
        Id = dto.Id;
        Nom = dto.Nom;
        Prenom = dto.Prenom;
        Photo = dto.Photo;
        Mot = dto.Mot;
        Pole = dto.Pole;
        Role = dto.Role;
        MandatId = dto.MandatId;
    }

}
