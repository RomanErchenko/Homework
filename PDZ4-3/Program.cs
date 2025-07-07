using System.Globalization;

namespace PDZ4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Створіть текстовий файл-чек на кшталт «Найменування товару – 0.00(ціна)грн.»
            // з певною кількістю найменувань товарів та датою здійснення покупки. Виведіть на
            // екран інформацію з чека у форматі поточної локалі користувача та у форматі локалі en-US.

            FileStream file = File.Create(@"D:\Bill.txt");

            var writer = new StreamWriter(file);
            writer.WriteLine(" Bill");
            writer.WriteLine("Pen amount 2 pc  -price 25$");
            writer.WriteLine("Pepsi amount 4 pc  -price 15$");
            writer.WriteLine("Phone amount 1 pc  -price 2500$");
            DateTime date = DateTime.Now;
            writer.WriteLine($"Date of purch: {date}");
            writer.Close();

            RegionInfo regionInfo = RegionInfo.CurrentRegion;
            RegionInfo region = RegionInfo.CurrentRegion;

            StreamReader reader = File.OpenText(@"D:\Bill.txt");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

           
            Thread.CurrentThread.CurrentCulture = CultureInfo.CurrentCulture;
            while (!reader.EndOfStream)
            {
               
                
                Console.WriteLine(reader.ReadToEnd()); 
                Console.WriteLine(Thread.CurrentThread.CurrentCulture); 
                Console.ReadKey();
            }
        }
    }
}
