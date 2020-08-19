using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CharacterBuilder.Console.Commons
{
    public static class CommonHandler 
    {


        public const string paragraph = @"this is what i learned from mr. jones about a paragraph group of words put together to form that usually longer than sentence paragraphs are often made up several sentences there between three and eight can begin with an indentation or by missing line out then starting again makes it easier see when one ends another begins in most organized forms writing such as essays contain topic the tells reader will be have multiple make claims support thesis statement which central idea essay may signal writer changes topics each number depending on now write sports e.g. basketball football baseball submit mrs. smith";

        public static string GetDataCollection(string strValue)
        {
            try
            {
                string result = "";

                List<DataCollection> collections = DataCollection.Colletion();
                foreach (DataCollection data in collections)
                {
                    foreach (string str in data.LetterCollection)
                    {
                        if (str.ToString() == strValue)
                        {
                            result = data.NumberCollection;
                        }
                    }
                }

                return result;
            }
            catch(Exception ex) {
                CommonHandler.LogError("GetDataCollection " + ex.Message);
                return "";
            }
           
        }

        public static string GetCharacter(string Char, int Index)
        {

            string result = Char;

            for (var i = 0; i < (Index / 26); i++)
            {
                result += Char;
            }
            return result;
        }

        public static string GetLetter(int value)
        {
            try
            {
                List<Letter> leter =  Letter.GetLetterCollection();
                return leter.Find(e => e.Index == value).Char as string;
            }
            catch (Exception ex)
            {
                CommonHandler.LogError("GetLetter " + ex.Message);
                return "";
            }
        }


        public static void LogError(string ex)
        {

            StringBuilder stringBuilder = new StringBuilder(string.Format("Time: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")));
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append("-----------------------------------------------------------");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append(string.Format("{0}", ex));
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append("-----------------------------------------------------------");

            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append(Environment.NewLine);

            using (StreamWriter writer = new StreamWriter(CreateTextFile(), true))
            {
                writer.WriteLine(stringBuilder.ToString());
                writer.Close();
            }

        }

        private static string CreateTextFile()
        {

            var obj = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            string path = System.IO.Directory.GetCurrentDirectory() + @"\Log";  //("/Logs/exception");

            if (!CheckDirectory(path))
            {
                DirectoryInfo di = Directory.CreateDirectory(path);
            }

            string FileName = path + @"\Logs_" + DateTime.UtcNow.ToString("yyyy-MM-dd") + ".txt";
            FileStream fs = null;
            if (!File.Exists(FileName))
            {
                using (fs = File.Create(FileName))
                {
                    fs.Close();
                }
            }
            return FileName;

        }

        private static bool CheckDirectory(string path)
        {
            if (Directory.Exists(path)) return true;
            
            return false;
        }

        private static string CreateDirectory(string p)
        {

           var obj = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            string path = obj; //("/Logs/exception");

            string FileName = path + @"\Logs_" + DateTime.UtcNow.ToString("yyyy-MM-dd") + ".txt";

            FileStream fs = null;
            if (!File.Exists(FileName))
            {
                using (fs = File.Create(FileName))
                {
                    fs.Close();
                }
            }
            return FileName;

        }

    }
}
