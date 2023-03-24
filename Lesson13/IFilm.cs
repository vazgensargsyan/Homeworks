namespace Lesson13
{
    internal interface IFilm
    {
        public string Genre { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte Star { get; set; }
        public string Category { get; set; }
    }
}
