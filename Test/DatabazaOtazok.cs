namespace Test
{
    partial class Test
    {
        private string[] Otazky = new string[]
        {
            "Kolko je 5 x 5?",
            "Aky je najvacsi suchozemsky cicavec?",
            "Ako sa vola sucasny slovensky prezident?",
            "Aky je najludnatejsi stat sveta?",
            "V ktorom roku bola objavena Amerika?",
            "Ktore z uvedenych moznosti patria medzi programovacie jazyky?",
            "Ktore z uvedenych miest sa nachadzaju na Slovensku?",
            "Ktore z uvedenych osob patria medzi byvalych americkych prezidentov?",
            "Ktore z uvedenych krajin nie su sucastou Europskej unie?",
            "Ktore z uvedenych knih nepatria do trilogie Pan prstenov?"
        };

        private string[][] Moznosti =
        {
            new string[] { "15", "10", "25", "18", "20" },
            new string[] { "slon", "velryba", "gorila", "zirafa", "nosorozec" },
            new string[] { "Ivan Gasparovic", "Robert Fico", "Pavol Rusko", "Andrej Kiska", "Vaclav Klaus" },
            new string[] { "Brazilia", "India", "USA", "Kanada", "Cina" },
            new string[] { "1500", "1492", "1831", "1250", "1993" },
            new string[] { "C++", "ABC", "C#", "RDR", "ACCA" },
            new string[] { "Brno", "Chorvatsky Grob", "Zvolen", "Kromeriz", "Skalica" },
            new string[] { "Thomas Edison", "Abraham Lincoln", "Jack Black", "Jimi Hendrix", "George Bush" },
            new string[] { "Ukrajina", "Francuzsko", "Svajciarsko", "Slovensko", "Nemecko" },
            new string[] { "O mysiach a ludoch", "Navrat krala", "Spolocenstvo prstena", "Sumrak", "Demon suhlasu" }
        };

        private Odpoved[][] SpravneOdpovede =
        {
            new Odpoved[] { Odpoved.C },
            new Odpoved[] { Odpoved.A },
            new Odpoved[] { Odpoved.D },
            new Odpoved[] { Odpoved.E },
            new Odpoved[] { Odpoved.B },
            new Odpoved[] { Odpoved.A, Odpoved.C },
            new Odpoved[] { Odpoved.B, Odpoved.C, Odpoved.E },
            new Odpoved[] { Odpoved.B, Odpoved.E },
            new Odpoved[] { Odpoved.A, Odpoved.C },
            new Odpoved[] { Odpoved.A, Odpoved.D, Odpoved.E }
        };
    }
}
