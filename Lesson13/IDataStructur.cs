using System.Collections;

namespace Lesson13
{
    internal interface IDataStructur
    {
        public Dictionary<int, string> categories { get; set; }
        public Dictionary<int, string> genres { get; set; }
        public Dictionary<int, string> films { get; set; }
        public Hashtable filmToGenre { get; set; }
        public Hashtable filmToPrice { get; set; }
        public void setValue();
    }
}
