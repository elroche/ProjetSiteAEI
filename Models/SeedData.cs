using MvcAEI.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace MvcAEI.Models;

public class SeedData
{
    public static async Task Init(ApplicationDbContext context, IServiceProvider serviceProvider)
    {
        if (!context.Users.Any())
        {
            var passwordHasher = new PasswordHasher<IdentityUser>();
            var hashedPassword = passwordHasher.HashPassword(null, "[*YwidqZ]HeP?<#;$7");

            var adminUser = new IdentityUser 
            { 
                UserName = "AdminAEI", 
                Email = "contact@junior-aei.com", 
                PasswordHash = hashedPassword, 
                NormalizedUserName = "CONTACT@JUNIOR-AEI.COM" 
            };

            adminUser.EmailConfirmed = true;
            context.Users.Add(adminUser);
            context.SaveChanges();
        }

        if (!context.Articles.Any() && !context.Contacts.Any() && !context.Mandats.Any() && !context.Membres.Any())
        {

            // Ajout de plusieurs membres
            //Membres du mandat 2022 2023
            Membre marques = new Membre
            {
                Nom = "Marques",
                Prenom = "Lorène",
                Photo = "/images/membres/LoreneMarques.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Bureau,
                Role = Role.President,
            };

            Membre bouhassoun = new Membre
            {
                Nom = "Bouhassoun",
                Prenom = "Tahir",
                Photo = "/images/membres/TahirBouhassoun.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Bureau,
                Role = Role.VicePresident,
            };

            Membre stubbe = new Membre
            {
                Nom = "Stubbe",
                Prenom = "Liam",
                Photo = "/images/membres/LiamStubbe.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Bureau,
                Role = Role.VicePresident,
            };

            Membre lemeur = new Membre
            {
                Nom = "Le Meur",
                Prenom = "Tristan",
                Photo = "/images/membres/TristanLeMeur.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Bureau,
                Role = Role.Secretaire,
            };

            Membre zilliox = new Membre
            {
                Nom = "Zilliox",
                Prenom = "Clément",
                Photo = "/images/membres/ClémentZilliox.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Bureau,
                Role = Role.Tresorier,
            };

            Membre zilliox2 = new Membre
            {
                Nom = "Zilliox",
                Prenom = "Clément",
                Photo = "/images/membres/ClémentZilliox.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Tresorerie,
                Role = Role.Tresorier,
            };

            Membre lemestre = new Membre
            {
                Nom = "Le Mestre",
                Prenom = "Théo",
                Photo = "/images/membres/ThéoLeMestre.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Tresorerie,
                Role = Role.Comptable,
            };

            Membre buzit = new Membre
            {
                Nom = "Buzit",
                Prenom = "Benjamin",
                Photo = "/images/membres/BenjaminBuzit.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Tresorerie,
                Role = Role.RespoQualite,
            };

            Membre rumen = new Membre
            {
                Nom = "Rumen",
                Prenom = "Tamara",
                Photo = "/images/membres/TamaraRumen.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.DevCommercial,
                Role = Role.ChargeAffaire,
            };

            Membre oukrid = new Membre
            {
                Nom = "Oukrid",
                Prenom = "Yann",
                Photo = "/images/membres/yannOukrid.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.DevCommercial,
                Role = Role.RespoDevCommercial,
            };

            Membre walther = new Membre
            {
                Nom = "Walther",
                Prenom = "Dimitri",
                Photo = "/images/membres/DimitriWalther.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.DevCommercial,
                Role = Role.ChargeAffaire,
            };

            Membre longechamp = new Membre
            {
                Nom = "Longechamp",
                Prenom = "Damien",
                Photo = "/images/membres/DamienLongechamp.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.DevCommercial,
                Role = Role.ChargeAffaire,
            };

            Membre meurrens = new Membre
            {
                Nom = "Meurrens",
                Prenom = "Serge",
                Photo = "/images/membres/SergeMeurens.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.DevCommercial,
                Role = Role.ChargeAffaire,
            };

            Membre penot = new Membre
            {
                Nom = "Penot",
                Prenom = "Victorine",
                Photo = "/images/membres/VictorinePenot.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.DevCommercial,
                Role = Role.ChargeAffaire,
            };

            Membre laurent = new Membre
            {
                Nom = "Laurent",
                Prenom = "Alban",
                Photo = "/images/membres/AlbanLaurent.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Qualite,
                Role = Role.RespoQualite,
            };

            Membre nadal = new Membre
            {
                Nom = "Nadal",
                Prenom = "Thibault",
                Photo = "/images/membres/ThibaultNadal.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Qualite,
                Role = Role.ChargeQualite,
            };

            Membre durand = new Membre
            {
                Nom = "Durand",
                Prenom = "Jules",
                Photo = "/images/membres/JulesDurand.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Qualite,
                Role = Role.ChargeQualite,
            };

            Membre barteau = new Membre
            {
                Nom = "Barteau",
                Prenom = "Nadjime",
                Photo = "/images/membres/NadjimeBarteau.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.SystemeInformation,
                Role = Role.RespoSystInformation,
            };

            Membre dupoux = new Membre
            {
                Nom = "Dupoux",
                Prenom = "Mathieu",
                Photo = "/images/membres/MathieuDupoux.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.SystemeInformation,
                Role = Role.RespoTechnique,
            };

            Membre raoult = new Membre
            {
                Nom = "Raoult",
                Prenom = "Antoine",
                Photo = "/images/membres/AntoineRaoult.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.SystemeInformation,
                Role = Role.RespoTechnique,
            };

            Membre roche = new Membre
            {
                Nom = "Roche",
                Prenom = "Naomi",
                Photo = "/images/membres/NaomiRoche.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Communication,
                Role = Role.RespoCom,
            };

            Membre pereira = new Membre
            {
                Nom = "Pereira",
                Prenom = "Luca",
                Photo = "/images/membres/LucaPereira.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Communication,
                Role = Role.ChargeComm,
            };

            Membre braun = new Membre
            {
                Nom = "Braun",
                Prenom = "Jules",
                Photo = "/images/membres/JulesBraun.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Communication,
                Role = Role.ChargeComm,
            };

            Membre cannet = new Membre
            {
                Nom = "Cannet",
                Prenom = "Alban",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Communication,
                Role = Role.ChargeComm,
            };

            Membre maziere = new Membre
            {
                Nom = "Mazière",
                Prenom = "Léo-Paul",
                Photo = "/images/membres/Leo-PaulMaziere.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Etude,
                Role = Role.RespoSuiviEtudes,
            };

            Membre messner = new Membre
            {
                Nom = "Messner",
                Prenom = "Julie",
                Photo = "/images/membres/JulieMessner.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Etude,
                Role = Role.ChefProjet,
            };

            Membre praud = new Membre
            {
                Nom = "Praud",
                Prenom = "Brieuc",
                Photo = "/images/membres/BrieucPraud.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Etude,
                Role = Role.ChefProjet,
            };

            Membre deSaintExupery = new Membre
            {
                Nom = "De Saint-Exupéry",
                Prenom = "Malo",
                Photo = "/images/membres/MaloDeSt-Exupery.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Etude,
                Role = Role.ChefProjet,
            };

            Membre haton = new Membre
            {
                Nom = "Haton",
                Prenom = "Antoine",
                Photo = "/images/membres/AntoineHaton.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Etude,
                Role = Role.ChefProjet,
            };

            Membre vovard = new Membre
            {
                Nom = "Vovard",
                Prenom = "Marine",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Etude,
                Role = Role.ChefProjet,
            };

            Membre derriey = new Membre
            {
                Nom = "Derriey",
                Prenom = "Alexandre",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Etude,
                Role = Role.ChefProjet,
            };

            Membre paul = new Membre
            {
                Nom = "Paul",
                Prenom = "Maël",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Etude,
                Role = Role.ChefProjet,
            };

            //Membres du mandat 2021 2022
            Membre derouet = new Membre
            {
                Nom = "Derouet",
                Prenom = "Jean-Baptiste",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Bureau,
                Role = Role.President,
            };

            Membre casal = new Membre
            {
                Nom = "Casal",
                Prenom = "Théo",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Bureau,
                Role = Role.Secretaire,
            };

            Membre casal2 = new Membre
            {
                Nom = "Casal",
                Prenom = "Théo",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Bureau,
                Role = Role.VicePresident,
            };

            Membre cassany = new Membre
            {
                Nom = "Cassany",
                Prenom = "Martin",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Bureau,
                Role = Role.Tresorier,
            };

            Membre cassany2 = new Membre
            {
                Nom = "Cassany",
                Prenom = "Martin",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Tresorerie,
                Role = Role.Tresorier,
            };

            Membre bailloux = new Membre
            {
                Nom = "Bailloux",
                Prenom = "Laetitia",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Tresorerie,
                Role = Role.Comptable,
            };

            Membre zizi = new Membre
            {
                Nom = "Zizi",
                Prenom = "Marwan",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.DevCommercial,
                Role = Role.RespoDevCommercial,
            };

            Membre batty = new Membre
            {
                Nom = "Batty",
                Prenom = "Sebastien",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.DevCommercial,
                Role = Role.ChargeAffaire,
            };

            Membre bahoussi = new Membre
            {
                Nom = "Bahoussi",
                Prenom = "Meryam",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.DevCommercial,
                Role = Role.ChargeAffaire,
            };

            Membre fellah = new Membre
            {
                Nom = "Fellah",
                Prenom = "Hicham",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.DevCommercial,
                Role = Role.ChargeAffaire,
            };

            Membre ginesy = new Membre
            {
                Nom = "Ginesy",
                Prenom = "Damien",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Qualite,
                Role = Role.RespoQualite,
            };

            Membre leGall = new Membre
            {
                Nom = "Le Gall",
                Prenom = "Mathis",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Qualite,
                Role = Role.ChargeQualite,
            };

            Membre darmon = new Membre
            {
                Nom = "Darmon",
                Prenom = "Valentin",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Qualite,
                Role = Role.ChargeQualite,
            };

            Membre langlais = new Membre
            {
                Nom = "Langlais",
                Prenom = "Hugo",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.SystemeInformation,
                Role = Role.RespoSystInformation,
            };

            Membre trupin = new Membre
            {
                Nom = "Trupin",
                Prenom = "Loic",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.SystemeInformation,
                Role = Role.RespoTechnique,
            };

            Membre catte = new Membre
            {
                Nom = "Catté",
                Prenom = "Vivien",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Communication,
                Role = Role.RespoCom,
            };

            Membre guerin = new Membre
            {
                Nom = "Guerin",
                Prenom = "Léo-Paul",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Communication,
                Role = Role.ChargeComm,
            };

            Membre fagues = new Membre
            {
                Nom = "Fagues",
                Prenom = "Corentin",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Communication,
                Role = Role.ChargeComm,
            };

            Membre abrouk = new Membre
            {
                Nom = "Abrouk",
                Prenom = "Nada",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Etude,
                Role = Role.RespoSuiviEtudes,
            };

            Membre fkyerat = new Membre
            {
                Nom = "Fkyerat",
                Prenom = "Gabriel",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Etude,
                Role = Role.CoRespoSuiviEtudes,
            };

            Membre hannier = new Membre
            {
                Nom = "Hannier",
                Prenom = "Cyril",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Etude,
                Role = Role.ChefProjet,
            };

            Membre kutkowski = new Membre
            {
                Nom = "Kutkowski",
                Prenom = "Pierre",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Etude,
                Role = Role.ChefProjet,
            };

            Membre rezette = new Membre
            {
                Nom = "Rezette",
                Prenom = "Paul",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Etude,
                Role = Role.ChefProjet,
            };

            Membre rivard = new Membre
            {
                Nom = "Rivard",
                Prenom = "Lilian",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Etude,
                Role = Role.ChefProjet,
            };


            //Membres du mandat 2020 2021
            Membre brejon = new Membre
            {
                Nom = "Brejon",
                Prenom = "Louis",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Bureau,
                Role = Role.President,
            };

            Membre deRoeck = new Membre
            {
                Nom = "De Roeck",
                Prenom = "Hugues",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Bureau,
                Role = Role.President,
            };

            Membre lechevallier = new Membre
            {
                Nom = "Lechevallier",
                Prenom = "Clément",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Bureau,
                Role = Role.VicePresident,
            };

            Membre brejon2 = new Membre
            {
                Nom = "Brejon",
                Prenom = "Louis",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Bureau,
                Role = Role.VicePresident,
            };

            Membre transon = new Membre
            {
                Nom = "transon",
                Prenom = "Pierre-Louis",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Bureau,
                Role = Role.Secretaire,
            };

            Membre nowominski = new Membre
            {
                Nom = "Nowominski",
                Prenom = "Elie",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Bureau,
                Role = Role.Tresorier,
            };

            Membre nowominski2 = new Membre
            {
                Nom = "Nowominski",
                Prenom = "Elie",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Tresorerie,
                Role = Role.Tresorier,
            };

            Membre drouin = new Membre
            {
                Nom = "Drouin",
                Prenom = "Maxence",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Tresorerie,
                Role = Role.Comptable,
            };

            Membre dubigeon = new Membre
            {
                Nom = "Dubigeon",
                Prenom = "Antonin",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.DevCommercial,
                Role = Role.RespoDevCommercial,
            };

            Membre lefebvre = new Membre
            {
                Nom = "Lefebvre",
                Prenom = "Virgil",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.DevCommercial,
                Role = Role.CoRespoDevCommercial,
            };

            Membre doulieri = new Membre
            {
                Nom = "Doulieri",
                Prenom = "Baudouin",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.DevCommercial,
                Role = Role.ChargeAffaire,
            };

            Membre gayot = new Membre
            {
                Nom = "Gayot",
                Prenom = "Basile",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.DevCommercial,
                Role = Role.ChargeAffaire,
            };

            Membre koutit = new Membre
            {
                Nom = "Koutit",
                Prenom = "Maryem",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.DevCommercial,
                Role = Role.ChargeAffaire,
            };

            Membre vidal = new Membre
            {
                Nom = "Vidal",
                Prenom = "Martin",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Qualite,
                Role = Role.RespoQualite,
            };

            Membre anfray = new Membre
            {
                Nom = "Anfray",
                Prenom = "Thomas",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Qualite,
                Role = Role.ChargeQualite,
            };

            Membre talio = new Membre
            {
                Nom = "Talio",
                Prenom = "Romain",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Qualite,
                Role = Role.ChargeQualite,
            };

            Membre decou = new Membre
            {
                Nom = "decou",
                Prenom = "Nathan",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.SystemeInformation,
                Role = Role.RespoSystInformation,
            };

            Membre jemmoudi = new Membre
            {
                Nom = "Jemmoudi",
                Prenom = "Ismail",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Communication,
                Role = Role.RespoCom,
            };

            Membre pouget = new Membre
            {
                Nom = "Pouget",
                Prenom = "Marine",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Communication,
                Role = Role.ChargeComm,
            };

            Membre nabet = new Membre
            {
                Nom = "Nabet",
                Prenom = "Yacine",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Etude,
                Role = Role.RespoSuiviEtudes,
            };

            Membre deRoeck2 = new Membre
            {
                Nom = "De Roeck",
                Prenom = "Hugues",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Etude,
                Role = Role.ChargeCommmercialEtude,
            };

            Membre benoit = new Membre
            {
                Nom = "Benoit",
                Prenom = "Thomas",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Etude,
                Role = Role.ChefProjet,
            };

            Membre bouidra = new Membre
            {
                Nom = "Bouidra",
                Prenom = "Leila",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Etude,
                Role = Role.ChefProjet,
            };

            Membre cabanes = new Membre
            {
                Nom = "Cabanes",
                Prenom = "Valentin",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Etude,
                Role = Role.ChefProjet,
            };

            Membre fadili = new Membre
            {
                Nom = "Fadili",
                Prenom = "Walid",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Etude,
                Role = Role.ChefProjet,
            };

            Membre gaudichau = new Membre
            {
                Nom = "Gaudichau",
                Prenom = "Pierre-Malo",
                Photo = "/images/membres/anonyme.jpg",
                Mot = "Quelques mots de la personne",
                Pole = Pole.Etude,
                Role = Role.ChefProjet,
            };

            // Ajout des différents mandats
            Mandat mandat_2020_2021 = new Mandat
            {
                Id = 1,
                Annee = "2020-2021",
                Membres = new List<Membre> { brejon, deRoeck, lechevallier, brejon2, transon, nowominski, nowominski2, drouin, dubigeon, lefebvre, doulieri, gayot, koutit, vidal, anfray, talio, decou, jemmoudi, pouget, nabet, deRoeck2, benoit, bouidra, cabanes, fadili, gaudichau },
            };
            brejon.Mandat = mandat_2020_2021;
            deRoeck.Mandat = mandat_2020_2021;
            lechevallier.Mandat = mandat_2020_2021;
            brejon2.Mandat = mandat_2020_2021;
            transon.Mandat = mandat_2020_2021;
            nowominski.Mandat = mandat_2020_2021;
            nowominski2.Mandat = mandat_2020_2021;
            drouin.Mandat = mandat_2020_2021;
            dubigeon.Mandat = mandat_2020_2021;
            lefebvre.Mandat = mandat_2020_2021;
            doulieri.Mandat = mandat_2020_2021;
            gayot.Mandat = mandat_2020_2021;
            koutit.Mandat = mandat_2020_2021;
            vidal.Mandat = mandat_2020_2021;
            anfray.Mandat = mandat_2020_2021;
            talio.Mandat = mandat_2020_2021;
            decou.Mandat = mandat_2020_2021;
            jemmoudi.Mandat = mandat_2020_2021;
            pouget.Mandat = mandat_2020_2021;
            nabet.Mandat = mandat_2020_2021;
            deRoeck2.Mandat = mandat_2020_2021;
            benoit.Mandat = mandat_2020_2021;
            bouidra.Mandat = mandat_2020_2021;
            cabanes.Mandat = mandat_2020_2021;
            fadili.Mandat = mandat_2020_2021;
            gaudichau.Mandat = mandat_2020_2021;


            Mandat mandat_2021_2022 = new Mandat
            {
                Id = 2,
                Annee = "2021-2022",
                Membres = new List<Membre> { derouet, casal, casal2, cassany, cassany2, bailloux, zizi, batty, bahoussi, fellah, ginesy, leGall, darmon, langlais, trupin, catte, guerin, fagues, abrouk, fkyerat, hannier, kutkowski, rezette, rivard },
            };
            derouet.Mandat = mandat_2021_2022;
            casal.Mandat = mandat_2021_2022;
            casal2.Mandat = mandat_2021_2022;
            cassany.Mandat = mandat_2021_2022;
            cassany2.Mandat = mandat_2021_2022;
            bailloux.Mandat = mandat_2021_2022;
            zizi.Mandat = mandat_2021_2022;
            batty.Mandat = mandat_2021_2022;
            bahoussi.Mandat = mandat_2021_2022;
            fellah.Mandat = mandat_2021_2022;
            ginesy.Mandat = mandat_2021_2022;
            leGall.Mandat = mandat_2021_2022;
            darmon.Mandat = mandat_2021_2022;
            langlais.Mandat = mandat_2021_2022;
            trupin.Mandat = mandat_2021_2022;
            catte.Mandat = mandat_2021_2022;
            guerin.Mandat = mandat_2021_2022;
            fagues.Mandat = mandat_2021_2022;
            abrouk.Mandat = mandat_2021_2022;
            fkyerat.Mandat = mandat_2021_2022;
            hannier.Mandat = mandat_2021_2022;
            kutkowski.Mandat = mandat_2021_2022;
            rezette.Mandat = mandat_2021_2022;
            rivard.Mandat = mandat_2021_2022;


            Mandat mandat_2022_2023 = new Mandat
            {
                Id = 3,
                Annee = "2022-2023",
                Membres = new List<Membre> { marques, bouhassoun, stubbe, lemeur, zilliox, zilliox2, lemestre, buzit, rumen, oukrid, walther, longechamp, meurrens, penot, laurent, nadal, durand, barteau, dupoux, raoult, roche, maziere, messner, praud, deSaintExupery, haton, vovard, derriey, paul, pereira, braun, cannet },
            };
            marques.Mandat = mandat_2022_2023;
            bouhassoun.Mandat = mandat_2022_2023;
            stubbe.Mandat = mandat_2022_2023;
            lemeur.Mandat = mandat_2022_2023;
            zilliox.Mandat = mandat_2022_2023;
            zilliox2.Mandat = mandat_2022_2023;
            lemestre.Mandat = mandat_2022_2023;
            buzit.Mandat = mandat_2022_2023;
            rumen.Mandat = mandat_2022_2023;
            oukrid.Mandat = mandat_2022_2023;
            walther.Mandat = mandat_2022_2023;
            longechamp.Mandat = mandat_2022_2023;
            meurrens.Mandat = mandat_2022_2023;
            penot.Mandat = mandat_2022_2023;
            laurent.Mandat = mandat_2022_2023;
            nadal.Mandat = mandat_2022_2023;
            durand.Mandat = mandat_2022_2023;
            barteau.Mandat = mandat_2022_2023;
            dupoux.Mandat = mandat_2022_2023;
            raoult.Mandat = mandat_2022_2023;
            roche.Mandat = mandat_2022_2023;
            pereira.Mandat = mandat_2022_2023;
            braun.Mandat = mandat_2022_2023;
            cannet.Mandat = mandat_2022_2023;
            maziere.Mandat = mandat_2022_2023;
            messner.Mandat = mandat_2022_2023;
            praud.Mandat = mandat_2022_2023;
            deSaintExupery.Mandat = mandat_2022_2023;
            haton.Mandat = mandat_2022_2023;
            vovard.Mandat = mandat_2022_2023;
            derriey.Mandat = mandat_2022_2023;
            paul.Mandat = mandat_2022_2023;


            context.Membres.AddRange(marques, bouhassoun, stubbe, lemeur, zilliox, zilliox2, lemestre, buzit, rumen, oukrid, walther, longechamp, meurrens, penot, laurent, nadal, durand, barteau, dupoux, raoult, roche, pereira, braun, cannet, maziere, messner, praud, deSaintExupery, haton, vovard, derriey, paul, derouet, casal, casal2, cassany, cassany2, bailloux, zizi, batty, bahoussi, fellah, ginesy, leGall, darmon, langlais, trupin, catte, guerin, fagues, abrouk, fkyerat, hannier, kutkowski, rezette, rivard, brejon, deRoeck, lechevallier, brejon2, transon, nowominski, nowominski2, drouin, dubigeon, lefebvre, doulieri, gayot, koutit, vidal, anfray, talio, decou, jemmoudi, pouget, nabet, deRoeck2, benoit, bouidra, cabanes, fadili, gaudichau);
            context.Mandats.AddRange(mandat_2020_2021, mandat_2021_2022, mandat_2022_2023);

            //Ajout des differents paragraphes
            Paragraphe temoignageRealisateurParagraphe = new Paragraphe
            {
                Texte = "“Être réalisateur pour AEI m’a permis de découvrir plus concrètement ce qu’est un projet dans un cadre professionnel. Je devais développer un site internet permettant de visualiser une base de données. En répondant à l’annonce, je voulais valoriser par une expérience professionnelle des compétences en développement que j’avais acquises en autodidacte. " + "\n" + "\n" + "Grâce à cette étude, j’ai pu découvrir l’organisation d’un projet où chaque acteur a un rôle bien défini et j’ai appris à m’adapter aux exigences d’un Client. C’était une belle expérience que je recommande aux étudiants s’ils sont motivés et particulièrement intéressés par le domaine de l’étude.”" + "\n" + "\n" + "Jérémie Soetens"
            };

            Paragraphe temoignangeJeanBaptisteParagraphe = new Paragraphe
            {
                Texte = "En tant qu’ancien président de la Junior-Entreprise AEI, j’ai été ravi de vivre cette belle aventure qu’est la Junior : une aventure à la fois passionnante et enrichissante !" + "\n" + "\n" + "J’avais peu d’expérience professionnelle en intégrant l’école. AEI m’a permis d’approcher ce monde professionnel. En effet, nous sommes en contact direct avec les entreprises auxquelles nous fournissons des prestations dans des domaines de compétences très divers. La diversité de ces prestations ainsi que les obstacles que nous pouvons rencontrer imposent une coopération de toute l’équipe." + "\n" + "\n" + "J’ai trouvé à AEI une expérience enrichissante dans le monde de l’entreprise avec l’occasion unique de pouvoir gérer une équipe d’une vingtaine de personnes. J’ai donc dû travailler en équipe dans le but de pérenniser la structure. En ce qui concerne les fonctions que j’ai exercées, en tant que président, j’ai appris à organiser mon travail, prendre du recul sur les choses, dialoguer avec mon équipe et fixer des stratégies avec le Bureau. Vivre cette expérience unique m’a fait grandir professionnellement et personnellement." + "\n" + "\n" + "Cette expérience m’a demandé beaucoup d’investissement mais m’a apporté beaucoup en retour. Ce fût une année intense qui m’a permis d’acquérir de nouvelles compétences et de faire face à de nouveaux défis. Cet engagement m’a permis de découvrir des personnes appliquées et impliquées dans leur travail, des gens passionnés par leurs missions, avec leurs qualités, leurs défauts, leurs sourires et leurs passions." + "\n" + "\n" + "La mise en place d’une nouvelle stratégie pour la Junior nous a permis de répondre aux défis qui nous étaient posés. Ce fut un honneur d’avoir pu prendre la responsabilité de ce travail qui ne s’est pas fait seul : je tiens de ce fait à remercier les membres du Conseil d’Administration. Je ressors grandi de cette expérience qui m’a offert un regard neuf sur le monde du travail et qui m’a permis de mieux percevoir certaines perspectives d’avenir après le diplôme d’ingénieur." + "\n" + "\n" + "Je souhaite le meilleur à la nouvelle équipe; qu’elle reste soudée, dynamique et engagée tout au long de son mandat !",
            };

            Paragraphe CRP2022Paragraphe = new Paragraphe
            {
                Texte = "Le samedi 12 et dimanche 13 mars, nous avons eu le plaisir de participer au Congrès Régional de Printemps Sud Ouest 2022, dont le thème était “L’innovation au service de l’urgence climatique”. 🌍" + "\n" + "\n" + "Lors de ce congrès, nous avons pu assister à diverses formations présentées entre autres par la CNJE et ses partenaires premium : ALTEN, BNP Paribas, ENGIE, EY. Nous tenions à les remercier pour nous avoir partagé leur expérience et nous avoir transmis de précieux conseils. ✨" + "\n" + "\n" + "Ce fut également l’occasion de rencontrer et d’échanger avec de nombreuses Junior Entreprises, ainsi que les divers intervenants présents. 🤝" + "\n" + "\n" + "👏 Un grand merci ainsi qu’un grand bravo à ENVOL Junior Etudes ✈️ pour avoir organisé et hébergé cet enrichissant événement." + "\n" + "\n" + "#WeAreJE",
            };

            Paragraphe SICA = new Paragraphe
            {
                Texte = "Depuis août 2020, SICA est en parrainage avec AEI, Aquitaine Electronique Informatique, la Junior-Entreprise de l’Enseirb-Matmeca. Ce parrainage permet une entraide entre les deux juniors et contribue fortement à leur développement. Il permet également un rapprochement entre les deux écoles d’ingénieur de Bordeaux INP pour la création de compétences transverses." + "\n" + "\n" + "N’hésitez pas à aller consulter directement leur site Web: https://junior-sica.com",
            };

            Paragraphe quEstCeQuneJE = new Paragraphe
            {
                Titre = "Qu'est-ce qu'une JE ?",
                Texte = "Une Junior-Entreprise (JE) est une association étudiante à visée pédagogique et commerciale, et à but non lucratif. Ces associations ont un fonctionnement proche de celui d’une entreprise, et sont encadrées juridiquement." + "\n" + "\n" + "Concrètement, elles permettent aux étudiants des écoles de mettre en pratique leurs enseignements au travers de missions pour des professionnels." + "\n" + "\n" + "Il existe pour les étudiants deux façons de s’engager au sein d’une JE : en tant qu’administrateur, ou en tant que réalisateur. Les administrateurs garantissent le bon développement de la JE, ils sont notamment le lien entre les professionnels et réalisateurs, qui eux ont pour mission de réaliser les projets." + "\n" + "\n" + "On compte actuellement plus de 200 JE en France. Ces structures en plein essor sont fédérées par la Confédération Nationale des Junior-Entreprises (CNJE).",
            };

            Paragraphe quiSommesNous = new Paragraphe
            {
                Titre = "Qui sommes-nous ?",
                Texte = "AEI (Aquitaine Electronique Informatique) est la Junior-Entreprise de l’ENSEIRB-MATMECA, une école d’ingénieur située à Talence." + "\n" + "\n" + "Grâce aux enseignements prodigués au sein de notre école, c’est plus de 1200 esprits jeunes, dynamiques, compétents et innovants qui sont en mesure de réaliser des projets dans les domaines de l’informatique, l’électronique, des télécommunications, des mathématiques et de la mécanique." + "\n" + "\n" + "Depuis sa création en 1987, AEI a remporté divers prix dont le challenge du meilleur espoir en 2008 et le challenge OpenMind d’Alten en 2014. Notre JE est également entrée dans la liste des 30 meilleures JE de France en 2010 et 2017 ainsi que dans celle des 8 meilleures en 2011." + "\n" + "\n" + "En tant que Junior-Entreprise, AEI fait partie de la CNJE au niveau national et à plus petite échelle elle fait également partie de la JEB (Junior-Entreprises Bordelaises). Ces intégrations élargissent notre réseau et contribuent à notre développement tout en élargissant notre champ d’action." + "\n" + "\n" + "C’est donc avec plus de 30 ans d’expérience, un réseau professionnel conséquent, une équipe réactive et impliquée, et le statut de Junior-Entreprise assurant une qualité professionnelle de nos services, qu’AEI sait accompagner ses clients tout au long de la réalisation de leurs projets afin d’aboutir au meilleur développement possible de ceux-ci.",
            };


            // Ajout des différents articles
            Article descriptionJE = new Article
            {
                Id = 1,
                Titre = "Qu'est ce qu'une JE ?",
                Description = "Présentation d’une Junior-Entreprise",
                Image = "/images/Articles/logoJE2.png",
                Paragraphes = new List<Paragraphe> { quEstCeQuneJE, quiSommesNous },
                Editeur = "Luca Pereira, Naomi Roche",
                Date = DateTime.Parse("2022-02-25"),
            };

            Article parrainageSICA = new Article
            {
                Id = 2,
                Titre = "AEI parraine la SICA, la junior de l'ENSCBP",
                Description = "AEI parraine la SICA, la junior de l’ENSCBP",
                Image = "/images/Articles/sica.png",
                Paragraphes = new List<Paragraphe> { SICA },
                Editeur = "Vivien CATTE",
                Date = DateTime.Parse("2022-03-18"),
            };

            Article CRP2022 = new Article
            {
                Id = 3,
                Titre = "CRP 2022",
                Description = "AEI au CRP 2022",
                Image = "/images/Articles/crp.png",
                Paragraphes = new List<Paragraphe> { CRP2022Paragraphe },
                Date = DateTime.Parse("2022-03-20"),
                Editeur = "Luca Pereira",
            };

            Article temoignageJeanBaptiste = new Article
            {
                Id = 4,
                Titre = "Témoignage de Jean-Baptiste, président 2021-2022",
                Description = "Mot de départ de Jean-Baptiste",
                Image = "/images/Articles/motjb.png",
                Paragraphes = new List<Paragraphe> { temoignangeJeanBaptisteParagraphe },
                Date = DateTime.Parse("2022-06-06"),
                Editeur = "Jean-Baptiste Derouet",
            };

            Article temoignageRealisateur = new Article
            {
                Id = 5,
                Titre = "Témoignage d'un Réalisateur",
                Description = "Témoignage d’un réalisateur d’AEI",
                Image = "/images/Articles/temoignageJS.png",
                Paragraphes = new List<Paragraphe> { temoignageRealisateurParagraphe },
                Date = DateTime.Parse("2022-08-03"),
                Editeur = "Naomi Roche",
            };


            quEstCeQuneJE.Article = descriptionJE;
            quiSommesNous.Article = descriptionJE;
            SICA.Article = parrainageSICA;
            CRP2022Paragraphe.Article = CRP2022;
            temoignangeJeanBaptisteParagraphe.Article = temoignageJeanBaptiste;
            temoignageRealisateurParagraphe.Article = temoignageRealisateur;


            context.Paragraphes.AddRange(temoignageRealisateurParagraphe, temoignangeJeanBaptisteParagraphe, CRP2022Paragraphe, SICA, quEstCeQuneJE, quiSommesNous);
            context.Articles.AddRange(descriptionJE, parrainageSICA, CRP2022, temoignageJeanBaptiste, temoignageRealisateur);


            context.SaveChanges();
        }

    }
}
