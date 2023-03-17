namespace OOP_5
{
    internal class Truck : ITransport
    {
        public int ShipTime { get; set; } = 40;
        public int MaxWeight { get; set; } = 20000;
        public int MinWeight { get; set; } = 100;
        public CountryRestractionEnum CountryRestraction { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine("Shipping by 'Truck' company " + ShipTime + "days, if you want that press 2");
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
