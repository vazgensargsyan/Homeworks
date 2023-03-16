namespace Lesson9
{
    internal class Car
    {
        public TypeEnum Type { get; set; }
        protected string Country { get; set; }
        public short Year { get; set; }
        protected bool Dangerous { get; set; }
        public string Color { get; set; }
        public double KmSecond { get; set; }
        public Car()
        {
            GeneralInfo();
        }
        private void GeneralInfo()
        {
            Console.WriteLine("Cars usually have 4 doors and 4 tires...");
        }
    }
}
