using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CharacterBuilder.Console.Commons
{
    public  class  SeriesOfWord : Letter
    {
        private readonly string paragraph;

        public SeriesOfWord()
        {
            this.Series = new List<SeriesOfWord>(); 
        }
        public SeriesOfWord(string str)
        {
            paragraph = str;
            this.Series = new List<SeriesOfWord>();
            ProcessParagraph();
        }

        public string Word { get; set; }

        private List<SeriesOfWord> Series { get; set; }
        private string character
        {
            get {
                return CommonHandler.GetCharacter(this.Char, this.Index);
            }
        }

        private string CharNumeric
        {
            get
            {
                return CommonHandler.GetDataCollection(this.character);
            }
        }

        #region private method
        private void ProcessParagraph()
        {
            char[] spearator = { SpecialCharacter.spliter };
            String[] strlist = paragraph.Split(spearator);
            for (var i = 0; i < strlist.Length; i++)
            {
                this.Series.Add(new SeriesOfWord
                {
                    Word = strlist[i].ToString(),
                    Index = i,
                    Char = CommonHandler.GetLetter(i % 26)
                }); ; ;
            }
        }

        #endregion


        #region public mmethod
        public new void ToString()
        {
            foreach (SeriesOfWord n in Series)
            {
                System.Console.WriteLine(SpecialCharacter.Space + n.character.ToString() + SpecialCharacter.Period + n.Word + SpecialCharacter.Space +  n.CharNumeric.Trim());
            }
            System.Console.ReadLine();
        }

        #endregion


    }
}
