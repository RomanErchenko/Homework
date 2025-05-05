namespace MyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new MyLinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddFirst(5);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Remove(10);
            Console.WriteLine("After removing 10:");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

    }
    
}
