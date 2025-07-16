using System.IO.Compression;

namespace PDZ3_2
{
    internal class Program
    {
        //Напишіть програму для пошуку заданого файлу на диску.
        //Додайте код, який використовує клас FileStream і дозволяє переглядати файл у текстовому вікні.
        //Насамкінець додайте можливість стиснення знайденого файлу.
        static void Main(string[] args)
        {
            
            string path = @"D:\entity";
            string searchPattern = "*.txt";
          
            string[] files = Directory.GetFiles(path, searchPattern, SearchOption.AllDirectories);
            string info;

            foreach (string  file in files)
            {
                Console.WriteLine($"Found file: {file}");
                using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read)) 
                using (StreamReader reader = new StreamReader(fs))
                { 
                 Console.WriteLine("File info");
                 Console.WriteLine( reader.ReadToEnd());
                 info= reader.ReadToEnd();


                }
            }

            FileStream source = File.OpenRead(@"D:\entity\test.txt");
            FileStream destination = File.Create(@"D:\archive.zip");

            GZipStream compressor = new GZipStream(destination, CompressionMode.Compress);

            int theByte = source.ReadByte();
            while (theByte != -1)
            {
                compressor.WriteByte((byte)theByte);
                theByte = source.ReadByte();
            }

            
            compressor.Close();
            Console.ReadKey();
        }
    }
}
