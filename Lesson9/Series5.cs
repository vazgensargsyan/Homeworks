namespace Lesson9
{
    internal class Series5 : BMW
    {
        public Series5()
        {
            Console.WriteLine("It is a 5th series car in BMW");
        }
        public void Info()
        {
            if (Year < 2018)
            {
                Console.WriteLine("It is a old car");
            }
            else
            {
                Console.WriteLine("It is a new car");
            }
            if (KmSecond < 4)
            {
                Dangerous = true;
            }
            else
            {
                Dangerous = false;
            }
            Console.WriteLine("Dangerous : " + Dangerous);
            Console.WriteLine("Color : " + Color);
            Console.WriteLine("Year : " + Year);
            Console.WriteLine("KmSecond : " + KmSecond);
            Console.WriteLine("Country : " + Country);
            Console.WriteLine("Type : " + Type);
        }
    }
}
