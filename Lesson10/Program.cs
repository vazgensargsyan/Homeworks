using OOP_5;

namespace Lesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write product weight with 'KG' ");
            int weight = int.Parse(Console.ReadLine());
            Ship ship = new Ship();
            Truck truck = new Truck();
            AirPlane airPlane = new AirPlane();
            bool check = false;
            ship.CheckWeight(weight);
            if (check)
            {
                Console.Write("Press company number ");
                int companyNumber = int.Parse(Console.ReadLine());
                switch (companyNumber)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Helar gorcerit");
            }
        }
    }
}