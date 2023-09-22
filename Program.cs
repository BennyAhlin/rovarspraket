Console.WriteLine("Skriv in ett ord och få tillbaka det översatt till rövarspråket.");
string word = Console.ReadLine();
Console.Clear();
string[] konsonant =
{
    "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z"
};
string[] vokal =
{
    "a", "e", "i", "o", "u", "y", "å", "ä", "ö"
};


for (int i = 0; i < konsonant.Length; i++)
{
   

            if ( vokal == konsonant)
            {
        Console.WriteLine("Detta är en vokal");


            }
            else if (vokal[j] == word[k].ToString())
            {


            }
                Console.WriteLine(konsonant[i] + "o" + konsonant[i]);
                Console.WriteLine(vokal[j]);


        }
    }
}