namespace Lesson9
{
    internal class BMW : Car
    {
        public BMW()
        {
            Country = "Germany";
            BMWInfo();
        }
        private void BMWInfo()
        {
            Console.WriteLine("BMW is a German car. It is mostly sports car...");
        }
    }
}
