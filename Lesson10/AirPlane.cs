namespace OOP_5
{
    internal class AirPlane : ITransport
    {
        public int ShipTime { get; set; } = 7;
        public int MaxWeight { get; set; } = 50000;
        public int MinWeight { get; set; } = 100;
        public CountryRestractionEnum CountryRestraction { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine("Shipping by 'AirPlane' company " + ShipTime + "days, if you want that press 3");
        }
        public bool CheckWeight(int weight)
        {
            if (weight >= MinWeight && weight <= MaxWeight)
            {
                PrintInfo();
                return true;
            }
            return false;
        }
    }
}
