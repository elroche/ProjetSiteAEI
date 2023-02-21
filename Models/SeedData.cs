
public class SeedData
{
    public static void Init()
    {
        using (var context = new AEIContext())
        {
            if (!context.Articles.Any() && !context.Contacts.Any() && !context.Mandats.Any() && !context.Membres.Any())
            {

                // Ajout de plusieurs membres
                Membre marques = new Membre
                {
                    Nom = "Marques",
                    Prenom = "Lorène",
                    Photo = "/images/LoreneMarques.jpg",
                    Pole = Pole.Bureau,
                    Role = Role.President,
                };

                Membre bouhassoun = new Membre
                {
                    Nom = "Bouhassoun",
                    Prenom = "Tahir",
                    Photo = "/images/TahirBouhassoun.jpg",
                    Pole = Pole.Bureau,
                    Role = Role.VicePresident,
                };

                Membre stubbe = new Membre
                {
                    Nom = "Stubbe",
                    Prenom = "Liam",
                    Photo = "/images/LiamStubbe.jpg",
                    Pole = Pole.Bureau,
                    Role = Role.VicePresident,
                };

                Membre lemeur = new Membre
                {
                    Nom = "Le Meur",
                    Prenom = "Tristan",
                    Photo = "/images/TristanLeMeur.jpg",
                    Pole = Pole.Bureau,
                    Role = Role.Secretaire,
                };

                Membre zilliox = new Membre
                {
                    Nom = "Zilliox",
                    Prenom = "Clément",
                    Photo = "/images/ClémentZilliox.jpg",
                    Pole = Pole.Bureau,
                    Role = Role.Tresorier,
                };

                Membre zilliox2 = new Membre
                {
                    Nom = "Zilliox",
                    Prenom = "Clément",
                    Photo = "/images/ClémentZilliox.jpg",
                    Pole = Pole.Tresorerie,
                    Role = Role.Tresorier,
                };

                Membre lemestre = new Membre
                {
                    Nom = "Le Mestre",
                    Prenom = "Théo",
                    Photo = "/images/ThéoLeMestre.jpg",
                    Pole = Pole.Tresorerie,
                    Role = Role.Comptable,
                };

                Membre buzit = new Membre
                {
                    Nom = "Buzit",
                    Prenom = "Benjamin",
                    Photo = "/images/BenjaminBuzit.jpg",
                    Pole = Pole.Tresorerie,
                    Role = Role.RespoQualite,
                };

                Membre rumen = new Membre
                {
                    Nom = "Rumen",
                    Prenom = "Tamara",
                    Photo = "/images/TamaraRumen.jpg",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre oukrid = new Membre
                {
                    Nom = "Oukrid",
                    Prenom = "Yann",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.DevCommercial,
                    Role = Role.RespoDevCommercial,
                };

                Membre walther = new Membre
                {
                    Nom = "Walther",
                    Prenom = "Dimitri",
                    Photo = "/images/DimitriWalther.jpg",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre longechamp = new Membre
                {
                    Nom = "Longechamp",
                    Prenom = "Damien",
                    Photo = "/images/DamienLongechamp.jpg",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre meurrens = new Membre
                {
                    Nom = "Meurrens",
                    Prenom = "Serge",
                    Photo = "/images/SergeMeurens.jpg",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre penot = new Membre
                {
                    Nom = "Penot",
                    Prenom = "Victorine",
                    Photo = "/images/VictorinePenot.jpg",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre laurent = new Membre
                {
                    Nom = "Laurent",
                    Prenom = "Alban",
                    Photo = "/images/AlbanLaurent.jpg",
                    Pole = Pole.Qualite,
                    Role = Role.RespoQualite,
                };

                Membre nadal = new Membre
                {
                    Nom = "Nadal",
                    Prenom = "Thibault",
                    Photo = "/images/ThibaultNadal.jpg",
                    Pole = Pole.Qualite,
                    Role = Role.ChargeQualite,
                };

                Membre durand = new Membre
                {
                    Nom = "Durand",
                    Prenom = "Jules",
                    Photo = "/images/JulesDurand.jpg",
                    Pole = Pole.Qualite,
                    Role = Role.ChargeQualite,
                };

                Membre barteau = new Membre
                {
                    Nom = "Barteau",
                    Prenom = "Nadjime",
                    Photo = "/images/NadjimeBarteau.jpg",
                    Pole = Pole.SystemeInformation,
                    Role = Role.RespoSystInformation,
                };

                Membre dupoux = new Membre
                {
                    Nom = "Dupoux",
                    Prenom = "Mathieu",
                    Photo = "/images/MathieuDupoux.jpg",
                    Pole = Pole.SystemeInformation,
                    Role = Role.RespoTechnique,
                };

                Membre raoult = new Membre
                {
                    Nom = "Raoult",
                    Prenom = "Antoine",
                    Photo = "/images/AntoineRaoult.jpg",
                    Pole = Pole.SystemeInformation,
                    Role = Role.RespoTechnique,
                };

                Membre roche = new Membre
                {
                    Nom = "Roche",
                    Prenom = "Naomi",
                    Photo = "/images/NaomiRoche.jpg",
                    Pole = Pole.Communication,
                    Role = Role.RespoCom,
                };

                Membre pereira = new Membre
                {
                    Nom = "Pereira",
                    Prenom = "Luca",
                    Photo = "/images/LucaPereira.jpg",
                    Pole = Pole.Communication,
                    Role = Role.ChargeComm,
                };

                Membre braun = new Membre
                {
                    Nom = "Braun",
                    Prenom = "Jules",
                    Photo = "/images/JulesBraun.jpg",
                    Pole = Pole.Communication,
                    Role = Role.ChargeComm,
                };

                Membre cannet = new Membre
                {
                    Nom = "Cannet",
                    Prenom = "Alban",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Communication,
                    Role = Role.ChargeComm,
                };

                Membre maziere = new Membre
                {
                    Nom = "Mazière",
                    Prenom = "Léo-Paul",
                    Photo = "/images/Leo-PaulMaziere.jpg",
                    Pole = Pole.Etude,
                    Role = Role.RespoSuiviEtudes,
                };

                Membre messner = new Membre
                {
                    Nom = "Messner",
                    Prenom = "Julie",
                    Photo = "/images/JulieMessner.jpg",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre praud = new Membre
                {
                    Nom = "Praud",
                    Prenom = "Brieuc",
                    Photo = "/images/BrieucPraud.jpg",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre deSaintExupery = new Membre
                {
                    Nom = "De Saint-Exupéry",
                    Prenom = "Malo",
                    Photo = "/images/MaloDeSt-Exupery.jpg",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre haton = new Membre
                {
                    Nom = "Haton",
                    Prenom = "Antoine",
                    Photo = "/images/AntoineHaton.jpg",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre vovard = new Membre
                {
                    Nom = "Vovard",
                    Prenom = "Marine",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre derriey = new Membre
                {
                    Nom = "Derriey",
                    Prenom = "Alexandre",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre paul = new Membre
                {
                    Nom = "Paul",
                    Prenom = "Maël",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre derouet = new Membre
                {
                    Nom = "Derouet",
                    Prenom = "Jean-Baptiste",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Bureau,
                    Role = Role.President,
                };

                Membre casal = new Membre
                {
                    Nom = "Casal",
                    Prenom = "Théo",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Bureau,
                    Role = Role.Secretaire,
                };

                Membre casal2 = new Membre
                {
                    Nom = "Casal",
                    Prenom = "Théo",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Bureau,
                    Role = Role.VicePresident,
                };

                Membre cassany = new Membre
                {
                    Nom = "Cassany",
                    Prenom = "Martin",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Bureau,
                    Role = Role.Tresorier,
                };

                Membre cassany2 = new Membre
                {
                    Nom = "Cassany",
                    Prenom = "Martin",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Tresorerie,
                    Role = Role.Tresorier,
                };

                Membre bailloux = new Membre
                {
                    Nom = "Bailloux",
                    Prenom = "Laetitia",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Tresorerie,
                    Role = Role.Comptable,
                };

                Membre zizi = new Membre
                {
                    Nom = "Zizi",
                    Prenom = "Marwan",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.DevCommercial,
                    Role = Role.RespoDevCommercial,
                };

                Membre batty = new Membre
                {
                    Nom = "Batty",
                    Prenom = "Sebastien",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre bahoussi = new Membre
                {
                    Nom = "Bahoussi",
                    Prenom = "Meryam",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre fellah = new Membre
                {
                    Nom = "Fellah",
                    Prenom = "Hicham",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre ginesy = new Membre
                {
                    Nom = "Ginesy",
                    Prenom = "Damien",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Qualite,
                    Role = Role.RespoQualite,
                };

                Membre leGall = new Membre
                {
                    Nom = "Le Gall",
                    Prenom = "Mathis",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Qualite,
                    Role = Role.ChargeQualite,
                };

                Membre darmon = new Membre
                {
                    Nom = "Darmon",
                    Prenom = "Valentin",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Qualite,
                    Role = Role.ChargeQualite,
                };

                Membre langlais = new Membre
                {
                    Nom = "Langlais",
                    Prenom = "Hugo",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.SystemeInformation,
                    Role = Role.RespoSystInformation,
                };

                Membre trupin = new Membre
                {
                    Nom = "Trupin",
                    Prenom = "Loic",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.SystemeInformation,
                    Role = Role.RespoTechnique,
                };

                Membre catte = new Membre
                {
                    Nom = "Catté",
                    Prenom = "Vivien",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Communication,
                    Role = Role.RespoCom,
                };

                Membre guerin = new Membre
                {
                    Nom = "Guerin",
                    Prenom = "Léo-Paul",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Communication,
                    Role = Role.ChargeComm,
                };

                Membre fagues = new Membre
                {
                    Nom = "Fagues",
                    Prenom = "Corentin",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Communication,
                    Role = Role.ChargeComm,
                };

                Membre abrouk = new Membre
                {
                    Nom = "Abrouk",
                    Prenom = "Nada",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Etude,
                    Role = Role.RespoSuiviEtudes,
                };

                Membre fkyerat = new Membre
                {
                    Nom = "Fkyerat",
                    Prenom = "Gabriel",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Etude,
                    Role = Role.CoRespoSuiviEtudes,
                };

                Membre hannier = new Membre
                {
                    Nom = "Hannier",
                    Prenom = "Cyril",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre kutkowski = new Membre
                {
                    Nom = "Kutkowski",
                    Prenom = "Pierre",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre rezette = new Membre
                {
                    Nom = "Rezette",
                    Prenom = "Paul",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre rivard = new Membre
                {
                    Nom = "Rivard",
                    Prenom = "Lilian",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre brejon = new Membre
                {
                    Nom = "Brejon",
                    Prenom = "Louis",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Bureau,
                    Role = Role.President,
                };

                Membre deRoeck = new Membre
                {
                    Nom = "De Roeck",
                    Prenom = "Hugues",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Bureau,
                    Role = Role.President,
                };

                Membre lechevallier = new Membre
                {
                    Nom = "Lechevallier",
                    Prenom = "Clément",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Bureau,
                    Role = Role.VicePresident,
                };

                Membre brejon2 = new Membre
                {
                    Nom = "Brejon",
                    Prenom = "Louis",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Bureau,
                    Role = Role.VicePresident,
                };

                Membre transon = new Membre
                {
                    Nom = "transon",
                    Prenom = "Pierre-Louis",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Bureau,
                    Role = Role.Secretaire,
                };

                Membre nowominski = new Membre
                {
                    Nom = "Nowominski",
                    Prenom = "Elie",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Bureau,
                    Role = Role.Tresorier,
                };

                Membre nowominski2 = new Membre
                {
                    Nom = "Nowominski",
                    Prenom = "Elie",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Tresorerie,
                    Role = Role.Tresorier,
                };

                Membre drouin = new Membre
                {
                    Nom = "Drouin",
                    Prenom = "Maxence",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Tresorerie,
                    Role = Role.Comptable,
                };

                Membre dubigeon = new Membre
                {
                    Nom = "Dubigeon",
                    Prenom = "Antonin",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.DevCommercial,
                    Role = Role.RespoDevCommercial,
                };

                Membre lefebvre = new Membre
                {
                    Nom = "Lefebvre",
                    Prenom = "Virgil",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.DevCommercial,
                    Role = Role.CoRespoDevCommercial,
                };

                Membre doulieri = new Membre
                {
                    Nom = "Doulieri",
                    Prenom = "Baudouin",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre gayot = new Membre
                {
                    Nom = "Gayot",
                    Prenom = "Basile",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre koutit = new Membre
                {
                    Nom = "Koutit",
                    Prenom = "Maryem",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre vidal = new Membre
                {
                    Nom = "Vidal",
                    Prenom = "Martin",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Qualite,
                    Role = Role.RespoQualite,
                };

                Membre anfray = new Membre
                {
                    Nom = "Anfray",
                    Prenom = "Thomas",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Qualite,
                    Role = Role.ChargeQualite,
                };

                Membre talio = new Membre
                {
                    Nom = "Talio",
                    Prenom = "Romain",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Qualite,
                    Role = Role.ChargeQualite,
                };

                Membre decou = new Membre
                {
                    Nom = "decou",
                    Prenom = "Nathan",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.SystemeInformation,
                    Role = Role.RespoSystInformation,
                };

                Membre jemmoudi = new Membre
                {
                    Nom = "Jemmoudi",
                    Prenom = "Ismail",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Communication,
                    Role = Role.RespoCom,
                };

                Membre pouget = new Membre
                {
                    Nom = "Pouget",
                    Prenom = "Marine",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Communication,
                    Role = Role.ChargeComm,
                };

                Membre nabet = new Membre
                {
                    Nom = "Nabet",
                    Prenom = "Yacine",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Etude,
                    Role = Role.RespoSuiviEtudes,
                };

                Membre deRoeck2 = new Membre
                {
                    Nom = "De Roeck",
                    Prenom = "Hugues",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Etude,
                    Role = Role.ChargeCommmercialEtude,
                };

                Membre benoit = new Membre
                {
                    Nom = "Benoit",
                    Prenom = "Thomas",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre bouidra = new Membre
                {
                    Nom = "Bouidra",
                    Prenom = "Leila",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre cabanes = new Membre
                {
                    Nom = "Cabanes",
                    Prenom = "Valentin",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre fadili = new Membre
                {
                    Nom = "Fadili",
                    Prenom = "Walid",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre gaudichau = new Membre
                {
                    Nom = "Gaudichau",
                    Prenom = "Pierre-Malo",
                    Photo = "/images/anonyme.jpg",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                context.Membres.AddRange(marques, bouhassoun, stubbe, lemeur, zilliox, zilliox2, lemestre, buzit, rumen, oukrid, walther, longechamp, meurrens, penot, laurent, nadal, durand, barteau, dupoux, raoult, roche, pereira, braun, cannet, maziere, messner, praud, deSaintExupery, haton, vovard, derriey, paul, derouet, casal, casal2, cassany, cassany2, bailloux, zizi, batty, bahoussi, fellah, ginesy, leGall, darmon, langlais, trupin, catte, guerin, fagues, abrouk, fkyerat, hannier, kutkowski, rezette, rivard, brejon, deRoeck, lechevallier, brejon2, transon, nowominski, nowominski2, drouin, dubigeon, lefebvre, doulieri, gayot, koutit, vidal, anfray, talio, decou, jemmoudi, pouget, nabet, deRoeck2, benoit, bouidra, cabanes, fadili, gaudichau);




                // Ajout des différents mandats
                Mandat mandat_2022_2023 = new Mandat
                {
                    Annee = 2022,
                    Membres = new List<Membre> { marques, bouhassoun, stubbe, lemeur, zilliox, zilliox2, lemestre, buzit, rumen, oukrid, walther, longechamp, meurrens, penot, laurent, nadal, durand, barteau, dupoux, raoult, roche, maziere, messner, praud, deSaintExupery, haton, vovard, derriey, paul, pereira, braun, cannet },
                };

                Mandat mandat_2021_2022 = new Mandat
                {
                    Annee = 2021,
                    Membres = new List<Membre> { derouet, casal, casal2, cassany, cassany2, bailloux, zizi, batty, bahoussi, fellah, ginesy, leGall, darmon, langlais, trupin, catte, guerin, fagues, abrouk, fkyerat, hannier, kutkowski, rezette, rivard },
                };

                Mandat mandat_2020_2021 = new Mandat
                {
                    Annee = 2020,
                    Membres = new List<Membre> { brejon, deRoeck, lechevallier, brejon2, transon, nowominski, nowominski2, drouin, dubigeon, lefebvre, doulieri, gayot, koutit, vidal, anfray, talio, decou, jemmoudi, pouget, nabet, deRoeck2, benoit, bouidra, cabanes, fadili, gaudichau },
                };

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

                context.Paragraphes.AddRange(temoignageRealisateurParagraphe, temoignangeJeanBaptisteParagraphe, CRP2022Paragraphe, SICA, quEstCeQuneJE, quiSommesNous);


                // Ajout des différents articles
                Article temoignageRealisateur = new Article
                {
                    Titre = "Témoignage d'un Réalisateur",
                    Description = "Témoignage d’un réalisateur d’AEI",
                    Image = "https://junior-aei.com/images/Image_temoignage_Jeremie_STOETENS.png",
                    Paragraphes = new List<Paragraphe> { temoignageRealisateurParagraphe },
                    Date = DateTime.Parse("2022-08-03"),
                    Editeur = "Naomi Roche",
                };

                Article temoignageJeanBaptiste = new Article
                {
                    Titre = "Témoignage de Jean-Baptiste, président 2021-2022",
                    Description = "Mot de départ de Jean-Baptiste",
                    Image = "https://junior-aei.com/images/motjb.png",
                    Paragraphes = new List<Paragraphe> { temoignangeJeanBaptisteParagraphe },
                    Date = DateTime.Parse("2022-06-06"),
                    Editeur = "Jean-Baptiste Derouet",
                };

                Article CRP2022 = new Article
                {
                    Titre = "CRP 2022",
                    Description = "AEI au CRP 2022",
                    Image = "https://junior-aei.com/images/crp.png",
                    Paragraphes = new List<Paragraphe> { CRP2022Paragraphe },
                    Date = DateTime.Parse("2022-03-20"),
                    Editeur = "Luca Pereira",
                };

                Article parrainageSICA = new Article
                {
                    Titre = "AEI parraine la SICA, la junior de l'ENSCBP",
                    Description = "AEI parraine la SICA, la junior de l’ENSCBP",
                    Image = "https://junior-aei.com/images/sica.png",
                    Paragraphes = new List<Paragraphe> { SICA },
                    Date = DateTime.Parse("2022-03-18"),
                    Editeur = "Vivien CATTE",
                };

                Article descriptionJE = new Article
                {
                    Titre = "Qu'est ce qu'une JE",
                    Description = "Présentation d’une Junior-Entreprise",
                    Image = "https://junior-aei.com/images/portfolio/JE_logo.png",
                    Paragraphes = new List<Paragraphe> { quEstCeQuneJE, quiSommesNous },
                    Date = DateTime.Parse("2022-02-25"),
                    Editeur = "Luca Pereira, Naomi Roche",
                };

                context.Articles.AddRange(temoignageRealisateur, temoignageJeanBaptiste, CRP2022, parrainageSICA, descriptionJE);


                context.SaveChanges();
            }

        }

    }
}
