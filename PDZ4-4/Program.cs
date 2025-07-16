using System.IO;
using System.Xml;

namespace PDZ4_4
{
    internal class Program
    {
        //Створіть програму, яка виводить на екран всю інформацію про вказаний .xml файл.
        static void Main(string[] args)
        {

            //var document = new XmlDocument();
            //document.Load("books.xml");
            //Console.WriteLine(document.InnerText);

            //Console.WriteLine(new string('-',15));
            //Console.WriteLine(document.InnerXml);

            FileStream fileStream = new FileStream("books.xml",FileMode.Open);
            XmlTextReader xmlReader = new XmlTextReader(fileStream);


            while (xmlReader.Read())
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15}",
                    xmlReader.NodeType,
                    xmlReader.Name,
                    xmlReader.Value);
            }

            xmlReader.Close();
            fileStream.Close();
            Console.ReadKey();

        }
    }
}
