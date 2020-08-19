using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.Console.Commons
{

    
    public class Letter
    {
        
       

        public  int Index { get; set; }

        public string Char { get; set; }

        public static List<Letter> GetLetterCollection()
        {
            return Letters();
        }

        protected static List<Letter> Letters()
        {
            var result = new List<Letter>();

            result.Add(new Letter { Index = 0, Char = "a" });
            result.Add(new Letter { Index = 1, Char = "b" });
            result.Add(new Letter { Index = 2, Char = "c" });
            result.Add(new Letter { Index = 3, Char = "d" });
            result.Add(new Letter { Index = 4, Char = "e" });
            result.Add(new Letter { Index = 5, Char = "f" });
            result.Add(new Letter { Index = 6, Char = "g" });
            result.Add(new Letter { Index = 7, Char = "h" });
            result.Add(new Letter { Index = 8, Char = "i" });
            result.Add(new Letter { Index = 9, Char = "j" });
            result.Add(new Letter { Index = 10, Char = "k" });
            result.Add(new Letter { Index = 11, Char = "l" });
            result.Add(new Letter { Index = 12, Char = "m" });
            result.Add(new Letter { Index = 13, Char = "n" });
            result.Add(new Letter { Index = 14, Char = "o" });
            result.Add(new Letter { Index = 15, Char = "p" });
            result.Add(new Letter { Index = 16, Char = "q" });
            result.Add(new Letter { Index = 17, Char = "r" });
            result.Add(new Letter { Index = 18, Char = "s" });
            result.Add(new Letter { Index = 19, Char = "t" });
            result.Add(new Letter { Index = 20, Char = "u" });
            result.Add(new Letter { Index = 21, Char = "v" });
            result.Add(new Letter { Index = 22, Char = "w" });
            result.Add(new Letter { Index = 23, Char = "x" });
            result.Add(new Letter { Index = 24, Char = "y" });
            result.Add(new Letter { Index = 25, Char = "z" });

            return result;

        }


    }
}
