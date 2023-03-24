using System.ComponentModel;

namespace Lesson14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stacks = new Stack<int>();
            stacks.Push(1);
            stacks.Push(2);
            stacks.Push(3);
            stacks.Push(4);
            stacks.Push(5);
            foreach (int stack in stacks)
            {
                Console.WriteLine(stack);
            }

            Queue<int> queues = new Queue<int>();
            queues.Enqueue(1);
            queues.Enqueue(2);
            queues.Enqueue(3);
            queues.Enqueue(4);
            queues.Enqueue(5);
            foreach (int queue in queues)
            {
                Console.WriteLine(queue);
            }

            List<string> lists = new List<string>();
            lists.Add("vazg");
            lists.Add("and");
            lists.Add("ponch");
            lists.Add("xmz");
            lists.Add("kchep");
            lists.Sort();
            foreach (string list in lists)
            {
                Console.WriteLine(list);
            }
        }
    }
}