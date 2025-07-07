using System.Text;

namespace PDZ3_1
{
    //Створіть файл, запишіть у нього довільні дані та закрийте файл.
    //Потім знову відкрийте цей файл, прочитайте дані і виведіть їх на консоль.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            var file = new FileInfo(@"D:\Test.txt");
            //FileStream stream = file.Create();
            StreamWriter writer = file.CreateText();
            writer.WriteLine("This is my text");
            writer.WriteLine("ryadok1...");
            writer.WriteLine("ryadok2...");
            writer.Close();

            StreamReader reader = File.OpenText(@"D:\Test.txt"); 
            string input;

            // Выводим содержимое файла в консоль.
            while ((input = reader.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }

            reader.Close();

            // Delay.
            Console.ReadKey();



        }
    }
}
