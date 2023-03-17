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
            ship.CheckWeight(weight, ref check);
            truck.CheckWeight(weight, ref check);
            airPlane.CheckWeight(weight, ref check);
            if (check)
            {
                Console.Write("Press company number ");
                byte companyNumber = byte.Parse(Console.ReadLine());
                Order order = new Order();
                switch (companyNumber)
                {
                    case 1:
                        order.ShipTime = ship.ShipTime;
                        order.ShipCoast = 3000;
                        order.StartDate = DateTime.Now.AddDays(3);
                        order.EndDate = DateTime.Now.AddDays(123);
                        order.Sale = 20;
                        order.PrintInfo();
                        break;
                    case 2:
                        order.ShipTime = truck.ShipTime;
                        order.ShipCoast = 1500;
                        order.StartDate = DateTime.Now.AddDays(1);
                        order.EndDate = DateTime.Now.AddDays(41);
                        order.Sale = 10;
                        order.PrintInfo();
                        break;
                    case 3:
                        order.ShipTime = airPlane.ShipTime;
                        order.ShipCoast = 6000;
                        order.StartDate = DateTime.Now.AddDays(2);
                        order.EndDate = DateTime.Now.AddDays(9);
                        order.Sale = 10;
                        order.PrintInfo();
                        break;
                    default:
                        Console.WriteLine("Qez asinq mutqagri 1-3 tvery");
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