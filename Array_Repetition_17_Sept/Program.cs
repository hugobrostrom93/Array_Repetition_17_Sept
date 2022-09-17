namespace Area_Kalkylator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            GothamsHjaltar();
            GothamVillains();
            TextNum();
            ReverseWordsOrder();
            ReverseWordsOrderLoop();
            AllChars();
            NameAndAge();
            */
            TenRandoms();
        }
        
        static void GothamsHjaltar()
        {
            Console.WriteLine("Övning 1");
            string[] GothamsHjaltar = new string[]
            {
                "Batman",
                "Alfred Pennyworth",
                "Robin",
                "Nightwing",
                "The Red Hood",
                "Red Robin",
                "Batgirl",
                "Batwoman",
                "Black cat",
                "Batwing",
                "Blue bird",
                "The Huntress",
                "Ghost-Maker",
                "Jarro",
                "Oracle",
                "James Gordon"
            };
            for (int i = 0; i < GothamsHjaltar.Length; i++)
            {
                Console.WriteLine(GothamsHjaltar[i]);
            }
        }

        static void GothamVillains()
        {
            Console.WriteLine("Övning 2");
            string[] GothamVillains = new string[]
            {
                "Bane",
                "Catwoman",
                "Deadshot",
                "Harley Quinn",
                "Hugo Strange",
                "Joe Chill",
                "Killer Croc",
                "Mr.Freeze",
                "Penguin",
                "Poison Ivy",
                "Ra's al Gul",
                "Scarecrow",
                "The Joker",
                "The Riddler",
                "Two face"
            };
            Array.Sort(GothamVillains);
            for (int iV = 0; iV < GothamVillains.Length; iV++)
            {
                Console.WriteLine(GothamVillains[iV]);
            }
        }

        static void TextNum()
        {
            Console.WriteLine("Övning 3");
            string[] TextNum = new string[]
            {
                "Ett",
                "Två",
                "Tre",
                "Fyra",
                "Fem",
                "Sex",
                "Sju",
                "Åtta",
                "Nio",
                "Tio",
                "Elva",
                "Tolv",
                "Tretton",
                "Fjorton",
                "Femton",
                "Sexton",
                "Sjutton",
                "Arton",
                "Nitton",
                "Tjugo"
            };
            Console.Write("Skriv en siffra mellan 1 och 20: ");
            string val = Console.ReadLine();
            int valInt = Int32.Parse(val);
            // Eller int valInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(TextNum[valInt - 1]);
        }

        static void ReverseWordsOrder()
        {
            Console.WriteLine("Övning 4");
            string[] ReverseWordsOrder = new string[3];
            Console.WriteLine("Ange Tre Ord:");
            Console.Write("> ");
            ReverseWordsOrder[0] = Console.ReadLine();
            Console.Write("> ");
            ReverseWordsOrder[1] = Console.ReadLine();
            Console.Write("> ");
            ReverseWordsOrder[2] = Console.ReadLine();

            Console.WriteLine($"{ReverseWordsOrder[2]} {ReverseWordsOrder[1]} {ReverseWordsOrder[0]}");

        }

        static void ReverseWordsOrderLoop()
        {
            Console.WriteLine("Övning 5");
            string[] ReverseWordsOrderLoop = new string[3];
            Console.WriteLine("Ange Tre Ord:");
            for (int i = 0; i < ReverseWordsOrderLoop.Length; i++)
            {
                Console.Write("> ");
                ReverseWordsOrderLoop[i] = Console.ReadLine();
            }

            Console.WriteLine($"{ReverseWordsOrderLoop[2]} {ReverseWordsOrderLoop[1]} {ReverseWordsOrderLoop[0]} ");
        }

        static void AllChars()
        {
            Console.WriteLine("Övning 6");
            Console.Write("Skriv ett ord: ");
            string svar = Console.ReadLine();
            foreach (char t in svar)
            {
                Console.WriteLine("> " + t);
            } 
        }

        static void NameAndAge()
        {
            Console.WriteLine("Övning 7");
            string[] nameHeroes = new string[]
            {
                "Batman",
                "Robin",
                "Batgirl",
                "Oracle",
                "James Gordon"
            };

            int[] ageHeroes = new int[]
            {
                35,
                15,
                15,
                35,
                55
            };
            for (int i = 0; i < ageHeroes.Length; i++)
            {
                Console.WriteLine($"{nameHeroes[i]} är {ageHeroes[i]} år gammal");
            }
        }

        static void TenRandoms()
        {
            Console.WriteLine("Övning 8");
            int[] TenRandoms = new int[10];
            int sum = 0;
            Random slumpTal = new();
            for (int i = 0; i < 10; i++)
            {
                TenRandoms[i] = slumpTal.Next(101);
                Console.WriteLine(TenRandoms[i]);
            }

            for (int i = 0; i < 10; i++)
            {
                sum = sum + TenRandoms[i];
            }

            
            Console.Write($"Summan av alla tal är: {sum}");

        }

    }
}