
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
                    Pole = Pole.Bureau,
                    Role = Role.President,
                };

                Membre bouhassoun = new Membre
                {
                    Nom = "Bouhassoun",
                    Prenom = "Tahir",
                    Pole = Pole.Bureau,
                    Role = Role.VicePresident,
                };

                Membre stubbe = new Membre
                {
                    Nom = "Stubbe",
                    Prenom = "Liam",
                    Pole = Pole.Bureau,
                    Role = Role.VicePresident,
                };

                Membre lemeur = new Membre
                {
                    Nom = "Le Meur",
                    Prenom = "Tristan",
                    Pole = Pole.Bureau,
                    Role = Role.Secretaire,
                };

                Membre zilliox = new Membre
                {
                    Nom = "Zilliox",
                    Prenom = "Clément",
                    Pole = Pole.Bureau,
                    Role = Role.Tresorier,
                };

                Membre zilliox2 = new Membre
                {
                    Nom = "Zilliox",
                    Prenom = "Clément",
                    Pole = Pole.Tresorerie,
                    Role = Role.Tresorier,
                };

                Membre lemestre = new Membre
                {
                    Nom = "Le Mestre",
                    Prenom = "Théo",
                    Pole = Pole.Tresorerie,
                    Role = Role.Comptable,
                };

                Membre buzit = new Membre
                {
                    Nom = "Buzit",
                    Prenom = "Benjamin",
                    Pole = Pole.Tresorerie,
                    Role = Role.RespoQualite,
                };

                Membre rumen = new Membre
                {
                    Nom = "Rumen",
                    Prenom = "Tamara",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre oukrid = new Membre
                {
                    Nom = "Oukrid",
                    Prenom = "Yann",
                    Pole = Pole.DevCommercial,
                    Role = Role.RespoDevCommercial,
                };

                Membre walther = new Membre
                {
                    Nom = "Walther",
                    Prenom = "Dimitri",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre longechamp = new Membre
                {
                    Nom = "Longechamp",
                    Prenom = "Damien",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre meurrens = new Membre
                {
                    Nom = "Meurrens",
                    Prenom = "Serge",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre penot = new Membre
                {
                    Nom = "Penot",
                    Prenom = "Victorine",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre laurent = new Membre
                {
                    Nom = "Laurent",
                    Prenom = "Alban",
                    Pole = Pole.Qualite,
                    Role = Role.RespoQualite,
                };

                Membre nadal = new Membre
                {
                    Nom = "Nadal",
                    Prenom = "Thibault",
                    Pole = Pole.Qualite,
                    Role = Role.ChargeQualite,
                };

                Membre durand = new Membre
                {
                    Nom = "Durand",
                    Prenom = "Jules",
                    Pole = Pole.Qualite,
                    Role = Role.ChargeQualite,
                };

                Membre barteau = new Membre
                {
                    Nom = "Barteau",
                    Prenom = "Nadjime",
                    Pole = Pole.SystemeInformation,
                    Role = Role.RespoSystInformation,
                };

                Membre dupoux = new Membre
                {
                    Nom = "Dupoux",
                    Prenom = "Mathieu",
                    Pole = Pole.SystemeInformation,
                    Role = Role.RespoTechnique,
                };

                Membre raoult = new Membre
                {
                    Nom = "Raoult",
                    Prenom = "Antoine",
                    Pole = Pole.SystemeInformation,
                    Role = Role.RespoTechnique,
                };

                Membre roche = new Membre
                {
                    Nom = "Roche",
                    Prenom = "Naomi",
                    Pole = Pole.Communication,
                    Role = Role.RespoCom,
                };

                Membre pereira = new Membre
                {
                    Nom = "Pereira",
                    Prenom = "Luca",
                    Pole = Pole.Communication,
                    Role = Role.ChargeComm,
                };

                Membre braun = new Membre
                {
                    Nom = "Braun",
                    Prenom = "Jules",
                    Pole = Pole.Communication,
                    Role = Role.ChargeComm,
                };

                Membre cannet = new Membre
                {
                    Nom = "Cannet",
                    Prenom = "Alban",
                    Pole = Pole.Communication,
                    Role = Role.ChargeComm,
                };

                Membre maziere = new Membre
                {
                    Nom = "Mazière",
                    Prenom = "Léo-Paul",
                    Pole = Pole.Etude,
                    Role = Role.RespoSuiviEtudes,
                };

                Membre messner = new Membre
                {
                    Nom = "Messner",
                    Prenom = "Julie",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre praud = new Membre
                {
                    Nom = "Praud",
                    Prenom = "Brieuc",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre deSaintExupery = new Membre
                {
                    Nom = "De Saint-Exupéry",
                    Prenom = "Malo",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre haton = new Membre
                {
                    Nom = "Haton",
                    Prenom = "Antoine",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre vovard = new Membre
                {
                    Nom = "Vovard",
                    Prenom = "Marine",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre derriey = new Membre
                {
                    Nom = "Derriey",
                    Prenom = "Alexandre",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre paul = new Membre
                {
                    Nom = "Paul",
                    Prenom = "Maël",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre derouet = new Membre
                {
                    Nom = "Derouet",
                    Prenom = "Jean-Baptiste",
                    Pole = Pole.Bureau,
                    Role = Role.President,
                };

                Membre casal = new Membre
                {
                    Nom = "Casal",
                    Prenom = "Théo",
                    Pole = Pole.Bureau,
                    Role = Role.Secretaire,
                };

                Membre casal2 = new Membre
                {
                    Nom = "Casal",
                    Prenom = "Théo",
                    Pole = Pole.Bureau,
                    Role = Role.VicePresident,
                };

                Membre cassany = new Membre
                {
                    Nom = "Cassany",
                    Prenom = "Martin",
                    Pole = Pole.Bureau,
                    Role = Role.Tresorier,
                };

                Membre cassany2 = new Membre
                {
                    Nom = "Cassany",
                    Prenom = "Martin",
                    Pole = Pole.Tresorerie,
                    Role = Role.Tresorier,
                };

                Membre bailloux = new Membre
                {
                    Nom = "Bailloux",
                    Prenom = "Laetitia",
                    Pole = Pole.Tresorerie,
                    Role = Role.Comptable,
                };

                Membre zizi = new Membre
                {
                    Nom = "Zizi",
                    Prenom = "Marwan",
                    Pole = Pole.DevCommercial,
                    Role = Role.RespoDevCommercial,
                };

                Membre batty = new Membre
                {
                    Nom = "Batty",
                    Prenom = "Sebastien",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre bahoussi = new Membre
                {
                    Nom = "Bahoussi",
                    Prenom = "Meryam",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre fellah = new Membre
                {
                    Nom = "Fellah",
                    Prenom = "Hicham",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre ginesy = new Membre
                {
                    Nom = "Ginesy",
                    Prenom = "Damien",
                    Pole = Pole.Qualite,
                    Role = Role.RespoQualite,
                };

                Membre leGall = new Membre
                {
                    Nom = "Le Gall",
                    Prenom = "Mathis",
                    Pole = Pole.Qualite,
                    Role = Role.ChargeQualite,
                };

                Membre darmon = new Membre
                {
                    Nom = "Darmon",
                    Prenom = "Valentin",
                    Pole = Pole.Qualite,
                    Role = Role.ChargeQualite,
                };

                Membre langlais = new Membre
                {
                    Nom = "Langlais",
                    Prenom = "Hugo",
                    Pole = Pole.SystemeInformation,
                    Role = Role.RespoSystInformation,
                };

                Membre trupin = new Membre
                {
                    Nom = "Trupin",
                    Prenom = "Loic",
                    Pole = Pole.SystemeInformation,
                    Role = Role.RespoTechnique,
                };

                Membre catte = new Membre
                {
                    Nom = "Catté",
                    Prenom = "Vivien",
                    Pole = Pole.Communication,
                    Role = Role.RespoCom,
                };

                Membre guerin = new Membre
                {
                    Nom = "Guerin",
                    Prenom = "Léo-Paul",
                    Pole = Pole.Communication,
                    Role = Role.ChargeComm,
                };

                Membre fagues = new Membre
                {
                    Nom = "Fagues",
                    Prenom = "Corentin",
                    Pole = Pole.Communication,
                    Role = Role.ChargeComm,
                };

                Membre abrouk = new Membre
                {
                    Nom = "Abrouk",
                    Prenom = "Nada",
                    Pole = Pole.Etude,
                    Role = Role.RespoSuiviEtudes,
                };

                Membre fkyerat = new Membre
                {
                    Nom = "Fkyerat",
                    Prenom = "Gabriel",
                    Pole = Pole.Etude,
                    Role = Role.CoRespoSuiviEtudes,
                };

                Membre hannier = new Membre
                {
                    Nom = "Hannier",
                    Prenom = "Cyril",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre kutkowski = new Membre
                {
                    Nom = "Kutkowski",
                    Prenom = "Pierre",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre rezette = new Membre
                {
                    Nom = "Rezette",
                    Prenom = "Paul",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre rivard = new Membre
                {
                    Nom = "Rivard",
                    Prenom = "Lilian",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre brejon = new Membre
                {
                    Nom = "Brejon",
                    Prenom = "Louis",
                    Pole = Pole.Bureau,
                    Role = Role.President,
                };

                Membre deRoeck = new Membre
                {
                    Nom = "De Roeck",
                    Prenom = "Hugues",
                    Pole = Pole.Bureau,
                    Role = Role.President,
                };

                Membre lechevallier = new Membre
                {
                    Nom = "Lechevallier",
                    Prenom = "Clément",
                    Pole = Pole.Bureau,
                    Role = Role.VicePresident,
                };

                Membre brejon2 = new Membre
                {
                    Nom = "Brejon",
                    Prenom = "Louis",
                    Pole = Pole.Bureau,
                    Role = Role.VicePresident,
                };

                Membre transon = new Membre
                {
                    Nom = "transon",
                    Prenom = "Pierre-Louis",
                    Pole = Pole.Bureau,
                    Role = Role.Secretaire,
                };

                Membre nowominski = new Membre
                {
                    Nom = "Nowominski",
                    Prenom = "Elie",
                    Pole = Pole.Bureau,
                    Role = Role.Tresorier,
                };

                Membre nowominski2 = new Membre
                {
                    Nom = "Nowominski",
                    Prenom = "Elie",
                    Pole = Pole.Tresorerie,
                    Role = Role.Tresorier,
                };

                Membre drouin = new Membre
                {
                    Nom = "Drouin",
                    Prenom = "Maxence",
                    Pole = Pole.Tresorerie,
                    Role = Role.Comptable,
                };

                Membre dubigeon = new Membre
                {
                    Nom = "Dubigeon",
                    Prenom = "Antonin",
                    Pole = Pole.DevCommercial,
                    Role = Role.RespoDevCommercial,
                };

                Membre lefebvre = new Membre
                {
                    Nom = "Lefebvre",
                    Prenom = "Virgil",
                    Pole = Pole.DevCommercial,
                    Role = Role.CoRespoDevCommercial,
                };

                Membre doulieri = new Membre
                {
                    Nom = "Doulieri",
                    Prenom = "Baudouin",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre gayot = new Membre
                {
                    Nom = "Gayot",
                    Prenom = "Basile",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre koutit = new Membre
                {
                    Nom = "Koutit",
                    Prenom = "Maryem",
                    Pole = Pole.DevCommercial,
                    Role = Role.ChargeAffaire,
                };

                Membre vidal = new Membre
                {
                    Nom = "Vidal",
                    Prenom = "Martin",
                    Pole = Pole.Qualite,
                    Role = Role.RespoQualite,
                };

                Membre anfray = new Membre
                {
                    Nom = "Anfray",
                    Prenom = "Thomas",
                    Pole = Pole.Qualite,
                    Role = Role.ChargeQualite,
                };

                Membre talio = new Membre
                {
                    Nom = "Talio",
                    Prenom = "Romain",
                    Pole = Pole.Qualite,
                    Role = Role.ChargeQualite,
                };

                Membre decou = new Membre
                {
                    Nom = "decou",
                    Prenom = "Nathan",
                    Pole = Pole.SystemeInformation,
                    Role = Role.RespoSystInformation,
                };

                Membre jemmoudi = new Membre
                {
                    Nom = "Jemmoudi",
                    Prenom = "Ismail",
                    Pole = Pole.Communication,
                    Role = Role.RespoCom,
                };

                Membre pouget = new Membre
                {
                    Nom = "Pouget",
                    Prenom = "Marine",
                    Pole = Pole.Communication,
                    Role = Role.ChargeComm,
                };

                Membre nabet = new Membre
                {
                    Nom = "Nabet",
                    Prenom = "Yacine",
                    Pole = Pole.Etude,
                    Role = Role.RespoSuiviEtudes,
                };

                Membre deRoeck2 = new Membre
                {
                    Nom = "De Roeck",
                    Prenom = "Hugues",
                    Pole = Pole.Etude,
                    Role = Role.ChargeCommmercialEtude,
                };

                Membre benoit = new Membre
                {
                    Nom = "Benoit",
                    Prenom = "Thomas",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre bouidra = new Membre
                {
                    Nom = "Bouidra",
                    Prenom = "Leila",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre cabanes = new Membre
                {
                    Nom = "Cabanes",
                    Prenom = "Valentin",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre fadili = new Membre
                {
                    Nom = "Fadili",
                    Prenom = "Walid",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };

                Membre gaudichau = new Membre
                {
                    Nom = "Gaudichau",
                    Prenom = "Pierre-Malo",
                    Pole = Pole.Etude,
                    Role = Role.ChefProjet,
                };



                // Ajout des différents mandats
                Mandat mandat_2022_2023 = new Mandat
                {
                    Annee = DateTime.Parse("2022"),
                    Membres = new List<Membre> { marques, bouhassoun, stubbe, lemeur, zilliox, zilliox2, lemestre, buzit, rumen, oukrid, walther, longechamp, meurrens, penot, laurent, nadal, durand, barteau, dupoux, raoult, roche, maziere, messner, praud, deSaintExupery, haton, vovard, derriey, paul },
                };

                Mandat mandat_2021_2022 = new Mandat
                {
                    Annee = DateTime.Parse("2021"),
                    Membres = new List<Membre> { derouet, casal, casal2, cassany, cassany2, bailloux, zizi, batty, bahoussi, fellah, ginesy, leGall, darmon, langlais, trupin, catte, guerin, fagues, abrouk, fkyerat, hannier, kutkowski, rezette, rivard },
                };

                Mandat mandat_2020_2021 = new Mandat
                {
                    Annee = DateTime.Parse("2021"),
                    Membres = new List<Membre> { brejon, deRoeck, lechevallier, brejon2, transon, nowominski, nowominski2, drouin, dubigeon, lefebvre, doulieri, gayot, koutit, vidal, anfray, talio, decou, jemmoudi, pouget, nabet, deRoeck2, benoit, bouidra, cabanes, fadili, gaudichau },
                };

                // Ajout des différents articles
                Article temoignangeRealisateur = new Article
                {
                    Titre = "Témoignage d'un Réalisateur",
                    Description = "Témoignage d’un réalisateur d’AEI",
                    Texte = "'Être réalisateur pour AEI m’a permis de découvrir plus concrètement ce qu’est un projet dans un cadre professionnel. Je devais développer un site internet permettant de visualiser une base de données. En répondant à l’annonce, je voulais valoriser par une expérience professionnelle des compétences en développement que j’avais acquises en autodidacte.Grâce à cette étude, j’ai pu découvrir l’organisation d’un projet où chaque acteur a un rôle bien défini et j’ai appris à m’adapter aux exigences d’un Client. C’était une belle expérience que je recommande aux étudiants s’ils sont motivés et particulièrement intéressés par le domaine de l’étude.'Jérémie Soetens",
                    Date = DateTime.Parse("2022-08-03"),
                    Editeur = "Naomi Roche",
                };

                Article temoignangeJeanBaptiste = new Article
                {
                    Titre = "Témoignage de Jean-Baptiste, président 2021-2022",
                    Description = "Mot de départ de Jean-Baptiste",
                    Texte = "En tant qu’ancien président de la Junior-Entreprise AEI, j’ai été ravi de vivre cette belle aventure qu’est la Junior : une aventure à la fois passionnante et enrichissante !J’avais peu d’expérience professionnelle en intégrant l’école. AEI m’a permis d’approcher ce monde professionnel. En effet, nous sommes en contact direct avec les entreprises auxquelles nous fournissons des prestations dans des domaines de compétences très divers. La diversité de ces prestations ainsi que les obstacles que nous pouvons rencontrer imposent une coopération de toute l’équipe.J’ai trouvé à AEI une expérience enrichissante dans le monde de l’entreprise avec l’occasion unique de pouvoir gérer une équipe d’une vingtaine de personnes. J’ai donc dû travailler en équipe dans le but de pérenniser la structure. En ce qui concerne les fonctions que j’ai exercées, en tant que président, j’ai appris à organiser mon travail, prendre du recul sur les choses, dialoguer avec mon équipe et fixer des stratégies avec le Bureau. Vivre cette expérience unique m’a fait grandir professionnellement et personnellement.Cette expérience m’a demandé beaucoup d’investissement mais m’a apporté beaucoup en retour. Ce fût une année intense qui m’a permis d’acquérir de nouvelles compétences et de faire face à de nouveaux défis. Cet engagement m’a permis de découvrir des personnes appliquées et impliquées dans leur travail, des gens passionnés par leurs missions, avec leurs qualités, leurs défauts, leurs sourires et leurs passions.La mise en place d’une nouvelle stratégie pour la Junior nous a permis de répondre aux défis qui nous étaient posés. Ce fut un honneur d’avoir pu prendre la responsabilité de ce travail qui ne s’est pas fait seul : je tiens de ce fait à remercier les membres du Conseil d’Administration. Je ressors grandi de cette expérience qui m’a offert un regard neuf sur le monde du travail et qui m’a permis de mieux percevoir certaines perspectives d’avenir après le diplôme d’ingénieur.Je souhaite le meilleur à la nouvelle équipe; qu’elle reste soudée, dynamique et engagée tout au long de son mandat !",
                    Date = DateTime.Parse("2022-06-06"),
                    Editeur = "Jean-Baptiste Derouet",
                };

                Article CRP2022 = new Article
                {
                    Titre = "CRP 2022",
                    Description = "AEI au CRP 2022",
                    Texte = "Le samedi 12 et dimanche 13 mars, nous avons eu le plaisir de participer au Congrès Régional de Printemps Sud Ouest 2022, dont le thème était “L’innovation au service de l’urgence climatique”. 🌍Lors de ce congrès, nous avons pu assister à diverses formations présentées entre autres par la CNJE et ses partenaires premium : ALTEN, BNP Paribas, ENGIE, EY. Nous tenions à les remercier pour nous avoir partagé leur expérience et nous avoir transmis de précieux conseils. ✨Ce fut également l’occasion de rencontrer et d’échanger avec de nombreuses Junior Entreprises, ainsi que les divers intervenants présents. 🤝👏 Un grand merci ainsi qu’un grand bravo à ENVOL Junior Etudes ✈️ pour avoir organisé et hébergé cet enrichissant événement.#WeAreJE",
                    Date = DateTime.Parse("2022-03-20"),
                    Editeur = "Luca Pereira",
                };

                Article parrainageSICA = new Article
                {
                    Titre = "AEI parraine la SICA, la junior de l'ENSCBP",
                    Description = "AEI parraine la SICA, la junior de l’ENSCBP",
                    Texte = "Depuis août 2020, SICA est en parrainage avec AEI, Aquitaine Electronique Informatique, la Junior-Entreprise de l’Enseirb-Matmeca. Ce parrainage permet une entraide entre les deux juniors et contribue fortement à leur développement. Il permet également un rapprochement entre les deux écoles d’ingénieur de Bordeaux INP pour la création de compétences transverses.N’hésitez pas à aller consulter directement leur site Web: https://junior-sica.com",
                    Date = DateTime.Parse("2022-03-18"),
                    Editeur = "Vivien CATTE",
                };

                Article descriptionJE = new Article
                {
                    Titre = "Qu'est ce qu'une JE",
                    Description = "Présentation d’une Junior-Entreprise",
                    Texte = "Depuis août 2020, SICA est en parrainage avec AEI, Aquitaine Electronique Informatique, la Junior-Entreprise de l’Enseirb-Matmeca. Ce parrainage permet une entraide entre les deux juniors et contribue fortement à leur développement. Il permet également un rapprochement entre les deux écoles d’ingénieur de Bordeaux INP pour la création de compétences transverses.N’hésitez pas à aller consulter directement leur site Web: https://junior-sica.com",
                    Date = DateTime.Parse("2022-02-25"),
                    Editeur = "Luca Pereira, Naomi Roche",
                };





                context.SaveChanges();
            }

        }

    }
}
