namespace OOP_5
{
    internal class Ship : ITransport
    {
        public int ShipTime { get; set; } = 120;
        public int MaxWeight { get; set; } = 140000;
        public int MinWeight { get; set; } = 40000;
        public CountryRestractionEnum CountryRestraction { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine("Shipping by 'Ship' company " + ShipTime + "days, if you want that press 1");
        }
        public bool CheckWeight(int weight)
        {
            if(weight >= MinWeight && weight <= MaxWeight)
            {
                PrintInfo();
                return true;
            }
            return false;
        }
    }
}
