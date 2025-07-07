namespace PDZ3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string basepath = @"D:\MyFolders";
            for (int i = 0; i < 99; i++)
            {

                string folderName = $"Folder{i}";
                string fullPath = Path.Combine(basepath, folderName);
                if (!Directory.Exists(fullPath))
                {
                    Directory.CreateDirectory(fullPath);
                    Console.WriteLine($"Create{fullPath}");
                }
                else
                {
                    Console.WriteLine($"Exist: {fullPath}");
                }
            }
            Console.ReadKey();
            for (int i = 0; i < 99; i++)
            {
                string folderName = $"Folder{i}";
                string fullPath = Path.Combine(basepath, folderName);
                if (Directory.Exists(fullPath))
                {
                    Directory.Delete(fullPath);
                    Console.WriteLine($"Delete{fullPath}");
                }
            }
            Console.ReadKey();
        }
    }
}
