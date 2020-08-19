using CharacterBuilder.Console.Commons;
 
namespace CharacterBuilder.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            SeriesOfWord series = new SeriesOfWord(CommonHandler.paragraph);
            series.ToString();
        }
    }
}
