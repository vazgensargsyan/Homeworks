namespace Lesson9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Series5 series5 = new Series5();
            series5.Year = 2000;
            series5.Color = "En qo asac guynic";
            series5.KmSecond = 4.5;
            series5.Type = TypeEnum.Sedan;
            series5.Info();
        }
    }
}