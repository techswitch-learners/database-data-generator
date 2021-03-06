﻿using System;

namespace ConsoleApp1
{
    public class NameGenerator
    {
        private static readonly string[] FirstNames = new[]
        {
            "Magnum",
            "Ed",
            "Roscoe",
            "Clarabelle",
            "Stefa",
            "Karim",
            "Jojo",
            "Toinette",
            "Walt",
            "Harmon",
            "Petronilla",
            "Smith",
            "Clarance",
            "Loree",
            "Anastasie",
            "Mallory",
            "Carolus",
            "Hilliary",
            "Neil",
            "Feliks",
            "Sibilla",
            "Tina",
            "Crystal",
            "Ax",
            "Patric",
            "Nathan",
            "Orville",
            "Rowena",
            "Northrup",
            "Reynard",
            "Harwell",
            "Johny",
            "Boot",
            "Matthiew",
            "Clementine",
            "Jereme",
            "Onofredo",
            "Gavan",
            "Benyamin",
            "Dot",
            "Ulrika",
            "Dukie",
            "Warde",
            "Nichole",
            "Carolan",
            "Jinny",
            "Alfonso",
            "Perrine",
            "Bonny",
            "Allene",
            "Horatia",
            "Halimeda",
            "Avie",
            "Mindy",
            "Red",
            "Fremont",
            "Portia",
            "Loise",
            "Norina",
            "Nikoletta",
            "Consolata",
            "Joyce",
            "Roscoe",
            "Georgy",
            "Ced",
            "Darbie",
            "Robin",
            "Alvin",
            "Avery",
            "Preston",
            "Jess",
            "Shadow",
            "Emory",
            "Rodd",
            "Betsy",
            "Cointon",
            "Siffre",
            "Celka",
            "Dennis",
            "Forster",
            "Godard",
            "Justinian",
            "Tibold",
            "Lottie",
            "Robenia",
            "Patricia",
            "Markos",
            "Hamil",
            "Payton",
            "Bernardine",
            "Rick",
            "Arlinda",
            "Lonny",
            "Bent",
            "Coraline",
            "Yankee",
            "Alaric",
            "Elton",
            "Beverly",
            "Bari"
        };

        private static readonly string[] LastNames = new[]
        {
            "Wratten",
            "Stockell",
            "Shadfourth",
            "Stote",
            "Swannell",
            "Dearden",
            "Condit",
            "Longstreet",
            "Busfield",
            "Molineaux",
            "Armfirld",
            "Frantz",
            "Kealy",
            "Rendle",
            "Threlfall",
            "Manson",
            "Pennick",
            "Cordery",
            "Paxman",
            "Yakubovics",
            "Jilkes",
            "Calton",
            "Hargey",
            "Kemetz",
            "O'Gormley",
            "Dole",
            "Findley",
            "MacGillivrie",
            "Linguard",
            "Hegge",
            "Sweatman",
            "Vaughan-Hughes",
            "Paike",
            "Olenchikov",
            "Aire",
            "Summerscales",
            "Hopkins",
            "Fenlon",
            "Harsant",
            "Manterfield",
            "Eastmond",
            "Effemy",
            "Louden",
            "Artharg",
            "Snoxall",
            "Farry",
            "Lettley",
            "Gallgher",
            "Venney",
            "Keenor",
            "Ulyat",
            "Clissett",
            "Dober",
            "Troyes",
            "Cayle",
            "Zarfat",
            "Harbison",
            "Djuricic",
            "Yeoman",
            "Yashaev",
            "Piscot",
            "Maxted",
            "Bulstrode",
            "Lambourne",
            "Knight",
            "Gawn",
            "Ellacombe",
            "Tonkin",
            "Fitzjohn",
            "Cutridge",
            "Kenworthey",
            "Cunniam",
            "Poile",
            "Kalker",
            "McAlroy",
            "Eydel",
            "Radoux",
            "Aland",
            "Mundie",
            "Tremblot",
            "O'Cassidy",
            "McIntosh",
            "Dilkes",
            "Emig",
            "Tulleth",
            "Rumbold",
            "Congreave",
            "Robrose",
            "Gegg",
            "Lytton",
            "Crevagh",
            "Hearle",
            "Este",
            "Vell",
            "Shaxby",
            "Gwilliam",
            "Beecroft",
            "Blethin",
            "Bowne",
            "Veracruysse"
        };

        public static string GetRandomFirstName()
        {
            return FirstNames[new Random().Next(FirstNames.Length)];
        }
        
        public static string GetRandomLastName()
        {
            return LastNames[new Random().Next(LastNames.Length)];
        }
    }
}