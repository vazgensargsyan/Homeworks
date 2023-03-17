namespace OOP_5
{
    internal interface IDelivery
    {
        public DateTime ShipTime { get; set; }
        public long TrackId { get; set; }
        public long OrderId { get; set; }
        public decimal ShipCoast { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Sale { get; set; }
    }
}
