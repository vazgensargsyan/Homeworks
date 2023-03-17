using OOP_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    internal class Order : IDelivery
    {
        public int ShipTime { get; set; }
        public long TrackId { get; set; }
        public long OrderId { get; set; }
        public decimal ShipCoast { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Sale { get; set; }
        public Order()
        {
            Random random = new Random();
            TrackId = random.Next(100000, 999999);
            OrderId = random.Next(1000000, 9999999);
        }
        public void PrintInfo()
        {
            Console.WriteLine("ShipTime: " + ShipTime + "days");
            Console.WriteLine("TrackId: " + TrackId);
            Console.WriteLine("OrderId: " + OrderId);
            Console.WriteLine("ShipCoast: " + ShipCoast + "$");
            Console.WriteLine("StartDate: " + StartDate);
            Console.WriteLine("EndDate: " + EndDate);
            Console.WriteLine("Sale: " + Sale + "%");
        }
    }
}
