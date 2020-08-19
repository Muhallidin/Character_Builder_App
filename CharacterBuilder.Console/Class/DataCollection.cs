using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterBuilder.Console.Commons
{

    public class DataCollection
    {
        public List<string> LetterCollection { get; set; }

        public string NumberCollection { get; set; }

        private enum Number { zero = 0, one = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9 };
        
        public static List<DataCollection> Colletion()
        {
            var result = new List<DataCollection>();

            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "e", "f", "g", "r", "h" },
                NumberCollection = SpecialCharacter.Left_brace +  ((int)Number.one).ToString() + SpecialCharacter.Colon + ((int)Number.one).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"
                 //NumberCollection = "{ 1: 1 }"
            });

            result.Add(new DataCollection {
                LetterCollection = new List<string> { "n", "o", "p", "r", "u", "v" }, // {1:2}
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.one).ToString() + SpecialCharacter.Colon + ((int)Number.Two).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"

                //NumberCollection = "{ 1: 2 }"

            });
            //public static List<string> LetterSeries_1_4 = new List<string> { "ee.there", "ff.between", "gg.three", "ii.eigh" }; //{ 1:4}

            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "z", "aa","bb","cc" },
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.one).ToString() + SpecialCharacter.Colon + ((int)Number.Three).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"

                //NumberCollection = "{ 1: 3 }"
            });

            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "ee", "ff", "gg","ii" },
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.one).ToString() + SpecialCharacter.Colon + ((int)Number.Four).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"

                //NumberCollection = "{ 1: 4 }"
            });

            //public static List<string> LetterSeries_1_5 = new List<string> { "kk.begin", "ll.with", "mm.an", "nn.inden", "oo.or", "pp.by", "qq.missi", "rr.line", "ss.out", "tt.then", "uu.starting", "vv.again" }; // {1:5}
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "kk", "ll", "mm", "nn", "oo", "pp", "qq", "rr", "ss", "tt", "uu", "vv" },
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.one).ToString() + SpecialCharacter.Colon + ((int)Number.Five).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"

              //  NumberCollection = "{ 1: 5 }"
            });
            //public static List<string> LetterSeries_1_6 = new List<string> { "bbb.one", "ccc.ends", "ddd.another", "eee.begins", "ww.makes", "yy.easier", "zz.see" }; // {1:6}
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "bbb", "ccc", "ddd", "eee", "ww", "yy", "zz" },
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.one).ToString() + SpecialCharacter.Colon + ((int)Number.Six).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"

                //NumberCollection = "{ 1: 6 }"
            });

            //public static List<string> LetterSeries_1_7 = new List<string> { "fff.in", "ggg.most", "hhh.organized", "iii.forms", "jjj.writing", "kkk.such", "lll.as", "nnn.contain" }; // {1:7}
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "fff", "ggg", "hhh", "iii", "jjj", "kkk", "lll", "nnn" },
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.one).ToString() + SpecialCharacter.Colon + ((int)Number.Seven).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"

                //NumberCollection = "{ 1: 7 }"
            });

            //public static List<string> LetterSeries_1_8 = new List<string> { "qqq.tells", "rrr.reader", "sss.will", "ttt.be" }; // {1:8}

            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "qqq", "rrr", "sss", "ttt" },
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.one).ToString() + SpecialCharacter.Colon + ((int)Number.Eight).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"

                //NumberCollection = "{ 1: 8 }"
            });

            //public static List<string> LetterSeries_1_9 = new List<string> { "vvv.multiple", "www.make", "xxx.claims", "yyy.support", "zzz.thesis", "aaaa.statement", "bbbb.which", "cccc.central", "dddd.idea", "eeee.essay" }; // {1:9}
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "vvv", "www", "xxx", "yyy", "zzz", "aaaa", "bbbb", "cccc", "dddd", "eeee" },
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.one).ToString() + SpecialCharacter.Colon + ((int)Number.Nine).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"

               // NumberCollection = "{ 1: 9 }"
            });
            //public static List<string> LetterSeries_1_10 = new List<string> { "gggg.signal", "hhhh.writer", "iiii.changes" }; // {1:10}
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "gggg", "hhhh", "iiii"  },
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.one).ToString() + SpecialCharacter.Colon + ((int)Number.one).ToString() + ((int)Number.zero).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"

                //    NumberCollection = "{ 1: 10 }"
            });
            //public static List<string> LetterSeries_1_11 = new List<string> { "kkkk.each", "llll.number", "mmmm.depending" }; //{ 1:11}
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "kkkk", "llll", "mmmm" },
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.one).ToString() + SpecialCharacter.Colon + ((int)Number.one).ToString() + ((int)Number.one).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"

               // NumberCollection = "{ 1: 11 }"
            });
            //public static List<string> LetterSeries_1_12 = new List<string> { "oooo.now", "pppp.write", "qqqq.sports", "rrrr.e.g.", "ssss.basketball", "tttt.football", "uuuu.baseball", "vvvv.submit", "wwww.mrs.", "xxxx.smith" }; //{ 1:12}
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "oooo", "pppp", "qqqq", "rrrr", "ssss", "tttt", "uuuu", "vvvv", "wwww", "xxxx" },
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.one).ToString() + SpecialCharacter.Colon + ((int)Number.one).ToString() + ((int)Number.Two).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"

               // NumberCollection = "{ 1: 12 }"
            });

            //public static List<string> LetterSeries_2_1_8 = new List<string> { "c.what", "i.about" }; // {2:1,8}
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "c", "i" },
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.Two).ToString() + SpecialCharacter.Colon + ((int)Number.one).ToString() + SpecialCharacter.Colon + ((int)Number.Eight).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"

                //NumberCollection = "{ 2: 1, 8 }"
            });

            //public static List<string> LetterSeries_2_1_1 = new List<string> { "d.i" };
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "d" },
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.Two).ToString() + SpecialCharacter.Colon + ((int)Number.one).ToString() + SpecialCharacter.Colon + ((int)Number.one).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"

              //  NumberCollection = "{ 2: 1, 1 }"
            });

            //public static List<string> LetterSeries_2_2_2 = new List<string> { "l.group" };
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "l" },
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.Two).ToString() + SpecialCharacter.Colon + ((int)Number.Two).ToString() + SpecialCharacter.Colon + ((int)Number.Three).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"

                //NumberCollection = "{ 2: 2, 3 }"
            });


            //public static List<string> LetterSeries_2_2_9 = new List<string> { "s.that" };
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "s" },
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.Two).ToString() + SpecialCharacter.Colon + ((int)Number.Two).ToString() + SpecialCharacter.Colon + ((int)Number.Nine).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"

            //    NumberCollection = "{ 2: 2, 9 }"
            });
            //public static List<string> LetterSeries_2_3_4 = new List<string> { "y.are" };
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "y" },
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.Two).ToString() + SpecialCharacter.Colon + ((int)Number.Three).ToString() + SpecialCharacter.Colon + ((int)Number.Four).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"

                //NumberCollection = "{ 2: 3, 4 }"
            });

            //public static List<string> LetterSeries_2_5_12 = new List<string> { "jj.can" };
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "jj" },
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.Two).ToString() + SpecialCharacter.Colon + ((int)Number.Five).ToString() + SpecialCharacter.Colon + ((int)Number.one).ToString() + ((int)Number.Two).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"

              //  NumberCollection = "{ 2: 5, 12 }"
            });
            //public static List<string> LetterSeries_2_6_10 = new List<string> { "aaa.when" };
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "aaa" },
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.Two).ToString() + SpecialCharacter.Colon + ((int)Number.Six).ToString() + SpecialCharacter.Colon + ((int)Number.one).ToString() + ((int)Number.zero).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"

              //  NumberCollection = "{ 2: 6, 10 }"
            });
            //public static List<string> LetterSeries_2_6_12 = new List<string> { "xx.it" };
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "xx" },
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.Two).ToString() + SpecialCharacter.Colon + ((int)Number.Six).ToString() + SpecialCharacter.Colon + ((int)Number.one).ToString() + ((int)Number.Two).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"

               // NumberCollection = "{ 2: 6, 12 }"
            });

            //public static List<string> LetterSeries_2_7_9 = new List<string> { "mmm.essays" };
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "mmm" },
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.Two).ToString() + SpecialCharacter.Colon + ((int)Number.Seven).ToString() + SpecialCharacter.Colon + ((int)Number.Nine).ToString()  + SpecialCharacter.Right_brace //"{ 1: 1 }"

                //NumberCollection = "{ 2: 7, 9 }"
            });

            //public static List<string> LetterSeries_2_9_11 = new List<string> { "uuu.have" };
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "uuu" },
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.Two).ToString() + SpecialCharacter.Colon + ((int)Number.Nine).ToString() + SpecialCharacter.Colon + ((int)Number.one).ToString() + ((int)Number.one).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"

                //NumberCollection = "{ 2: 9, 11 }"
            });

            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "jjjj" },
                NumberCollection = SpecialCharacter.Left_brace + ((int)Number.Two).ToString() + SpecialCharacter.Colon + ((int)Number.one).ToString() + ((int)Number.zero).ToString() + SpecialCharacter.Colon + ((int)Number.one).ToString() + ((int)Number.Two).ToString() + SpecialCharacter.Right_brace //"{ 1: 1 }"

                //NumberCollection = "{ 2: 10, 12 }"
            });


            //public static List<string> LetterSeries_2_10_11 = new List<string> { "ffff.may" };
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "ffff" },
                NumberCollection = "{ 2: 11, 12 }".Trim()
            });


            //public static List<string> LetterSeries_2_9_11 = new List<string> { "uuu.have" };
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "nnnn" },
                NumberCollection = "{ 2: 11, 12 }".Trim()
            });

            //public static List<string> LetterSeries_3_1_6_8 = new List<string> { "a.this" };
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "a" },
                NumberCollection = "{ 3: 1, 6, 8 }".Trim()
            });
            //public static List<string> LetterSeries_3_2_4_9 = new List<string> { "t.usually" }; // {2:2,2}
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "t" },
                NumberCollection = "{ 3: 2, 4, 9 }".Trim()
            });
            //public static List<string> LetterSeries_3_2_7_8 = new List<string> { "w.sentence" }; // {2:2,2}
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "w" },
                NumberCollection = "{ 3: 2, 7, 8 }".Trim()
            });
            //public static List<string> LetterSeries_3_3_4_11 = new List<string> { "dd.sentences" }; // {2:2,2}
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "dd" },
                NumberCollection = "{ 3: 3, 4, 11 }".Trim()
            });
            //public static List<string> LetterSeries_3_7_8_11 = new List<string> { "ooo.topic" }; // {2:2,2}
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "ooo" },
                NumberCollection = "{ 3: 7, 8, 77 }".Trim()
            });

            //public static List<string> LetterSeries_4_1_2_2_9 = new List<string> { "b.is" }; // {2:2,2}
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "b" },
                NumberCollection = "{ 4: 1, 2, 2,8 }".Trim()
            });
            //public static List<string> LetterSeries_4_2_6_9_12 = new List<string> { "q.to" }; // {2:2,2}
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "q" },
                NumberCollection = "{ 4: 2, 6, 9,12 }".Trim()
            });
            //public static List<string> LetterSeries_4_4_5_6_12 = new List<string> { "hh.and" }; // {2:2,2}
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "q" },
                NumberCollection = "{ 4: 2, 6, 9, 12 }".Trim()
            });

            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "hh" },
                NumberCollection = "{4:4,5,6,12}"
            });


            //public static List<string> LetterSeries_5_3_5_7_9_10 = new List<string> { "x.paragraphs" }; // {2:2,2}
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "x" },
                NumberCollection = "{5:3,5,7,9,10 }".Trim()
            });
            //public static List<string> LetterSeries_6_1_2_6_8_8_11 = new List<string> { "k.paragraph" }; // {2:2,2}
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "k" },
                NumberCollection = "{ 6: 1, 2, 6, 8, 8, 11 }".Trim()
            });
            //public static List<string> LetterSeries_6_2_3_7_8_9_11 = new List<string> { "m.of" }; // {2:2,2}
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "m" },
                NumberCollection = "{ 6: 2, 3, 7, 8, 9, 11 }".Trim()
            });
            //public static List<string> LetterSeries_7_8_8_8_9_9_10_11 = new List<string> { "m.of" }; // {2:2,2}
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "ppp" },
                NumberCollection = "{ 7: 8, 8, 8, 9, 9, 10, 11 }".Trim()
            });
            //public static List<string> LetterSeries_9_1_2_2_2_2_5_7_9_11 = new List<string> { "j.a" }; // {2:2,2}
            result.Add(new DataCollection
            {
                LetterCollection = new List<string> { "j" },
                NumberCollection = "{ 9: 1, 2, 2, 2, 2, 5, 7, 9, 11 }".Trim()
            });

            return result;

        }



    }
}
