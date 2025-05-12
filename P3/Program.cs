using System.Text;

namespace P3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            var directory = new DirectoryInfo(@"D:\ClassWork1");

            if (directory.Exists)
            {
                directory.CreateSubdirectory("Task1");
            }

        }
    }
}
